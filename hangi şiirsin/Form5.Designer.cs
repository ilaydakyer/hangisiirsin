namespace hangi_şiirsin
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Azure;
            richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(63, 127);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(282, 163);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Seni düşünmek güzel şey,\nümitli şey,\ndünyanın en güzel sesinden\nen güzel şarkıyı dinlemek gibi birşey...\nFakat artık ümit yetmiyor bana,\nben artık şarkı dinlemek değil,\nşarkı söylemek istiyorum...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(272, 53);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 1;
            label1.Text = "Seni Düsünmek";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(417, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(712, 374);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}