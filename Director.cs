using System;
using System.Collections.Generic;
using colony_builder.Casting;
using colony_builder.Services;
using colony_builder.Scripting;
using colony_builder.Logic;

namespace colony_builder
{
    public class Director
    {
        private bool _keepPlaying = true;
        private Dictionary<string, List<Actor>> _cast;
        private Dictionary<string, List<Action>> _script;
        OutputService _outputService;
        Resources _resources;
        EmployedVillagers _employedVillagers;
        Population _population;

        public Director(Dictionary<string, List<Actor>> cast,
            Dictionary<string, List<Action>> script, OutputService outputService,
            Resources resources, EmployedVillagers employedVillagers,
            Population population)
        {
            _cast = cast;
            _script = script;
            _outputService = outputService;
            _resources = resources;
            _employedVillagers = employedVillagers;
            _population = population;
        }
        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void Direct()
        {
            while (_keepPlaying)
            {
                CueAction("input");
                CueAction("update");
                CueAction("output");

                if (Raylib_cs.Raylib.WindowShouldClose())
                {
                    _keepPlaying = false;
                }
                else if (IsGameOver())
                {
                    _keepPlaying = false;
                    EndGame();
                }
            }
        }

        /// <summary>
        /// Executes all of the actions for the provided phase.
        /// </summary>
        /// <param name="phase"></param>
        private void CueAction(string phase)
        {
            List<Action> actions = _script[phase];

            foreach (Action action in actions)
            {
                action.Execute(_cast);
            }
        }

        /// <summary>
        /// Checks if the game-over conditions have been met.
        /// </summary>
        private bool IsGameOver()
        {
            // TODO: Determine game-end conditions. For now it is always true
            if (_resources.GetResourceCount(Constants.FOOD_ACTIONBAR_TEXT) <= 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Execute the game-end routine
        /// </summary>
        private void EndGame()
        {
            Text gameOverText = new Text(new Point(
                Constants.GAME_OVER_TEXT_X, Constants.GAME_OVER_TEXT_Y),
                Constants.GAME_OVER_TEXT);
            _cast["gameOver"] = new List<Actor>();
            _cast["gameOver"].Add(gameOverText);

            while (!Raylib_cs.Raylib.WindowShouldClose())
            {
                DisplayLastFrame();
            }
        }

        private void DisplayLastFrame()
        {
            _script["output"][0].Execute(_cast);
        }
    }
}
