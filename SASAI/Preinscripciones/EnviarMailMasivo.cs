using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace SASAI
{
    public partial class EnviarMailMasivo : Form
    {
        public EnviarMailMasivo()
        {
            InitializeComponent();
        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }

        private void EnviarMailMasivo_Load(object sender, EventArgs e)
        {
           

        }

        private void btn_EnviarMail_Click(object sender, EventArgs e)
        {
            /*-------------------------MENSAJE DE CORREO----------------------*/

            //Creamos un nuevo Objeto de mensaje
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            //Direccion de correo electronico a la que queremos enviar el mensaje

            AccesoDatos aq = new AccesoDatos();
            DataSet ds = new DataSet();

            try
            {

                string consulta2 = "select Email from Interesados";
                aq.cargaTabla("Interesados", consulta2, ref ds);
                
                for (int i = 0; i < ds.Tables["Interesados"].Rows.Count; i++) {
                    mmsg.To.Add(ds.Tables["Interesados"].Rows[i][0].ToString());
    //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }


            //Asunto
            mmsg.Subject = txb_asunto.Text;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            //Direccion de correo electronico que queremos que reciba una copia del mensaje
           // mmsg.Bcc.Add("destinatariocopia@servidordominio.com"); //Opcional

            //Cuerpo del Mensaje
            mmsg.Body = txb_Mensaje.Text;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true; //Si queremos que se envíe como HTML

            //Correo electronico desde la que enviamos el mensaje
            mmsg.From = new System.Net.Mail.MailAddress(txb_Mail.Text);


            /*-------------------------CLIENTE DE CORREO----------------------*/

            //Creamos un objeto de cliente de correo
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            //Hay que crear las credenciales del correo emisor
            cliente.Credentials =
                new System.Net.NetworkCredential(txb_Mail.Text, txb_pass.Text);

            //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail
           // /*
            cliente.Port = 25;
            cliente.EnableSsl = true;
            //*/

            cliente.Host = "smtp.live.com"; //Para Gmail "smtp.gmail.com";


            /*-------------------------ENVIO DE CORREO----------------------*/

            try
            {
                //Enviamos el mensaje      
                cliente.Send(mmsg);
                MessageBox.Show("Correos Enviados Exitosamente");
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                MessageBox.Show(ex.ToString());
                //Aquí gestionamos los errores al intentar enviar el correo
            }
        }

        private void txb_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btn_EnviarMail_Click(sender, e);
            }
        }
    }
}
