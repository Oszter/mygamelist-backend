using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyGameList.Models;
using MyGameList.Services;

namespace MyGameList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(UserService service) : ControllerBase
    {
        readonly UserService _service = service;

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            var game = _service.GetById(id);

            if (game is not null)
            {
                return game;
            }
            else
            {
                return NotFound();
            }
        }
    }
}