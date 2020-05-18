using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PerfectDay.Repositories;

namespace PerfectDay.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IRepositoryUser<Entities.User> _repositoryUser;

        public UserController(IRepositoryUser<Entities.User> repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }
        [HttpGet]
        public IEnumerable<Entities.User> Get()
        {
            return _repositoryUser.GetAll();
        }
        [Route("/api/users/get/{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            if (id > 0)
            {
                try
                {
                    Entities.User User = _repositoryUser.FindById(id);
                    if (User != null)
                        return Ok(User);
                    else
                        return BadRequest($"Couldn't find a User with id: {id}");
                }

                catch (Exception ex)
                {
                    //logger.critical(ex.message);
                    return BadRequest("Server error(this is not correct)");
                }
            }
            else
            {
                return BadRequest("Incorrect id");
            }
        }
        [Route("/api/{controller}/add")]
        [HttpPost]
        public IActionResult Add([FromBody] Entities.User User)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }
            else
            {
                _repositoryUser.Create(User);
                return Ok();
            }
        }
        [Route("/api/{controller}/update")]
        [HttpPost]
        public IActionResult Update([FromBody] Entities.User User)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }
            else
            {
                _repositoryUser.Update(User);
                return Ok();
            }
        }
        [Route("/api/{controller}/delete/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Entities.User User = _repositoryUser.FindById(id); 
            if (id <= 0) return BadRequest("Invalid Id");
            if (User != null) { _repositoryUser.Delete(User); }
            else
            {
                return BadRequest("Null object");
}

            return Ok();
        }
    }
}