namespace WinFormsCalculator
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(566, 83);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(566, 117);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 23);
            btnSubtract.TabIndex = 3;
            btnSubtract.Text = "SUBTRACT";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(566, 156);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 23);
            btnMultiply.TabIndex = 4;
            btnMultiply.Text = "MULTIPLY";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(566, 194);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 23);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "DIVIDE";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
    }
}
