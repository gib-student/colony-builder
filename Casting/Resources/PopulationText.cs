using System;

namespace colony_builder.Casting
{
    public class PopulationText : Actor
    {
        Population _population;
        private int _populationCount;
        
        public PopulationText(Population population)
        {
            _population = population;
            _populationCount = _population.GetPopulation();
            SetPosition(new Point(Constants.POP_X, Constants.POP_Y));
            SetText(_populationCount.ToString());
        }

        public void UpdatePopulationText()
        {
            _populationCount = _population.GetPopulation();
            SetText(_populationCount.ToString());
        }

        public override void DoAction()
        {

        }

        public override void Update()
        {
            _populationCount = _population.GetPopulation();
            SetText(_populationCount.ToString());
        }
    }
}
