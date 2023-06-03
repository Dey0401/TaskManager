using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskManager.Share.Entities;

namespace TaskManager.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyTasksController : ControllerBase
    {
        private List<MyTask> _myTasks;

        public MyTasksController()
        {
            _myTasks = new List<MyTask>
            {
               new MyTask { Id = 1, Description = "Learn C#", Date = DateTime.Now },
               new MyTask { Id = 2, Description = "Learn API .Net Core", Date = DateTime.Now },
               new MyTask { Id = 3, Description = "Learn Blazor", Date = DateTime.Now },
               new MyTask { Id = 4, Description = "Learn DataBase with Entity Frameworks", Date = DateTime.Now },
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_myTasks);
        }

        [HttpPost]
        public IActionResult Post(MyTask myTask)
        {
            _myTasks.Add(myTask);
            return Ok(myTask);
        }

        [HttpPut]
        public IActionResult Put(MyTask myTask) 
        {
            var task = _myTasks.FirstOrDefault(t => t.Id == myTask.Id);
            if(task == null)
            {
                return NotFound();
            }
            task.Description = myTask.Description; 
            task.Date = DateTime.Now;
            return Ok(task);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var task = _myTasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }

            _myTasks.Remove(task);
            return NoContent();
        }
        
    }
}
