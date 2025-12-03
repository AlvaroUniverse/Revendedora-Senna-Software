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
        // Campos para placeholder e marcas
        private bool _lstCarroPlaceholderActive = false;
        private readonly string _lstCarroPlaceholderText = "escolha a marca do carro";
        private readonly string[] _lstCarroMarcas = new[] { "Mclaren", "Ferrari", "Sauber", "Willians" };

        public frm_add_carro()
        {
            InitializeComponent();

            // Associa o clique do botão "Home" para voltar ao frm_home
            btn_voltar_add.Click += Btn_voltar_add_Click;

            // Associa o clique do botão "Adicionar Acessorios" para abrir frm_add_acessorio
            btn_acessorio.Click += Btn_acessorio_Click;

            // Garante que o botão Enviar chame o handler de validação (remove inscrição anterior para evitar duplicação)
            btn_enviar.Click -= btn_enviar_Click;
            btn_enviar.Click += btn_enviar_Click;

            // --- Inicializa placeholder da lista de carros ---
            // Usa owner-draw para poder desenhar o texto ofuscado/placeholder
            try
            {
                lst_carro.DrawMode = DrawMode.OwnerDrawFixed;
            }
            catch
            {
                // Se o controle for um ComboBox, DrawMode também existe; ignore falhas inesperadas
            }

            _lstCarroPlaceholderActive = true;
            lst_carro.Items.Clear();
            lst_carro.Items.Add(_lstCarroPlaceholderText);

            // Eventos para desenhar e para primeiro clique/foco (popula marcas)
            lst_carro.DrawItem -= Lst_carro_DrawItem;
            lst_carro.DrawItem += Lst_carro_DrawItem;

            lst_carro.MouseDown -= Lst_carro_FirstOpen;
            lst_carro.MouseDown += Lst_carro_FirstOpen;

            lst_carro.GotFocus -= Lst_carro_FirstOpen;
            lst_carro.GotFocus += Lst_carro_FirstOpen;

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
            // Nota: removido o handler de Leave para que o aviso só apareça ao clicar em btn_enviar
            // txt_ano.Leave += TxtAno_Leave;
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

        // Valida o ano — retorna true se válido. Se showMessage for true, exibe aviso e devolve foco.
        private bool ValidateAno(bool showMessage)
        {
            var txt = txt_ano.Text.Trim();

            if (string.IsNullOrEmpty(txt) || !int.TryParse(txt, out int ano) || ano < AnoMinimo || ano > AnoMaximo)
            {
                if (showMessage)
                {
                    MessageBox.Show($"Informe um ano válido entre {AnoMinimo} e {AnoMaximo}.", "Ano inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // devolve o foco ao txt_ano e seleciona o texto para facilitar correção
                    BeginInvoke((Action)(() =>
                    {
                        txt_ano.Focus();
                        txt_ano.SelectAll();
                    }));
                }
                return false;
            }

            return true;
        }

        // Verifica se campos obrigatórios estão preenchidos. Se showMessage for true exibe aviso com a lista de campos faltantes.
        private bool ValidateRequiredFields(bool showMessage)
        {
            var missing = new List<string>();

            if (string.IsNullOrWhiteSpace(txt_nome_vendedor.Text))
                missing.Add("Nome do vendedor");

            // lst_carro representa a lista de marcas/carros — exige seleção
            if (lst_carro.SelectedIndex < 0)
                missing.Add("Marca do carro (selecione na lista)");

            if (string.IsNullOrWhiteSpace(txt_nome_carro.Text))
                missing.Add("Nome do carro");

            if (string.IsNullOrWhiteSpace(txt_ano.Text))
                missing.Add("Ano do carro");

            // Novo: exige pelo menos 1 CheckBox marcada pelo usuário
            var anyCheckedAcessorio = panel1.Controls
                .OfType<CheckBox>()
                .Any(cb => cb.Checked);

            if (!anyCheckedAcessorio)
                missing.Add("Selecione pelo menos 1 acessório (marque uma checkbox)");

            if (missing.Count > 0)
            {
                if (showMessage)
                {
                    var msg = "Preencha os seguintes campos obrigatórios:\r\n\r\n- " + string.Join("\r\n- ", missing);
                    MessageBox.Show(msg, "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Coloca foco em um elemento útil: primeiro CheckBox existente ou no botão de adicionar acessório
                    var firstCb = panel1.Controls.OfType<CheckBox>().FirstOrDefault();
                    if (firstCb != null)
                    {
                        BeginInvoke((Action)(() => firstCb.Focus()));
                    }
                    else
                    {
                        BeginInvoke((Action)(() => btn_acessorio.Focus()));
                    }
                }
                return false;
            }

            // Se todos os campos estiverem preenchidos, valida o ano (mostrando aviso se inválido)
            if (!ValidateAno(showMessage))
                return false;

            return true;
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

        // Abre o formulário de acessórios; este form é aberto com Owner=this e esconde o frm_add_carro
        private void Btn_acessorio_Click(object sender, EventArgs e)
        {
            var frm = new frm_add_acessorio
            {
                Owner = this
            };
            frm.Show();
            this.Hide();
        }

        // Método público para permitir que frm_add_acessorio adicione um CheckBox no panel1
        public void AddAcessorio(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return;

            // Executa no thread da UI
            if (this.InvokeRequired)
            {
                this.BeginInvoke((Action)(() => AddAcessorio(nome)));
                return;
            }

            var texto = nome.Trim();

            // Evitar duplicatas exatas (usando nome diferente na lambda para não conflitar com a variável 'cb' abaixo)
            var exists = panel1.Controls.OfType<CheckBox>().Any(existing => string.Equals(existing.Text, texto, StringComparison.OrdinalIgnoreCase));
            if (exists)
                return;

            var cb = new CheckBox
            {
                AutoSize = true,
                Text = texto,
                Tag = texto
            };

            // Calcula posição vertical: empilha abaixo dos controles existentes com padding
            const int padding = 6;
            int y = padding;
            foreach (Control c in panel1.Controls)
            {
                y = Math.Max(y, c.Bottom + padding);
            }

            cb.Location = new Point(padding, y);

            // Menu de contexto específico para esse CheckBox (opção "Excluir")
            cb.ContextMenuStrip = BuildCheckboxContextMenu(cb);

            // Duplo clique também remove (com confirmação)
            cb.DoubleClick += CheckBox_DoubleClick;

            panel1.Controls.Add(cb);
            // Força atualização visual
            panel1.PerformLayout();
        }

        // Cria um ContextMenuStrip com opção de excluir ligada ao CheckBox passado
        private ContextMenuStrip BuildCheckboxContextMenu(CheckBox cb)
        {
            var cms = new ContextMenuStrip();
            var excluir = new ToolStripMenuItem("Excluir");
            excluir.Click += (s, e) => DeleteCheckbox(cb);
            cms.Items.Add(excluir);
            return cms;
        }

        // Evento de duplo clique — remove com confirmação
        private void CheckBox_DoubleClick(object sender, EventArgs e)
        {
            if (sender is CheckBox cb)
                DeleteCheckbox(cb);
        }

        // Remove o CheckBox com confirmação do usuário
        private void DeleteCheckbox(CheckBox cb)
        {
            if (cb == null) return;

            var res = MessageBox.Show($"Deseja excluir o acessório \"{cb.Text}\"?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                panel1.Controls.Remove(cb);
                cb.Dispose();
                panel1.PerformLayout();
            }
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

        // Mantive o handler para compatibilidade com o Designer — sem lógica relacionada à lista.
        private void lst_carro_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            // Executa validação de campos obrigatórios e do ano somente ao clicar em Enviar.
            if (!ValidateRequiredFields(showMessage: true))
                return;

            // Tenta salvar no banco (substitua SaveCarToDatabase pela implementação real)
            bool saved;
            try
            {
                saved = SaveCarToDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (saved)
            {
                // Mostra confirmação ao usuário antes de limpar os campos
                MessageBox.Show("Dados enviados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Não foi possível salvar os dados.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Limpa os campos do formulário e remove os CheckBox de acessórios adicionados
        private void ClearForm()
        {
            txt_nome_vendedor.Clear();
            txt_nome_carro.Clear();
            txt_ano.Clear();

            // Limpa seleção da lista (se for ListBox/ComboBox)
            try
            {
                lst_carro.ClearSelected();
            }
            catch
            {
                lst_carro.SelectedIndex = -1;
            }

            // Remove e libera todos os CheckBox adicionados dinamicamente no panel1
            var checkboxes = panel1.Controls.OfType<CheckBox>().ToList();
            foreach (var cb in checkboxes)
            {
                panel1.Controls.Remove(cb);
                cb.Dispose();
            }

            panel1.PerformLayout();

            // Reseta a lista de marcas para o estado inicial com placeholder ofuscado
            ResetLstCarroPlaceholder();

            txt_nome_vendedor.Focus();
        }

        // Restaura a lista de marcas ao estado inicial: apenas o texto ofuscado "escolha a marca do carro"
        private void ResetLstCarroPlaceholder()
        {
            _lstCarroPlaceholderActive = true;
            lst_carro.DrawMode = DrawMode.OwnerDrawFixed; // garante que o placeholder será desenhado corretamente
            lst_carro.Items.Clear();
            lst_carro.Items.Add(_lstCarroPlaceholderText);
            lst_carro.SelectedIndex = -1;
            lst_carro.Invalidate();
        }

        // Método placeholder para gravação — substitua pela implementação real de persistência.
        // Retorna true se a gravação foi bem sucedida.
        private bool SaveCarToDatabase()
        {
            // TODO: implementar a lógica real de salvar no banco de dados (ORM, ADO.NET, repositório, etc.)
            return true;
        }

        private void btn_voltar_add_Click_1(object sender, EventArgs e)
        {

        }

        // Desenha o item — se for placeholder, desenha em cor ofuscada/itálico
        private void Lst_carro_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var lb = (ListBox)sender;

            e.DrawBackground();

            string text = lb.Items[e.Index].ToString();

            // Se placeholder ativo e item for o placeholder, desenha ofuscado
            if (_lstCarroPlaceholderActive && e.Index == 0)
            {
                using (var brush = new SolidBrush(Color.Gray))
                using (var font = new Font(e.Font, FontStyle.Italic))
                {
                    e.Graphics.DrawString(text, font, brush, e.Bounds);
                }
            }
            else
            {
                // Desenho padrão com seleção
                Color fore = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ? SystemColors.HighlightText : lb.ForeColor;
                using (var brush = new SolidBrush(fore))
                {
                    e.Graphics.DrawString(text, e.Font, brush, e.Bounds);
                }
            }

            e.DrawFocusRectangle();
        }

        // Evento que, ao primeiro foco/cliique, popula as marcas (substitui o placeholder)
        private void Lst_carro_FirstOpen(object sender, EventArgs e)
        {
            if (!_lstCarroPlaceholderActive) return;

            // Substitui os itens pelo array de marcas
            lst_carro.Items.Clear();
            lst_carro.Items.AddRange(_lstCarroMarcas);

            _lstCarroPlaceholderActive = false;

            // Redesenha e abre seleção visualmente
            lst_carro.Invalidate();
        }
    }
}
