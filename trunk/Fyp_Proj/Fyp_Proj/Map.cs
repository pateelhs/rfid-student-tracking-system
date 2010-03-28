// Fig. 17.21: DrawShapes.cs
// Drawing various shapes on a Form.
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Fyp_Proj
{
    // draws shapes with different brushes
    public partial class Map : Form
    {
        // default constructor
        public Map()
        {
            InitializeComponent();
        } // end constructor

        // draw various shapes on Form
        private void DrawShapesForm_Paint(object sender, PaintEventArgs e)
        {
            // references to object we will use
            Graphics graphicsObject = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, 2000, 1000);
            LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Black, Color.Black, LinearGradientMode.BackwardDiagonal);
            graphicsObject.FillRectangle(lBrush, rect);

            // brush and pen used throughout program
            SolidBrush solidColorBrush =
               new SolidBrush(Color.White);
            Pen coloredPen = new Pen(solidColorBrush);

            coloredPen.Width = 5;
            Rectangle libraryBlock = new Rectangle(70, 200, 170, 300);
            graphicsObject.DrawRectangle(coloredPen, libraryBlock);

            Rectangle JBlock = new Rectangle(430, 80, 670, 200);
            graphicsObject.DrawRectangle(coloredPen, JBlock);

            Rectangle AdminBlock = new Rectangle(430, 480, 670, 200);
            graphicsObject.DrawRectangle(coloredPen, AdminBlock);

            Rectangle NewBlock = new Rectangle(1000, 280, 200, 200);
            graphicsObject.DrawRectangle(coloredPen, NewBlock);


        } // end method DrawShapesForm_Paint
    } // end class DrawShapesForm

}
/**************************************************************************
 * (C) Copyright 1992-2006 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/