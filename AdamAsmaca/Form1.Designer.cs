namespace AdamAsmaca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblYanlisHarfler = new Label();
            button1 = new Button();
            txtHarf = new TextBox();
            lblHataSayisi = new Label();
            pictureBox1 = new PictureBox();
            lblKelime = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblYanlisHarfler
            // 
            lblYanlisHarfler.AutoSize = true;
            lblYanlisHarfler.Location = new Point(50, 72);
            lblYanlisHarfler.Name = "lblYanlisHarfler";
            lblYanlisHarfler.Size = new Size(38, 15);
            lblYanlisHarfler.TabIndex = 0;
            lblYanlisHarfler.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(237, 101);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtHarf
            // 
            txtHarf.Location = new Point(225, 184);
            txtHarf.Name = "txtHarf";
            txtHarf.Size = new Size(100, 23);
            txtHarf.TabIndex = 2;
            // 
            // lblHataSayisi
            // 
            lblHataSayisi.AutoSize = true;
            lblHataSayisi.Location = new Point(50, 126);
            lblHataSayisi.Name = "lblHataSayisi";
            lblHataSayisi.Size = new Size(38, 15);
            lblHataSayisi.TabIndex = 3;
            lblHataSayisi.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bacak2;
            pictureBox1.Location = new Point(413, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 417);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblKelime
            // 
            lblKelime.AutoSize = true;
            lblKelime.Location = new Point(50, 172);
            lblKelime.Name = "lblKelime";
            lblKelime.Size = new Size(38, 15);
            lblKelime.TabIndex = 5;
            lblKelime.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblKelime);
            Controls.Add(pictureBox1);
            Controls.Add(lblHataSayisi);
            Controls.Add(txtHarf);
            Controls.Add(button1);
            Controls.Add(lblYanlisHarfler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblYanlisHarfler;
        private Button button1;
        private TextBox txtHarf;
        private Label lblHataSayisi;
        private PictureBox pictureBox1;
        private Label lblKelime;
    }
}
