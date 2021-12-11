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
            Population population = new Population(employedVillagers);
            EditCastAction editCastAction = new EditCastAction();
            BuildService buildService = new BuildService(resources, 
                constructions, editCastAction);

            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();

            // Map
            cast[Constants.MAP_LIST_KEY]= new List<Actor>();
            Map defaultMap = new Map();
            cast[Constants.MAP_LIST_KEY].Add(defaultMap);

            // Initial Settlement
            cast[Constants.SETTLEMENT_LIST_KEY] = new List<Actor>();
            Settlement initialSettlement = new Settlement(new Point(
                Constants.START_SETTLEMENT_X, Constants.START_SETTLEMENT_Y));
            cast[Constants.SETTLEMENT_LIST_KEY].Add(initialSettlement);

            // Unbuilt Settlements
            cast[Constants.UNBUILT_SETTLEMENT_LIST_KEY] = new List<Actor>();
            UnbuiltSettlement settlement2 = new UnbuiltSettlement(new Point(
                Constants.SETTLEMENT_2_X, Constants.SETTLEMENT_2_Y), Constants.AVAILABLE_TO_BUILD,
                Constants.SETTLEMENT_2_NUM, resources, buildService);
            cast[Constants.UNBUILT_SETTLEMENT_LIST_KEY].Add(settlement2);

            // Initial Roads
            cast[Constants.ROAD_LIST_KEY] = new List<Actor>();
            Road initialRoad = new Road(new Point(
                Constants.ROAD_INITIAL_X, Constants.ROAD_INITIAL_Y),
                Constants.ORIENTATION_VERTICAL);
            cast[Constants.ROAD_LIST_KEY].Add(initialRoad);

            // Unbuilt Roads
            cast[Constants.UNBUILT_ROAD_LIST_KEY] = new List<Actor>();
            
            // Initial Farms
            cast[Constants.FARM_LIST_KEY] = new List<Actor>();
            Farm initialFarm = new Farm(new Point(
                Constants.FARM_INITIAL_X, Constants.FARM_INITIAL_Y));
            cast[Constants.FARM_LIST_KEY].Add(initialFarm);

            // Unbuilt Farms
            cast[Constants.UNBUILT_FARM_LIST_KEY] = new List<Actor>();
            
            // Initial Mines
            cast[Constants.MINE_LIST_KEY] = new List<Actor>();
            Mine initialMine = new Mine(new Point(
                Constants.MINE_INITIAL_X, Constants.MINE_INITIAL_Y));
            cast[Constants.MINE_LIST_KEY].Add(initialMine);

            // Unbuilt Mines
            cast[Constants.UNBUILT_MINE_LIST_KEY] = new List<Actor>();
            
            // Initial Resources
            cast[Constants.RESOURCES_LIST_KEY] = new List<Actor>();
            FoodCount foodCountText = new FoodCount(resources);
            WoodCount woodCountText = new WoodCount(resources);
            StoneCount stoneCountText = new StoneCount(resources);
            GoldCount goldCountText = new GoldCount(resources);
            FoodImg foodImg = new FoodImg();
            WoodImg woodImg = new WoodImg();
            StoneImg stoneImg = new StoneImg();
            GoldImg goldImg = new GoldImg();
            cast[Constants.RESOURCES_LIST_KEY].Add(foodCountText);
            cast[Constants.RESOURCES_LIST_KEY].Add(woodCountText);
            cast[Constants.RESOURCES_LIST_KEY].Add(stoneCountText);
            cast[Constants.RESOURCES_LIST_KEY].Add(goldCountText);
            cast[Constants.RESOURCES_LIST_KEY].Add(foodImg);
            cast[Constants.RESOURCES_LIST_KEY].Add(woodImg);
            cast[Constants.RESOURCES_LIST_KEY].Add(stoneImg);
            cast[Constants.RESOURCES_LIST_KEY].Add(goldImg);

            // Initial Population
            cast[Constants.POP_LIST_KEY] = new List<Actor>();
            PopulationText popText = new PopulationText(population);
            PopImg popImg = new PopImg();
            cast[Constants.POP_LIST_KEY].Add(popText);
            cast[Constants.POP_LIST_KEY].Add(popImg);

            /// Action Bar
            cast[Constants.ACTIONBAR_LIST_KEY] = new List<Actor>();
            // Working Villagers text
            Text workingVillagersText = new Text(new Point(
                Constants.WORKING_VILLAGERS_X, Constants.WORKING_VILLAGERS_Y),
                Constants.WORKING_VILLAGRS_TEXT);
            // Horizontal Line

            // Food actors
            Text foodActionbarText = new Text(new Point(
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
            Text woodActionbarText = new Text(new Point(
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
            Text stoneActionbarText = new Text(new Point(
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
            cast[Constants.ACTIONBAR_LIST_KEY].Add(workingVillagersText);
            // Food
            cast[Constants.ACTIONBAR_LIST_KEY].Add(foodActionbarText);
            cast[Constants.ACTIONBAR_LIST_KEY].Add(foodMinusButton);
            cast[Constants.ACTIONBAR_LIST_KEY].Add(foodAddButton);
            cast[Constants.ACTIONBAR_LIST_KEY].Add(foodMinusSign);
            cast[Constants.ACTIONBAR_LIST_KEY].Add(foodAddSign);
            cast[Constants.ACTIONBAR_LIST_KEY].Add(employedFoodNum);
            // Wood
            cast[Constants.ACTIONBAR_LIST_KEY].Add(woodActionbarText);
            cast[Constants.ACTIONBAR_LIST_KEY].Add(woodMinusButton);
            cast[Constants.ACTIONBAR_LIST_KEY].Add(woodAddButton);
            cast[Constants.ACTIONBAR_LIST_KEY].Add(woodMinusSign);
            cast[Constants.ACTIONBAR_LIST_KEY].Add(woodAddSign);
            cast[Constants.ACTIONBAR_LIST_KEY].Add(employedWoodNum);
            // Stone
            cast[Constants.ACTIONBAR_LIST_KEY].Add(stoneActionbarText);
            cast[Constants.ACTIONBAR_LIST_KEY].Add(stoneMinusButton);
            cast[Constants.ACTIONBAR_LIST_KEY].Add(stoneAddButton);
            cast[Constants.ACTIONBAR_LIST_KEY].Add(stoneMinusSign);
            cast[Constants.ACTIONBAR_LIST_KEY].Add(stoneAddSign);
            cast[Constants.ACTIONBAR_LIST_KEY].Add(employedStoneNum);
            // Unemployed
            cast[Constants.ACTIONBAR_LIST_KEY].Add(unemployedText);
            cast[Constants.ACTIONBAR_LIST_KEY].Add(unemployedNum);

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            AudioService audioService = new AudioService();
            TimeService timeService = new TimeService();

            script["input"] = new List<Action>();
            script["update"] = new List<Action>();
            script["output"] = new List<Action>();
            
            // TODO: Add all of the script
            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            GetTimeAction getTimeAction = new GetTimeAction(timeService);
            ManageMouseInputAction manageMouseInputAction = 
                new ManageMouseInputAction(inputService);
            UpdateActorsAction updateActorsAction = new UpdateActorsAction();
            ManageResourcesAction manageResourcesAction = 
                new ManageResourcesAction(resources, employedVillagers, 
                population, timeService);
            ManagePopulationAction managePopulationAction = new ManagePopulationAction(
                population, resources, timeService, constructions);
            ResetTimeAction resetTimeAction = new ResetTimeAction(timeService);
            
            
            script["input"].Add(manageMouseInputAction);
            script["update"].Add(getTimeAction);    // Must be FIRST update
            script["update"].Add(updateActorsAction);
            script["update"].Add(manageResourcesAction);
            script["update"].Add(managePopulationAction);
            script["update"].Add(editCastAction);
            script["update"].Add(resetTimeAction);  // Must be LAST update
            script["output"].Add(drawActorsAction);
            
            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y,
                "Colony Builder", Constants.FRAME_RATE);
            audioService.StartAudio();
            // audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script, outputService,
                inputService, timeService, buildService, resources, 
                employedVillagers, population);
            theDirector.Direct();
        }
    }
}
