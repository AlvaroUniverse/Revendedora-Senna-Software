namespace revendedora_senna_software
{
    partial class frm_Cadastrado
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
            this.lbl_DesativarCarro = new System.Windows.Forms.Label();
            this.pnl_header_cadastrados = new System.Windows.Forms.Panel();
            this.btn_voltar_cadastrados = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lsv_carros = new System.Windows.Forms.ListView();
            this.pnl_header_cadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DesativarCarro
            // 
            this.lbl_DesativarCarro.AutoSize = true;
            this.lbl_DesativarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DesativarCarro.Location = new System.Drawing.Point(152, 103);
            this.lbl_DesativarCarro.Name = "lbl_DesativarCarro";
            this.lbl_DesativarCarro.Size = new System.Drawing.Size(276, 31);
            this.lbl_DesativarCarro.TabIndex = 3;
            this.lbl_DesativarCarro.Text = "Carros Cadastrados";
            this.lbl_DesativarCarro.Click += new System.EventHandler(this.lbl_DesativarCarro_Click);
            // 
            // pnl_header_cadastrados
            // 
            this.pnl_header_cadastrados.BackColor = System.Drawing.Color.Transparent;
            this.pnl_header_cadastrados.Controls.Add(this.btn_voltar_cadastrados);
            this.pnl_header_cadastrados.Controls.Add(this.pictureBox1);
            this.pnl_header_cadastrados.Location = new System.Drawing.Point(1, 1);
            this.pnl_header_cadastrados.Name = "pnl_header_cadastrados";
            this.pnl_header_cadastrados.Size = new System.Drawing.Size(588, 85);
            this.pnl_header_cadastrados.TabIndex = 2;
            this.pnl_header_cadastrados.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_header_cadastrados_Paint);
            // 
            // btn_voltar_cadastrados
            // 
            this.btn_voltar_cadastrados.Location = new System.Drawing.Point(11, 18);
            this.btn_voltar_cadastrados.Name = "btn_voltar_cadastrados";
            this.btn_voltar_cadastrados.Size = new System.Drawing.Size(53, 22);
            this.btn_voltar_cadastrados.TabIndex = 5;
            this.btn_voltar_cadastrados.Text = "Home";
            this.btn_voltar_cadastrados.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::revendedora_senna_software.Properties.Resources.senna_ds;
            this.pictureBox1.Location = new System.Drawing.Point(207, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 55);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lsv_carros
            // 
            this.lsv_carros.HideSelection = false;
            this.lsv_carros.Location = new System.Drawing.Point(31, 169);
            this.lsv_carros.Name = "lsv_carros";
            this.lsv_carros.Size = new System.Drawing.Size(527, 152);
            this.lsv_carros.TabIndex = 4;
            this.lsv_carros.UseCompatibleStateImageBehavior = false;
            // 
            // frm_Cadastrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 381);
            this.Controls.Add(this.lsv_carros);
            this.Controls.Add(this.lbl_DesativarCarro);
            this.Controls.Add(this.pnl_header_cadastrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Cadastrado";
            this.Text = "Carros Cadastrados";
            this.Load += new System.EventHandler(this.frm_Cadastrado_Load);
            this.pnl_header_cadastrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DesativarCarro;
        private System.Windows.Forms.Panel pnl_header_cadastrados;
        private System.Windows.Forms.Button btn_voltar_cadastrados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lsv_carros;
    }
}