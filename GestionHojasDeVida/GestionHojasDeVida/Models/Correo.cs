using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
namespace GestionHojasDeVida.Models
{
    public class Correo 
    {
        public void enviaEmail()
        {
            
            SmtpClient cliente = new SmtpClient();
            //espefica el que esta enviando el Email
            //crea un email address que incluye UTF caracteres
            // en el muestra el nombre
            MailAddress from = new MailAddress("hojasdevidakonrad@gmail.com", "Hojas" + "de" + "Vida", System.Text.Encoding.UTF8);
            // pone el destinatario
            MailAddress to = new MailAddress("omarmanfor@gmail.com");
            //especifica el contenido del mensaje
            MailMessage mensaje = new MailMessage(from, to);
            mensaje.Body = "Señor(a) hemos revisado su hoja de vida y queremos informarle que debe ingresar el dia tal para empezar la capacitación del nuevo cargo.";
            //incluye algunas non-ASCII en el cuerpo y tema
            string someArrows = new string(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
            mensaje.Body += Environment.NewLine;
            mensaje.BodyEncoding = System.Text.Encoding.UTF8;
            mensaje.Subject = "Confirmación de cargo";
            mensaje.SubjectEncoding = System.Text.Encoding.UTF8;
            cliente.EnableSsl = true;
          //  cliente.UseDefaultCredentials = false;
            cliente.Host = "smtp.gmail.com";
            cliente.Port = 587;
            cliente.Credentials = new System.Net.NetworkCredential("hojasdevidakonrad@gmail.com", "ingenieria2");
            cliente.Send(mensaje);
            //este el que m,e devuleve la llamada cuando el mensaje ya se completo
            // cliente.SendCompleted += new SendCompletedEventHandler();
            //string userState = "test message1";
            //cliente.SendAsync(mensaje, userState);
            mensaje.Dispose();
           
        }
    }
}