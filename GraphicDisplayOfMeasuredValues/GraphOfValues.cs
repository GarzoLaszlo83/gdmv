using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System;

namespace GraphicDisplayOfMeasuredValues
{
    public partial class GraphOfValues : PictureBox
    {
        private float borderWidth = 2;

        public GraphOfValues()
        {
            InitializeComponent();
            ShowDatas();
        }

        public GraphOfValues(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region Unused item hide

        [Browsable(false)]
        new public Image Image { get; set; }

        [Browsable(false)]
        public override Color BackColor { get; set; }

        [Browsable(false)]
        public override Image BackgroundImage { get; set; }

        [Browsable(false)]
        public override ImageLayout BackgroundImageLayout { get; set; }

        [Browsable(false)]
        new public BorderStyle BorderStyle { get; set; }

        [Browsable(false)]
        new public Image InitialImage { get; set; }

        [Browsable(false)]
        new public Image ErrorImage { get; set; }

        [Browsable(false)]
        new public PictureBoxSizeMode SizeMode { get; set; }

        #endregion

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ShowDatas();
        }

        private delegate void DelegateDiagram(PictureBox pictureBox, Bitmap bitmap);

        private void ShowDiagram(PictureBox pictureBox, Bitmap bitmap)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new DelegateDiagram(ShowDiagram), new object[] { pictureBox, bitmap });
                    return;
                }
                else
                {
                    pictureBox.Image = bitmap;
                    pictureBox.Refresh();
                    GC.Collect();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DrawTheBorder(Graphics g)
        {
            Pen borderPen = new Pen(Color.Black, borderWidth);
            g.DrawRectangle(borderPen, borderWidth, borderWidth, Width - (borderWidth * 2), Height - (borderWidth * 2));
        }

        private void DrawTheBackground(Graphics g)
        {
            SolidBrush borderBrush = new SolidBrush(Color.White);
            g.FillRectangle(borderBrush, borderWidth, borderWidth, Width - (borderWidth * 2), Height - (borderWidth * 2));
        }


        private void ShowDatas()
        {
            var tempBitmap = new Bitmap(Width, Height);
            var g = Graphics.FromImage(tempBitmap);
            DrawTheBackground(g);

            DrawTheBorder(g);
            ShowDiagram(this, tempBitmap);
            tempBitmap = null;
        }

    }
}
