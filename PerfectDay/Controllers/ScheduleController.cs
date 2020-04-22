using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PerfectDay.Repositories;

namespace PerfectDay.Controllers
{
    [Route("api/[controller]")]
    public class ScheduleController : ControllerBase
    {
        private readonly IRepositorySchedule<Entities.Schedule> _repositorySchedule;

        public ScheduleController(IRepositorySchedule<Entities.Schedule> repositorySchedule)
        {
            _repositorySchedule = repositorySchedule;
        }
        [HttpGet]
        public IEnumerable<Entities.Schedule> Get()
        {
            return _repositorySchedule.GetAll();
        }
        [Route("/api/schedules/get/{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            if (id > 0)
            {
                try
                {
                    Entities.Schedule schedule = _repositorySchedule.FindById(id);
                    if (schedule != null)
                        return Ok(schedule);
                    else
                        return BadRequest($"Couldn't find a schedule with id: {id}");
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
        public IActionResult Add(Entities.Schedule schedule)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }
            else
            {
                _repositorySchedule.Create(schedule);
                return Ok();
            }
        }
        [Route("/api/{controller}/update")]
        [HttpPost]
        public IActionResult Update(Entities.Schedule schedule)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
            }
            else
            {
                _repositorySchedule.Update(schedule);
                return Ok();
            }
        }
        [Route("/api/{controller}/delete/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Entities.Schedule schedule = _repositorySchedule.FindById(id);
            if (id <= 0) return BadRequest("Error");
            _repositorySchedule.Remove(schedule);
            return Ok();
        }
    }
}
