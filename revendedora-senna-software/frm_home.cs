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

            // Associa clique para abrir o formulário de desativar carros
            btn_DesativarCarro.Click += Btn_DesativarCarro_Click;

            // Associa clique para abrir o formulário de adicionar carro
            btn_AdicionarCarro.Click += Btn_AdicionarCarro_Click;

            // Garante que ao fechar este form (clicar no X) a aplicação termine definitivamente
            this.FormClosing += Frm_home_FormClosing;
        }

        private void Frm_home_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Se o usuário está fechando a janela principal, encerra a aplicação por completo.
            // Application.Exit fecha todas as forms; Environment.Exit garante finalização do processo se necessário.
            try
            {
                Application.Exit();
            }
            finally
            {
                // Força encerramento do processo caso algo impeça o Application.Exit de finalizar.
                Environment.Exit(0);
            }
        }

        private void Btn_DesativarCarro_Click(object sender, EventArgs e)
        {
            // Abre frm_Desativar_Carro como owned form e esconde o Home para navegação consistente
            var frm = new frm_Desativar_Carro
            {
                Owner = this
            };
            frm.Show();
            this.Hide();
        }

        private void Btn_AdicionarCarro_Click(object sender, EventArgs e)
        {
            // Abre frm_add_carro como owned form e esconde o Home para navegação consistente
            var frm = new frm_add_carro
            {
                Owner = this
            };
            frm.Show();
            this.Hide();
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

        private void btn_VerCarro_Click(object sender, EventArgs e)
        {
            // Ao clicar em Ver Carro, abre o formulário de cadastrados e esconde o Home
            var frm = new frm_Cadastrado
            {
                Owner = this
            };
            frm.Show();
            this.Hide();
        }
    }
}