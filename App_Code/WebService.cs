using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Net.Mail;
using System.Net;
/// <summary>
/// Summary description for WebService
/// </summary>
/// 
[WebService(Namespace="http://microsoft.com/webservices/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]

public class WebService : System.Web.Services.WebService {

    public WebService () {
             //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public void HelloWorld(string name, string surname, string email, string phone, string message1)
    {

        string names = name;
        string server = "smtp.gmail.com";
        int port = 587;
        string to = "sh.sondhi@gmail.com";
        string from = email;
        string subject = "Feedback From"+ name+" "+surname+" email is: "+email;
        string body = @message1;
        MailMessage message = new MailMessage(from, to, subject, body);
        SmtpClient client = new SmtpClient(server, port);
        // Credentials are necessary if the server requires the client 
        // to authenticate before it will send e-mail on the client's behalf.
        client.Credentials = new System.Net.NetworkCredential("sh.sondhi@gmail.com", "Shrewd6622");
        client.EnableSsl = true;
        //new System.Net.NetworkCredential("username", "password");


        try
        {
            client.Send(message);
        }
        catch (Exception ex)
        {
            HttpContext.Current.Response.Redirect("../contact.html?id=0");

        }
        HttpContext.Current.Response.Redirect("../contact.html?id=1");

       
    }
    
}
