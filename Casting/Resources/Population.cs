using System;

namespace colony_builder.Casting
{
    public class Population : Actor
    {
        private int _population;
        
        public Population()
        {
            _population = Constants.POP_INITIAL;
            SetPosition(new Point(Constants.POP_X, Constants.POP_Y));
            SetText(_population.ToString());
        }

        public void UpdatePopulationText()
        {
            SetText(_population.ToString());
        }

        public override void DoAction()
        {
            
        }
    }
}
