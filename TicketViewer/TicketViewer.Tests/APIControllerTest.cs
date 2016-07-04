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

        [TestMethod]
        public void TestInvalidURL()
        {
            try
            {
                APIController.callWebRequest(@"https://invalidURL.com.au");

            }
            catch (WebException we)
            {
                Assert.AreEqual(we.Message, "The remote server returned an error: (404) Not Found.");
            }
        }


        //[TestMethod]
        //public void TestValidOverallWebRequest()
        //{
        //    try
        //    {
        //        APIController.callWebRequest(AccountDetails.listAllTickets);
        //        throw new Exception("Good Exception");
        //    }
        //    catch(Exception e)
        //    {
        //        Assert.AreEqual(e.Message, "Good Exception");
        //    }
        //}

    }
}
