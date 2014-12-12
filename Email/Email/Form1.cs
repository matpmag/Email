using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace Email
{
    public partial class Form1 : Form
    {
        string to;
        string subject;
        string body;

        public Form1()
        {
            InitializeComponent();
        }

        void btnSend_Click(object sender, EventArgs e)
        {
            to = tbxTo.Text;
            subject = tbxSubject.Text;
            body = tbxBody.Text;
            if (validEmail(to) && !(tbxSubject.Text == "" || tbxBody.Text == "")) //If email is valid and neither subject nor body are empty then...
            {
                sendMail();
                MessageBox.Show("Sent");
            }
        }

        bool validEmail(string email) //checks if email is valid
        {
            try { return new System.Net.Mail.MailAddress(email).Address == email; }
            catch { return false; }
        }

        void sendMail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com"); //Change if using hotmail etc

            mail.From = new MailAddress("softwaresystemsggs@gmail.com"); //From address
            mail.To.Add(to);
            mail.Subject = subject;
            mail.Body = body;

            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("softwaresystemsggs", "ggsssd123"); //Dummy username and password in here
            smtp.EnableSsl = true;

            smtp.Send(mail);
        }
    }
}