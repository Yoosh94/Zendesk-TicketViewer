using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketViewer.Controller;
using System.Web;
using TicketViewer.Models;
using System.Net;
using System.IO;
using System.Text;


namespace TicketViewer.Tests
{
    [TestClass]
    public class APIControllerTest
    {


        [TestMethod]
        public void TestInvalidURLNotZendeskDomain()
        {
            try
            {
                APIController.callWebRequest(@"https://invalidURL.com.au");

            }
            catch (WebException we)
            {
                Assert.AreEqual(we.Message, "The remote name could not be resolved: 'invalidurl.com.au'");
            }
        }

        [TestMethod]
        public void TestInvalidURLZendeskDomain()
        {
            try
            {
                APIController.callWebRequest(@"https://firstpointhelp.zendesk.com/api/v2/ticgkets.json");

            }
            catch (WebException we)
            {
                Assert.AreEqual(we.Message, "The remote server returned an error: (404) Not Found.");
            }
        }
        [TestMethod]
        public void TestInvalidAuth()
        {
            AccountDetails.password = "incorrect";
            AccountDetails.username = "incorrect";
            try
            {
                APIController.callWebRequest(AccountDetails.listAllTickets);
            }
            catch (WebException we)
            {
                Assert.AreEqual("The remote server returned an error: (401) Unauthorized.", we.Message);
            }

        }
    }
}
