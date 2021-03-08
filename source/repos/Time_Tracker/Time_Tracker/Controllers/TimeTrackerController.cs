using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace Time_Tracker.Controllers
{
    [ApiController]
    [Route("TimeTracker")]
    public class TimeTrackerController : ControllerBase
    {
       

        [Route("Start")]
        [HttpGet]
        public string StartTime()
        {
            DateTime _StartTime;
            using (var tw = new StreamWriter("StoreData.txt") )
            {
                 _StartTime = DateTime.Now;
                tw.WriteLine(_StartTime.ToString());
                tw.Close();
            }
        
            return _StartTime.ToString();


        }


        [Route("Stop")]
        [HttpGet]
        public string StopTime()
        {

          var  EndTime = DateTime.Now;

            string ReadText;

            using (var tr =new StreamReader("StoreData.txt"))
            {

                 ReadText = tr.ReadLine();
                 tr.Close();
            }
            var TimeDiff = EndTime.Subtract(Convert.ToDateTime(ReadText));
         
          


            return TimeDiff.ToString();


        }


    }
}
