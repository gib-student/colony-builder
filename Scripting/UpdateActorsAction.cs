using System;
using System.Collections.Generic;
using colony_builder.Casting;

namespace colony_builder.Scripting
{
    public class UpdateActorsAction : Action
    {
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            foreach (List<Actor> group in cast.Values)
            {
                foreach (Actor actor in group)
                {
                    actor.Update();
                }
            }
        }
        
        public UpdateActorsAction()
        {
           
        }
    }
}
