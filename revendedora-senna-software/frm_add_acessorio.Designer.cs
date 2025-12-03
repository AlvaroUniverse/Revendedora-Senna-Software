namespace revendedora_senna_software
{
    partial class frm_add_acessorio
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
            this.btn_enviar_acessorio = new System.Windows.Forms.Button();
            this.txt_acessorio = new System.Windows.Forms.TextBox();
            this.lbl_acessorio = new System.Windows.Forms.Label();
            this.pnl_header_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header_add
            // 
            this.pnl_header_add.BackColor = System.Drawing.Color.Transparent;
            this.pnl_header_add.Controls.Add(this.btn_voltar_add);
            this.pnl_header_add.Controls.Add(this.pictureBox1);
            this.pnl_header_add.Location = new System.Drawing.Point(-62, 5);
            this.pnl_header_add.Name = "pnl_header_add";
            this.pnl_header_add.Size = new System.Drawing.Size(470, 79);
            this.pnl_header_add.TabIndex = 5;
            this.pnl_header_add.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_header_add_Paint);
            // 
            // btn_voltar_add
            // 
            this.btn_voltar_add.Location = new System.Drawing.Point(74, 7);
            this.btn_voltar_add.Name = "btn_voltar_add";
            this.btn_voltar_add.Size = new System.Drawing.Size(53, 22);
            this.btn_voltar_add.TabIndex = 5;
            this.btn_voltar_add.Text = "Voltar";
            this.btn_voltar_add.UseVisualStyleBackColor = true;
            this.btn_voltar_add.Click += new System.EventHandler(this.btn_voltar_add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::revendedora_senna_software.Properties.Resources.senna_ds;
            this.pictureBox1.Location = new System.Drawing.Point(170, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_enviar_acessorio
            // 
            this.btn_enviar_acessorio.Location = new System.Drawing.Point(108, 229);
            this.btn_enviar_acessorio.Name = "btn_enviar_acessorio";
            this.btn_enviar_acessorio.Size = new System.Drawing.Size(143, 28);
            this.btn_enviar_acessorio.TabIndex = 7;
            this.btn_enviar_acessorio.Text = "Enviar";
            this.btn_enviar_acessorio.UseVisualStyleBackColor = true;
            // 
            // txt_acessorio
            // 
            this.txt_acessorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_acessorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_acessorio.Location = new System.Drawing.Point(99, 166);
            this.txt_acessorio.Name = "txt_acessorio";
            this.txt_acessorio.Size = new System.Drawing.Size(164, 24);
            this.txt_acessorio.TabIndex = 8;
            // 
            // lbl_acessorio
            // 
            this.lbl_acessorio.AutoSize = true;
            this.lbl_acessorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acessorio.Location = new System.Drawing.Point(54, 105);
            this.lbl_acessorio.Name = "lbl_acessorio";
            this.lbl_acessorio.Size = new System.Drawing.Size(273, 31);
            this.lbl_acessorio.TabIndex = 9;
            this.lbl_acessorio.Text = "Adicionar Acessorio";
            // 
            // frm_add_acessorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 288);
            this.Controls.Add(this.lbl_acessorio);
            this.Controls.Add(this.txt_acessorio);
            this.Controls.Add(this.btn_enviar_acessorio);
            this.Controls.Add(this.pnl_header_add);
            this.Name = "frm_add_acessorio";
            this.Text = "frm_add_acessorio";
            this.pnl_header_add.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header_add;
        private System.Windows.Forms.Button btn_voltar_add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_enviar_acessorio;
        private System.Windows.Forms.TextBox txt_acessorio;
        private System.Windows.Forms.Label lbl_acessorio;
    }
}