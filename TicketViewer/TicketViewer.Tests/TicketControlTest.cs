using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketViewer.Controller;
using TicketViewer.Models;
using System.Linq;
using System.Collections.Generic;


namespace TicketViewer.Tests
{
    [TestClass]
    public class TicketControlTest
    {
        [TestMethod]
        public void TestGetDescriptionIsTrue()
        {
            //Create ticket
            Tickets ticket = new Tickets();
            ticket.description = "This is a test Ticket";
            ticket.id = 1;
            TicketResults.listOfTickets.Add(ticket);
            //run function and get description of the ticket.
            string description = TicketResultController.getDescription(1);
            Assert.AreEqual(description, "This is a test Ticket");
        }

        [TestMethod]
        public void TestGetDescriptionIsFalse()
        {
            //Craete ticket
            Tickets ticket = new Tickets();
            ticket.description = "This is a test Ticket";
            ticket.id = 1;
            TicketResults.listOfTickets.Add(ticket);
            //run function and get description of the ticket.
            string description = TicketResultController.getDescription(1);
            Assert.AreNotEqual(description, "incorrect");
        }

        [TestMethod]
        public void TestMoveTempRootTicket()
        {
            //Setting up Tickets and lists.
            RootTicket rt = new RootTicket();
            Tickets ticket = new Tickets();
            ticket.id = 1;
            ticket.subject = "Test SUbject";
            List<Tickets> list = new List<Tickets>();
            list.Add(ticket);
            rt.tickets = list;
            List<RootTicket> rtList = new List<RootTicket>();
            rtList.Add(rt);
            TicketResults.tempRootTickets = rtList;
            //show that the two lists are not equal
            Assert.AreNotEqual(TicketResults.tempRootTickets, TicketResults.listOfRootTicket);
            //Run function
            TicketResultController.moveTempRootTickets();
            //Check that there is only one object in the list
            Assert.AreEqual(TicketResults.listOfRootTicket.Count, 1);
        }

        [TestMethod]
        public void TestMoveTempRootTicketFail()
        {
            //Setting up Tickets and lists.
            RootTicket rt = new RootTicket();
            Tickets ticket = new Tickets();
            ticket.id = 1;
            ticket.subject = "Test SUbject";
            List<Tickets> list = new List<Tickets>();
            list.Add(ticket);
            rt.tickets = list;
            List<RootTicket> rtList = new List<RootTicket>();
            rtList.Add(rt);
            TicketResults.tempRootTickets = rtList;
            //show that the two lists are not equal
            Assert.AreNotEqual(TicketResults.tempRootTickets, TicketResults.listOfRootTicket);
            //Run function
            TicketResultController.moveTempRootTickets();
            //Check that there is only one object in the list
            Assert.AreNotEqual(TicketResults.listOfRootTicket.Count, 5);
        }


        [TestMethod]
        public void TestClearTempRootTicket()
        {
            RootTicket rt = new RootTicket();
            TicketResults.tempRootTickets.Add(rt);
            //Make sure there is atleast one ticket first
            Assert.IsTrue(TicketResults.tempRootTickets.Count > 0, "The count was not greater than 0");
            TicketResultController.clearTempRootTicket();
            //Check that there is zero tickets now
            Assert.AreEqual(TicketResults.tempRootTickets.Count, 0);
        }

        [TestMethod]
        public void TestClearTempRootTicketFail()
        {
            RootTicket rt = new RootTicket();
            TicketResults.tempRootTickets.Add(rt);
            //Make sure there is atleast one ticket first
            Assert.IsTrue(TicketResults.tempRootTickets.Count > 0, "The count was not greater than 0");
            TicketResultController.clearTempRootTicket();
            //Check that there is zero tickets now
            Assert.AreNotEqual(TicketResults.tempRootTickets.Count, 10);
        }

        [TestMethod]
        public void TestClearTempTicket()
        {
            Tickets ticket = new Tickets();
            TicketResults.tempListOfTikets.Add(ticket);
            //Make sure there is atleast one ticket first
            Assert.IsTrue(TicketResults.tempListOfTikets.Count > 0, "The count was not greater than 0");
            TicketResultController.clearTempTicket();
            //Check that there is zero tickets now
            Assert.AreEqual(TicketResults.tempRootTickets.Count, 0);
        }

        [TestMethod]
        public void TestClearTempTicketFail()
        {
            Tickets ticket = new Tickets();
            TicketResults.tempListOfTikets.Add(ticket);
            //Make sure there is atleast one ticket first
            Assert.IsTrue(TicketResults.tempListOfTikets.Count > 0, "The count was not greater than 0");
            TicketResultController.clearTempTicket();
            //Check that there is zero tickets now
            Assert.AreNotEqual(TicketResults.tempRootTickets.Count, 10);
        }


        [TestMethod]
        public void TestPopulateTicketsFromRootTickets()
        {
            Assert.IsTrue(TicketResults.tempListOfTikets.Count == 0, "The count was not zero");
            //Setting up Tickets and lists.
            RootTicket rt = new RootTicket();
            Tickets ticket = new Tickets();
            ticket.id = 1;
            ticket.subject = "Test SUbject";
            List<Tickets> list = new List<Tickets>();
            list.Add(ticket);
            rt.tickets = list;
            List<RootTicket> rtList = new List<RootTicket>();
            rtList.Add(rt);
            TicketResults.tempRootTickets = rtList;
            //Run function
            TicketResultController.populateTicketFromRootTicket();
            Assert.IsTrue(TicketResults.tempListOfTikets.Count > 0, "The count was not zero after function");
        }

        [TestMethod]
        public void TestMoveTempTicket()
        {
            //Setting up the ticket
            Tickets ticket1 = new Tickets();
            ticket1.id = 1;
            ticket1.subject = "Test SUbject";
            Tickets ticket2 = new Tickets();
            ticket2.id = 2;
            ticket2.subject = "Test SUbject 2";
            Tickets ticket3 = new Tickets();
            ticket3.id = 3;
            ticket3.subject = "Test SUbject 3";
            List<Tickets> listOfTicket = new List<Tickets>();
            listOfTicket.Add(ticket1);
            listOfTicket.Add(ticket2);
            listOfTicket.Add(ticket3);
            TicketResults.tempListOfTikets = listOfTicket;
            //Run function
            TicketResultController.moveTempTickets();
            //Check that there is only one object in the list
            Assert.IsTrue(TicketResults.listOfTickets.Count > 0, "List has more than zero objects after function");
        }
    }
}
