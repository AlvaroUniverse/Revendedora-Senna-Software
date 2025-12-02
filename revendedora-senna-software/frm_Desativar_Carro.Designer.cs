namespace revendedora_senna_software
{
    partial class frm_Desativar_Carro
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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_DesativarCarro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_desativar = new System.Windows.Forms.Button();
            this.lst_carroJaAdicionados = new System.Windows.Forms.ListBox();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.Transparent;
            this.pnl_header.Controls.Add(this.btn_voltar);
            this.pnl_header.Controls.Add(this.pictureBox1);
            this.pnl_header.Location = new System.Drawing.Point(1, -6);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(621, 85);
            this.pnl_header.TabIndex = 0;
            this.pnl_header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(11, 18);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(53, 22);
            this.btn_voltar.TabIndex = 5;
            this.btn_voltar.Text = "Home";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::revendedora_senna_software.Properties.Resources.senna_ds;
            this.pictureBox1.Location = new System.Drawing.Point(228, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 54);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_DesativarCarro
            // 
            this.lbl_DesativarCarro.AutoSize = true;
            this.lbl_DesativarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DesativarCarro.Location = new System.Drawing.Point(200, 100);
            this.lbl_DesativarCarro.Name = "lbl_DesativarCarro";
            this.lbl_DesativarCarro.Size = new System.Drawing.Size(220, 31);
            this.lbl_DesativarCarro.TabIndex = 1;
            this.lbl_DesativarCarro.Text = "Desativar Carro";
            this.lbl_DesativarCarro.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o carro para desativar:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_desativar
            // 
            this.btn_desativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desativar.Location = new System.Drawing.Point(128, 300);
            this.btn_desativar.Name = "btn_desativar";
            this.btn_desativar.Size = new System.Drawing.Size(361, 45);
            this.btn_desativar.TabIndex = 3;
            this.btn_desativar.Text = "Desativar Carro";
            this.btn_desativar.UseVisualStyleBackColor = true;
            // 
            // lst_carroJaAdicionados
            // 
            this.lst_carroJaAdicionados.FormattingEnabled = true;
            this.lst_carroJaAdicionados.Location = new System.Drawing.Point(70, 205);
            this.lst_carroJaAdicionados.Name = "lst_carroJaAdicionados";
            this.lst_carroJaAdicionados.Size = new System.Drawing.Size(500, 69);
            this.lst_carroJaAdicionados.TabIndex = 4;
            // 
            // frm_Desativar_Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 357);
            this.Controls.Add(this.lst_carroJaAdicionados);
            this.Controls.Add(this.btn_desativar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_DesativarCarro);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Desativar_Carro";
            this.Text = "Desativar Carro";
            this.Load += new System.EventHandler(this.frm_Desativar_Carro_Load);
            this.pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_DesativarCarro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_desativar;
        private System.Windows.Forms.ListBox lst_carroJaAdicionados;
        private System.Windows.Forms.Button btn_voltar;
    }
}