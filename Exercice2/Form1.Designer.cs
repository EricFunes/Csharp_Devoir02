namespace Exercice2
{
    partial class Form1
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
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblPalArr = new System.Windows.Forms.Label();
            this.lblPalForEach = new System.Windows.Forms.Label();
            this.lblPalFor = new System.Windows.Forms.Label();
            this.txtPalindrome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(192, 25);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(305, 61);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "Est-ce un palindrome?";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(32, 153);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(48, 25);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "Mot";
            // 
            // lblPalArr
            // 
            this.lblPalArr.AutoSize = true;
            this.lblPalArr.Location = new System.Drawing.Point(32, 267);
            this.lblPalArr.Name = "lblPalArr";
            this.lblPalArr.Size = new System.Drawing.Size(318, 25);
            this.lblPalArr.TabIndex = 2;
            this.lblPalArr.Text = "Mot inversé par Array.Reverse()";
            // 
            // lblPalForEach
            // 
            this.lblPalForEach.AutoSize = true;
            this.lblPalForEach.Location = new System.Drawing.Point(32, 332);
            this.lblPalForEach.Name = "lblPalForEach";
            this.lblPalForEach.Size = new System.Drawing.Size(284, 25);
            this.lblPalForEach.TabIndex = 3;
            this.lblPalForEach.Text = "Mot inversé avec un foreach";
            // 
            // lblPalFor
            // 
            this.lblPalFor.AutoSize = true;
            this.lblPalFor.Location = new System.Drawing.Point(32, 397);
            this.lblPalFor.Name = "lblPalFor";
            this.lblPalFor.Size = new System.Drawing.Size(237, 25);
            this.lblPalFor.TabIndex = 4;
            this.lblPalFor.Text = "Mot inversé avec un for";
            // 
            // txtPalindrome
            // 
            this.txtPalindrome.Location = new System.Drawing.Point(192, 150);
            this.txtPalindrome.Name = "txtPalindrome";
            this.txtPalindrome.Size = new System.Drawing.Size(305, 31);
            this.txtPalindrome.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.txtPalindrome);
            this.Controls.Add(this.lblPalFor);
            this.Controls.Add(this.lblPalForEach);
            this.Controls.Add(this.lblPalArr);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnValidate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblPalArr;
        private System.Windows.Forms.Label lblPalForEach;
        private System.Windows.Forms.Label lblPalFor;
        private System.Windows.Forms.TextBox txtPalindrome;
    }
}

