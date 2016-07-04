using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Net;
using System.Web.UI.WebControls;
using TicketViewer.Controller;
using TicketViewer.Models;

namespace TicketViewer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Thi function will load all the tickets.
            loadAllTickets(AccountDetails.listAllTickets);
        }

        //This function will run when a ticket is selected and update the table showing the ticket.
        protected void showTicket(object sender, EventArgs e)
        {
            int tixID = Int32.Parse(ticketGridView.SelectedRow.Cells[1].Text);
            singleTicketView.Border = 1;
            ticketSubject.InnerText = ticketGridView.SelectedRow.Cells[2].Text;
            requestorIdLabel.InnerText = "Requestor ID: ";
            ticketDescriptionLabel.InnerText = "Description: ";
            priorityLabal.InnerText = "Priority: ";
            statusLabel.InnerText = "Status: ";
            subjectLabel.InnerText = "Subject: ";
            statusStatus.InnerText = ticketGridView.SelectedRow.Cells[4].Text;
            priorityStatus.InnerText = ticketGridView.SelectedRow.Cells[5].Text;
            ticketDescription.InnerText = TicketResultController.getDescription(tixID);
            requestorId.InnerText = ticketGridView.SelectedRow.Cells[3].Text;
        }

        //This will handle when the user presses a new page.
        protected void handlePageIndexing(object sender, GridViewPageEventArgs e)
        {
            ticketGridView.PageIndex = e.NewPageIndex;
            ticketGridView.DataBind();
        }

        //Function which will load the tickets from a server and save them in appropriate lists.
        private void loadAllTickets(string url)
        {
            RootTicket rt = new RootTicket(); ;
            string valueFromAPI = "";
            try
            {
                valueFromAPI = APIController.callWebRequest(url);
                rt = TicketResultController.convertStringToObject(valueFromAPI);
                //Need to now check for page two?
                TicketResultController.addToTemp(rt);
                TicketResultController.moveTempRootTickets();
                TicketResultController.clearTempRootTicket();
                TicketResultController.populateTicketFromRootTicket();
                TicketResultController.moveTempTickets();
                TicketResultController.clearTempTicket();
                ticketGridView.DataSource = TicketResults.listOfTickets;
                ticketGridView.PageSize = 25;
                ticketGridView.PageIndexChanging += handlePageIndexing;
                ticketGridView.SelectedIndexChanged += showTicket;
                ticketGridView.DataBind();
            }
            catch (WebException we)
            {
                errorMessageLabel.Text = we.Message;
            }
            catch(Exception ex)
            {
                errorMessageLabel.Text = ex.Message;
            }
            if (rt.next_page != null)
            {
                loadAllTickets(rt.next_page);
            }
        }


    }
}