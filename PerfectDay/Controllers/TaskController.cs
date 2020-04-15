using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PerfectDay.Repositories;
using PerfectDay.Entities;

namespace PerfectDay.Controllers
{
    [Route("/api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly IRepositoryTask<Entities.Task> _repositoryTask;

        public TaskController(IRepositoryTask<Entities.Task> repositoryTask)
        {
            _repositoryTask = repositoryTask;
        }
        [HttpGet]
        public IEnumerable<Entities.Task> Get()
        {
            return _repositoryTask.GetAll();
        }
        [Route("/api/tasks/get/{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            {
                if (id > 0)
                {
                    try
                    {
                        Entities.Task task = _repositoryTask.FindById(id);
                        if (task != null)
                            return Ok(task);
                        else
                            return BadRequest($"Couldn't find a goal with id: {id}");
                    }

                    catch (Exception ex)
                    {
                        //logger.critical(ex.message);
                        return BadRequest("Server error(this is nort correct)");
                    }
                }
                else
                {
                    return BadRequest("Incorrect id");
                }
            }
        }


        [Route("/api/{controller}/add")]
        [HttpPost]
        public IActionResult Add(Entities.Task task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Model is not valid");
            }
            else {
                _repositoryTask.Create(task);
            return Ok();
            }
        }
        [Route("/api/{controller}/update")]
        [HttpPost]
        public IActionResult Update(Entities.Task task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Model is not valid");
            }
            else
            {
                _repositoryTask.Update(task);
                return Ok();
            }
        }
        [Route("/api/{controller}/delete/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Entities.Task task = _repositoryTask.FindById(id); 
            if (id <= 0) return BadRequest("Invalid Id");
            if (task != null) { _repositoryTask.Delete(task); }
            else
            {
                return BadRequest("Null object");
            }

            return Ok();
        }
    }
}