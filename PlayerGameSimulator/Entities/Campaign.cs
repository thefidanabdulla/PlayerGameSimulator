using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerGameSimulator.Entities
{
    public class Campaign
    {
        public Campaign(int CampaignId, string Name, string Content)
        {
            this.Id = Id;
            this.Name = Name;
            this.Content = Content;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
