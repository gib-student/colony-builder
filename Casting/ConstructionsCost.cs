using System;

namespace colony_builder.Casting
{
    public class ConstructionsCost : Actor
    {
        public ConstructionsCost()
        {
            SetPosition(new Point(Constants.CONSTRUCTIONS_COST_X,
                Constants.CONSTRUCTIONS_COST_Y));
            SetText("Cost of Constructions\n" +
                    "Settlement: 150 food, 100 wood, 100 stone\n" +
                    "Road:         75 food, 75 wood, 75 stone\n" +
                    "Farm:         100 food, 75 wood, 25 stone\n" +
                    "Mine:          100 food, 100 wood, 50 stone");
        }

        public override void DoAction()
        {

        }

        public override void Update()
        {
            
        }
    }
}