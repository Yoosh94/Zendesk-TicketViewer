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
            ticketGridView.DataSource = TicketResults.listOfTickets;
            ticketGridView.PageSize = 25;
            ticketGridView.SelectedIndexChanged += showTicket;
            ticketGridView.DataBind();


        }

        protected void btn_Click(object sender,EventArgs e)
        {
            //APIController.getRequest(AccountDetails.showTicket);
        }

        protected void showTicket(object sender, EventArgs e)
        {
            
            int tixID = Int32.Parse(ticketGridView.SelectedRow.Cells[1].Text);
            singleTicketView.Border = 1;
            ticketSubject.InnerText = ticketGridView.SelectedRow.Cells[2].Text;
            requestorIdLabel.InnerText = "Requestor ID: ";
            ticketDescriptionLabel.InnerText = "Description: ";
            priorityLabal.InnerText = "Priority: ";
            statusLabel.InnerText = "Status: ";
            statusStatus.InnerText = ticketGridView.SelectedRow.Cells[4].Text;
            priorityStatus.InnerText = ticketGridView.SelectedRow.Cells[5].Text;
            ticketDescription.InnerText = TicketResultController.getDescription(tixID);
            requestorId.InnerText = ticketGridView.SelectedRow.Cells[3].Text;

        }

        

    }
}