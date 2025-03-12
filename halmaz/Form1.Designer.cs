namespace halmaz
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
            listBoxA = new ListBox();
            listBoxB = new ListBox();
            listBoxUnio = new ListBox();
            listBoxMetszet = new ListBox();
            listBoxKulonbsegAB = new ListBox();
            listBoxKulonbsegBA = new ListBox();
            btnGeneral = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownA
            // 
            numericUpDownA.Location = new Point(12, 369);
            numericUpDownA.Name = "numericUpDownA";
            numericUpDownA.Size = new Size(120, 23);
            numericUpDownA.TabIndex = 0;
            numericUpDownA.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDownB
            // 
            numericUpDownB.Location = new Point(138, 369);
            numericUpDownB.Name = "numericUpDownB";
            numericUpDownB.Size = new Size(120, 23);
            numericUpDownB.TabIndex = 1;
            // 
            // listBoxA
            // 
            listBoxA.FormattingEnabled = true;
            listBoxA.ItemHeight = 15;
            listBoxA.Location = new Point(12, 12);
            listBoxA.Name = "listBoxA";
            listBoxA.Size = new Size(120, 274);
            listBoxA.TabIndex = 2;
            // 
            // listBoxB
            // 
            listBoxB.FormattingEnabled = true;
            listBoxB.ItemHeight = 15;
            listBoxB.Location = new Point(138, 12);
            listBoxB.Name = "listBoxB";
            listBoxB.Size = new Size(120, 274);
            listBoxB.TabIndex = 3;
            // 
            // listBoxUnio
            // 
            listBoxUnio.FormattingEnabled = true;
            listBoxUnio.ItemHeight = 15;
            listBoxUnio.Location = new Point(264, 12);
            listBoxUnio.Name = "listBoxUnio";
            listBoxUnio.Size = new Size(120, 274);
            listBoxUnio.TabIndex = 4;
            // 
            // listBoxMetszet
            // 
            listBoxMetszet.FormattingEnabled = true;
            listBoxMetszet.ItemHeight = 15;
            listBoxMetszet.Location = new Point(390, 12);
            listBoxMetszet.Name = "listBoxMetszet";
            listBoxMetszet.Size = new Size(120, 274);
            listBoxMetszet.TabIndex = 5;
            // 
            // listBoxKulonbsegAB
            // 
            listBoxKulonbsegAB.FormattingEnabled = true;
            listBoxKulonbsegAB.ItemHeight = 15;
            listBoxKulonbsegAB.Location = new Point(516, 12);
            listBoxKulonbsegAB.Name = "listBoxKulonbsegAB";
            listBoxKulonbsegAB.Size = new Size(120, 274);
            listBoxKulonbsegAB.TabIndex = 6;
            // 
            // listBoxKulonbsegBA
            // 
            listBoxKulonbsegBA.FormattingEnabled = true;
            listBoxKulonbsegBA.ItemHeight = 15;
            listBoxKulonbsegBA.Location = new Point(642, 12);
            listBoxKulonbsegBA.Name = "listBoxKulonbsegBA";
            listBoxKulonbsegBA.Size = new Size(120, 274);
            listBoxKulonbsegBA.TabIndex = 7;
            // 
            // btnGeneral
            // 
            btnGeneral.Location = new Point(277, 367);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Size = new Size(75, 23);
            btnGeneral.TabIndex = 8;
            btnGeneral.Text = "Generálj!";
            btnGeneral.UseVisualStyleBackColor = true;
            btnGeneral.Click += btnGeneral_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 329);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 9;
            textBox1.Text = "A halmazok elemszáma";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 450);
            Controls.Add(textBox1);
            Controls.Add(btnGeneral);
            Controls.Add(listBoxKulonbsegBA);
            Controls.Add(listBoxKulonbsegAB);
            Controls.Add(listBoxMetszet);
            Controls.Add(listBoxUnio);
            Controls.Add(listBoxB);
            Controls.Add(listBoxA);
            Controls.Add(numericUpDownB);
            Controls.Add(numericUpDownA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownA;
        private NumericUpDown numericUpDownB;
        private ListBox listBoxA;
        private ListBox listBoxB;
        private ListBox listBoxUnio;
        private ListBox listBoxMetszet;
        private ListBox listBoxKulonbsegAB;
        private ListBox listBoxKulonbsegBA;
        private Button btnGeneral;
        private TextBox textBox1;
    }
}
