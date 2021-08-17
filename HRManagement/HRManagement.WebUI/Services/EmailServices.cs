using HRManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace HRManagement.WebUI.Services
{
    public partial class EmailServices
    {
        //    string mail = "random.murat.super@outlook.com";

        //    string pass = "159753eR!";


        string mail = "smallblog-verification@outlook.com";
        string pass = "sfr19ER!";

        public string SendCode(Personel personel)
        {
            try
            {

                //aktivasyon sayfasının linki + code
                string path = "http://localhost:51601/AccountActivation/Index?code=" +"aktivasyon kodu";
                MailMessage message = new MailMessage(mail, "kullanıcı mail", "Onay Kodu", "Üyeliğinizin onaylanması için bu adresten aktivasyon işleminizi yapabilirsiniz\n\n" + path);
                SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(mail, pass);
                smtp.EnableSsl = true;

                smtp.Send(message);
                return "aktivasyon kodu";
            }
            catch (Exception ex)
            {
                new Exception("Onay Kodu Gönderiminde Hata" + ex.Message);
            }
            return "aktivasyon kodu";
        }

        public string SendTempPass()
        {
            try
            {
                MailMessage mesaj = new MailMessage(mail, "kullanıcı adı", "Geçici Şifre", "Geçici şifresiniz:" + "geçici şifre" + "\nlütfen şifrenizi değiştiriniz. ");
                SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(mail, pass);
                smtp.EnableSsl = true;

                smtp.Send(mesaj);
                return "aktivasyon kodu";
            }
            catch (Exception ex)
            {
                new Exception("Onay Kodu Gönderiminde Hata" + ex.Message);
            }
            return "aktivasyon kodu";
        }

        public bool ResetPasswordMail(string userMail, string code)
        {

            try
            {


                //reset sayfasının linki + mail
                string path = "http://localhost:51601/ResetPassword/ResetPassIndex?mail=" + userMail + "&code=" + code;
                MailMessage mesaj = new MailMessage(mail, userMail, "Şifre Resetleme", "Lütfen aşağıdaki linke tıklayarak şifre resetleme işlemlerini gerçekleştiriniz.Eğer şifre resetleme işlemini siz başlatmadıysanız en kısa sürede bilgilerinizi güncelleyiniz.\n" + path);
                SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(mail, pass);
                smtp.EnableSsl = true;

                smtp.Send(mesaj);
                return true;
            }
            catch (Exception ex)
            {
                new Exception("Şifre reset maili Gönderiminde Hata" + ex.Message);
            }
            return false;
        }

    }
}
