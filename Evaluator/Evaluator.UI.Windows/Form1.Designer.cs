namespace Evaluator.UI.Windows
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
            txtInput = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnOpenParenthesis = new Button();
            btnPlus = new Button();
            btnDIvide = new Button();
            btnResult = new Button();
            btnCloseParenthesis = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnPow = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtInput.BackColor = SystemColors.ButtonFace;
            txtInput.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(17, 25);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(583, 61);
            txtInput.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btn7.Location = new Point(17, 92);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 80);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btn8.Location = new Point(112, 92);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 80);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btn9.Location = new Point(207, 92);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 80);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btn6.Location = new Point(207, 178);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 80);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btn5.Location = new Point(112, 178);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 80);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btn4.Location = new Point(17, 178);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 80);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btn3.Location = new Point(207, 264);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 80);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btn2.Location = new Point(112, 264);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 80);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btn1.Location = new Point(17, 264);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 80);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnDot.Location = new Point(207, 350);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(80, 80);
            btnDot.TabIndex = 12;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btn0.Location = new Point(17, 350);
            btn0.Name = "btn0";
            btn0.Size = new Size(175, 80);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnOpenParenthesis.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnOpenParenthesis.Location = new Point(303, 264);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(80, 80);
            btnOpenParenthesis.TabIndex = 15;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlus.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnPlus.Location = new Point(303, 178);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(80, 80);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDIvide
            // 
            btnDIvide.BackColor = Color.FromArgb(255, 128, 0);
            btnDIvide.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnDIvide.ForeColor = Color.Black;
            btnDIvide.Location = new Point(303, 92);
            btnDIvide.Name = "btnDIvide";
            btnDIvide.Size = new Size(80, 80);
            btnDIvide.TabIndex = 13;
            btnDIvide.Text = "/";
            btnDIvide.UseVisualStyleBackColor = false;
            btnDIvide.Click += btnDIvide_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.LimeGreen;
            btnResult.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnResult.Location = new Point(303, 350);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(288, 80);
            btnResult.TabIndex = 20;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnCloseParenthesis.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnCloseParenthesis.Location = new Point(399, 264);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(80, 80);
            btnCloseParenthesis.TabIndex = 19;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnMinus.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnMinus.Location = new Point(399, 178);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(80, 80);
            btnMinus.TabIndex = 18;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiply.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnMultiply.Location = new Point(399, 92);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(80, 80);
            btnMultiply.TabIndex = 17;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.FromArgb(255, 128, 0);
            btnPow.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnPow.Location = new Point(491, 264);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(100, 80);
            btnPow.TabIndex = 23;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnClear.Location = new Point(491, 178);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 80);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnDelete.Location = new Point(491, 92);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 80);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(612, 458);
            Controls.Add(btnPow);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnResult);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnMinus);
            Controls.Add(btnMultiply);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnPlus);
            Controls.Add(btnDIvide);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Functions Evaluator ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnDot;
        private Button btn0;
        private Button btnOpenParenthesis;
        private Button btnPlus;
        private Button btnDIvide;
        private Button btnResult;
        private Button btnCloseParenthesis;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnPow;
        private Button btnClear;
        private Button btnDelete;
    }
}
