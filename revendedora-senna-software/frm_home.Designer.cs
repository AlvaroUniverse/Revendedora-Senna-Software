namespace revendedora_senna_software
{
    partial class frm_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_home));
            this.btn_DesativarCarro = new System.Windows.Forms.Button();
            this.btn_VerCarro = new System.Windows.Forms.Button();
            this.btn_AdicionarCarro = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DesativarCarro
            // 
            this.btn_DesativarCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DesativarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DesativarCarro.Location = new System.Drawing.Point(537, 329);
            this.btn_DesativarCarro.Name = "btn_DesativarCarro";
            this.btn_DesativarCarro.Size = new System.Drawing.Size(183, 40);
            this.btn_DesativarCarro.TabIndex = 5;
            this.btn_DesativarCarro.Text = "Desativar Carro";
            this.btn_DesativarCarro.UseVisualStyleBackColor = true;
            // 
            // btn_VerCarro
            // 
            this.btn_VerCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VerCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerCarro.Location = new System.Drawing.Point(319, 329);
            this.btn_VerCarro.Name = "btn_VerCarro";
            this.btn_VerCarro.Size = new System.Drawing.Size(183, 40);
            this.btn_VerCarro.TabIndex = 4;
            this.btn_VerCarro.Text = "Ver Carros";
            this.btn_VerCarro.UseVisualStyleBackColor = true;
            this.btn_VerCarro.Click += new System.EventHandler(this.btn_VerCarro_Click);
            // 
            // btn_AdicionarCarro
            // 
            this.btn_AdicionarCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AdicionarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdicionarCarro.Location = new System.Drawing.Point(97, 329);
            this.btn_AdicionarCarro.Name = "btn_AdicionarCarro";
            this.btn_AdicionarCarro.Size = new System.Drawing.Size(183, 40);
            this.btn_AdicionarCarro.TabIndex = 3;
            this.btn_AdicionarCarro.Text = "Adicionar Carro";
            this.btn_AdicionarCarro.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(257, 74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(302, 35);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::revendedora_senna_software.Properties.Resources.senna;
            this.pictureBox2.Location = new System.Drawing.Point(468, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 39);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::revendedora_senna_software.Properties.Resources.foto_fundo;
            this.pictureBox1.Location = new System.Drawing.Point(-124, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1006, 200);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 442);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_DesativarCarro);
            this.Controls.Add(this.btn_VerCarro);
            this.Controls.Add(this.btn_AdicionarCarro);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_home";
            this.Text = "Pagina Inicial";
            this.Load += new System.EventHandler(this.frm_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DesativarCarro;
        private System.Windows.Forms.Button btn_VerCarro;
        private System.Windows.Forms.Button btn_AdicionarCarro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}