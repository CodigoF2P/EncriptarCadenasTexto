namespace EncriptarCadenasTexto
{
    public partial class Form1 : Form
    {
        /*
         * Esta aplicaci�n est� enfocada �nicamente a crear claves codificadas,
         * las cuales se pueden usar para los datos de conexi�n,
         * dentro de nuestras cadenas de conexi�n.
         * Se agregan las clases para codificar y decodificar el texto.
         * aunque la �llave� se integra al texto y se guarda dentro de la cadena,
         * la �Llave para encriptar� no se guarda y solo la conoce la persona que usa esta aplicaci�n.
         * Cualquiera es libre de usar estas clases o modificarlas para sus proyectos,
         * as� como de crear sus librer�as en caso de no querer usar clases.
         */
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
            clDecryptText objDecrypt = new clDecryptText();

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
            txtEncryptedText.ReadOnly = false;
        }

        private void btnCleanDecrypt_Click(object sender, EventArgs e)
        {
            txtDecryptText.Text = "";
            txtTextEncrypted.Text = "";
            txtKey2.Text = "";
            txtKeyDecrypt.Text = "";

            btnCopyDecrypt.Visible = false;
            txtDecryptText.ReadOnly = false;
        }

        private void btnCopyEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                //No es necesaria esta linea solo es para enviar un apoyo visual de que el texto fue copiado, se puede cambiar por un mensaje
                txtEncryptedText.ReadOnly = true;

                Clipboard.SetDataObject(txtEncryptedText.Text, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al copiar texto al portapapeles: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopyDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                //No es necesaria esta linea solo es para enviar un apoyo visual de que el texto fue copiado, se puede cambiar por un mensaje
                txtDecryptText.ReadOnly = true;

                Clipboard.SetDataObject(txtDecryptText.Text, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al copiar texto al portapapeles: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}