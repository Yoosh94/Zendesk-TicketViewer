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
        //public static void getAllTickets()
        //{
        //    //do the request
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(AccountDetails.listAllTickets);
        //    string username = "ayush_94@hotmail.com";
        //    string password = "Ageofkings12#4";
        //    string encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
        //    request.Headers.Add("Authorization", "Basic " + encoded);
        //    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //    Stream resStream = response.GetResponseStream();
        //    StreamReader reader = new StreamReader(resStream);
        //    string value = reader.ReadLine();
        //    RootTicket d = new RootTicket();
        //    d = JsonConvert.DeserializeObject<RootTicket>(value);
        //    //If there is a second page that needs to be called.
        //    if(d.next_page != null)
        //    {

        //    }


        //}

        public static void callWebRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            string encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(AccountDetails.username + ":" + AccountDetails.password));
            request.Headers.Add("Authorization", "Basic " + encoded);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(resStream);
            string valueFromAPI = reader.ReadLine();
            RootTicket tickets = new RootTicket();
            tickets = JsonConvert.DeserializeObject<RootTicket>(valueFromAPI);
            //Add the tickets to a list.
            ResultController.listOfTicket.Add(tickets);
            //If there is a next page, call this method again.
            if (tickets.next_page != null)
            {
                callWebRequest(tickets.next_page);
            }

        }
    }


}


