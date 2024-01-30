using DesignPatterns.ObserverPattern.Implementation;
using DesignPatterns.ObserverPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObserverController : ControllerBase
    {
        private readonly ISubject _subject;

        public ObserverController(ISubject subject)
        {
            _subject = subject;
        }

        // POST api/<ObserverController>
        [HttpPost("multiply/{multiplier}")]
        public string Post(int multiplier)
        {
            var message =_subject.IncreaseNumber(multiplier);
            return message;
        }

        // PUT api/<ObserverController>/5
        [HttpPut("add-observers")]
        public string Put()
        {
            var message1 = _subject.AddObserver(new OddNumberObserver());
            var message2 = _subject.AddObserver(new EvenNumberObserver());
            return message1 + "\n" + message2;
        }

        // DELETE api/<ObserverController>/5
        /*[HttpDelete("remove-observer")]
        public void Delete(int id)
        {

        }*/
    }
}
