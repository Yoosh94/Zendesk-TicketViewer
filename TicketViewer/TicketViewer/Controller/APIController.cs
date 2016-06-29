using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Net.Http;
using TicketViewer.Models;
using System.Text;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;


namespace TicketViewer.Controller
{
    public class APIController
    {
        public static void getAllTickets()
        {
            //do the request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(AccountDetails.listAllTickets);
            string username = "ayush_94@hotmail.com";
            string password = "Ageofkings12#4";
            String encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(resStream);
            string value = reader.ReadLine();
            RootObject d = new RootObject();
            d = JsonConvert.DeserializeObject<RootObject>(value);       

        }
    }


}


