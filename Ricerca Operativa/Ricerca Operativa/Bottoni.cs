using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LAB_Festa_fine_anno.Properties
{
    internal class Bottoni : Button
    {
        //---CAMPI---
        //Spessore Bordi
        private int borderSize = 0;
        //smussatura angoli 0--> angoli retti
        private int borderRadius = 40;
        //colore del bordo
        private Color borderColor = Color.Black;


        //costruttore
        public Bottoni()
        {
            //tenere .Flat se no fa schifo
            this.FlatStyle = FlatStyle.Flat;
            //tenere a 0
            this.FlatAppearance.BorderSize = 0;
            //Dimensione del bottone
            this.Size = new Size(150, 40);
            //Colore dello sfondo del bottone
            this.BackColor = Color.AliceBlue;
            //colore del testo dentro al bottone
            this.ForeColor = Color.White;
        }
        //metodi
        private GraphicsPath GetGraphicsPath(RectangleF rect, float radius)
        {
            //crea l'elemento bottone
            //tramite i 4 angoli
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            //creo l'angolo alto sx
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            //creo l'angolo alto dx
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            //angolo basso dx
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            //angolo basso sx
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
        //senza questo il bottone è colorato ma non ha gli attributi che si vuole tipo le forme
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);
            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetGraphicsPath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetGraphicsPath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

        }
    }
}
