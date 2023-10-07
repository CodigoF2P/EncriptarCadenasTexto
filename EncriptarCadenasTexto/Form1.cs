namespace EncriptarCadenasTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            clEncryptText objEncrypt = new clEncryptText();

            txtEncryptedText.Text = objEncrypt.Encrypt(txtText.Text, txtKey.Text, txtKeyEncryption.Text);
            btnCopyEncrypt.Visible = true;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            clEncryptText objDecrypt = new clEncryptText();

            txtDecryptText.Text = objDecrypt.Decrypt(txtTextEncrypted.Text, txtKey2.Text, txtKeyDecrypt.Text);
            btnCopyDecrypt.Visible = true;
        }

        private void btnCleanEncrypt_Click(object sender, EventArgs e)
        {
            txtEncryptedText.Text = "";
            txtText.Text = "";
            txtKey.Text = "";
            txtKeyEncryption.Text = "";

            btnCopyEncrypt.Visible = false;
        }

        private void btnCleanDecrypt_Click(object sender, EventArgs e)
        {
            txtDecryptText.Text = "";
            txtTextEncrypted.Text = "";
            txtKey2.Text = "";
            txtKeyDecrypt.Text = "";

            btnCopyDecrypt.Visible = false;
        }
    }
}