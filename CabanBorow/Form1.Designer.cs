namespace CabanBorow
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
            Caban1 = new PictureBox();
            Caban2 = new PictureBox();
            Caban3 = new PictureBox();
            Caban4 = new PictureBox();
            Caban5 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Caban1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Caban2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Caban3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Caban4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Caban5).BeginInit();
            SuspendLayout();
            // 
            // Caban1
            // 
            Caban1.Location = new Point(12, 153);
            Caban1.Name = "Caban1";
            Caban1.Size = new Size(174, 174);
            Caban1.TabIndex = 0;
            Caban1.TabStop = false;
            Caban1.Click += Caban1_Click;
            // 
            // Caban2
            // 
            Caban2.Location = new Point(192, 153);
            Caban2.Name = "Caban2";
            Caban2.Size = new Size(174, 174);
            Caban2.TabIndex = 1;
            Caban2.TabStop = false;
            Caban2.Click += Caban2_Click;
            // 
            // Caban3
            // 
            Caban3.Location = new Point(372, 153);
            Caban3.Name = "Caban3";
            Caban3.Size = new Size(174, 174);
            Caban3.TabIndex = 2;
            Caban3.TabStop = false;
            Caban3.Click += Caban3_Click;
            // 
            // Caban4
            // 
            Caban4.Location = new Point(552, 153);
            Caban4.Name = "Caban4";
            Caban4.Size = new Size(174, 174);
            Caban4.TabIndex = 3;
            Caban4.TabStop = false;
            Caban4.Click += Caban4_Click;
            // 
            // Caban5
            // 
            Caban5.Location = new Point(732, 153);
            Caban5.Name = "Caban5";
            Caban5.Size = new Size(174, 174);
            Caban5.TabIndex = 4;
            Caban5.TabStop = false;
            Caban5.Click += Caban5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(149, 421);
            label1.Name = "label1";
            label1.Size = new Size(0, 89);
            label1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 547);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(Caban5);
            Controls.Add(Caban4);
            Controls.Add(Caban3);
            Controls.Add(Caban2);
            Controls.Add(Caban1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)Caban1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Caban2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Caban3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Caban4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Caban5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void InitCabans()
        {
            sadCaban = Image.FromFile($"{Environment.CurrentDirectory}/Resources/2.png");
            happyCaban = Image.FromFile($"{Environment.CurrentDirectory}/Resources/1.png");
            cabans = new List<PictureBox>() { Caban1, Caban2, Caban3, Caban4, Caban5 };
            foreach (var _ in cabans)
            {
                _.Image = sadCaban;
                _.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            FormBorderStyle = FormBorderStyle.None;
            TransparencyKey = BackColor;
        }
        #endregion

        private PictureBox Caban1;
        private PictureBox Caban2;
        private PictureBox Caban3;
        private PictureBox Caban4;
        private PictureBox Caban5;
        private Label label1;
    }
}