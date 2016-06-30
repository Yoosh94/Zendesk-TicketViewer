using System;
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
    
    public class Tickets
    {
        public string url { get; set; }
        public int? id { get; set; }
        public string external_id { get; set; }
        public Via via { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public string type { get; set; }
        public string subject { get; set; }
        public string raw_subject { get; set; }
        public string description { get; set; }
        public string priority { get; set; }
        public string status { get; set; }
        public string recipient { get; set; }

        public double requester_id { get; set; }
        public double submitter_id { get; set; }
        public double assignee_id { get; set; }
        public double? organization_id { get; set; }
        public double group_id { get; set; }

        public List<int> collaborator_ids { get; set; }
        public int? forum_topic_id { get; set; }
        public int? problem_id { get; set; }
        public bool has_incidents { get; set; }
        public DateTime? due_at { get; set; }
        public List<string> tags { get; set; }
        public List<string> custom_fields { get; set; }
        public object satisfaction_rating { get; set; }
        public List<string> sharing_agreement_ids { get; set; }
        public List<string> fields { get; set; }
        public int? brand_id { get; set; }
        public bool? allow_channelback { get; set; }
    }

    public class RootTicket
    {
        [JsonProperty("tickets")]
        public List<Tickets> tickets { get; set; }
        public string next_page { get; set; }
        public object previous_page { get; set; }
        public int count { get; set; }
    }
}