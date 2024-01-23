using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR.Client;

namespace Unidad12.Pages
{
    public class IndexModel : PageModel
    {

        private readonly HubConnection _hubConnection;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _hubConnection= new HubConnectionBuilder()
                .WithUrl("http://192.168.0.165:5151")
                .Build();
            _hubConnection.On<string>("ReceiveMessage", (message) => 
            {
                chatMessages.Text += $"{Environment.NewLine}{message}";
            });
        }

        public void OnGet()
        {

        }
    }
}
