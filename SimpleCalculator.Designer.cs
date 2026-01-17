namespace SimpleCalculatorGUI
{
    partial class SimpleCalculator
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
            InputKey1 = new TextBox();
            InputKey2 = new TextBox();
            buttonadd = new Button();
            buttonequals = new Button();
            AnswerBar = new ProgressBar();
            Answer = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            ProgressLabel = new Label();
            buttonsub = new Button();
            buttonmul = new Button();
            buttondiv = new Button();
            ((System.ComponentModel.ISupportInitialize)Answer).BeginInit();
            SuspendLayout();
            // 
            // InputKey1
            // 
            InputKey1.Location = new Point(12, 25);
            InputKey1.Name = "InputKey1";
            InputKey1.Size = new Size(100, 23);
            InputKey1.TabIndex = 0;
            InputKey1.Text = "6";
            // 
            // InputKey2
            // 
            InputKey2.Location = new Point(450, 26);
            InputKey2.Name = "InputKey2";
            InputKey2.Size = new Size(100, 23);
            InputKey2.TabIndex = 1;
            InputKey2.Text = "7";
            // 
            // buttonadd
            // 
            buttonadd.Location = new Point(118, 26);
            buttonadd.Name = "buttonadd";
            buttonadd.Size = new Size(75, 23);
            buttonadd.TabIndex = 2;
            buttonadd.Text = "+";
            buttonadd.UseVisualStyleBackColor = true;
            // 
            // buttonequals
            // 
            buttonequals.Location = new Point(556, 26);
            buttonequals.Name = "buttonequals";
            buttonequals.Size = new Size(75, 23);
            buttonequals.TabIndex = 3;
            buttonequals.Text = "=";
            buttonequals.UseVisualStyleBackColor = true;
            buttonequals.Click += this.button2_Click;
            // 
            // AnswerBar
            // 
            AnswerBar.Location = new Point(276, 150);
            AnswerBar.Name = "AnswerBar";
            AnswerBar.Size = new Size(100, 23);
            AnswerBar.TabIndex = 4;
            AnswerBar.Value = 50;
            // 
            // Answer
            // 
            Answer.Location = new Point(653, 26);
            Answer.Name = "Answer";
            Answer.Size = new Size(120, 23);
            Answer.TabIndex = 5;
            Answer.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 6;
            label1.Text = "Input 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(450, 8);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 7;
            label2.Text = "Input 2:";
            // 
            // ProgressLabel
            // 
            ProgressLabel.AutoSize = true;
            ProgressLabel.Location = new Point(276, 132);
            ProgressLabel.Name = "ProgressLabel";
            ProgressLabel.Size = new Size(55, 15);
            ProgressLabel.TabIndex = 8;
            ProgressLabel.Text = "Progress:";
            // 
            // buttonsub
            // 
            buttonsub.Location = new Point(199, 26);
            buttonsub.Name = "buttonsub";
            buttonsub.Size = new Size(75, 23);
            buttonsub.TabIndex = 9;
            buttonsub.Text = "-";
            buttonsub.UseVisualStyleBackColor = true;
            // 
            // buttonmul
            // 
            buttonmul.Location = new Point(280, 26);
            buttonmul.Name = "buttonmul";
            buttonmul.Size = new Size(75, 23);
            buttonmul.TabIndex = 10;
            buttonmul.Text = "x";
            buttonmul.UseVisualStyleBackColor = true;
            // 
            // buttondiv
            // 
            buttondiv.Location = new Point(361, 25);
            buttondiv.Name = "buttondiv";
            buttondiv.Size = new Size(75, 23);
            buttondiv.TabIndex = 11;
            buttondiv.Text = "÷";
            buttondiv.UseVisualStyleBackColor = true;
            // 
            // SimpleCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttondiv);
            Controls.Add(buttonmul);
            Controls.Add(buttonsub);
            Controls.Add(ProgressLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Answer);
            Controls.Add(AnswerBar);
            Controls.Add(buttonequals);
            Controls.Add(buttonadd);
            Controls.Add(InputKey2);
            Controls.Add(InputKey1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SimpleCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Calculator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Answer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputKey1;
        private TextBox InputKey2;
        private Button buttonadd;
        private Button buttonequals;
        private ProgressBar AnswerBar;
        private NumericUpDown Answer;
        private Label label1;
        private Label label2;
        private Label ProgressLabel;
        private Button buttonsub;
        private Button buttonmul;
        private Button buttondiv;
    }
}
