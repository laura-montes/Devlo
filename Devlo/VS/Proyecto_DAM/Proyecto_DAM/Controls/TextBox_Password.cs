using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DAM.Controls
{
    public partial class TextBox_Password : UserControl
    {
        //Fields
        private Color borderColor = Color.White;
        private int borderSize = 1;
        

        public TextBox_Password()
        {
            InitializeComponent();
        }

        public Color BorderColor { get => borderColor; set => borderColor = value; }
        public int BorderSize { get => borderSize; set => borderSize = value; }


        //Overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            
            //Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                graph.DrawRectangle(penBorder, 0, 0, this.Width, this.Height);
            }
        }
    }
}
