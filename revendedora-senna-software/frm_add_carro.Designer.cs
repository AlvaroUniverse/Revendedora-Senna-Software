namespace revendedora_senna_software
{
    partial class frm_add_carro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_header_add = new System.Windows.Forms.Panel();
            this.btn_voltar_add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_nome_vendedor = new System.Windows.Forms.TextBox();
            this.txt_nome_carro = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lst_carro = new System.Windows.Forms.ListBox();
            this.btn_acessorio = new System.Windows.Forms.Button();
            this.pnl_header_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header_add
            // 
            this.pnl_header_add.BackColor = System.Drawing.Color.Transparent;
            this.pnl_header_add.Controls.Add(this.btn_voltar_add);
            this.pnl_header_add.Controls.Add(this.pictureBox1);
            this.pnl_header_add.Location = new System.Drawing.Point(2, 2);
            this.pnl_header_add.Name = "pnl_header_add";
            this.pnl_header_add.Size = new System.Drawing.Size(740, 88);
            this.pnl_header_add.TabIndex = 4;
            this.pnl_header_add.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_header_add_Paint);
            // 
            // btn_voltar_add
            // 
            this.btn_voltar_add.Location = new System.Drawing.Point(11, 18);
            this.btn_voltar_add.Name = "btn_voltar_add";
            this.btn_voltar_add.Size = new System.Drawing.Size(53, 22);
            this.btn_voltar_add.TabIndex = 5;
            this.btn_voltar_add.Text = "Home";
            this.btn_voltar_add.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::revendedora_senna_software.Properties.Resources.senna_ds;
            this.pictureBox1.Location = new System.Drawing.Point(204, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 55);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_nome_vendedor
            // 
            this.txt_nome_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nome_vendedor.Location = new System.Drawing.Point(43, 142);
            this.txt_nome_vendedor.Name = "txt_nome_vendedor";
            this.txt_nome_vendedor.Size = new System.Drawing.Size(164, 20);
            this.txt_nome_vendedor.TabIndex = 5;
            // 
            // txt_nome_carro
            // 
            this.txt_nome_carro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nome_carro.Location = new System.Drawing.Point(43, 263);
            this.txt_nome_carro.Name = "txt_nome_carro";
            this.txt_nome_carro.Size = new System.Drawing.Size(164, 20);
            this.txt_nome_carro.TabIndex = 7;
            // 
            // txt_ano
            // 
            this.txt_ano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ano.Location = new System.Drawing.Point(43, 310);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(164, 20);
            this.txt_ano.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome Completo do Vendedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Marca do Carro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome do carro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ano do carro:";
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(191, 374);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(179, 40);
            this.btn_enviar.TabIndex = 6;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(284, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 172);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acessorios";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 145);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lst_carro
            // 
            this.lst_carro.FormattingEnabled = true;
            this.lst_carro.Location = new System.Drawing.Point(43, 184);
            this.lst_carro.Name = "lst_carro";
            this.lst_carro.Size = new System.Drawing.Size(164, 56);
            this.lst_carro.TabIndex = 14;
            this.lst_carro.SelectedIndexChanged += new System.EventHandler(this.lst_carro_SelectedIndexChanged);
            // 
            // btn_acessorio
            // 
            this.btn_acessorio.Location = new System.Drawing.Point(290, 120);
            this.btn_acessorio.Name = "btn_acessorio";
            this.btn_acessorio.Size = new System.Drawing.Size(120, 25);
            this.btn_acessorio.TabIndex = 15;
            this.btn_acessorio.Text = "Adicionar Acessorios";
            this.btn_acessorio.UseVisualStyleBackColor = true;
            // 
            // frm_add_carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 426);
            this.Controls.Add(this.btn_acessorio);
            this.Controls.Add(this.lst_carro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_nome_carro);
            this.Controls.Add(this.txt_nome_vendedor);
            this.Controls.Add(this.pnl_header_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_add_carro";
            this.Text = "frm_add_carro";
            this.pnl_header_add.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header_add;
        private System.Windows.Forms.Button btn_voltar_add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_nome_vendedor;
        private System.Windows.Forms.TextBox txt_nome_carro;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lst_carro;
        private System.Windows.Forms.Button btn_acessorio;
    }
}