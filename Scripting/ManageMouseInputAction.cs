
using System;
using System.Collections.Generic;
using colony_builder.Casting;
using colony_builder.Services;

namespace colony_builder.Scripting
{
    public class ManageMouseInputAction : Action
    {
        InputService _inputService;
        Point _mousePosition ;
        bool _leftMouseButtonPressed;
        bool _rightMouseButtonPressed;

        public ManageMouseInputAction(InputService inputService)
        {
            _inputService = inputService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            _mousePosition = _inputService.GetMousePosition();
            _leftMouseButtonPressed = _inputService.IsLeftMouseButtonPressed();
            _rightMouseButtonPressed = _inputService.IsRightMouseButtonPressed();
            
            if (_leftMouseButtonPressed)
            {
                foreach (List<Actor> group in cast.Values)
                {
                    foreach (Actor actor in group)
                    {
                        if (MouseInsideActor(actor))
                        {
                            if (actor.HasActionIfPressed())
                            {
                                actor.DoAction();
                                if (Debug.debug)
                                {
                                    Console.WriteLine("ManageMouseInputAction: Actor action performed");
                                }
                            }
                        }
                    }
                }
            }
            
        }

        public bool MouseInsideActor(Actor actor)
        {
            int leftEdge = actor.GetLeftEdge();
            int rightEdge = actor.GetRightEdge();
            int topEdge = actor.GetTopEdge();
            int bottomEdge = actor.GetBottomEdge();
            int mouseX = _mousePosition.GetX();
            int mouseY = _mousePosition.GetY();
            
            if (mouseX >= leftEdge && mouseX <= rightEdge && 
                mouseY <= bottomEdge && mouseY >= topEdge)
            {
                if (Debug.debug)
                {
                    Console.WriteLine("\nMouseInsideActor returns true");
                    Console.WriteLine($"\tleftEdge: {leftEdge}");
                    Console.WriteLine($"\trightEdge: {rightEdge}");
                    Console.WriteLine($"\ttopEdge: {topEdge}");
                    Console.WriteLine($"\tbottomEdge: {bottomEdge}");
                    Console.WriteLine($"\tmouseX: {mouseX}");
                    Console.WriteLine($"\tmouseY: {mouseY}");
                    Console.WriteLine($"\tActor Text: {actor.GetText()}");
                    Console.WriteLine($"\tActor has action?: {actor.HasActionIfPressed()}");
                    Console.WriteLine($"\tActor image filepath: {actor.GetImage()}");
                    Console.WriteLine();
                }
                return true;
            }
            return false;
        }
    }
}
