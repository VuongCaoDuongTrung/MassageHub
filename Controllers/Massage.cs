using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using BE_Shop.Data;
using Microsoft.AspNetCore.SignalR;
using BE_Shop.Hubs;

namespace BE_Shop.Controllers.Schemas
{
    [ApiController]
    [Route("/api/Massage")]
    [Produces("application/json")]
    public class Massage : ControllerBase
    {
        private readonly IHubContext<NotificationHub> _hubContext;

        public Massage(IHubContext<NotificationHub> hubContext)
        {
            hubContext = hubContext;
        }

    [HttpGet]
    [Route("PushUer")]
        public IActionResult PushUer(Guid Id, string Username)
        {
            User employee = new User();
            employee.Id = Id;
            employee.UserName = Username;

            _hubContext.Clients.All.SendAsync("ReceiveEmployee", employee);
            return Ok("Done");
        }
    [HttpGet]
        public IActionResult PushMassage(string Massage)
        {
            _hubContext.Clients.All.SendAsync("ReceiveEmployee", Massage);
            return Ok("Done");
        }
   
    }
}
