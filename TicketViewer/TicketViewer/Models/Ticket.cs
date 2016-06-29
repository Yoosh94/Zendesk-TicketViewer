//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using Newtonsoft.Json;

//namespace TicketViewer.Models
//{
//    //This class holds all the data for a ticket
//    public class RootTicketObject
//    {
//        [JsonProperty("ticket")]
//        public TicketProperty result { get; set; }
//    }

//    public class TicketProperty
//    {
//        [JsonProperty("id")]
//        private int _id;
//        public int Id
//        {
//            get { return _id; }
//            set { _id = value; }
//        }
//        [JsonProperty("url")]
//        private string _url;
//        public string Url
//        {
//            get { return _url; }
//            set { _url = value; }
//        }
//        [JsonProperty("external_id")]
//        private string _external_id;
//        public string External_Id
//        {
//            get { return _external_id; }
//            set { _external_id = value; }
//        }
//        [JsonProperty("type")]
//        private string _type;
//        public string Type
//        {
//            get { return _type; }
//            set { _type = value; }
//        }
//        [JsonProperty("subject")]
//        private string _subject;
//        public string Subject
//        {
//            get { return _subject; }
//            set { _subject = value; }
//        }
//        [JsonProperty("description")]
//        private string _description;
//        public string Description
//        {
//            get { return _description; }
//            set { _description = value; }
//        }
//        [JsonProperty("priority")]
//        private string _priority;
//        public string Priority
//        {
//            get { return _priority; }
//            set { _priority = value; }
//        }
//        [JsonProperty("statis")]
//        private string _status;
//        public string Status
//        {
//            get { return _status; }
//            set { _status = value; }
//        }
//        [JsonProperty("recipient")]
//        private string _recipient;
//        public string Recipient
//        {
//            get { return _recipient; }
//            set { _recipient = value; }
//        }
//        [JsonProperty("requester_id")]
//        private Int64 _requestor_id;
//        public Int64 Requestor_Id
//        {
//            get { return _requestor_id; }
//            set { _requestor_id = value; }
//        }
//        [JsonProperty("submitter_id")]
//        private Int64 _submitter_id;
//        public Int64 Submitter_Id
//        {
//            get { return _submitter_id; }
//            set { _submitter_id = value; }
//        }
//        [JsonProperty("assignee_id")]
//        private Int64 _assignee_id;
//        public Int64 Assignee_Id
//        {
//            get { return _assignee_id; }
//            set { _assignee_id = value; }
//        }
//        [JsonProperty("organization_id")]
//        private Int64 _organisation_id;
//        public Int64 Organisation_Id
//        {
//            get { return _organisation_id; }
//            set { _organisation_id = value; }
//        }
//        [JsonProperty("group_id")]
//        private Int64 _group_id;
//        public Int64 Group_Id
//        {
//            get { return _group_id; }
//            set { _group_id = value; }
//        }
//        [JsonProperty("created_at")]
//        private DateTime _created_at;
//        public DateTime Created_At
//        {
//            get { return _created_at; }
//            set { _created_at = value; }
//        }
//        [JsonProperty("updated_at")]
//        private DateTime _updated_at;
//        public DateTime Updated_At
//        {
//            get { return _updated_at; }
//            set { _updated_at = value; }
//        }
//    }
//}