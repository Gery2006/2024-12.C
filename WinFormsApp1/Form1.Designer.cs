namespace WinFormsApp1
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
            jobb = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            bal = new Label();
            label8 = new Label();
            label2 = new Label();
            label10 = new Label();
            label11 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // jobb
            // 
            jobb.Image = Properties.Resources.forgjobb;
            jobb.Location = new Point(622, 9);
            jobb.Name = "jobb";
            jobb.Size = new Size(72, 74);
            jobb.TabIndex = 1;
            jobb.Click += jobb_Click;
            // 
            // label3
            // 
            label3.Image = Properties.Resources.fej3;
            label3.Location = new Point(378, 450);
            label3.Name = "label3";
            label3.Size = new Size(72, 74);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.Image = Properties.Resources.fej8;
            label4.Location = new Point(622, 234);
            label4.Name = "label4";
            label4.Size = new Size(72, 74);
            label4.TabIndex = 3;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Image = Properties.Resources.fej2;
            label5.Location = new Point(248, 351);
            label5.Name = "label5";
            label5.Size = new Size(72, 74);
            label5.TabIndex = 4;
            // 
            // bal
            // 
            bal.Image = Properties.Resources.forgbal;
            bal.Location = new Point(122, 9);
            bal.Name = "bal";
            bal.Size = new Size(72, 74);
            bal.TabIndex = 5;
            bal.Click += label6_Click;
            // 
            // label8
            // 
            label8.Image = Properties.Resources.fej4;
            label8.Location = new Point(505, 351);
            label8.Name = "label8";
            label8.Size = new Size(72, 74);
            label8.TabIndex = 7;
            // 
            // label2
            // 
            label2.Image = Properties.Resources.fej7;
            label2.Location = new Point(505, 133);
            label2.Name = "label2";
            label2.Size = new Size(72, 74);
            label2.TabIndex = 8;
            // 
            // label10
            // 
            label10.Image = Properties.Resources.fej5;
            label10.Location = new Point(248, 133);
            label10.Name = "label10";
            label10.Size = new Size(72, 74);
            label10.TabIndex = 9;
            // 
            // label11
            // 
            label11.Image = Properties.Resources.fej1;
            label11.Location = new Point(122, 234);
            label11.Name = "label11";
            label11.Size = new Size(73, 74);
            label11.TabIndex = 10;
            // 
            // label1
            // 
            label1.Image = Properties.Resources.fej6;
            label1.Location = new Point(378, 59);
            label1.Name = "label1";
            label1.Size = new Size(72, 74);
            label1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(bal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(jobb);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Label jobb;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label bal;
        private Label label8;
        private Label label2;
        private Label label10;
        private Label label11;
        private Label label1;
    }
}
