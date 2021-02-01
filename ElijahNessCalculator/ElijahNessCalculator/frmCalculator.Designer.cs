
namespace ElijahNessCalculator
{
    partial class frmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculator));
            this.lblHistory = new System.Windows.Forms.Label();
            this.tbxDisplay = new System.Windows.Forms.TextBox();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSqr = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.rlbHistory = new ReverseListBox();
            this.SuspendLayout();
            // 
            // lblHistory
            // 
            this.lblHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.Location = new System.Drawing.Point(725, 21);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(63, 20);
            this.lblHistory.TabIndex = 1;
            this.lblHistory.Text = "History";
            // 
            // tbxDisplay
            // 
            this.tbxDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDisplay.Location = new System.Drawing.Point(13, 13);
            this.tbxDisplay.Name = "tbxDisplay";
            this.tbxDisplay.ReadOnly = true;
            this.tbxDisplay.Size = new System.Drawing.Size(466, 38);
            this.tbxDisplay.TabIndex = 0;
            this.tbxDisplay.Text = "0";
            this.tbxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSqrt
            // 
            this.btnSqrt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.Location = new System.Drawing.Point(13, 64);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(110, 51);
            this.btnSqrt.TabIndex = 1;
            this.btnSqrt.Text = "√ Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnSqr
            // 
            this.btnSqr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqr.Location = new System.Drawing.Point(129, 64);
            this.btnSqr.Name = "btnSqr";
            this.btnSqr.Size = new System.Drawing.Size(110, 51);
            this.btnSqr.TabIndex = 2;
            this.btnSqr.Text = "x^2";
            this.btnSqr.UseVisualStyleBackColor = true;
            this.btnSqr.Click += new System.EventHandler(this.btnSqr_Click);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciprocal.Location = new System.Drawing.Point(361, 64);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(110, 51);
            this.btnReciprocal.TabIndex = 4;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            // 
            // btnPower
            // 
            this.btnPower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPower.Location = new System.Drawing.Point(245, 64);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(110, 51);
            this.btnPower.TabIndex = 3;
            this.btnPower.Text = "x^y";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(361, 129);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(110, 51);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(245, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 51);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Del.";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(129, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 51);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCE
            // 
            this.btnCE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(13, 129);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(110, 51);
            this.btnCE.TabIndex = 5;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(361, 194);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(110, 51);
            this.btnMultiply.TabIndex = 12;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btn9
            // 
            this.btn9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(245, 194);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(110, 51);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(129, 194);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(110, 51);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(13, 194);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(110, 51);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(361, 389);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(110, 51);
            this.btnEquals.TabIndex = 24;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(245, 389);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(110, 51);
            this.btnDecimal.TabIndex = 23;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btn0
            // 
            this.btn0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(129, 389);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(110, 51);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnSign
            // 
            this.btnSign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(13, 389);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(110, 51);
            this.btnSign.TabIndex = 21;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(361, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 51);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(245, 324);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(110, 51);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(129, 324);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(110, 51);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(13, 324);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(110, 51);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(361, 259);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(110, 51);
            this.btnSubtract.TabIndex = 16;
            this.btnSubtract.Text = "--";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btn6
            // 
            this.btn6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(245, 259);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(110, 51);
            this.btn6.TabIndex = 15;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(129, 259);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(110, 51);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(13, 259);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(110, 51);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // rlbHistory
            // 
            this.rlbHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rlbHistory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rlbHistory.FormattingEnabled = true;
            this.rlbHistory.Location = new System.Drawing.Point(494, 44);
            this.rlbHistory.Name = "rlbHistory";
            this.rlbHistory.Size = new System.Drawing.Size(294, 394);
            this.rlbHistory.TabIndex = 25;
            this.rlbHistory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rlbHistory_MouseClick);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnSqr);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.tbxDisplay);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.rlbHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCalculator";
            this.Text = "Elijah\'s Calculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCalculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReverseListBox rlbHistory;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.TextBox tbxDisplay;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSqr;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
    }
}

