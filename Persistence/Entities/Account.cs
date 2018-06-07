using System;

namespace AnitaBlog.Persistence.Entities
{
    public class Account
    {
        public Guid ID { get; set; }
        public string Username { get; set; }
        public string DisplayedName { get; set; }
    }
}