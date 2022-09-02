namespace HashMethodsForm
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
            this.lblUyari = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblEncypt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUyari.Location = new System.Drawing.Point(252, 65);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(203, 19);
            this.lblUyari.TabIndex = 0;
            this.lblUyari.Text = "Şifrelenecek olan metni giriniz:";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(71, 131);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(853, 27);
            this.txtPlainText.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.LightCoral;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncrypt.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEncrypt.Location = new System.Drawing.Point(71, 196);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(227, 27);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Sifrele";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblEncypt
            // 
            this.lblEncypt.AutoSize = true;
            this.lblEncypt.Location = new System.Drawing.Point(315, 203);
            this.lblEncypt.Name = "lblEncypt";
            this.lblEncypt.Size = new System.Drawing.Size(0, 20);
            this.lblEncypt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.lblEncypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.lblUyari);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblEncypt;
    }
}
