namespace n6_Calculator {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnPlus = new System.Windows.Forms.Button();
            this.lbNumber1 = new System.Windows.Forms.Label();
            this.lbOperation = new System.Windows.Forms.Label();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.lbNumber2 = new System.Windows.Forms.Label();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lbAnswerField = new System.Windows.Forms.Label();
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.tbNumber2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.AutoSize = true;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlus.FlatAppearance.BorderSize = 3;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(190, 68);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(35, 35);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lbNumber1
            // 
            this.lbNumber1.AutoSize = true;
            this.lbNumber1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNumber1.Location = new System.Drawing.Point(23, 25);
            this.lbNumber1.Name = "lbNumber1";
            this.lbNumber1.Size = new System.Drawing.Size(136, 37);
            this.lbNumber1.TabIndex = 1;
            this.lbNumber1.Text = "Number 1";
            // 
            // lbOperation
            // 
            this.lbOperation.AutoSize = true;
            this.lbOperation.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOperation.Location = new System.Drawing.Point(23, 68);
            this.lbOperation.Name = "lbOperation";
            this.lbOperation.Size = new System.Drawing.Size(137, 37);
            this.lbOperation.TabIndex = 2;
            this.lbOperation.Text = "Operation";
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAnswer.Location = new System.Drawing.Point(23, 157);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(103, 37);
            this.lbAnswer.TabIndex = 4;
            this.lbAnswer.Text = "Answer";
            // 
            // lbNumber2
            // 
            this.lbNumber2.AutoSize = true;
            this.lbNumber2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNumber2.Location = new System.Drawing.Point(23, 111);
            this.lbNumber2.Name = "lbNumber2";
            this.lbNumber2.Size = new System.Drawing.Size(136, 37);
            this.lbNumber2.TabIndex = 3;
            this.lbNumber2.Text = "Number 2";
            // 
            // btnMultiply
            // 
            this.btnMultiply.AutoSize = true;
            this.btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMultiply.FlatAppearance.BorderSize = 3;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(291, 68);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(35, 35);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.Text = "*";
            this.btnMultiply.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.AutoSize = true;
            this.btnDivision.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDivision.FlatAppearance.BorderSize = 3;
            this.btnDivision.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDivision.Location = new System.Drawing.Point(341, 68);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(35, 35);
            this.btnDivision.TabIndex = 6;
            this.btnDivision.Text = "/";
            this.btnDivision.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.AutoSize = true;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMinus.FlatAppearance.BorderSize = 3;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(241, 68);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(35, 35);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lbAnswerField
            // 
            this.lbAnswerField.AutoSize = true;
            this.lbAnswerField.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAnswerField.Location = new System.Drawing.Point(181, 157);
            this.lbAnswerField.Name = "lbAnswerField";
            this.lbAnswerField.Size = new System.Drawing.Size(29, 37);
            this.lbAnswerField.TabIndex = 8;
            this.lbAnswerField.Text = "..";
            // 
            // tbNumber1
            // 
            this.tbNumber1.Location = new System.Drawing.Point(181, 25);
            this.tbNumber1.Multiline = true;
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(203, 28);
            this.tbNumber1.TabIndex = 9;
            // 
            // tbNumber2
            // 
            this.tbNumber2.Location = new System.Drawing.Point(181, 120);
            this.tbNumber2.Multiline = true;
            this.tbNumber2.Name = "tbNumber2";
            this.tbNumber2.Size = new System.Drawing.Size(203, 28);
            this.tbNumber2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 313);
            this.Controls.Add(this.tbNumber2);
            this.Controls.Add(this.tbNumber1);
            this.Controls.Add(this.lbAnswerField);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.lbNumber2);
            this.Controls.Add(this.lbOperation);
            this.Controls.Add(this.lbNumber1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lbNumber1;
        private System.Windows.Forms.Label lbOperation;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.Label lbNumber2;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lbAnswerField;
        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.TextBox tbNumber2;
    }
}
