using System;

namespace colony_builder.Services
{
    public class TimeService
    {
        private double _previousTimeElapsed;
        double _timeElapsedTotal;
        int counter = 0;

        public TimeService()
        {
            _previousTimeElapsed = 0;
        }

        public bool SecondHasPassed()
        {
            _timeElapsedTotal = Raylib_cs.Raylib.GetTime();
            double dtime = _timeElapsedTotal - _previousTimeElapsed;
            if (dtime >= 1)
            {
                counter++;
                if (Debug.debug)
                {
                    Console.WriteLine($"\tTimeService: secondHasPassed: {true}");
                }
                return true;
            }
            
            return false;
        }

        public void UpdatePreviousTime()
        {
            _previousTimeElapsed = Raylib_cs.Raylib.GetTime();
        }
    }
}