using System;

namespace colony_builder
{
    public static class Constants
    {
        public const int MAX_X = 1600;
        public const int MAX_Y = 1060;
        public const int FRAME_RATE = 30;

        public const int DEFAULT_SQUARE_SIZE = 20;
        public const int DEFAULT_FONT_SIZE = 20;
        public const int DEFAULT_TEXT_OFFSET = 4;

        public const string MAP_IMG_FILEPATH = "./Assets/russia-map-medium.png";
        public const int MAP_WIDTH = 1600;
        public const int MAP_HEIGHT = 1060;

        public const string SETTLEMENT_IMG_FILEPATH = "./Assets/pixel-log-cabin-tiny.png";
        public const int SETTLEMENT_WIDTH = 75;
        public const int SETTLEMENT_HEIGHT = 75;
        public const int START_SETTLEMENT_X = 1285;
        public const int START_SETTLEMENT_Y = 915;
        
        public const string UNBUILT_SETTLEMENT_IMG_FILEPATH = "./Assets/pixel-log-cabin-tiny-light.png";

        public const int SETTLEMENT_2_X = START_SETTLEMENT_X;
        public const int SETTLEMENT_2_Y = ROAD_INITIAL_Y - 80;

        public const string ROAD_IMG_FILEPATH = "";
        public const int ROAD_WIDTH = 15;
        public const int ROAD_HEIGHT = 200;
        public const int ROAD_INITIAL_X = 1315;
        public const int ROAD_INITIAL_Y = 710;

        public const string FARM_IMG_FILEPATH = "";
        public const int FARM_WIDTH = 60;
        public const int FARM_HEIGHT = 60;
        public const int FARM_INITIAL_X = 1190;
        public const int FARM_INITIAL_Y = 950;

        public const string MINE_IMG_FILEPATH = "";
        public const int MINE_WIDTH = 75;
        public const int MINE_HEIGHT = 50;
        public const int MINE_INITIAL_X = 1370;
        public const int MINE_INITIAL_Y = 810;

        public const int RESOURCES_X = 50;
        public const int RESOURCES_Y = 1000;
        public const int INITIAL_FOOD = 100;
        public const int INITIAL_WOOD = 50;
        public const int INITIAL_STONE = 25;
        public const int INITIAL_GOLD = 15;

        public const int FOOD_IMG_X = 55;
        public const int FOOD_IMG_WIDTH = 35;
        public const int FOOD_IMG_HEIGHT = FOOD_IMG_WIDTH;
        public const int WOOD_IMG_X = FOOD_IMG_X + 76;
        public const int WOOD_IMG_WIDTH = 35;
        public const int WOOD_IMG_HEIGHT = WOOD_IMG_WIDTH;
        public const int STONE_IMG_X = FOOD_IMG_X + 152;
        public const int STONE_IMG_WIDTH = 35;
        public const int STONE_IMG_HEIGHT = STONE_IMG_WIDTH;
        public const int GOLD_IMG_X = FOOD_IMG_X + 215;
        public const int GOLD_IMG_WIDTH = 35;
        public const int GOLD_IMG_HEIGHT = GOLD_IMG_WIDTH;
        public const int RESOURCES_IMG_Y = 960;

        
        public const int POP_INITIAL = 31;
        public const int POP_X = RESOURCES_X + 290;
        public const int POP_Y = RESOURCES_Y;
        
        public const int POP_IMG_X = POP_X - 3;
        public const int POP_IMG_Y = RESOURCES_IMG_Y;
        public const int POP_IMG_WIDTH = 50;
        public const int POP_IMG_HEIGHT = POP_IMG_WIDTH;
    }
}
