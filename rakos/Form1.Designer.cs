namespace rakos
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
            numericUpDownA = new NumericUpDown();
            numericUpDownB = new NumericUpDown();
            btnGeneral = new Button();
            A_halmaz = new ListBox();
            B_halmaz = new ListBox();
            A_unio_B = new ListBox();
            A_metszet_B = new ListBox();
            A_B = new ListBox();
            label2 = new Label();
            B_A = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownA
            // 
            numericUpDownA.Location = new Point(39, 340);
            numericUpDownA.Name = "numericUpDownA";
            numericUpDownA.Size = new Size(88, 23);
            numericUpDownA.TabIndex = 0;
            // 
            // numericUpDownB
            // 
            numericUpDownB.Location = new Point(133, 340);
            numericUpDownB.Name = "numericUpDownB";
            numericUpDownB.Size = new Size(81, 23);
            numericUpDownB.TabIndex = 1;
            // 
            // btnGeneral
            // 
            btnGeneral.Location = new Point(220, 340);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Size = new Size(75, 23);
            btnGeneral.TabIndex = 2;
            btnGeneral.Text = "Generálj!";
            btnGeneral.UseVisualStyleBackColor = true;
            btnGeneral.Click += btnGeneral_Click;
            // 
            // A_halmaz
            // 
            A_halmaz.FormattingEnabled = true;
            A_halmaz.ItemHeight = 15;
            A_halmaz.Location = new Point(25, 60);
            A_halmaz.Name = "A_halmaz";
            A_halmaz.Size = new Size(120, 229);
            A_halmaz.TabIndex = 3;
            A_halmaz.SelectedIndexChanged += numericUpDownA_SelectedIndexChanged;
            // 
            // B_halmaz
            // 
            B_halmaz.FormattingEnabled = true;
            B_halmaz.ItemHeight = 15;
            B_halmaz.Location = new Point(151, 60);
            B_halmaz.Name = "B_halmaz";
            B_halmaz.Size = new Size(120, 229);
            B_halmaz.TabIndex = 4;
            // 
            // A_unio_B
            // 
            A_unio_B.FormattingEnabled = true;
            A_unio_B.ItemHeight = 15;
            A_unio_B.Location = new Point(277, 60);
            A_unio_B.Name = "A_unio_B";
            A_unio_B.Size = new Size(120, 229);
            A_unio_B.TabIndex = 5;
            A_unio_B.SelectedIndexChanged += listBoxUnion_SelectedIndexChanged;
            // 
            // A_metszet_B
            // 
            A_metszet_B.FormattingEnabled = true;
            A_metszet_B.ItemHeight = 15;
            A_metszet_B.Location = new Point(403, 60);
            A_metszet_B.Name = "A_metszet_B";
            A_metszet_B.Size = new Size(120, 229);
            A_metszet_B.TabIndex = 6;
            A_metszet_B.SelectedIndexChanged += listBoxIntersection_SelectedIndexChanged;
            // 
            // A_B
            // 
            A_B.FormattingEnabled = true;
            A_B.ItemHeight = 15;
            A_B.Location = new Point(529, 60);
            A_B.Name = "A_B";
            A_B.Size = new Size(120, 229);
            A_B.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 311);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 9;
            label2.Text = "A halmazok elemszáma:";
            // 
            // B_A
            // 
            B_A.FormattingEnabled = true;
            B_A.ItemHeight = 15;
            B_A.Location = new Point(655, 60);
            B_A.Name = "B_A";
            B_A.Size = new Size(120, 229);
            B_A.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(B_A);
            Controls.Add(label2);
            Controls.Add(A_B);
            Controls.Add(A_metszet_B);
            Controls.Add(A_unio_B);
            Controls.Add(B_halmaz);
            Controls.Add(A_halmaz);
            Controls.Add(btnGeneral);
            Controls.Add(numericUpDownB);
            Controls.Add(numericUpDownA);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownA;
        private NumericUpDown numericUpDownB;
        private Button btnGeneral;
        private ListBox A_halmaz;
        private ListBox B_halmaz;
        private ListBox A_unio_B;
        private ListBox A_metszet_B;
        private ListBox A_B;
        private Label label2;
        private ListBox B_A;
    }
}

