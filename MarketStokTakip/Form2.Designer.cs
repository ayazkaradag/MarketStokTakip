namespace MarketStokTakip
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGida = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnIcecek = new System.Windows.Forms.Button();
            this.btnHijyen = new System.Windows.Forms.Button();
            this.btnSorgu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(311, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hangi Ürün Listesine Ulaşmak İstersiniz?";
            // 
            // btnGida
            // 
            this.btnGida.BackColor = System.Drawing.Color.Transparent;
            this.btnGida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGida.ForeColor = System.Drawing.Color.Black;
            this.btnGida.Location = new System.Drawing.Point(244, 268);
            this.btnGida.Name = "btnGida";
            this.btnGida.Size = new System.Drawing.Size(205, 108);
            this.btnGida.TabIndex = 1;
            this.btnGida.Text = "Gıda Ürünleri";
            this.btnGida.UseVisualStyleBackColor = false;
            this.btnGida.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnIcecek
            // 
            this.btnIcecek.BackColor = System.Drawing.Color.Transparent;
            this.btnIcecek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIcecek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIcecek.ForeColor = System.Drawing.Color.Black;
            this.btnIcecek.Location = new System.Drawing.Point(244, 415);
            this.btnIcecek.Name = "btnIcecek";
            this.btnIcecek.Size = new System.Drawing.Size(205, 108);
            this.btnIcecek.TabIndex = 3;
            this.btnIcecek.Text = "İçecekler";
            this.btnIcecek.UseVisualStyleBackColor = false;
            this.btnIcecek.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnHijyen
            // 
            this.btnHijyen.BackColor = System.Drawing.Color.Transparent;
            this.btnHijyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHijyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHijyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHijyen.ForeColor = System.Drawing.Color.Black;
            this.btnHijyen.Location = new System.Drawing.Point(533, 268);
            this.btnHijyen.Name = "btnHijyen";
            this.btnHijyen.Size = new System.Drawing.Size(205, 108);
            this.btnHijyen.TabIndex = 4;
            this.btnHijyen.Text = "Hijyen Ürünleri";
            this.btnHijyen.UseVisualStyleBackColor = false;
            this.btnHijyen.Click += new System.EventHandler(this.btnHijyen_Click);
            // 
            // btnSorgu
            // 
            this.btnSorgu.BackColor = System.Drawing.Color.Transparent;
            this.btnSorgu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSorgu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgu.ForeColor = System.Drawing.Color.Black;
            this.btnSorgu.Location = new System.Drawing.Point(533, 415);
            this.btnSorgu.Name = "btnSorgu";
            this.btnSorgu.Size = new System.Drawing.Size(205, 108);
            this.btnSorgu.TabIndex = 5;
            this.btnSorgu.Text = "Stok Sorgu Ekranı";
            this.btnSorgu.UseVisualStyleBackColor = false;
            this.btnSorgu.Click += new System.EventHandler(this.btnSorgu_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 592);
            this.Controls.Add(this.btnSorgu);
            this.Controls.Add(this.btnHijyen);
            this.Controls.Add(this.btnIcecek);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGida);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form2";
            this.Text = "Seçim Listesi";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGida;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIcecek;
        private System.Windows.Forms.Button btnHijyen;
        private System.Windows.Forms.Button btnSorgu;
    }
}