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
    public partial class frm_add_acessorio : Form
    {
        public frm_add_acessorio()
        {
            InitializeComponent();

            // Ao fechar este formulário, restaurar/mostrar o frm_add_carro quando possível
            this.FormClosing += Frm_add_acessorio_FormClosing;

            // Associa o botão Enviar para inserir acessório no painel do frm_add_carro
            btn_enviar_acessorio.Click += Btn_enviar_acessorio_Click;
        }

        private void pnl_header_add_Paint(object sender, PaintEventArgs e)
        {
            pnl_header_add.BackColor =
            ColorTranslator.FromHtml("#002160");
        }

        private void btn_voltar_add_Click(object sender, EventArgs e)
        {
            // Preferir retornar ao frm_add_carro se este form foi aberto por ele
            if (this.Owner is frm_add_carro ownerCarro)
            {
                if (ownerCarro.WindowState == FormWindowState.Minimized)
                    ownerCarro.WindowState = FormWindowState.Normal;

                ownerCarro.Show();
                ownerCarro.BringToFront();
            }
            else if (this.Owner is frm_home ownerHome)
            {
                // Caso tenha sido aberto a partir do frm_home (compatibilidade)
                if (ownerHome.WindowState == FormWindowState.Minimized)
                    ownerHome.WindowState = FormWindowState.Normal;

                ownerHome.Show();
                ownerHome.BringToFront();
            }
            else
            {
                // Caso não haja Owner, tenta encontrar uma instância aberta de frm_add_carro
                var openAddCarro = Application.OpenForms.OfType<frm_add_carro>().FirstOrDefault();
                if (openAddCarro != null)
                {
                    if (openAddCarro.WindowState == FormWindowState.Minimized)
                        openAddCarro.WindowState = FormWindowState.Normal;

                    openAddCarro.Show();
                    openAddCarro.BringToFront();
                }
                else
                {
                    // Se não existir, cria uma nova instância de frm_add_carro
                    var novo = new frm_add_carro();
                    novo.Show();
                }
            }

            // Fecha o formulário atual
            this.Close();
        }

        // Handler do botão Enviar dentro de frm_add_acessorio
        private void Btn_enviar_acessorio_Click(object sender, EventArgs e)
        {
            var nome = txt_acessorio.Text?.Trim();
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Informe o nome do acessório.", "Acessório vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_acessorio.Focus();
                return;
            }

            // Tenta adicionar no Owner (frm_add_carro) primeiro
            if (this.Owner is frm_add_carro ownerCarro)
            {
                ownerCarro.AddAcessorio(nome);
            }
            else
            {
                // Caso não haja Owner, tenta localizar uma instância aberta
                var open = Application.OpenForms.OfType<frm_add_carro>().FirstOrDefault();
                if (open != null)
                    open.AddAcessorio(nome);
                else
                {
                    // Se não houver instância aberta, cria uma nova (mantendo compatibilidade com comportamento anterior)
                    var novo = new frm_add_carro();
                    novo.AddAcessorio(nome);
                    novo.Show();
                }
            }

            // Limpa o campo para permitir entrada de próximo acessório
            txt_acessorio.Clear();
            txt_acessorio.Focus();
        }

        // Ao fechar o formulário, garantir que o usuário volte ao frm_add_carro
        private void Frm_add_acessorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Não tentar reabrir se a aplicação está sendo encerrada globalmente
            if (e.CloseReason == CloseReason.ApplicationExitCall ||
                e.CloseReason == CloseReason.WindowsShutDown ||
                e.CloseReason == CloseReason.TaskManagerClosing)
            {
                return;
            }

            // Se este formulário foi aberto definindo Owner como frm_add_carro, mostra o Owner.
            if (this.Owner is frm_add_carro ownerCarro)
            {
                if (ownerCarro.WindowState == FormWindowState.Minimized)
                    ownerCarro.WindowState = FormWindowState.Normal;

                ownerCarro.Show();
                ownerCarro.BringToFront();
                return;
            }

            // Caso não haja Owner, tenta encontrar uma instância aberta de frm_add_carro
            var openAddCarro = Application.OpenForms.OfType<frm_add_carro>().FirstOrDefault();
            if (openAddCarro != null)
            {
                if (openAddCarro.WindowState == FormWindowState.Minimized)
                    openAddCarro.WindowState = FormWindowState.Normal;

                openAddCarro.Show();
                openAddCarro.BringToFront();
                return;
            }

            // Se não existir, cria uma nova instância e mostra
            var novoForm = new frm_add_carro();
            novoForm.Show();
        }
    }
}
