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

            // Initial Map
            cast["maps"]= new List<Actor>();
            Map defaultMap = new Map();
            cast["maps"].Add(defaultMap);

            // Initial  Resources

            // Initial Settlements
            cast["settlements"] = new List<Actor>();
            Settlement defaultSettlement = new Settlement(new Point(
                Constants.START_SETTLEMENT_X, Constants.START_SETTLEMENT_Y));
            cast["settlements"].Add(defaultSettlement);

            // Initial Roads

            // Initial Population

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
            
            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);

            // TODO: Add all of the script

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y,
                "Colony Builder", Constants.FRAME_RATE);
            audioService.StartAudio();
            // audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();
        }
    }
}
