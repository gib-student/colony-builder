using System;

namespace colony_builder.Services
{
    public class TimeService
    {
        private double _previousTimeElapsed;

        public TimeService()
        {
            _previousTimeElapsed = 0;
        }

        public bool SecondHasPassed()
        {
            double _timeElapsedTotal = Raylib_cs.Raylib.GetTime();
            double dtime = _timeElapsedTotal - _previousTimeElapsed;
            if (dtime >= 1)
            {
                if (Debug.debug)
                {
                    Console.WriteLine($"TimeService: secondHasPassed: {true}");
                }
                _previousTimeElapsed = _timeElapsedTotal;
                return true;
            }
            
            return false;
        }
    }
}