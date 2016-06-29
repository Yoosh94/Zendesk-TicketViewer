﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TicketViewer.Models
{
    public class From
    {
    }

    public class To
    {
    }

    public class Source
    {
        public From from { get; set; }
        public To to { get; set; }
        public object rel { get; set; }
    }

    public class Via
    {
        public string channel { get; set; }
        public Source source { get; set; }
    }

    public class Ticket
    {
        public string url { get; set; }
        public int id { get; set; }
        public string external_id { get; set; }
        public Via via { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string type { get; set; }
        public string subject { get; set; }
        public string raw_subject { get; set; }
        public string description { get; set; }
        public string priority { get; set; }
        public string status { get; set; }
        public string recipient { get; set; }
        public Int64 requester_id { get; set; }
        public Int64 submitter_id { get; set; }
        public Int64 assignee_id { get; set; }
        public Int64 organization_id { get; set; }
        public Int64 group_id { get; set; }
        public List<Int64> collaborator_ids { get; set; }
        public Int64 forum_topic_id { get; set; }
        public int problem_id { get; set; }
        public bool has_incidents { get; set; }
        public DateTime due_at { get; set; }
        public List<string> tags { get; set; }
        public List<object> custom_fields { get; set; }
        public object satisfaction_rating { get; set; }
        public List<object> sharing_agreement_ids { get; set; }
        public List<object> fields { get; set; }
        public int brand_id { get; set; }
        public bool allow_channelback { get; set; }
    }

    public class RootObject
    {
        //[JsonProperty("ticket")]
        public List<Ticket> ticket { get; set; }
        public string next_page { get; set; }
        public object previous_page { get; set; }
        public int count { get; set; }
    }
}