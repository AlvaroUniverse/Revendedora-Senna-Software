using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revendedora_senna_software
{
    public partial class frm_add_carro : Form
    {
       

       
        public frm_add_carro()
        {
            InitializeComponent();

            // Associa o clique do botão "Home" para voltar ao frm_home
            btn_voltar_add.Click += Btn_voltar_add_Click;

            // Ao fechar o formulário, mostra o frm_home (comportamento consistente com outros forms)
            this.FormClosing += Frm_add_carro_FormClosing;

            // Validação: permite apenas letras, espaços e alguns sinais comuns em nomes
            txt_nome_vendedor.KeyPress += TxtLettersOnly_KeyPress;
            txt_nome_carro.KeyPress += TxtLettersOnly_KeyPress;

            // Também sanitiza colagens/alterações via teclado ao alterar o texto
            txt_nome_vendedor.TextChanged += (s, e) => EnforceLettersOnly((TextBox)s);
            txt_nome_carro.TextChanged += (s, e) => EnforceLettersOnly((TextBox)s);

            // --- Validação para txt_ano: apenas números inteiros e entre 1970 e 2025 ---
                txt_ano.KeyPress += TxtDigitsOnly_KeyPress;
            txt_ano.TextChanged += (s, e) => EnforceDigitsOnly((TextBox)s);
            txt_ano.Leave += TxtAno_Leave;

    
        }

        private void InitializeAccessoriesPlaceholder()
        {
            if (panel1 == null) return;
            panel1.Controls.Clear();
            var lbl = new Label
            {
                Text = "Clique aqui ou role para ver acessórios...",
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Gray,
                Dock = DockStyle.Fill
            };
            panel1.Controls.Add(lbl);
        }

        
        private void TxtLettersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir controle (backspace), letras Unicode (inclui acentos) e espaço.
            // Também permitir hífen e apóstrofo (opcionais em nomes compostos).
            if (char.IsControl(e.KeyChar) ||
                char.IsLetter(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                e.KeyChar == '-' || e.KeyChar == '\'')
            {
                // permitido
                return;
            }

            // bloqueia todo o resto (números, símbolos indesejados)
            e.Handled = true;
        }

        private void EnforceLettersOnly(TextBox tb)
        {
            if (tb == null) return;

            var original = tb.Text;
            // Mantém apenas letras, espaço, hífen e apóstrofo
            var filtered = new string(original.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c == '-' || c == '\'').ToArray());

            if (!string.Equals(original, filtered, StringComparison.Ordinal))
            {
                var selStart = tb.SelectionStart;
                tb.Text = filtered;
                // Ajusta a posição do cursor de forma segura
                tb.SelectionStart = Math.Min(selStart, tb.Text.Length);
            }
        }

        private const int AnoMinimo = 1970;
        private const int AnoMaximo = 2025;

        // Bloqueia qualquer tecla que não seja dígito ou tecla de controle (backspace, delete...)
        private void TxtDigitsOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
                return;

            e.Handled = true;
        }

        // Remove caracteres não numéricos (protege contra colar texto inválido)
        private void EnforceDigitsOnly(TextBox tb)
        {
            if (tb == null) return;

            var original = tb.Text;
            var filtered = new string(original.Where(char.IsDigit).ToArray());

            // Limita tamanho para 4 dígitos (anos têm 4 dígitos)
            if (filtered.Length > 4)
                filtered = filtered.Substring(0, 4);

            if (!string.Equals(original, filtered, StringComparison.Ordinal))
            {
                var selStart = tb.SelectionStart;
                tb.Text = filtered;
                tb.SelectionStart = Math.Min(selStart, tb.Text.Length);
            }
        }

        // Validação final ao sair do campo: exige inteiro entre AnoMinimo e AnoMaximo
        private void TxtAno_Leave(object sender, EventArgs e)
        {
            var txt = txt_ano.Text.Trim();

            if (string.IsNullOrEmpty(txt) || !int.TryParse(txt, out int ano) || ano < AnoMinimo || ano > AnoMaximo)
            {
                MessageBox.Show($"Informe um ano válido entre {AnoMinimo} e {AnoMaximo}.", "Ano inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // devolve o foco ao txt_ano e seleciona o texto para facilitar correção
                BeginInvoke((Action)(() =>
                {
                    txt_ano.Focus();
                    txt_ano.SelectAll();
                }));
            }
        }

        private void Frm_add_carro_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Não reabrir o home se a aplicação está sendo encerrada globalmente
            if (e.CloseReason == CloseReason.ApplicationExitCall ||
                e.CloseReason == CloseReason.WindowsShutDown ||
                e.CloseReason == CloseReason.TaskManagerClosing)
            {
                return;
            }

            // Se este formulário foi aberto definindo Owner (frm_home), mostra o Owner.
            if (this.Owner is frm_home ownerHome)
            {
                if (ownerHome.WindowState == FormWindowState.Minimized)
                    ownerHome.WindowState = FormWindowState.Normal;

                ownerHome.Show();
                ownerHome.BringToFront();
                return;
            }

            // Caso não haja Owner, tenta encontrar uma instância aberta de frm_home
            var openHome = Application.OpenForms.OfType<frm_home>().FirstOrDefault();
            if (openHome != null)
            {
                if (openHome.WindowState == FormWindowState.Minimized)
                    openHome.WindowState = FormWindowState.Normal;

                openHome.Show();
                openHome.BringToFront();
                return;
            }

            // Se não existir, cria uma nova instância e mostra
            var novo = new frm_home();
            novo.Show();
        }

        private void Btn_voltar_add_Click(object sender, EventArgs e)
        {
            // Se este formulário foi aberto definindo Owner (frm_home), mostra o Owner.
            if (this.Owner is frm_home ownerHome)
            {
                if (ownerHome.WindowState == FormWindowState.Minimized)
                    ownerHome.WindowState = FormWindowState.Normal;

                ownerHome.Show();
                ownerHome.BringToFront();
            }
            else
            {
                // Caso não haja Owner, tenta encontrar uma instância aberta de frm_home
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
                    // Se não existir, cria uma nova instância e mostra
                    var novo = new frm_home();
                    novo.Show();
                }
            }

            // Fecha o formulário atual
            this.Close();
        }

        private void pnl_header_add_Paint(object sender, PaintEventArgs e)
        {
            pnl_header_add.BackColor =
            ColorTranslator.FromHtml("#002160");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lst_carro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {

        }
    }
}
