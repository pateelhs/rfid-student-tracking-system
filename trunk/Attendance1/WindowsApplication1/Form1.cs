using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Xml;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private string file;
        private String pathx;
        FileStream filex;
        StreamReader fr;
        Attendance att = new Attendance();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog fb1 = new OpenFileDialog();
            fb1.InitialDirectory = path.Text;
            if (fb1.ShowDialog() == DialogResult.OK)
            {
                path.Text =System.IO.Path.GetDirectoryName(fb1.FileName );
                file = System.IO.Path.GetFileName(fb1.FileName);
                pathx = fb1.FileName.ToString();
                File.WriteAllText("file.xml", String.Empty);
                XmlTextWriter twriter = new XmlTextWriter("file.xml", null);
                twriter.WriteStartDocument();
                twriter.WriteStartElement("file_path");
                twriter.WriteString(fb1.FileName);
                twriter.WriteEndElement();
                twriter.WriteEndDocument();
                twriter.Close();
               

            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                fileSystemWatcher1.Path = @path.Text;
                fileSystemWatcher1.EnableRaisingEvents = true;
                Start.Enabled = false;
                browse.Enabled = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
      
        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
           
            try
            {
               
                if (e.Name == file)
                {
                    filex = new FileStream(pathx, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                    fr = new StreamReader(filex);
                    string line = fr.ReadLine().ToString();
                    att.Attendance_apply(line);
                    fr.Close();
                    filex.Close();
                }
               
                fileSystemWatcher1.EnableRaisingEvents = false;
                File.WriteAllText(pathx, String.Empty);
                fileSystemWatcher1.EnableRaisingEvents = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        
        private void Stop_Click(object sender, EventArgs e)
        {
            fileSystemWatcher1.EnableRaisingEvents = false;
            Start.Enabled = true;
            browse.Enabled = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path.Enabled = false;
            XmlTextReader treader = new XmlTextReader("file.xml");
            treader.Read();
            pathx = treader.ReadElementString("file_path");
            path.Text = System.IO.Path.GetDirectoryName(pathx);
            treader.Close();
            Start.PerformClick();
            Start.Enabled = false;
            browse.Enabled = false;
            Console.WriteLine(pathx);
        }
    }
}