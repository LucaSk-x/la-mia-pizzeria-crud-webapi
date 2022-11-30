using la_mia_pizzeria_crud_webapi.Models;
using la_mia_pizzeria_static.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_crud_webapi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private PizzaDbContext db;
        public MessageController(PizzaDbContext _db)
        {
            db = _db;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Message message)
        {
            try
            {
                db.Messages.Add(message);
                db.SaveChanges();
            }
            catch(Exception e)
            {
                return UnprocessableEntity(e.Message);
            }
            return Ok(message);
        }
    }
}
