using CES.MOD.CES.XGP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace CES.APP.XGP.Classes
{
    public static class Mail
    {

        const string CO_EMAIL_FROM = "protecnica.araxa@gmail.com";
        const string CO_EMAIL_NAME = "Protécnica Sistemas [Não responder]";
        
        public static void SendTicket(modMOVIMENTO pMOV)
        {

            try
            {

                MailMessage oMailMessage = new MailMessage();

                //oMailMessage.From = new MailAddress(ConfigurationManager.AppSettings["GMAIL_FROM"].ToString(), ConfigurationManager.AppSettings["GMAIL_FROM_NAME"].ToString());
                oMailMessage.From = new MailAddress(CO_EMAIL_FROM, string.Format("{0} - E-mail automático", pMOV.CLI.CLI_Nome));

                foreach (string sMailTo in pMOV.BAL.BAL_Mail_To)
                {
                    oMailMessage.To.Add(sMailTo);
                }

                foreach (string sMailBcc in pMOV.BAL.BAL_Mail_Bcc)
                {
                    oMailMessage.Bcc.Add(sMailBcc);
                }

                foreach (string sMailBco in pMOV.BAL.BAL_Mail_Bco)
                {
                    oMailMessage.Bcc.Add(sMailBco);
                }

                oMailMessage.Subject = string.Format("Gestão de Pesagem - Ticket: {1}", pMOV.BAL.BAL_Nome, pMOV.MOV_Ticket); // assunto
                oMailMessage.Body = Get_HtmlTicket(pMOV); // mensagem
                oMailMessage.IsBodyHtml = true;

                // em caso de anexos
                //oMailMessage.Attachments.Add(new Attachment(@"C:\teste.txt"));

                Send(oMailMessage);
            }
            catch (Exception pEx)
            {
                System.Diagnostics.Debug.WriteLine(pEx.Message);
            }

        }

        public static void SendError(string pError)
        {
            try
            {
                MailMessage oMailMessage = new MailMessage();
                oMailMessage.From = new MailAddress(CO_EMAIL_FROM, "Protécnica Sistemas");
                oMailMessage.To.Add(CO_EMAIL_FROM);
                oMailMessage.Subject = string.Format("Gestão de Pesagem - Erro"); 
                oMailMessage.Body = pError;
                oMailMessage.IsBodyHtml = false;
                Send(oMailMessage);
            }
            catch (Exception pEx)
            {
                System.Diagnostics.Debug.WriteLine(pEx.Message);
            }

        }

        private static string Get_HtmlTicket(modMOVIMENTO pMOV)
        {
            string sText = "";

            sText += string.Format(@"<html>");
            sText += string.Format(@"<table style=""height: 400px; background-color: #fff6cc; border-spacing: 10px 0;"" width=""493"" align=""center"">");
            sText += string.Format(@"<tbody>");
            sText += string.Format(@"<tr>");
            sText += string.Format(@"<td style=""width: 483.333px; text-align: center;"" colspan=""2""><strong>Ticket Online</strong></td>");
            sText += string.Format(@"</tr>");
            sText += string.Format(@"<tr>");
            sText += string.Format(@"<td style=""width: 483.333px; text-align: center;"" colspan=""2"">{0}</td>", pMOV.BAL.BAL_Nome);
            sText += string.Format(@"</tr>");
            sText += string.Format(@"<tr>");
            sText += string.Format(@"<td style=""width: 238px;"">Ticket: {0}</td>", pMOV.MOV_Ticket);
            sText += string.Format(@"<td style=""width: 239.333px; text-align: right;"">{0}</td>", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            sText += string.Format(@"</tr>");
            sText += string.Format(@"<tr>");
            sText += string.Format(@"<td style=""width: 483.333px; text-align: left;"" colspan=""2"">Produto: {0}</td>", pMOV.PRD.PRD_Nome);
            sText += string.Format(@"</tr>");
            sText += string.Format(@"<tr>");
            sText += string.Format(@"<td style=""width: 483.333px; text-align: left;"" colspan=""2"">Motorista: {0}</td>", pMOV.Motorista.ENT_Nome);
            sText += string.Format(@"</tr>");
            sText += string.Format(@"<tr>");
            sText += string.Format(@"<td style=""width: 483.333px; text-align: left;"" colspan=""2"">CPF: {0}</td>", pMOV.Motorista.ENT_CPF_CNPJ_Text);
            sText += string.Format(@"</tr>");
            sText += string.Format(@"<tr>");
            sText += string.Format(@"<td style=""width: 483.333px; text-align: left;"" colspan=""2"">Placa: {0}</td>", pMOV.MOV_Placa);
            sText += string.Format(@"</tr>");
            sText += string.Format(@"<tr>");
            sText += string.Format(@"<td style=""width: 483.333px; text-align: left;"" colspan=""2"">Cliente: {0}</td>", pMOV.Cliente.ENT_Nome);
            sText += string.Format(@"</tr>");
            sText += string.Format(@"<tr>");
            sText += string.Format(@"<td style=""width: 483.333px; text-align: left;"" colspan=""2"">Fornecedor: {0}</td>", pMOV.Fornecedor.ENT_Nome);
            sText += string.Format(@"</tr>");
            sText += string.Format(@"<tr>");
            sText += string.Format(@"<td style=""width: 483.333px; text-align: left;"" colspan=""2"">Transp.: {0}</td>", pMOV.Transportadora.ENT_Nome);
            sText += string.Format(@"</tr>");
            if (pMOV.MOV_Observacao.Trim() != "")
            {
                sText += string.Format(@"<tr>");
                sText += string.Format(@"<td style=""width: 483.333px; text-align: left;"" colspan=""2"">Obs.: {0}</td>", pMOV.MOV_Observacao);
                sText += string.Format(@"</tr>");
            }
            if (pMOV.MOV_Tipo.Trim() == "I")
            {
                sText += string.Format(@"<tr>");
                sText += string.Format(@"<td style=""width: 483.333px; text-align: left;"" colspan=""2"">Pesagem interna</td>");
                sText += string.Format(@"</tr>");
            }

            sText += string.Format(@"<tr>");
            sText += string.Format(@"<td style=""width: 238px; text-align: left;""><strong>PESAGEM DE ENTRADA</strong></td>");
            sText += string.Format(@"<td style=""width: 239.333px; text-align: right;""><strong>PESAGEM DE SA&Iacute;DA</strong></td>");
            sText += string.Format(@"</tr>");

            sText += string.Format(@"<tr>");
            sText += string.Format(@"<td style=""width: 238px; text-align: left;"">Data: {0}</td>", pMOV.MOV_EntradaData.ToString("dd/MM/yyyy"));
            sText += string.Format(@"<td style=""width: 238px; text-align: right;"">Data: {0}</td>", pMOV.MOV_SaidaData.ToString("dd/MM/yyyy"));
            sText += string.Format(@"</tr>");

            sText += string.Format(@"<tr>");
            sText += string.Format(@"<td style=""width: 238px; text-align: left;"">Hora: {0}</td>", pMOV.MOV_EntradaData.ToString("HH:mm"));
            sText += string.Format(@"<td style=""width: 238px; text-align: right;"">Hora: {0}</td>", pMOV.MOV_SaidaData.ToString("HH:mm"));
            sText += string.Format(@"</tr>");

            sText += string.Format(@"<tr>");
            sText += string.Format(@"<td style=""width: 238px; text-align: left;"">Peso: {0} kg</td>", pMOV.MOV_EntradaPeso.ToString("N2"));
            sText += string.Format(@"<td style=""width: 238px; text-align: right;"">Peso: {0} kg</td>", pMOV.MOV_SaidaPeso.ToString("N2"));
            sText += string.Format(@"</tr>");

            sText += string.Format(@"<tr>");
            sText += string.Format(@"<td style=""width: 483.333px; text-align: center;"" colspan=""2"">");
            sText += string.Format(@"<h2><strong>L&iacute;quido: {0} kg</strong></h2>", pMOV.MOV_CargaPeso.ToString("N2"));
            sText += string.Format(@"</td>");
            sText += string.Format(@"</tr>");
            sText += string.Format(@"</tbody>");
            sText += string.Format(@"</table>");
            sText += string.Format(@"</html>");

            return sText;
        }

        private static void Send(MailMessage pMailMessage)
        {
            SmtpClient oSmtpClient = new SmtpClient("smtp.gmail.com");
            {
                oSmtpClient.EnableSsl = true; // GMail requer SSL
                oSmtpClient.Port = 587;       // porta para SSL
                oSmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                oSmtpClient.UseDefaultCredentials = false; // vamos utilizar credencias especificas

                // seu usuário e senha para autenticação
                //oSmtpClient.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["GMAIL_FROM"].ToString(), ConfigurationManager.AppSettings["GMAIL_PASSWORD"].ToString());
                oSmtpClient.Credentials = new NetworkCredential(CO_EMAIL_FROM, ConfigurationManager.AppSettings["MAIL_Key"].ToString());

                // envia o e-mail
                oSmtpClient.Send(pMailMessage);
            }
        }
    }
}