using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotificationPoc.ServiceDefaults.DTOs;
using System.Reflection;
using System.Text;

namespace NotificationService.Controllers
{
    [ApiController]
    public class ServiceController : ControllerBase
    {
        [HttpPost("/binding-notification-input")]
        public ActionResult<Guid> Send([FromBody] NotificationMessageSendingInput input)
        {
            Console.WriteLine("Received Message: \n" + PrintObject(input));
            return Guid.NewGuid();
        }

        private string PrintObject(NotificationMessageSendingInput input)
        {
            StringBuilder sb = new StringBuilder();

            // Get the type of the input object
            Type type = input.GetType();

            // Get all the properties of the input object
            PropertyInfo[] properties = type.GetProperties();

            // Iterate through each property and append its name and value to the StringBuilder
            foreach (PropertyInfo property in properties)
            {
                string propertyName = property.Name;
                object propertyValue = property.GetValue(input);

                sb.AppendLine($"{propertyName}: {propertyValue}");
            }

            // Return the string representation of the object's properties
            return sb.ToString();
        }
    }
}
