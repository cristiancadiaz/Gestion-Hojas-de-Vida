using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.ComponentModel;

namespace GestionHojasDeVida.Models
{
    public class Correo 
    {
        static bool mailSent = false;
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            String token = (string)e.UserState;

            if (e.Cancelled)
            {
                Console.WriteLine("[{0}] Send canceled.", token);
            }
            if (e.Error != null)
            {
                Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
            }
            else
            {
                Console.WriteLine("Message sent.");
            }
            mailSent = true;
        }



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

            //    static bool mailSent = false;
            //private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
            //{
            //    // Get the unique identifier for this asynchronous operation.
            //    String token = (string)e.UserState;

            //    if (e.Cancelled)
            //    {
            //        Console.WriteLine("[{0}] Send canceled.", token);
            //    }
            //    if (e.Error != null)
            //    {
            //        Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Message sent.");
            //    }
            //    mailSent = true;

            //string userState = "test message1";
            //client.SendAsync(message, userState);
            //Console.WriteLine("Sending message... press c to cancel mail. Press any other key to exit.");
            //string answer = Console.ReadLine();
            //// If the user canceled the send, and mail hasn't been sent yet,
            //// then cancel the pending operation.
            //if (answer.StartsWith("c") && mailSent == false)
            //{
            //    client.SendAsyncCancel();
            //}
            //// Clean up.
            //message.Dispose();
            //Console.WriteLine("Goodbye.");

        }
    }
}