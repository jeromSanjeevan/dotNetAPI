using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;



namespace dotNetMVCApp.Controllers
{
   [ApiController]
    public class MusicController : Controller
    {

        private Music myMusic = new Music();
        private readonly ILogger<MusicController> _logger;

        public MusicController(ILogger<MusicController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]")]
        public String Get()
        {
            return "<h1> My Jukebox!</h1>";
        }

        [HttpGet]
        [Route("[controller]/NotAfraid")]
        public String GetNotAfraid()
        {
            return myMusic.NotAfraid;
        }

        [HttpGet]
        [Route("[controller]/RiseUp")]
        public String GetRiseUp()
        {
            return myMusic.RiseUp;
        }

        [HttpGet]
        [Route("[controller]/AllTheStars")]
        public String GetAllTheStars()
        {
            return myMusic.AllTheStars;
        }
    }


}
