using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revendedora_senna_software
{
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();

            // Habilita estilos para reduzir flicker
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            // Mantém para compatibilidade adicional
            this.DoubleBuffered = true;

            // Requisita redesenho ao redimensionar para manter o fundo correto
            this.Resize += (s, e) => this.Invalidate();
        }

        private void frm_home_Load(object sender, EventArgs e)
        {
            // Mantido vazio
        }

        // Desenha o fundo: gradiente vertical com 3 cores
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var rect = this.ClientRectangle;
            if (rect.Width <= 0 || rect.Height <= 0)
            {
                base.OnPaintBackground(e);
                return;
            }

            // Gradiente vertical com 3 cores (topo #ffc620, meio #fed86a, base branco)
            var topColor = ColorTranslator.FromHtml("#ffc620");
            var middleColor = ColorTranslator.FromHtml("#fed86a");
            var bottomColor = Color.White;

            using (var brush = new LinearGradientBrush(rect, topColor, bottomColor, LinearGradientMode.Vertical))
            {
                var blend = new ColorBlend(3)
                {
                    Colors = new[] { topColor, middleColor, bottomColor },
                    Positions = new[] { 0f, 0.5f, 1f }
                };
                brush.InterpolationColors = blend;

                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}