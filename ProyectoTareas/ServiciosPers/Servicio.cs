using ProyectoTareas.Models;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProyectoTareas.ServiciosPers
{
    /// <summary>
    /// Servicios personalizados para el sitio
    /// Programador: Alan Torres
    /// Fecha: 26-05-2015
    /// </summary>
    public class Servicio
    {
        /// <summary>
        /// Servicio para transferencia de mails, Requiere SendGrid
        /// Nuget Pack Install-Package Sendgrid
        /// </summary>
        public class EmailServicio {
            string usuario = ConfigurationManager.AppSettings["usuario"];
            string contraseña = ConfigurationManager.AppSettings["contraseña"];
            /// <summary>
            /// Envia el mensaje configurado de send grid al destinatario
            /// </summary>
            /// <returns></returns>
            public async Task EnviarMensaje(MCorreoElectronico model) {
                await ConfigMensaje(model);
            }
            /// <summary>
            /// Configura el mensaje a enviar
            /// </summary>
            /// <returns></returns>
            private async Task ConfigMensaje(MCorreoElectronico model)
            {

                var mensaje = new SendGrid.SendGridMessage();
                mensaje.AddTo(model.destino);
                mensaje.From = new System.Net.Mail.MailAddress(model.de, "HomeWork Wizard");
                mensaje.Subject = model.asunot;
                mensaje.Text = model.mensaje;
                mensaje.Html = model.mensajeHtml;
                var credenciales = new NetworkCredential(usuario,contraseña);
                var transporteWeb = new Web(credenciales);
                if (transporteWeb != null)
                {
                    await transporteWeb.DeliverAsync(mensaje);
                }
                else {
                    Trace.TraceError("Error");
                    await Task.FromResult(0);
                }
            }
        }
    }
}