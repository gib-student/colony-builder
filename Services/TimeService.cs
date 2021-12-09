using System;

namespace colony_builder.Services
{
    public class TimeService
    {
        private bool _secondHasPassed;
        private double _secondsElapsed;
        
        int counter = 0;

        public TimeService()
        {
            _secondsElapsed = 0;
        }

        public bool SecondHasPassed()
        {
            return _secondHasPassed;
        }

        public void ComputeSecondHasPassed()
        {
            double currentTime = Raylib_cs.Raylib.GetTime();
            double dtime = currentTime - _secondsElapsed;
            if (dtime >= 1)
            {
                _secondHasPassed = true;
                _secondsElapsed = currentTime;

                counter++;
                if (Debug.debug)
                {
                    Console.WriteLine($"\tTimeService: secondHasPassed: {true}");
                }
            }
            else
            {
                _secondHasPassed = false;
            }
        }

        public void ResetSecondHasPassed()
        {
            _secondHasPassed = false;
        }
    }
}