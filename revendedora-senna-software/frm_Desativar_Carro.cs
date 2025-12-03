using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revendedora_senna_software
{
    public partial class frm_Desativar_Carro : Form
    {
        // Flag para indicar se a lista exibe o placeholder
        private bool placeholderActive = true;

        // Fonte de dados exemplo (substitua pela sua fonte real)
        private readonly List<string> carros = new List<string>
        {
            
        };

        public frm_Desativar_Carro()
        {
            InitializeComponent();

            // Configura o botão para desenho personalizado (gradiente)
            btn_desativar.FlatStyle = FlatStyle.Flat;
            btn_desativar.FlatAppearance.BorderSize = 0;
            btn_desativar.UseVisualStyleBackColor = false; // permite pintar o background
            btn_desativar.ForeColor = Color.White;

            // Eventos para desenhar e forçar redesenho ao redimensionar
            btn_desativar.Paint += Btn_desativar_Paint;
            btn_desativar.Resize += (s, e) => btn_desativar.Invalidate();

            // Torna o botão clicável: associa o evento Click
            btn_desativar.Click += Btn_desativar_Click;

            // Associa clique do botão Voltar para abrir/retornar ao frm_home
            btn_voltar.Click += Btn_voltar_Click;

            // Restaura comportamento anterior: ao fechar este form, volta ao frm_home
            this.FormClosing += Frm_Desativar_Carro_FormClosing;

            // Inicializa listbox com placeholder
            InitializeListPlaceholder();

            // Eventos para popular a lista quando o usuário interagir
            lst_carroJaAdicionados.MouseDown += Lst_carroJaAdicionados_MouseDown;
            lst_carroJaAdicionados.Enter += Lst_carroJaAdicionados_Enter;
            lst_carroJaAdicionados.KeyDown += Lst_carroJaAdicionados_KeyDown;
        }

        private void InitializeListPlaceholder()
        {
            lst_carroJaAdicionados.Items.Clear();
            lst_carroJaAdicionados.Items.Add("Escolha um carro");
            lst_carroJaAdicionados.ForeColor = Color.Gray;
            lst_carroJaAdicionados.SelectedIndex = -1;
            placeholderActive = true;
        }

        private void PopulateCarros()
        {
            if (!placeholderActive) return;

            lst_carroJaAdicionados.BeginUpdate();
            lst_carroJaAdicionados.Items.Clear();
            foreach (var c in carros)
                lst_carroJaAdicionados.Items.Add(c);
            lst_carroJaAdicionados.ForeColor = SystemColors.ControlText;
            lst_carroJaAdicionados.SelectedIndex = -1;
            placeholderActive = false;
            lst_carroJaAdicionados.EndUpdate();
        }

        private void Lst_carroJaAdicionados_MouseDown(object sender, MouseEventArgs e)
        {
            // MouseDown ocorre antes de alterar seleção — ideal para popular a lista
            if (placeholderActive)
                PopulateCarros();
        }

        private void Lst_carroJaAdicionados_Enter(object sender, EventArgs e)
        {
            if (placeholderActive)
                PopulateCarros();
        }

        private void Lst_carroJaAdicionados_KeyDown(object sender, KeyEventArgs e)
        {
            // Ativa com tecla (por ex. seta para baixo/enter)
            if (placeholderActive && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space))
                PopulateCarros();
        }

        private void Btn_desativar_Paint(object sender, PaintEventArgs e)
        {
            var btn = sender as Button;
            if (btn == null)
                return;

            var rect = btn.ClientRectangle;
            if (rect.Width <= 0 || rect.Height <= 0)
                return;

            // Gradiente da esquerda para a direita: #00256f -> #008a4e
            using (var brush = new LinearGradientBrush(rect,
                                                       ColorTranslator.FromHtml("#00256f"),
                                                       ColorTranslator.FromHtml("#008a4e"),
                                                       LinearGradientMode.Horizontal))
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.FillRectangle(brush, rect);
            }

            // Desenha o texto centralizado (preserva fonte e cor do botão)
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine;
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, rect, btn.ForeColor, flags);
        }

        // Handler do clique: valida seleção, pede confirmação e "desativa" removendo da lista
        private void Btn_desativar_Click(object sender, EventArgs e)
        {
            // Se o placeholder estiver ativo ou nenhum item selecionado, pede que o usuário selecione
            if (placeholderActive || lst_carroJaAdicionados.SelectedItem == null)
            {
                MessageBox.Show("Selecione um carro antes de desativar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = lst_carroJaAdicionados.SelectedItem.ToString();
            var resposta = MessageBox.Show($"Deseja desativar o carro \"{item}\"?", "Confirmar desativação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                lst_carroJaAdicionados.Items.Remove(lst_carroJaAdicionados.SelectedItem);
                MessageBox.Show($"Carro \"{item}\" desativado com sucesso.", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Evento do botão Voltar: volta para frm_home sem encerrar o app
        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            // Mantém comportamento já implementado: mostra o frm_home se existir, senão cria um novo
            var openHome = Application.OpenForms.OfType<frm_home>().FirstOrDefault();
            if (openHome != null)
            {
                if (openHome.WindowState == FormWindowState.Minimized)
                    openHome.WindowState = FormWindowState.Normal;

                openHome.Show();
                openHome.BringToFront();
            }
            else
            {
                var novoHome = new frm_home();
                novoHome.Show();
            }

            // Fecha apenas este formulário
            this.Close();
        }

        // Ao fechar este formulário (X), mostra o frm_home em vez de deixar a aplicação sem janelas
        private void Frm_Desativar_Carro_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Se houver Owner definido como frm_home, apenas mostra-o
            if (this.Owner is frm_home ownerHome)
            {
                if (ownerHome.WindowState == FormWindowState.Minimized)
                    ownerHome.WindowState = FormWindowState.Normal;

                ownerHome.Show();
                ownerHome.BringToFront();
                return;
            }

            // Se não houver Owner, tenta encontrar uma instância aberta de frm_home
            var openHome = Application.OpenForms.OfType<frm_home>().FirstOrDefault();
            if (openHome != null)
            {
                if (openHome.WindowState == FormWindowState.Minimized)
                    openHome.WindowState = FormWindowState.Normal;

                openHome.Show();
                openHome.BringToFront();
                return;
            }

            // Se realmente não existir frm_home em memória, cria uma nova instância e mostra
            var novo = new frm_home();
            novo.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            pnl_header.BackColor =
            ColorTranslator.FromHtml("#002160");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbl_DesativarCarro.BackColor =
            ColorTranslator.FromHtml("#002775");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frm_Desativar_Carro_Load(object sender, EventArgs e)
        {

        }

        private void lst_carroJaAdicionados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
