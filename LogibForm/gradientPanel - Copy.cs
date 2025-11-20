using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogibForm
{
    public class gradientPanel : Panel
    {
        //Create a properties to define the colur for the gradient's top and bottom
        public Color gradientTop { get; set; }
        public Color gradientBottom { get; set; }

        //Creates a Constructor for the Gradient Panel Calss
        public gradientPanel() {
            this.Resize += GradientPanel_Resize;
        }

        private void GradientPanel_Resize(object sender, EventArgs e)
        {
           this.Invalidate(); //this marks the control as needing to be redrawn
        }

        //override the onPaint methid to dra a gradient background
        protected override void OnPaint(PaintEventArgs e) {
            //create a linergradient with the specified top and bottom gradient colours
            LinearGradientBrush linear = new LinearGradientBrush(
                
                this.ClientRectangle,// this area to fill eith the gradient 
                this.gradientTop, // the startign colour (top of the gardient)
                this.gradientBottom, // the ending colour (bottom of the gradient)
                90F //lastly the angle of the gradient (90 degrees = vertical)
                );
                
            // get the graphics context for the drawing
            Graphics graphics = e.Graphics;

            //fill the entire control with the gradient
            graphics.FillRectangle(linear, this.ClientRectangle);
            
            // lastly call the base class onpaint to ensure any additonal painting is done

            base.OnPaint(e);

        }
    }
}