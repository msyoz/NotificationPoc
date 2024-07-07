using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationPoc.ServiceDefaults.DTOs
{
    public record NotificationMessageSendingInput
    {
        public required string Type { get; init; }
        public required string Title { get; init; }
        public required string Body { get; init; }
        public required string[] Recipients { get; init; }
        public required string AppId { get; init; }
    }
}