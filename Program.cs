using System;
using System.Collections.Generic;
using colony_builder.Services;
using colony_builder.Scripting;
using colony_builder.Logic;
using colony_builder.Casting;

namespace colony_builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();

            // Initial  Resources

            // Initial Settlements

            // Initial Roads

            // Initial Population

            // Initial Map

            // Initial Farms

            // Initial Mines

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();
            
            DrawActorsAction drawActorsAction = new DrawActorsAction();
            script["output"].Add(drawActorsAction);

            // TODO: Add all of the script

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y,
                "Batter", Constants.FRAME_RATE);
            audioService.StartAudio();
            // audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();
        }
    }
}
