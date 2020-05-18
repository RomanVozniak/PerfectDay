using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PerfectDay.Repositories;

namespace PerfectDay.Controllers
{
    [Route("/api/[controller]")]
    public class GoalController : ControllerBase
    {
        private readonly IRepositoryGoal<Entities.Goal> _repositoryGoal;

        public GoalController(IRepositoryGoal<Entities.Goal> repositoryGoal)
        {
            _repositoryGoal = repositoryGoal;
        }
        [HttpGet]
        public IEnumerable<Entities.Goal> Get()
        {
            return _repositoryGoal.GetAll();
        }
        [Route("/api/{controller}/get/{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            if (id > 0)
            {
                try
                {
                    Entities.Goal goal = _repositoryGoal.FindById(id);
                    if (goal != null)
                        return Ok(goal);
                    else
                        return BadRequest($"Couldn't find a goal with id: {id}");
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
        public IActionResult Add([FromBody] Entities.Goal goal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }
            else
            {
                _repositoryGoal.Create(goal);
                return Ok();
            }
        }
        [Route("/api/{controller}/update")]
        [HttpPost]
        public IActionResult Update([FromBody] Entities.Goal goal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }
            else
            {
                _repositoryGoal.Update(goal);
                return Ok();
            }
        }
        [Route("/api/{controller}/delete/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Entities.Goal goal = _repositoryGoal.FindById(id);
            if (id <= 0) return BadRequest("Error");
            _repositoryGoal.Delete(goal);
            return Ok();
        }
    }
}