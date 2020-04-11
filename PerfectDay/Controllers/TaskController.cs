using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PerfectDay.Repositories;
using PerfectDay.Entities;
using AutoMapper;

namespace PerfectDay.Controllers
{
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly IRepositoryTask<Entities.Task> _repositoryTask;
        private readonly IMapper _mapper;

        public TaskController(IRepositoryTask<Entities.Task> repositoryTask, IMapper mapper)
        {
            _repositoryTask = repositoryTask;
            _mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<Entities.Task> Get()
        {
            return _repositoryTask.GetAll();
        }
        [Route("/api/tasks/get/{id}")]
        [HttpGet]
        public  IActionResult Get(int id)
        {
            Entities.Task task = _repositoryTask.FindById(id);
            if (id <= 0) return BadRequest("Error");
            return (IActionResult) task;
        }
        [Route("/api/{controller}/add")]
        [HttpPost]
        public IActionResult Add(Entities.Task task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Error");
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
                return BadRequest("Error");
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
            if (id <= 0) return BadRequest("Error");
            _repositoryTask.Delete(task);
            return Ok();
        }
    }
}