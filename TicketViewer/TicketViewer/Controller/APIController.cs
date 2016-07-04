using System;
using System.IO;
using System.Net;
using TicketViewer.Models;
using System.Text;



namespace TicketViewer.Controller
{
    public class APIController
    {
        public static string callWebRequest(string url)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            string encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(AccountDetails.username + ":" + AccountDetails.password));
            request.Headers.Add("Authorization", "Basic " + encoded);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(resStream);
            return reader.ReadLine();
        }
    }
}


