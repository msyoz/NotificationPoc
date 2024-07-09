using NotificationPoc.ServiceDefaults.DTOs;

namespace WebFrontend
{
    public class SendApiClient(HttpClient httpClient)
    {
        public async Task Send(NotificationMessageSendingInput input,
            CancellationToken cancellationToken = default)
        {
            await httpClient.PostAsJsonAsync("/api/send", input, cancellationToken);
        }
    }
}
