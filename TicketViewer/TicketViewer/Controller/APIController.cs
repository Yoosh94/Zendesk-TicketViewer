using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Net.Http;
using TicketViewer.Models;
using System.Text;


namespace TicketViewer.Controller
{
    public class APIController
    {
        public static string g; 

        public static void initThings()
        {
            //do the request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(AccountDetails.listAllTickets);
            string username = "ayush_94@hotmail.com";
            string password = "Ageofkings12#4";
            String encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
            using (var reader = new StreamReader(resStream))
            {
                string value = reader.ReadToEnd();
                g = value;
            }

        }
    }


}