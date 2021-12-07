using System;
using System.Collections.Generic;
using colony_builder.Services;
using colony_builder.Scripting;
using colony_builder.Casting;

namespace colony_builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Variables we will need for the whole class
            Resources resources = new Resources();
            Constructions constructions = new Constructions();
            EmployedVillagers employedVillagers = new EmployedVillagers(constructions);
            Population population = new Population();

            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();

            // Map
            cast["maps"]= new List<Actor>();
            Map defaultMap = new Map();
            cast["maps"].Add(defaultMap);

            // Initial Settlement
            cast["settlements"] = new List<Actor>();
            Settlement initialSettlement = new Settlement(new Point(
                Constants.START_SETTLEMENT_X, Constants.START_SETTLEMENT_Y));
            cast["settlements"].Add(initialSettlement);

            // Unbuilt Settlements
            cast["unbuiltSettlements"] = new List<Actor>();
            UnbuiltSettlement settlement2 = new UnbuiltSettlement(new Point(
                Constants.SETTLEMENT_2_X, Constants.SETTLEMENT_2_Y), Constants.AVAILABLE_TO_BUILD);
            cast["unbuiltSettlements"].Add(settlement2);

            // Initial Roads
            cast["roads"] = new List<Actor>();
            Road initialRoad = new Road(new Point(
                Constants.ROAD_INITIAL_X, Constants.ROAD_INITIAL_Y),
                Constants.ORIENTATION_VERTICAL);
            cast["roads"].Add(initialRoad);

            // Unbuilt Roads
            cast["unbuiltRoads"] = new List<Actor>();
            UnbuiltRoad road2 = new UnbuiltRoad(new Point(
                Constants.ROAD_2_X, Constants.ROAD_2_Y),
                Constants.ORIENTATION_HORIZONTAL);
            UnbuiltRoad road3 = new UnbuiltRoad(new Point(
                Constants.ROAD_3_X, Constants.ROAD_3_Y),
                Constants.ORIENTATION_VERTICAL);
            cast["unbuiltRoads"].Add(road3);
            cast["unbuiltRoads"].Add(road2);

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
            ResourcesText resourcesText = new ResourcesText(resources);
            FoodImg foodImg = new FoodImg();
            WoodImg woodImg = new WoodImg();
            StoneImg stoneImg = new StoneImg();
            GoldImg goldImg = new GoldImg();
            cast["resources"].Add(resourcesText);
            cast["resources"].Add(foodImg);
            cast["resources"].Add(woodImg);
            cast["resources"].Add(stoneImg);
            cast["resources"].Add(goldImg);

            // Initial Population
            cast["population"] = new List<Actor>();
            PopulationText popText = new PopulationText(population);
            PopImg popImg = new PopImg();
            cast["population"].Add(popText);
            cast["population"].Add(popImg);

            /// Action Bar
            cast["actionBar"] = new List<Actor>();
            // Working Villagers text
            Text workingVillagersText = new Text(new Point(
                Constants.WORKING_VILLAGERS_X, Constants.WORKING_VILLAGERS_Y),
                Constants.WORKING_VILLAGRS_TEXT);
            // Horizontal Line

            // Food actors
            Text foodText = new Text(new Point(
                Constants.RESOURCE_ACTIONBAR_TEXT_X, Constants.FOOD_ACTIONBAR_TEXT_Y),
                Constants.FOOD_ACTIONBAR_TEXT);
            Button foodMinusButton = new Button(new Point(
                Constants.MINUS_BUTTON_X, Constants.FOOD_BUTTONS_Y),
                Constants.MINUS_BUTTON_TYPE, Constants.FOOD_ACTIONBAR_TEXT,
                employedVillagers, resources);
            Button foodAddButton = new Button(new Point(
                Constants.ADD_BUTTON_X, Constants.FOOD_BUTTONS_Y),
                Constants.ADD_BUTTON_TYPE, Constants.FOOD_ACTIONBAR_TEXT,
                employedVillagers, resources);
            Text foodMinusSign = new Text(new Point(
                Constants.MINUS_SIGN_X, Constants.FOOD_SIGNS_Y),
                Constants.MINUS_SIGN);
            Text foodAddSign = new Text(new Point(
                Constants.ADD_SIGN_X, Constants.FOOD_SIGNS_Y),
                Constants.ADD_SIGN);
            EmployedFoodNum employedFoodNum = new EmployedFoodNum(employedVillagers);
            // Wood actors
            Text woodText = new Text(new Point(
                Constants.RESOURCE_ACTIONBAR_TEXT_X, Constants.WOOD_ACTIONBAR_TEXT_Y),
                Constants.WOOD_ACTIONBAR_TEXT);
            Button woodMinusButton = new Button(new Point(
                Constants.MINUS_BUTTON_X, Constants.WOOD_BUTTONS_Y),
                Constants.MINUS_BUTTON_TYPE, Constants.WOOD_ACTIONBAR_TEXT,
                employedVillagers, resources);
            Button woodAddButton = new Button(new Point(
                Constants.ADD_BUTTON_X, Constants.WOOD_BUTTONS_Y),
                Constants.ADD_BUTTON_TYPE, Constants.WOOD_ACTIONBAR_TEXT,
                employedVillagers, resources);
            Text woodMinusSign = new Text(new Point(
                Constants.MINUS_SIGN_X, Constants.WOOD_SIGNS_Y),
                Constants.MINUS_SIGN);
            Text woodAddSign = new Text(new Point(
                Constants.ADD_SIGN_X, Constants.WOOD_SIGNS_Y),
                Constants.ADD_SIGN);
            EmployedWoodNum employedWoodNum = new EmployedWoodNum(employedVillagers);
            // Stone actors
            Text stoneText = new Text(new Point(
                Constants.RESOURCE_ACTIONBAR_TEXT_X, Constants.STONE_ACTIONBAR_TEXT_Y),
                Constants.STONE_ACTIONBAR_TEXT);
            Button stoneMinusButton = new Button(new Point(
                Constants.MINUS_BUTTON_X, Constants.STONE_BUTTONS_Y),
                Constants.MINUS_BUTTON_TYPE, Constants.STONE_ACTIONBAR_TEXT,
                employedVillagers, resources);
            Button stoneAddButton = new Button(new Point(
                Constants.ADD_BUTTON_X, Constants.STONE_BUTTONS_Y),
                Constants.ADD_BUTTON_TYPE, Constants.STONE_ACTIONBAR_TEXT,
                employedVillagers, resources);
            Text stoneMinusSign = new Text(new Point(
                Constants.MINUS_SIGN_X, Constants.STONE_SIGNS_Y),
                Constants.MINUS_SIGN);
            Text stoneAddSign = new Text(new Point(
                Constants.ADD_SIGN_X, Constants.STONE_SIGNS_Y),
                Constants.ADD_SIGN);
            EmployedStoneNum employedStoneNum = new EmployedStoneNum(employedVillagers);
            // Unemployed actors
            Text unemployedText = new Text(new Point(
                Constants.RESOURCE_ACTIONBAR_TEXT_X - Constants.RESOURCE_TEXT_X_INDENT, 
                Constants.UNEMPLOYED_TEXT_Y),
                Constants.UNEMPLOYED_TEXT);
            UnemployedNum unemployedNum = new UnemployedNum(employedVillagers);
            
            /// Add them to the cast
            // Working villagers text
            cast["actionBar"].Add(workingVillagersText);
            // Food
            cast["actionBar"].Add(foodText);
            cast["actionBar"].Add(foodMinusButton);
            cast["actionBar"].Add(foodAddButton);
            cast["actionBar"].Add(foodMinusSign);
            cast["actionBar"].Add(foodAddSign);
            cast["actionBar"].Add(employedFoodNum);
            // Wood
            cast["actionBar"].Add(woodText);
            cast["actionBar"].Add(woodMinusButton);
            cast["actionBar"].Add(woodAddButton);
            cast["actionBar"].Add(woodMinusSign);
            cast["actionBar"].Add(woodAddSign);
            cast["actionBar"].Add(employedWoodNum);
            // Stone
            cast["actionBar"].Add(stoneText);
            cast["actionBar"].Add(stoneMinusButton);
            cast["actionBar"].Add(stoneAddButton);
            cast["actionBar"].Add(stoneMinusSign);
            cast["actionBar"].Add(stoneAddSign);
            cast["actionBar"].Add(employedStoneNum);
            // Unemployed
            cast["actionBar"].Add(unemployedText);
            cast["actionBar"].Add(unemployedNum);

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            AudioService audioService = new AudioService();
            TimeService timeService = new TimeService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();
            
            // TODO: Add all of the script
            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            ManageMouseInputAction manageMouseInputAction = 
                new ManageMouseInputAction(inputService);
            UpdateActorsAction updateActorsAction = new UpdateActorsAction();
            ManageResourcesAction manageResourcesAction = 
                new ManageResourcesAction(resources, employedVillagers, 
                population, timeService);
            ManagePopulationAction managePopulationAction = new ManagePopulationAction(
                population, resources, timeService);
            
            script["output"].Add(drawActorsAction);
            script["update"].Add(manageMouseInputAction);
            script["update"].Add(updateActorsAction);
            script["update"].Add(manageResourcesAction);
            script["update"].Add(managePopulationAction);
            
            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y,
                "Colony Builder", Constants.FRAME_RATE);
            audioService.StartAudio();
            // audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script, outputService, 
                resources, employedVillagers, population);
            theDirector.Direct();
        }
    }
}
