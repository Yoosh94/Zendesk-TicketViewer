using System;
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
            //This function will load all the tickets.
            loadAllTickets(AccountDetails.listAllTickets);
        }

        //This function will run when a ticket is selected and update the table showing the ticket.
        protected void showTicket(object sender, EventArgs e)
        {
            //Get the Ticket ID
            int tixID = Int32.Parse(ticketGridView.SelectedRow.Cells[1].Text);
            //Create a border for the table
            singleTicketView.Border = 1;
            //Insert the subject that is part of the grid view
            ticketSubject.InnerText = ticketGridView.SelectedRow.Cells[2].Text;
            //Add titles to the table
            requestorIdLabel.InnerText = "Requestor ID: ";
            ticketDescriptionLabel.InnerText = "Description: ";
            priorityLabal.InnerText = "Priority: ";
            statusLabel.InnerText = "Status: ";
            subjectLabel.InnerText = "Subject: ";
            //Add the status of the ticket from the gridView
            statusStatus.InnerText = ticketGridView.SelectedRow.Cells[4].Text;
            //Add the priority from the gridView
            priorityStatus.InnerText = ticketGridView.SelectedRow.Cells[5].Text;
            //Get the description of the ticket by passing a Ticket ID
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
            //Try create a web request, if it fails throw an error
            try
            {
                //Get the string represenation of response
                valueFromAPI = APIController.callWebRequest(url);
                //COnvert the string to an object
                rt = TicketResultController.convertStringToObject(valueFromAPI);
                //Add the new ticket to the correct Lists
                TicketResultController.addToTemp(rt);
                TicketResultController.moveTempRootTickets();
                TicketResultController.clearTempRootTicket();
                TicketResultController.populateTicketFromRootTicket();
                TicketResultController.moveTempTickets();
                TicketResultController.clearTempTicket();
                //Add the list of tickets as the data source for the grid view.
                ticketGridView.DataSource = TicketResults.listOfTickets;
                //Have the list display 25 tickets on one page.
                ticketGridView.PageSize = 25;
                //Create two event handlers for when then page is changed and when a ticket is selected
                ticketGridView.PageIndexChanging += handlePageIndexing;
                ticketGridView.SelectedIndexChanged += showTicket;
                //FInally bind all the data to the grid view
                ticketGridView.DataBind();
            }
            catch (WebException we)
            {
                errorMessageLabel.Text = we.Message;
            }
            catch (Exception ex)
            {
                errorMessageLabel.Text = ex.Message;
            }
            //If there is a second page, (Zendesk API only returns a max of 100 per response) call the function again and repeat the process
            if (rt.next_page != null)
            {
                loadAllTickets(rt.next_page);
            }
        }
    }
}