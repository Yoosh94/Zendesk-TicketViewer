using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketViewer.Models
{
    //This class holds all the data for a ticket
    public class Ticket
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _url;
        public string Url
        {
            get {return _url;}
            set { _url = value;}
        }

        private string _external_id;
        public string External_Id
        {
            get { return _external_id; }
            set { _external_id = value; }
        }

        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _priority;
        public string Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        private string _status;
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private string _recipient;
        public string Recipient
        {
            get { return _recipient; }
            set { _recipient = value; }
        }

        private int _requestor_id;
        public int Requestor_Id
        {
            get { return _requestor_id; }
            set { _requestor_id = value; }
        }

        private int _submitter_id;
        public int Submitter_Id
        {
            get { return _submitter_id; }
            set { _submitter_id = value; }
        }

        private int _assignee_id;
        public int Assignee_Id
        {
            get { return _assignee_id; }
            set { _assignee_id = value; }
        }

        private int _organisation_id;
        public int Organisation_Id
        {
            get { return _organisation_id; }
            set { _organisation_id = value; }
        }

        private int _group_id;
        public int Group_Id
        {
            get { return _group_id; }
            set { _group_id = value; }
        }

    }
}