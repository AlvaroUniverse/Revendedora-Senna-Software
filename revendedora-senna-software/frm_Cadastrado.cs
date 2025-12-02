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
    public partial class frm_Cadastrado : Form
    {
        public frm_Cadastrado()
        {
            InitializeComponent();

            // Associa o clique do botão "Home" para voltar ao frm_home
            btn_voltar_cadastrados.Click += Btn_voltar_cadastrados_Click;

            // Quando o formulário for fechado, mostra o frm_home (ou o Owner, se definido),
            // exceto quando a aplicação está sendo finalizada pelo sistema ou por Application.Exit.
            this.FormClosing += Frm_Cadastrado_FormClosing;

            // Configura a ListView para permitir apenas rolagem (sem seleção/edição/interação)
            ConfigureListViewForScrollOnly();
        }

        private void ConfigureListViewForScrollOnly()
        {
            if (lsv_carros == null) return;

            // Propriedades básicas
            lsv_carros.LabelEdit = false;                     // não permite editar labels
            lsv_carros.FullRowSelect = false;                 // não seleciona a linha inteira
            lsv_carros.MultiSelect = false;                   // evita múltiplas seleções
            lsv_carros.HideSelection = true;                  // não manter seleção visível
            lsv_carros.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lsv_carros.TabStop = false;                       // evita foco via TAB
            lsv_carros.Scrollable = true;                     // garante que a rolagem esteja ativa
            lsv_carros.ShowItemToolTips = false;

            // Cancelar qualquer seleção que apareça (p.ex. por clique)
            lsv_carros.ItemSelectionChanged += (s, e) =>
            {
                if (e.IsSelected)
                    BeginInvoke((MethodInvoker)(() => lsv_carros.SelectedItems.Clear()));
            };

            lsv_carros.SelectedIndexChanged += (s, e) =>
            {
                if (lsv_carros.SelectedItems.Count > 0)
                    BeginInvoke((MethodInvoker)(() => lsv_carros.SelectedItems.Clear()));
            };

            // Cliques do mouse não devem selecionar / abrir itens
            lsv_carros.MouseDown += (s, e) =>
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                    BeginInvoke((MethodInvoker)(() => lsv_carros.SelectedItems.Clear()));
            };
            lsv_carros.MouseUp += (s, e) =>
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                    BeginInvoke((MethodInvoker)(() => lsv_carros.SelectedItems.Clear()));
            };
            lsv_carros.MouseClick += (s, e) =>
            {
                // evita menu de contexto ou seleção por clique; mantém apenas rolagem
                BeginInvoke((MethodInvoker)(() => lsv_carros.SelectedItems.Clear()));
            };
            lsv_carros.DoubleClick += (s, e) =>
            {
                // impede ação em double click
                BeginInvoke((MethodInvoker)(() => lsv_carros.SelectedItems.Clear()));
            };

            // Bloqueia navegação por teclado dentro da lista (setas, enter, etc.)
            lsv_carros.KeyDown += (s, e) =>
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            };

            // Evita foco visual quando clicado (permite rolagem pela roda do mouse)
            lsv_carros.GotFocus += (s, e) =>
            {
                this.ActiveControl = null;
            };
        }

        private void Frm_Cadastrado_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Não reabrir o home se a aplicação está sendo encerrada globalmente
            if (e.CloseReason == CloseReason.ApplicationExitCall ||
                e.CloseReason == CloseReason.WindowsShutDown ||
                e.CloseReason == CloseReason.TaskManagerClosing)
            {
                return;
            }

            if (this.Owner != null)
            {
                this.Owner.Show();
            }
            else
            {
                var home = new frm_home();
                home.Show();
            }
        }

        private void Btn_voltar_cadastrados_Click(object sender, EventArgs e)
        {
            // Se este formulário foi aberto definindo Owner (frm_home), mostra o Owner.
            // Caso contrário, instancia um novo frm_home.
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
            else
            {
                var home = new frm_home();
                home.Show();
            }

            // Fecha o formulário atual (libera recursos); Home ficará visível.
            this.Close();
        }

        private void frm_Cadastrado_Load(object sender, EventArgs e)
        {

        }

        private void lbl_DesativarCarro_Click(object sender, EventArgs e)
        {

        }

        private void pnl_header_cadastrados_Paint(object sender, PaintEventArgs e)
        {
            pnl_header_cadastrados.BackColor =
            ColorTranslator.FromHtml("#002160");
        }
    }
}
