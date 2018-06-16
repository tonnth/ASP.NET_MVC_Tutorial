using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
namespace Tutorial.tools
{
    public class SendMail
    {
        public bool sendMail(String from, String subject, String text)
        {
            SmtpClient smtp = new SmtpClient();
            //ĐỊA CHỈ SMTP Server
            smtp.Host = "smtp.gmail.com";
            //Cổng SMTP
            smtp.Port = 587;
            //SMTP yêu cầu mã hóa dữ liệu theo SSL
            smtp.EnableSsl = true;
            //UserName và Password của mail
            smtp.Credentials = new NetworkCredential("bookstoreabc123@gmail.com", "bookstore@123");

            //Tham số lần lượt là địa chỉ người gửi, người nhận, tiêu đề và nội dung thư
            smtp.Send("bookstoreabc123@gmail.com", from, subject, text);
            return true;
        }
    }
}