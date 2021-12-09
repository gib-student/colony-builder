using System;
using System.Collections.Generic;
using colony_builder.Casting;
using colony_builder.Services;

namespace colony_builder.Scripting
{
    public class GetTimeAction: Action
    {
        TimeService _timeService;

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            _timeService.ComputeSecondHasPassed();
        }

        public GetTimeAction(TimeService timeService)
        {
            _timeService = timeService;
        }
    }
}