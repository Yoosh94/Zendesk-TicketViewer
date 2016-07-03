using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketViewer.Controller;
using TicketViewer.Models;
using System.Data;

namespace TicketViewer.Controller
{
    public static class TicketResultController
    {
        public static string getDescription(int ticketID)
        {
            //var query = from singleTicket in TicketResults.listOfTickets
            //            where singleTicket.id == ticketID
            //            select singleTicket.description;
            return TicketResults.listOfTickets.Find(ticket => ticket.id == ticketID).description;
        }
    }
}