namespace revendedora_senna_software
{
    partial class frm_Menu
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
            this.lbl_TextRevendedora = new System.Windows.Forms.Label();
            this.lbl_TextSenna = new System.Windows.Forms.Label();
            this.btn_AdicionarCarro = new System.Windows.Forms.Button();
            this.btn_VerCarro = new System.Windows.Forms.Button();
            this.btn_DesativarCarro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_TextRevendedora
            // 
            this.lbl_TextRevendedora.AutoSize = true;
            this.lbl_TextRevendedora.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TextRevendedora.Location = new System.Drawing.Point(46, 9);
            this.lbl_TextRevendedora.Name = "lbl_TextRevendedora";
            this.lbl_TextRevendedora.Size = new System.Drawing.Size(629, 108);
            this.lbl_TextRevendedora.TabIndex = 3;
            this.lbl_TextRevendedora.Text = "Revendedora";
            // 
            // lbl_TextSenna
            // 
            this.lbl_TextSenna.AutoSize = true;
            this.lbl_TextSenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TextSenna.Location = new System.Drawing.Point(209, 117);
            this.lbl_TextSenna.Name = "lbl_TextSenna";
            this.lbl_TextSenna.Size = new System.Drawing.Size(326, 108);
            this.lbl_TextSenna.TabIndex = 4;
            this.lbl_TextSenna.Text = "Senna";
            // 
            // btn_AdicionarCarro
            // 
            this.btn_AdicionarCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AdicionarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdicionarCarro.Location = new System.Drawing.Point(55, 276);
            this.btn_AdicionarCarro.Name = "btn_AdicionarCarro";
            this.btn_AdicionarCarro.Size = new System.Drawing.Size(190, 40);
            this.btn_AdicionarCarro.TabIndex = 0;
            this.btn_AdicionarCarro.Text = "Adicionar Carro";
            this.btn_AdicionarCarro.UseVisualStyleBackColor = true;
            // 
            // btn_VerCarro
            // 
            this.btn_VerCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VerCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerCarro.Location = new System.Drawing.Point(277, 276);
            this.btn_VerCarro.Name = "btn_VerCarro";
            this.btn_VerCarro.Size = new System.Drawing.Size(190, 40);
            this.btn_VerCarro.TabIndex = 1;
            this.btn_VerCarro.Text = "Ver Carros";
            this.btn_VerCarro.UseVisualStyleBackColor = true;
            // 
            // btn_DesativarCarro
            // 
            this.btn_DesativarCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DesativarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DesativarCarro.Location = new System.Drawing.Point(495, 276);
            this.btn_DesativarCarro.Name = "btn_DesativarCarro";
            this.btn_DesativarCarro.Size = new System.Drawing.Size(190, 40);
            this.btn_DesativarCarro.TabIndex = 2;
            this.btn_DesativarCarro.Text = "Desativar Carro";
            this.btn_DesativarCarro.UseVisualStyleBackColor = true;
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(724, 372);
            this.Controls.Add(this.btn_DesativarCarro);
            this.Controls.Add(this.btn_VerCarro);
            this.Controls.Add(this.btn_AdicionarCarro);
            this.Controls.Add(this.lbl_TextSenna);
            this.Controls.Add(this.lbl_TextRevendedora);
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revendora Senna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TextRevendedora;
        private System.Windows.Forms.Label lbl_TextSenna;
        private System.Windows.Forms.Button btn_AdicionarCarro;
        private System.Windows.Forms.Button btn_VerCarro;
        private System.Windows.Forms.Button btn_DesativarCarro;
    }
}