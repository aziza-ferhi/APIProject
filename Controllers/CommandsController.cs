using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using commander.Models;
using commander.Data;

namespace commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _Repository;

        public CommandsController(ICommanderRepo repository)
        {
            _Repository=repository;
        }
        //private readonly MockCommanderRepo _Repository = new MockCommanderRepo();
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
          var commandItems = _Repository.GetAppCommands();
          return Ok(commandItems);
        }
        //Get api/commands/id
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById (int id)
        {
          var commandItem= _Repository.GetCommandById(id);
          return Ok(commandItem);
        }      
    }
}