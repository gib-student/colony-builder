using System;
using System.Collections.Generic;
using colony_builder.Casting;

namespace colony_builder
{
    /// <summary>
    /// The base class of all other actions.
    /// </summary>
    public abstract class Action
    {
        public abstract void Execute(Dictionary<string, List<Actor>> cast);
    }
}
