namespace Exercice3
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.numTime = new System.Windows.Forms.NumericUpDown();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // numTime
            // 
            this.numTime.Location = new System.Drawing.Point(156, 63);
            this.numTime.Name = "numTime";
            this.numTime.Size = new System.Drawing.Size(120, 31);
            this.numTime.TabIndex = 1;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(377, 57);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(191, 41);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Chercher";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(12, 136);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(771, 302);
            this.txtBox.TabIndex = 3;
            this.txtBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.numTime);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown numTime;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.RichTextBox txtBox;
    }
}

