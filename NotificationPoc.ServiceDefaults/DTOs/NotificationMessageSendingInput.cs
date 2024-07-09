using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationPoc.ServiceDefaults.DTOs
{
    public class NotificationMessageSendingInput
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string[] Recipients { get; set; } = Array.Empty<string>();
        public string AppId { get; set; }
    }
}