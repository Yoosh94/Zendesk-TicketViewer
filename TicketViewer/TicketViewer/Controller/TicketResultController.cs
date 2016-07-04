using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketViewer.Controller;
using TicketViewer.Models;
using System.Data;
using Newtonsoft.Json;

namespace TicketViewer.Controller
{
    public static class TicketResultController
    {
        public static string getDescription(int ticketID)
        {
            return TicketResults.listOfTickets.Find(ticket => ticket.id == ticketID).description;
        }

        public static RootTicket convertStringToObject(string streamOfObject)
        {
            RootTicket rootTickets = new RootTicket();
            return JsonConvert.DeserializeObject<RootTicket>(streamOfObject);               
        }

        public static void moveTempRootTickets()
        {
            foreach(RootTicket rt in TicketResults.tempRootTickets)
            {
                if (!TicketResults.listOfRootTicket.Contains(rt))
                {
                    TicketResults.listOfRootTicket.Add(rt);
                }
            }
        }

        public static void clearTempRootTicket()
        {
            TicketResults.tempRootTickets.Clear();
        }

        public static void clearTempTicket()
        {
            TicketResults.tempListOfTikets.Clear();
        }

        public static void populateTicketFromRootTicket()
        {
            foreach(RootTicket rt in TicketResults.listOfRootTicket)
            {
                foreach(Tickets tix in rt.tickets)
                {
                    TicketResults.tempListOfTikets.Add(tix);
                }
            }
        }

        public static void moveTempTickets()
        {
            foreach(Tickets tix in TicketResults.tempListOfTikets)
            {
                if (!TicketResults.listOfTickets.Contains(tix))
                {
                    TicketResults.listOfTickets.Add(tix);
                }
            }
        }

        public static void addToTemp(RootTicket rt)
        {
            TicketResults.tempRootTickets.Add(rt);
        }

        public static void addToTemp(Tickets tix)
        {
            TicketResults.tempListOfTikets.Add(tix);
        }
    }
}