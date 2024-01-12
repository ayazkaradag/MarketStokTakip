namespace MarketStokTakip
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGidaAra = new System.Windows.Forms.Button();
            this.txtGidaAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIcecekAra = new System.Windows.Forms.Button();
            this.txtIcecekAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHijyenAra = new System.Windows.Forms.Button();
            this.txtHijyenAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSorgu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorgu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(345, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOK SORGULAMA EKRANI";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnGidaAra);
            this.groupBox1.Controls.Add(this.txtGidaAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gıda Ürünleri Sorgusu";
            // 
            // btnGidaAra
            // 
            this.btnGidaAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGidaAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGidaAra.Location = new System.Drawing.Point(104, 85);
            this.btnGidaAra.Name = "btnGidaAra";
            this.btnGidaAra.Size = new System.Drawing.Size(75, 37);
            this.btnGidaAra.TabIndex = 2;
            this.btnGidaAra.Text = "Ara";
            this.btnGidaAra.UseVisualStyleBackColor = true;
            this.btnGidaAra.Click += new System.EventHandler(this.txt_Click);
            // 
            // txtGidaAdi
            // 
            this.txtGidaAdi.Location = new System.Drawing.Point(104, 45);
            this.txtGidaAdi.Name = "txtGidaAdi";
            this.txtGidaAdi.Size = new System.Drawing.Size(140, 22);
            this.txtGidaAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnIcecekAra);
            this.groupBox2.Controls.Add(this.txtIcecekAdi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(683, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 146);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İçecek Ürünleri Arama";
            // 
            // btnIcecekAra
            // 
            this.btnIcecekAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcecekAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIcecekAra.Location = new System.Drawing.Point(98, 85);
            this.btnIcecekAra.Name = "btnIcecekAra";
            this.btnIcecekAra.Size = new System.Drawing.Size(78, 37);
            this.btnIcecekAra.TabIndex = 2;
            this.btnIcecekAra.Text = "Ara";
            this.btnIcecekAra.UseVisualStyleBackColor = true;
            this.btnIcecekAra.Click += new System.EventHandler(this.btnIcecekAra_Click);
            // 
            // txtIcecekAdi
            // 
            this.txtIcecekAdi.Location = new System.Drawing.Point(98, 41);
            this.txtIcecekAdi.Name = "txtIcecekAdi";
            this.txtIcecekAdi.Size = new System.Drawing.Size(141, 22);
            this.txtIcecekAdi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnHijyenAra);
            this.groupBox3.Controls.Add(this.txtHijyenAdi);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(350, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 146);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hijyen Ürünleri Sorgusu";
            // 
            // btnHijyenAra
            // 
            this.btnHijyenAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHijyenAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHijyenAra.Location = new System.Drawing.Point(103, 85);
            this.btnHijyenAra.Name = "btnHijyenAra";
            this.btnHijyenAra.Size = new System.Drawing.Size(75, 37);
            this.btnHijyenAra.TabIndex = 2;
            this.btnHijyenAra.Text = "Ara";
            this.btnHijyenAra.UseVisualStyleBackColor = true;
            this.btnHijyenAra.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtHijyenAdi
            // 
            this.txtHijyenAdi.Location = new System.Drawing.Point(102, 45);
            this.txtHijyenAdi.Name = "txtHijyenAdi";
            this.txtHijyenAdi.Size = new System.Drawing.Size(135, 22);
            this.txtHijyenAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adı:";
            // 
            // dgvSorgu
            // 
            this.dgvSorgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSorgu.GridColor = System.Drawing.Color.Black;
            this.dgvSorgu.Location = new System.Drawing.Point(116, 328);
            this.dgvSorgu.Name = "dgvSorgu";
            this.dgvSorgu.RowHeadersWidth = 51;
            this.dgvSorgu.RowTemplate.Height = 24;
            this.dgvSorgu.Size = new System.Drawing.Size(723, 252);
            this.dgvSorgu.TabIndex = 4;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 592);
            this.Controls.Add(this.dgvSorgu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorgu Ekranı";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorgu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvSorgu;
        private System.Windows.Forms.Button btnGidaAra;
        private System.Windows.Forms.TextBox txtGidaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIcecekAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHijyenAra;
        private System.Windows.Forms.TextBox txtHijyenAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIcecekAra;
    }
}