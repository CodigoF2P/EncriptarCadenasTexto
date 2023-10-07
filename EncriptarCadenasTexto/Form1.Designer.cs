namespace EncriptarCadenasTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            grbEncrypt = new GroupBox();
            txtEncryptedText = new TextBox();
            lblEncryptedText = new Label();
            btnCopyEncrypt = new Button();
            btnCleanEncrypt = new Button();
            btnEncrypt = new Button();
            txtKeyEncryption = new TextBox();
            lblKeyEncryption = new Label();
            txtKey = new TextBox();
            lblKey = new Label();
            txtText = new TextBox();
            lblText = new Label();
            grbDecrypt = new GroupBox();
            txtDecryptText = new TextBox();
            lblDecryptText = new Label();
            btnCopyDecrypt = new Button();
            btnCleanDecrypt = new Button();
            btnDecrypt = new Button();
            txtKeyDecrypt = new TextBox();
            lblKeyDecrypt = new Label();
            txtKey2 = new TextBox();
            lblKey2 = new Label();
            txtTextEncrypted = new TextBox();
            lblTextEncrypted = new Label();
            grbEncrypt.SuspendLayout();
            grbDecrypt.SuspendLayout();
            SuspendLayout();
            // 
            // grbEncrypt
            // 
            grbEncrypt.Controls.Add(txtEncryptedText);
            grbEncrypt.Controls.Add(lblEncryptedText);
            grbEncrypt.Controls.Add(btnCopyEncrypt);
            grbEncrypt.Controls.Add(btnCleanEncrypt);
            grbEncrypt.Controls.Add(btnEncrypt);
            grbEncrypt.Controls.Add(txtKeyEncryption);
            grbEncrypt.Controls.Add(lblKeyEncryption);
            grbEncrypt.Controls.Add(txtKey);
            grbEncrypt.Controls.Add(lblKey);
            grbEncrypt.Controls.Add(txtText);
            grbEncrypt.Controls.Add(lblText);
            grbEncrypt.Location = new Point(12, 12);
            grbEncrypt.Name = "grbEncrypt";
            grbEncrypt.Size = new Size(544, 151);
            grbEncrypt.TabIndex = 0;
            grbEncrypt.TabStop = false;
            grbEncrypt.Text = "Encriptar";
            // 
            // txtEncryptedText
            // 
            txtEncryptedText.Location = new Point(141, 118);
            txtEncryptedText.Name = "txtEncryptedText";
            txtEncryptedText.Size = new Size(397, 23);
            txtEncryptedText.TabIndex = 10;
            // 
            // lblEncryptedText
            // 
            lblEncryptedText.AutoSize = true;
            lblEncryptedText.Location = new Point(6, 121);
            lblEncryptedText.Name = "lblEncryptedText";
            lblEncryptedText.Size = new Size(95, 15);
            lblEncryptedText.TabIndex = 9;
            lblEncryptedText.Text = "Texto encriptado";
            // 
            // btnCopyEncrypt
            // 
            btnCopyEncrypt.Location = new Point(394, 80);
            btnCopyEncrypt.Name = "btnCopyEncrypt";
            btnCopyEncrypt.Size = new Size(144, 32);
            btnCopyEncrypt.TabIndex = 8;
            btnCopyEncrypt.Text = "Copiar";
            btnCopyEncrypt.UseVisualStyleBackColor = true;
            btnCopyEncrypt.Visible = false;
            btnCopyEncrypt.Click += btnCopyEncrypt_Click;
            // 
            // btnCleanEncrypt
            // 
            btnCleanEncrypt.Location = new Point(156, 80);
            btnCleanEncrypt.Name = "btnCleanEncrypt";
            btnCleanEncrypt.Size = new Size(144, 32);
            btnCleanEncrypt.TabIndex = 7;
            btnCleanEncrypt.Text = "Limpiar";
            btnCleanEncrypt.UseVisualStyleBackColor = true;
            btnCleanEncrypt.Click += btnCleanEncrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(6, 80);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(144, 32);
            btnEncrypt.TabIndex = 6;
            btnEncrypt.Text = "Encriptar texto";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // txtKeyEncryption
            // 
            txtKeyEncryption.Location = new Point(343, 51);
            txtKeyEncryption.Name = "txtKeyEncryption";
            txtKeyEncryption.Size = new Size(195, 23);
            txtKeyEncryption.TabIndex = 5;
            // 
            // lblKeyEncryption
            // 
            lblKeyEncryption.AutoSize = true;
            lblKeyEncryption.Location = new Point(209, 54);
            lblKeyEncryption.Name = "lblKeyEncryption";
            lblKeyEncryption.Size = new Size(110, 15);
            lblKeyEncryption.TabIndex = 4;
            lblKeyEncryption.Text = "Llave para encriptar";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(46, 51);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(157, 23);
            txtKey.TabIndex = 3;
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Location = new Point(6, 54);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(34, 15);
            lblKey.TabIndex = 2;
            lblKey.Text = "Llave";
            // 
            // txtText
            // 
            txtText.Location = new Point(141, 22);
            txtText.Name = "txtText";
            txtText.Size = new Size(397, 23);
            txtText.TabIndex = 1;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(6, 25);
            lblText.Name = "lblText";
            lblText.Size = new Size(111, 15);
            lblText.TabIndex = 0;
            lblText.Text = "Texto para encriptar";
            // 
            // grbDecrypt
            // 
            grbDecrypt.Controls.Add(txtDecryptText);
            grbDecrypt.Controls.Add(lblDecryptText);
            grbDecrypt.Controls.Add(btnCopyDecrypt);
            grbDecrypt.Controls.Add(btnCleanDecrypt);
            grbDecrypt.Controls.Add(btnDecrypt);
            grbDecrypt.Controls.Add(txtKeyDecrypt);
            grbDecrypt.Controls.Add(lblKeyDecrypt);
            grbDecrypt.Controls.Add(txtKey2);
            grbDecrypt.Controls.Add(lblKey2);
            grbDecrypt.Controls.Add(txtTextEncrypted);
            grbDecrypt.Controls.Add(lblTextEncrypted);
            grbDecrypt.Location = new Point(12, 169);
            grbDecrypt.Name = "grbDecrypt";
            grbDecrypt.Size = new Size(544, 151);
            grbDecrypt.TabIndex = 1;
            grbDecrypt.TabStop = false;
            grbDecrypt.Text = "Desencriptar";
            // 
            // txtDecryptText
            // 
            txtDecryptText.Location = new Point(141, 118);
            txtDecryptText.Name = "txtDecryptText";
            txtDecryptText.Size = new Size(397, 23);
            txtDecryptText.TabIndex = 10;
            // 
            // lblDecryptText
            // 
            lblDecryptText.AutoSize = true;
            lblDecryptText.Location = new Point(6, 121);
            lblDecryptText.Name = "lblDecryptText";
            lblDecryptText.Size = new Size(103, 15);
            lblDecryptText.TabIndex = 9;
            lblDecryptText.Text = "Texto desencriptar";
            // 
            // btnCopyDecrypt
            // 
            btnCopyDecrypt.Location = new Point(394, 80);
            btnCopyDecrypt.Name = "btnCopyDecrypt";
            btnCopyDecrypt.Size = new Size(144, 32);
            btnCopyDecrypt.TabIndex = 8;
            btnCopyDecrypt.Text = "Copiar";
            btnCopyDecrypt.UseVisualStyleBackColor = true;
            btnCopyDecrypt.Visible = false;
            btnCopyDecrypt.Click += btnCopyDecrypt_Click;
            // 
            // btnCleanDecrypt
            // 
            btnCleanDecrypt.Location = new Point(156, 80);
            btnCleanDecrypt.Name = "btnCleanDecrypt";
            btnCleanDecrypt.Size = new Size(144, 32);
            btnCleanDecrypt.TabIndex = 7;
            btnCleanDecrypt.Text = "Limpiar";
            btnCleanDecrypt.UseVisualStyleBackColor = true;
            btnCleanDecrypt.Click += btnCleanDecrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(6, 80);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(144, 32);
            btnDecrypt.TabIndex = 6;
            btnDecrypt.Text = "Desencriptar texto";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // txtKeyDecrypt
            // 
            txtKeyDecrypt.Location = new Point(343, 51);
            txtKeyDecrypt.Name = "txtKeyDecrypt";
            txtKeyDecrypt.Size = new Size(195, 23);
            txtKeyDecrypt.TabIndex = 5;
            // 
            // lblKeyDecrypt
            // 
            lblKeyDecrypt.AutoSize = true;
            lblKeyDecrypt.Location = new Point(209, 54);
            lblKeyDecrypt.Name = "lblKeyDecrypt";
            lblKeyDecrypt.Size = new Size(128, 15);
            lblKeyDecrypt.TabIndex = 4;
            lblKeyDecrypt.Text = "Llave para desencriptar";
            // 
            // txtKey2
            // 
            txtKey2.Location = new Point(46, 51);
            txtKey2.Name = "txtKey2";
            txtKey2.Size = new Size(157, 23);
            txtKey2.TabIndex = 3;
            // 
            // lblKey2
            // 
            lblKey2.AutoSize = true;
            lblKey2.Location = new Point(6, 54);
            lblKey2.Name = "lblKey2";
            lblKey2.Size = new Size(34, 15);
            lblKey2.TabIndex = 2;
            lblKey2.Text = "Llave";
            // 
            // txtTextEncrypted
            // 
            txtTextEncrypted.Location = new Point(141, 22);
            txtTextEncrypted.Name = "txtTextEncrypted";
            txtTextEncrypted.Size = new Size(397, 23);
            txtTextEncrypted.TabIndex = 1;
            // 
            // lblTextEncrypted
            // 
            lblTextEncrypted.AutoSize = true;
            lblTextEncrypted.Location = new Point(6, 25);
            lblTextEncrypted.Name = "lblTextEncrypted";
            lblTextEncrypted.Size = new Size(129, 15);
            lblTextEncrypted.TabIndex = 0;
            lblTextEncrypted.Text = "Texto para desencriptar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 336);
            Controls.Add(grbDecrypt);
            Controls.Add(grbEncrypt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(584, 375);
            MinimumSize = new Size(584, 375);
            Name = "Form1";
            Text = "Encriptar texto";
            grbEncrypt.ResumeLayout(false);
            grbEncrypt.PerformLayout();
            grbDecrypt.ResumeLayout(false);
            grbDecrypt.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbEncrypt;
        private TextBox txtText;
        private Label lblText;
        private TextBox txtKey;
        private Label lblKey;
        private Label lblKeyEncryption;
        private Button btnEncrypt;
        private TextBox txtKeyEncryption;
        private Label lblEncryptedText;
        private Button btnCopyEncrypt;
        private Button btnCleanEncrypt;
        private TextBox txtEncryptedText;
        private GroupBox grbDecrypt;
        private TextBox txtDecryptText;
        private Label lblDecryptText;
        private Button btnCopyDecrypt;
        private Button btnCleanDecrypt;
        private Button btnDecrypt;
        private TextBox txtKeyDecrypt;
        private Label lblKeyDecrypt;
        private TextBox txtKey2;
        private Label lblKey2;
        private TextBox txtTextEncrypted;
        private Label lblTextEncrypted;
    }
}