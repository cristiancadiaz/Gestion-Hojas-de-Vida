using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
namespace GestionHojasDeVida.Models
{
    public class Correo : IDisposable
    {
        public void Dispose()
        {
            
            SmtpClient cliente = new SmtpClient();
            //espefica el que esta enviando el Email
            //crea un email address que incluye UTF caracteres
            // en el muestra el nombre
            MailAddress from = new MailAddress("omarmanfor@gmail.com", "Omar" + (char)0xD8 + "Manjarres", System.Text.Encoding.UTF8);
            // pone el destinatario
            MailAddress to = new MailAddress("omarmanfor@gmail.com");
            //especifica el contenido del mensaje
            MailMessage mensaje = new MailMessage(from, to);
            mensaje.Body = "Este es un correo de mi para el otro correo por que soy muy teso";
            //incluye algunas non-ASCII en el cuerpo y tema
            string someArrows = new string(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
            mensaje.Body += Environment.NewLine + someArrows;
            mensaje.BodyEncoding = System.Text.Encoding.UTF8;
            mensaje.Subject = "mensaje de prueba" + someArrows;
            mensaje.SubjectEncoding = System.Text.Encoding.UTF8;
            cliente.EnableSsl = true;
          //  cliente.UseDefaultCredentials = false;
            cliente.Host = "smtp.gmail.com";
            cliente.Port = 587;
            cliente.Credentials = new System.Net.NetworkCredential("omarmanfor@gmail.com", "0m4rm4nj4rr35");
            cliente.Send(mensaje);
            //este el que m,e devuleve la llamada cuando el mensaje ya se completo
            // cliente.SendCompleted += new SendCompletedEventHandler();
            //string userState = "test message1";
            //cliente.SendAsync(mensaje, userState);
            mensaje.Dispose();
        }
    }
}