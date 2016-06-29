using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketViewer.Models
{
    public static class AccountDetails
    {
        public static string requestUri = @"https://firstpointhelp.zendesk.com/";
        public static string testURl = @"https://firstpointhelp.zendesk.com/api/v2/users/{id}.json";
        public static string showTicket = @"https://firstpointhelp.zendesk.com/api/v2/tickets/101.json";
        public static string listAllTickets = @"https://firstpointhelp.zendesk.com/api/v2/tickets.json";


    }
}