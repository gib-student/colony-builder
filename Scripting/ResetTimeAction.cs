using System;
using System.Collections.Generic;
using colony_builder.Casting;
using colony_builder.Services;

namespace colony_builder.Scripting
{
    public class ResetTimeAction : Action
    {
        TimeService _timeService;

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            _timeService.ResetSecondHasPassed();
        }

        public ResetTimeAction(TimeService timeService)
        {
            _timeService = timeService;
        }
    }
}