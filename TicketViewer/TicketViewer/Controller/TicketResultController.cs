using TicketViewer.Models;
using Newtonsoft.Json;

namespace TicketViewer.Controller
{
    /// <summary>
    /// This class is the controller for the TicketResult Class
    /// </summary>
    public static class TicketResultController
    {
        /// <summary>
        /// Get the description of a ticket
        /// </summary>
        /// <param name="ticketID">The ticket ID we want the description for</param>
        /// <returns>Description of the ticket</returns>
        public static string getDescription(int ticketID)
        {
            return TicketResults.listOfTickets.Find(ticket => ticket.id == ticketID).description;
        }

        /// <summary>
        /// Convert a stream of string to a rootTicket Object
        /// </summary>
        /// <param name="streamOfObject">a stream of strings </param>
        /// <returns>A RootTicket Object</returns>
        public static RootTicket convertStringToObject(string streamOfObject)
        {
            RootTicket rootTickets = new RootTicket();
            return JsonConvert.DeserializeObject<RootTicket>(streamOfObject);
        }

        /// <summary>
        /// Move items from the temporary List to the the persistant list. This allows for recursive web response and avoids dulicates.
        /// </summary>
        public static void moveTempRootTickets()
        {
            foreach (RootTicket rt in TicketResults.tempRootTickets)
            {
                if (!TicketResults.listOfRootTicket.Contains(rt))
                {
                    TicketResults.listOfRootTicket.Add(rt);
                }
            }
        }

        /// <summary>
        /// Clears the array of any root tickets.
        /// </summary>
        public static void clearTempRootTicket()
        {
            TicketResults.tempRootTickets.Clear();
        }

        /// <summary>
        /// Clears the array of any tickets
        /// </summary>
        public static void clearTempTicket()
        {
            TicketResults.tempListOfTikets.Clear();
        }

        /// <summary>
        /// Gets the root ticket list and extracts all the tickets from it.
        /// </summary>
        public static void populateTicketFromRootTicket()
        {
            foreach (RootTicket rt in TicketResults.listOfRootTicket)
            {
                foreach (Tickets tix in rt.tickets)
                {
                    TicketResults.tempListOfTikets.Add(tix);
                }
            }
        }

        /// <summary>
        /// Move tickets from the temp list to the persistant list
        /// </summary>
        public static void moveTempTickets()
        {
            foreach (Tickets tix in TicketResults.tempListOfTikets)
            {
                if (!TicketResults.listOfTickets.Contains(tix))
                {
                    TicketResults.listOfTickets.Add(tix);
                }
            }
        }

        /// <summary>
        /// Add the root ticket to the list
        /// </summary>
        /// <param name="rt">RootTicket Object</param>
        public static void addToTemp(RootTicket rt)
        {
            TicketResults.tempRootTickets.Add(rt);
        }

        /// <summary>
        /// Add the ticket to the list
        /// </summary>
        /// <param name="tix">Ticket object</param>
        public static void addToTemp(Tickets tix)
        {
            TicketResults.tempListOfTikets.Add(tix);
        }
    }
}