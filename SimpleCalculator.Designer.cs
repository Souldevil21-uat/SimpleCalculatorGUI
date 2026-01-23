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
            txtInput1 = new TextBox();
            txtInput2 = new TextBox();
            btnAdd = new Button();
            buttonequals = new Button();
            nudResult = new NumericUpDown();
            lblStatus = new Label();
            lblOpCount = new Label();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            ((System.ComponentModel.ISupportInitialize)nudResult).BeginInit();
            SuspendLayout();
            // 
            // txtInput1
            // 
            txtInput1.Location = new Point(16, 182);
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new Size(100, 23);
            txtInput1.TabIndex = 0;
            txtInput1.Text = "6";
            // 
            // txtInput2
            // 
            txtInput2.Location = new Point(454, 182);
            txtInput2.Name = "txtInput2";
            txtInput2.Size = new Size(100, 23);
            txtInput2.TabIndex = 1;
            txtInput2.Text = "7";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(122, 182);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // buttonequals
            // 
            buttonequals.Location = new Point(560, 182);
            buttonequals.Name = "buttonequals";
            buttonequals.Size = new Size(75, 23);
            buttonequals.TabIndex = 3;
            buttonequals.Text = "=";
            buttonequals.UseVisualStyleBackColor = true;
            // 
            // nudResult
            // 
            nudResult.Location = new Point(657, 182);
            nudResult.Name = "nudResult";
            nudResult.Size = new Size(120, 23);
            nudResult.TabIndex = 5;
            nudResult.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(16, 148);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Input 1:";
            // 
            // lblOpCount
            // 
            lblOpCount.AutoSize = true;
            lblOpCount.Location = new Point(657, 148);
            lblOpCount.Name = "lblOpCount";
            lblOpCount.Size = new Size(55, 15);
            lblOpCount.TabIndex = 8;
            lblOpCount.Text = "Progress:";
            // 
            // btnSub
            // 
            btnSub.Location = new Point(203, 182);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 23);
            btnSub.TabIndex = 9;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(284, 182);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(75, 23);
            btnMul.TabIndex = 10;
            btnMul.Text = "x";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(365, 182);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 23);
            btnDiv.TabIndex = 11;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // SimpleCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(lblOpCount);
            Controls.Add(lblStatus);
            Controls.Add(nudResult);
            Controls.Add(buttonequals);
            Controls.Add(btnAdd);
            Controls.Add(txtInput2);
            Controls.Add(txtInput1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SimpleCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Calculator";
            ((System.ComponentModel.ISupportInitialize)nudResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput1;
        private TextBox txtInput2;
        private Button btnAdd;
        private Button buttonequals;
        private NumericUpDown nudResult;
        private Label lblStatus;
        private Label lblOpCount;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
    }
}
