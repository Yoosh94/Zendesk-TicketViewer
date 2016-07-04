using System;
using System.IO;
using System.Net;
using TicketViewer.Models;
using System.Text;

namespace TicketViewer.Controller
{
    /// <summary>
    /// This call will control any calls that are made to the Zendesk API
    /// </summary>
    public class APIController
    {
        /// <summary>
        /// Make a web request to a URL specififed in the parameter. Basic authentication is used and the response is returned as a string
        /// </summary>
        /// <param name="url">URL to make a request too.</param>
        /// <returns>string representation of the response</returns>
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


