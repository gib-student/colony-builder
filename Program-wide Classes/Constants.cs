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
        public const string MAP_LIST_KEY = "maps";

        public const string SETTLEMENT_LIST_KEY = "settlements";
        public const string SETTLEMENT_IMG_FILEPATH = "./Assets/pixel-log-cabin-tiny.png";
        public const int SETTLEMENT_WIDTH = 100;
        public const int SETTLEMENT_HEIGHT = SETTLEMENT_WIDTH;
        public const string UNBUILT_SETTLEMENT_LIST_KEY = "unbuiltSettlements";
        public const string UNBUILT_SETTLEMENT_IMG_FILEPATH = "./Assets/pixel-log-cabin-tiny-light.png";
        public const bool AVAILABLE_TO_BUILD = true;
        public const bool NOT_AVAILABLE_TO_BUILD = false;
        public const int SETTLEMENT_FOOD_COST = 150;
        public const int SETTLEMENT_WOOD_COST = 100;
        public const int SETTLEMENT_STONE_COST = 20;
        public const int SETTLEMENT_2_NUM = 2;
        public const int SETTLEMENT_3_NUM = 3;
        public const int SETTLEMENT_4_NUM = 4;
        public const int SETTLEMENT_5_NUM = 5;
        public const int SETTLEMENT_6_NUM = 6;
        public const int SETTLEMENT_7_NUM = 7;
        public const int SETTLEMENT_8_NUM = 8;
        
        public const int START_SETTLEMENT_X = 1285;
        public const int START_SETTLEMENT_Y = 915;
        public const int SETTLEMENT_2_X = START_SETTLEMENT_X;
        public const int SETTLEMENT_2_Y = ROAD_INITIAL_Y - 80;
        public const int SETTLEMENT_3_X = ROAD_2_X - 80;
        public const int SETTLEMENT_3_Y = SETTLEMENT_2_Y;
        public const int SETTLEMENT_4_X = START_SETTLEMENT_X;
        public const int SETTLEMENT_4_Y = ROAD_3_Y - 80;
        public const int SETTLEMENT_5_X = SETTLEMENT_3_X - 280;
        public const int SETTLEMENT_5_Y = SETTLEMENT_3_Y;
        public const int SETTLEMENT_6_X = SETTLEMENT_3_X;
        public const int SETTLEMENT_6_Y = SETTLEMENT_4_Y;
        public const int SETTLEMENT_7_X = START_SETTLEMENT_X;
        public const int SETTLEMENT_7_Y = ROAD_7_Y - 30;

        public const string ROAD_LIST_KEY = "roads";
        public const string UNBUILT_ROAD_LIST_KEY = "unbuiltRoads";
        public const string ROAD_VERTICAL_IMG_FILEPATH = "./Assets/road-vertical.png";
        public const string ROAD_HORIZONTAL_IMG_FILEPATH = "./Assets/road-horizontal.png";
        public const int VERTICAL_ROAD_WIDTH = 15;
        public const int VERTICAL_ROAD_HEIGHT = 200;
        public const int HORIZONTAL_ROAD_WIDTH = VERTICAL_ROAD_HEIGHT;
        public const int HORIZONTAL_ROAD_HEIGHT = VERTICAL_ROAD_WIDTH;
        public const string ORIENTATION_VERTICAL = "vertical";
        public const string ORIENTATION_HORIZONTAL = "horizontal";
        public const int ROAD_FOOD_COST = 75;
        public const int ROAD_WOOD_COST = 75;
        public const int ROAD_STONE_COST = 75;
        public const int DEFAULT_ROAD_NUM = 1;
        public const int ROAD_2_NUM = 2;
        public const int ROAD_3_NUM = 3;
        public const int ROAD_4_NUM = 4;
        public const int ROAD_5_NUM = 5;
        public const int ROAD_6_NUM = 6;
        public const int ROAD_7_NUM = 7;

        public const int ROAD_INITIAL_X = 1315;
        public const int ROAD_INITIAL_Y = 710;
        public const int ROAD_2_X = 1075;
        public const int ROAD_2_Y = 665;
        public const int ROAD_3_X = ROAD_INITIAL_X;
        public const int ROAD_3_Y = 420;
        public const int ROAD_4_X = SETTLEMENT_3_X - 200;
        public const int ROAD_4_Y = ROAD_2_Y;
        public const int ROAD_5_X = SETTLEMENT_5_X + 30;
        public const int ROAD_5_Y = SETTLEMENT_5_Y - 205;
        public const int ROAD_6_X = ROAD_2_X;
        public const int ROAD_6_Y = ROAD_2_Y - 270;
        public const int ROAD_7_X = ROAD_INITIAL_X;
        public const int ROAD_7_Y = SETTLEMENT_4_X + 30;

        public const string FARM_IMG_FILEPATH = "./Assets/corn-field-tiny.png";
        public const string UNBUILT_FARM_IMG_FILEPATH = "./Assets/corn-field-tiny-dark.png";
        public const string FARM_LIST_KEY = "farms";
        public const string UNBUILT_FARM_LIST_KEY = "unbuiltFarms";
        public const int FARM_WIDTH = 70;
        public const int FARM_HEIGHT = 70;
        public const int FARM_FOOD_COST = 50;
        public const int FARM_WOOD_COST = 50;
        public const int FARM_STONE_COST = 15;
        public const int FARM_1_NUM = 1;
        public const int FARM_2_NUM = 2;
        public const int FARM_3_NUM = 3;
        public const int FARM_4_NUM = 4;

        public const int FARM_INITIAL_X = 1150;
        public const int FARM_INITIAL_Y = 950;
        public const int FARM_2_X = 1130;
        public const int FARM_2_Y = 550;
        public const int FARM_3_X = SETTLEMENT_3_X - 170;
        public const int FARM_3_Y = FARM_2_Y;

        public const string MINE_IMG_FILEPATH = "./Assets/cave-entrance-tiny.png";
        public const string UNBUILT_MINE_IMG_FILEPATH = "./Assets/cave-entrance-tiny-dark.png";
        public const string MINE_LIST_KEY = "mines";
        public const string UNBUILT_MINE_LIST_KEY = "unbuiltMines";
        public const int MINE_WIDTH = 90;
        public const int MINE_HEIGHT = 100;
        public const int MINE_FOOD_COST = 75;
        public const int MINE_WOOD_COST = 100;
        public const int MINE_STONE_COST = 50;
        public const int MINE_1_NUM = 1;
        public const int MINE_2_NUM = 2;
        public const int MINE_3_NUM = 3;
        public const int MINE_4_NUM = 4;
        
        public const int MINE_INITIAL_X = 1370;
        public const int MINE_INITIAL_Y = 810;
        public const int MINE_2_X = 1450;
        public const int MINE_2_Y = 500;

        public const string RESOURCES_LIST_KEY = "resources";
        public const int INITIAL_FOOD = 100;    // 100
        public const int INITIAL_WOOD = 50;     // 50
        public const int INITIAL_STONE = 25;    // 25
        public const int INITIAL_GOLD = 15;     // 15

        public const int FOOD_IMG_X = 55;
        public const int FOOD_IMG_WIDTH = 35;
        public const int FOOD_IMG_HEIGHT = FOOD_IMG_WIDTH;
        public const string FOOD_IMG_FILEPATH = "./Assets/bread-tiny.png";
        public const int FOOD_COUNT_TEXT_X = FOOD_IMG_X + 31;
        public const int WOOD_IMG_X = FOOD_IMG_X + 150;
        public const int WOOD_IMG_WIDTH = 35;
        public const int WOOD_IMG_HEIGHT = WOOD_IMG_WIDTH;
        public const string WOOD_IMG_FILEPATH = "./Assets/log-tiny.png";
        public const int WOOD_COUNT_TEXT_X = WOOD_IMG_X + 31;
        public const int STONE_IMG_X = WOOD_IMG_X + 150;
        public const int STONE_IMG_WIDTH = 35;
        public const string STONE_IMG_FILEPATH = "./Assets/stone-tiny.png";
        public const int STONE_IMG_HEIGHT = STONE_IMG_WIDTH;
        public const int STONE_COUNT_TEXT_X = STONE_IMG_X + 31;
        public const int GOLD_IMG_X = STONE_IMG_X + 150;
        public const int GOLD_IMG_WIDTH = 35;
        public const int GOLD_IMG_HEIGHT = GOLD_IMG_WIDTH;
        public const string GOLD_IMG_FILEPATH = "./Assets/gold-tiny.png";
        public const int GOLD_COUNT_TEXT_X = GOLD_IMG_X + 31;
        public const string GOLD_TEXT = "gold";
        public const int RESOURCES_IMG_Y = 860;
        public const int GOLD_IMG_Y = RESOURCES_IMG_Y + 15;
        public const int RESOURCES_COUNT_TEXT_Y = RESOURCES_IMG_Y + 130;

        public const string POP_LIST_KEY = "population";
        public const int POP_INITIAL = 30;
        public const int POP_COUNT_TEXT_X = POP_IMG_X + 28;
        public const int POP_COUNT_TEXT_Y = RESOURCES_COUNT_TEXT_Y;
        
        public const int POP_IMG_X = GOLD_IMG_X + 230;
        public const int POP_IMG_Y = RESOURCES_IMG_Y;
        public const int POP_IMG_WIDTH = 50;
        public const int POP_IMG_HEIGHT = POP_IMG_WIDTH;
        public const string POP_IMG_FILEPATH = "./Assets/population-tiny.png";

        /// Action Bar Constants
        public const string ACTIONBAR_LIST_KEY = "actionBar";
        // Padding and spacing values
        public const int HORIZONTAL_LINE_VERTICAL_PADDING = 20;
        public const int RESOURCE_TEXT_BUTTONS_VERTICAL_PADDING = 40;
        public const int RESOURCE_TEXT_X_INDENT = 30;
        public const int BETWEEN_BUTTONS_X_PADDING = 100;
        public const int MINUS_BUTTON_EMPLOYED_VALUE_X_PADDING = BETWEEN_BUTTONS_X_PADDING / 2;
        public const int BUTTON_WIDTH = 40;
        public const int BUTTON_HEIGHT = BUTTON_WIDTH;
        public const int BUTTON_SIGN_X_Y_SPACE = 11;
        // "Working Villagers" text constants
        public const string WORKING_VILLAGRS_TEXT = "Working Villagers";
        public const int WORKING_VILLAGERS_X = 30;
        public const int WORKING_VILLAGERS_Y = 30;
        // Horizontal separating Line constants
        public const int VERTICAL_LINE_X = WORKING_VILLAGERS_X;
        public const int VERTICAL_LINE_Y = WORKING_VILLAGERS_Y + HORIZONTAL_LINE_VERTICAL_PADDING;
        // General constants
        public const string MINUS_SIGN = "-";
        public const string ADD_SIGN = "+";
        public const int RESOURCE_ACTIONBAR_TEXT_X = WORKING_VILLAGERS_X + RESOURCE_TEXT_X_INDENT;
        public const int MINUS_BUTTON_X = RESOURCE_ACTIONBAR_TEXT_X - RESOURCE_TEXT_X_INDENT;
        public const int ADD_BUTTON_X = MINUS_BUTTON_X + BETWEEN_BUTTONS_X_PADDING;
        public const int MINUS_SIGN_X = MINUS_BUTTON_X + BUTTON_SIGN_X_Y_SPACE;
        public const int ADD_SIGN_X  = ADD_BUTTON_X + BUTTON_SIGN_X_Y_SPACE;
        public const int EMPLOYED_VALUE_X = MINUS_BUTTON_X + MINUS_BUTTON_EMPLOYED_VALUE_X_PADDING;
        public const string MINUS_BUTTON_TYPE = "minus_button";
        public const string ADD_BUTTON_TYPE = "add_button";
        public const string BUTTON_IMG_FILEPATH = "./Assets/green-tiny.png";
        // Food constants
        public const string FOOD_ACTIONBAR_TEXT = "Food";
        public const int FOOD_EMPLOYED_INITIAL_VALUE = 13;
        public const int FOOD_ACTIONBAR_TEXT_Y = VERTICAL_LINE_Y + HORIZONTAL_LINE_VERTICAL_PADDING;
        public const int FOOD_BUTTONS_Y =  FOOD_ACTIONBAR_TEXT_Y + RESOURCE_TEXT_BUTTONS_VERTICAL_PADDING;
        public const int FOOD_SIGNS_Y = FOOD_BUTTONS_Y + BUTTON_SIGN_X_Y_SPACE;
        public const int FOOD_EMPLOYED_Y = FOOD_BUTTONS_Y;
        // Wood constants
        public const string WOOD_ACTIONBAR_TEXT = "Wood";
        public const int WOOD_EMPLOYED_INITIAL_VALUE = 10;
        public const int WOOD_ACTIONBAR_TEXT_Y = FOOD_BUTTONS_Y + BUTTON_HEIGHT + RESOURCE_TEXT_BUTTONS_VERTICAL_PADDING;
        public const int WOOD_BUTTONS_Y = WOOD_ACTIONBAR_TEXT_Y + RESOURCE_TEXT_BUTTONS_VERTICAL_PADDING;
        public const int WOOD_SIGNS_Y = WOOD_BUTTONS_Y + BUTTON_SIGN_X_Y_SPACE;
        public const int WOOD_EMPLOYED_Y = WOOD_BUTTONS_Y;
        // Stone constants
        public const string STONE_ACTIONBAR_TEXT = "Stone";
        public const int STONE_EMPLOYED_INITIAL_VALUE = 5;
        public const int STONE_ACTIONBAR_TEXT_Y = WOOD_BUTTONS_Y + BUTTON_HEIGHT + RESOURCE_TEXT_BUTTONS_VERTICAL_PADDING;
        public const int STONE_BUTTONS_Y = STONE_ACTIONBAR_TEXT_Y + RESOURCE_TEXT_BUTTONS_VERTICAL_PADDING;
        public const int STONE_SIGNS_Y = STONE_BUTTONS_Y + BUTTON_SIGN_X_Y_SPACE;
        public const int STONE_EMPLOYED_Y = STONE_BUTTONS_Y;
        // Unemployed constants
        public const string UNEMPLOYED_TEXT = "Unemployed";
        public const int UNEMPLOYED_INITIAL_VALUE = 2;
        public const int UNEMPLOYED_TEXT_Y = STONE_BUTTONS_Y + BUTTON_HEIGHT + RESOURCE_TEXT_BUTTONS_VERTICAL_PADDING;
        public const int UNEMPLOYED_NUMVILLAGERS_X = RESOURCE_ACTIONBAR_TEXT_X + 15;
        public const int UNEMPLOYED_NUMVILLAGERS_Y = UNEMPLOYED_TEXT_Y + RESOURCE_TEXT_BUTTONS_VERTICAL_PADDING;

        // Game Over Screen Constants
        public const string GAME_OVER_TEXT = "GAME OVER";
        public const int GAME_OVER_TEXT_X = 700;
        public const int GAME_OVER_TEXT_Y = 530;

        // Error codes
        public const int ERROR = -1;
    }
}
