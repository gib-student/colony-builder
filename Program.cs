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


            // Initial Settlements
            cast["settlements"] = new List<Actor>();
            Settlement initialSettlement = new Settlement(new Point(
                Constants.START_SETTLEMENT_X, Constants.START_SETTLEMENT_Y));
            cast["settlements"].Add(initialSettlement);

            // Initial Roads
            cast["roads"] = new List<Actor>();
            Road initialRoad = new Road(new Point(
                Constants.ROAD_INITIAL_X, Constants.ROAD_INITIAL_Y));
            cast["roads"].Add(initialRoad);

            // Initial Farms
            cast["farms"] = new List<Actor>();
            Farm initialFarm = new Farm(new Point(
                Constants.FARM_INITIAL_X, Constants.FARM_INITIAL_Y));
            cast["farms"].Add(initialFarm);
            
            // Initial Mines
            cast["mines"] = new List<Actor>();
            Mine initialMine = new Mine(new Point(
                Constants.MINE_INITIAL_X, Constants.MINE_INITIAL_Y));
            cast["mines"].Add(initialMine);
            
            // Initial Resources
            cast["resources"] = new List<Actor>();
            Resources resources = new Resources();
            cast["resources"].Add(resources);

            // Resources images
            cast["resourcesImages"] = new List<Actor>();
            FoodImg foodImg = new FoodImg();
            WoodImg woodImg = new WoodImg();
            StoneImg stoneImg = new StoneImg();
            GoldImg goldImg = new GoldImg();
            cast["resourcesImages"].Add(foodImg);
            cast["resourcesImages"].Add(woodImg);
            cast["resourcesImages"].Add(stoneImg);
            cast["resourcesImages"].Add(goldImg);

            // Initial Population

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
