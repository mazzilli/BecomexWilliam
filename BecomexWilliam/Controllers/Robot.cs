using Microsoft.AspNetCore.Mvc;
using Models;
using RobotApp;
using System;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BecomexWilliam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Robot : ControllerBase
    {
        private readonly IRobotApp _robotApp;
        public Robot(IRobotApp robo)
        {
            _robotApp = robo;
        }
        // GET: api/<Robot>
        [HttpGet]
        public string Get()
        {
            return JsonSerializer.Serialize(_robotApp.Robot);
        }


        // POST api/<Robot>
        [HttpPost("MoveElbow"), ActionName("MoveElbow")]
        public string MoveElbow([FromBody] Body obj)
        {
            if (Enum.IsDefined(typeof(Elbow), obj.NewPosition))
            {
                _robotApp.MoveElbow(obj.Left, (Elbow)obj.NewPosition);
            }
            return JsonSerializer.Serialize(_robotApp.Robot);
        }

        // POST api/<Robot>
        [HttpPost("MoveFist"), ActionName("MoveFist")]
        public string MoveFist([FromBody] Body obj)
        {
            if (Enum.IsDefined(typeof(Fist), obj.NewPosition))
            {
                _robotApp.MoveFist(obj.Left, (Fist)obj.NewPosition);
            }
            return JsonSerializer.Serialize(_robotApp.Robot);
        }

        // POST api/<Robot>
        [HttpPost("MoveTilt"), ActionName("MoveTilt")]
        public string MoveTilt([FromBody] Body obj)
        {
            if (Enum.IsDefined(typeof(Tilt), obj.NewPosition))
            {
                _robotApp.MoveHeadTilt((Tilt)obj.NewPosition);
            }
            return JsonSerializer.Serialize(_robotApp.Robot);
        }

        // POST api/<Robot>
        [HttpPost("MoveRotation"), ActionName("MoveRotation")]
        public string MoveRotation([FromBody] Body obj)
        {
            if (Enum.IsDefined(typeof(Rotation), obj.NewPosition))
            {
                _robotApp.MoveHeadRotation((Rotation)obj.NewPosition);
            }
            return JsonSerializer.Serialize(_robotApp.Robot);
        }

    }
}
public class Body
{
    public bool Left { get; set; }

    public int NewPosition { get; set; }
}