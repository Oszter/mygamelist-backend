using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyGameList.Models;
using MyGameList.Services;

namespace MyGameList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController(GameService service) : ControllerBase
    {
        readonly GameService _service = service;

        [HttpGet]
        public IEnumerable<Game> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Game> GetById(int id)
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