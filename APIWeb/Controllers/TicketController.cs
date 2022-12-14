using APIWeb.Models;
using APIWeb.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public List<Ticket> Get()
        {
            return TicketService.GetAll ();

        }
        [HttpGet]
        [Route("{id}")]
        public Ticket Get(int id)
        {
            Ticket t = TicketService.Get(id);
            return t;
        }
    }
}
