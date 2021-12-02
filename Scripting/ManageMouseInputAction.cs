using System;
using System.Collections.Generic;
using colony_builder.Casting;
using colony_builder.Services;

namespace colony_builder.Scripting
{
    public class MangeMouseInputAction : Action
    {
        InputService _inputService;
        public MangeMouseInputAction(InputService inputService)
        {
            _inputService = inputService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Point mousePosition = _inputService.GetMousePosition();
            bool leftMouseButtonPressed = _inputService.IsLeftMouseButtonPressed();
            bool rightMouseButtonPressed = _inputService.IsRightMouseButtonPressed();
            if (leftMouseButtonPressed || rightMouseButtonPressed)
            {
                foreach (List<Actor> group in cast.Values)
                {
                    foreach (Actor actor in group)
                    {
                        if (actor.HasActionIfPressed())
                        {
                            actor.DoAction();
                        }
                    }
                }
            }
        }
    }
}
