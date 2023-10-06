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
            grbEncrypt = new GroupBox();
            lblText = new Label();
            txtText = new TextBox();
            lblKey = new Label();
            txtKey = new TextBox();
            lblKeyEncryption = new Label();
            txtKeyEncryption = new TextBox();
            btnEncrypt = new Button();
            btnCleanEncrypt = new Button();
            btnCopy = new Button();
            lblEncryptedText = new Label();
            txtEncryptedText = new TextBox();
            grbEncrypt.SuspendLayout();
            SuspendLayout();
            // 
            // grbEncrypt
            // 
            grbEncrypt.Controls.Add(txtEncryptedText);
            grbEncrypt.Controls.Add(lblEncryptedText);
            grbEncrypt.Controls.Add(btnCopy);
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
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(6, 25);
            lblText.Name = "lblText";
            lblText.Size = new Size(111, 15);
            lblText.TabIndex = 0;
            lblText.Text = "Texto para encriptar";
            // 
            // txtText
            // 
            txtText.Location = new Point(123, 22);
            txtText.Name = "txtText";
            txtText.Size = new Size(415, 23);
            txtText.TabIndex = 1;
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
            // txtKey
            // 
            txtKey.Location = new Point(46, 51);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(157, 23);
            txtKey.TabIndex = 3;
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
            // txtKeyEncryption
            // 
            txtKeyEncryption.Location = new Point(325, 51);
            txtKeyEncryption.Name = "txtKeyEncryption";
            txtKeyEncryption.Size = new Size(213, 23);
            txtKeyEncryption.TabIndex = 5;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(6, 80);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(136, 32);
            btnEncrypt.TabIndex = 6;
            btnEncrypt.Text = "Encriptar texto";
            btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // btnCleanEncrypt
            // 
            btnCleanEncrypt.Location = new Point(148, 80);
            btnCleanEncrypt.Name = "btnCleanEncrypt";
            btnCleanEncrypt.Size = new Size(136, 32);
            btnCleanEncrypt.TabIndex = 7;
            btnCleanEncrypt.Text = "Limpiar";
            btnCleanEncrypt.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(402, 80);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(136, 32);
            btnCopy.TabIndex = 8;
            btnCopy.Text = "Copiar";
            btnCopy.UseVisualStyleBackColor = true;
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
            // txtEncryptedText
            // 
            txtEncryptedText.Location = new Point(123, 118);
            txtEncryptedText.Name = "txtEncryptedText";
            txtEncryptedText.Size = new Size(415, 23);
            txtEncryptedText.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 261);
            Controls.Add(grbEncrypt);
            Name = "Form1";
            Text = "Encriptar texto";
            grbEncrypt.ResumeLayout(false);
            grbEncrypt.PerformLayout();
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
        private Button btnCopy;
        private Button btnCleanEncrypt;
        private TextBox txtEncryptedText;
    }
}