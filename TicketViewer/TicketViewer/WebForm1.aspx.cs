using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TicketViewer.Controller;
using TicketViewer.Models;

namespace TicketViewer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            APIController.callWebRequest(AccountDetails.listAllTickets);
                
        }

        protected void btn_Click(object sender,EventArgs e)
        {
            //APIController.getRequest(AccountDetails.showTicket);
        }
    }
}