using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Controllers
{
    public class TimeTrackerController : ControllerBase
    {
        [Route("Start")]
        [HttpGet]
        public string StartTime()
        {
            DateTime _StartTime;
            using (var tw = new StreamWriter("StoreData.txt"))
            {
                _StartTime = DateTime.Now;
                tw.WriteLine(_StartTime.ToString());

            }

            return _StartTime.ToString();


        }


        [Route("Stop")]
        [HttpGet]
        public string StopTime()
        {

            var EndTime = DateTime.Now;

            string ReadText;

            using (var tr = new StreamReader("StoreData.txt"))
            {

                ReadText = tr.ReadLine();

            }
            var TimeDiff = EndTime.Subtract(Convert.ToDateTime(ReadText));




            return TimeDiff.ToString();


        }
    }
}
