using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PerfectDay.Repositories;

namespace PerfectDay.Controllers
{
    [Route("api/[controller]")]
    public class HistoryController : ControllerBase
    {
        private readonly IRepositoryHistory<Entities.History> _repositoryHistory;

        public HistoryController(IRepositoryHistory<Entities.History> repositoryHistory)
        {
            _repositoryHistory = repositoryHistory;
        }
        [HttpGet]
        public IEnumerable<Entities.History> Get()
        {
            return _repositoryHistory.GetAll();
        }
        [Route("/api/history/get/{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            if (id > 0)
            {
                try
                {
                    Entities.History goal = _repositoryHistory.FindById(id);
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
        public IActionResult Add(Entities.History goal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }
            else
            {
                _repositoryHistory.Create(goal);
                return Ok();
            }
        }
        [Route("/api/{controller}/update")]
        [HttpPost]
        public IActionResult Update(Entities.History goal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }
            else
            {
                _repositoryHistory.Update(goal);
                return Ok();
            }
        }
        [Route("/api/{controller}/delete/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Entities.History goal = _repositoryHistory.FindById(id);
            if (id <= 0) return BadRequest("Error");
            _repositoryHistory.Delete(goal);
            return Ok();
        }
    }
}