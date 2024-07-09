using Dapr.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotificationPoc.ServiceDefaults.DTOs;

namespace OtherService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendController : ControllerBase
    {
        private readonly DaprClient daprClient;

        public SendController(DaprClient daprClient)
        {
            this.daprClient = daprClient;
        }

        [HttpPost]
        public IActionResult Send([FromBody] NotificationMessageSendingInput input)
        {
            daprClient.InvokeBindingAsync("binding-notification-output", "create", input);
            return Ok();
        }
    }
}
