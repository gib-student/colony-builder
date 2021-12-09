using System;
using System.Collections.Generic;
using colony_builder.Casting;

namespace colony_builder.Scripting
{
    public class EditCastAction: Action
    {
        Dictionary<string, List<Actor>> _cast;
        Dictionary<string, List<Actor>> _actorsToAdd;
        Dictionary<string, List<Actor>> _actorsToRemove;

        public EditCastAction()
        {
            _actorsToAdd                                        = new Dictionary<string, List<Actor>>();
            _actorsToAdd[Constants.MAP_LIST_KEY]                = new List<Actor>();
            _actorsToAdd[Constants.SETTLEMENT_LIST_KEY]         = new List<Actor>();
            _actorsToAdd[Constants.UNBUILT_SETTLEMENT_LIST_KEY] = new List<Actor>();
            _actorsToAdd[Constants.ROAD_LIST_KEY]               = new List<Actor>();
            _actorsToAdd[Constants.UNBUILT_ROAD_LIST_KEY]       = new List<Actor>();
            _actorsToAdd[Constants.FARM_LIST_KEY]               = new List<Actor>();
            _actorsToAdd[Constants.UNBUILT_FARM_LIST_KEY]       = new List<Actor>();
            _actorsToAdd[Constants.MINE_LIST_KEY]               = new List<Actor>();
            _actorsToAdd[Constants.UNBUILT_MINE_LIST_KEY]       = new List<Actor>();
            _actorsToAdd[Constants.RESOURCES_LIST_KEY]          = new List<Actor>();
            _actorsToAdd[Constants.POP_LIST_KEY]                = new List<Actor>();
            _actorsToAdd[Constants.ACTIONBAR_LIST_KEY]          = new List<Actor>();

            _actorsToRemove                                         = new Dictionary<string, List<Actor>>();
            _actorsToRemove[Constants.MAP_LIST_KEY]                = new List<Actor>();
            _actorsToRemove[Constants.SETTLEMENT_LIST_KEY]          = new List<Actor>();
            _actorsToRemove[Constants.UNBUILT_SETTLEMENT_LIST_KEY]  = new List<Actor>();
            _actorsToRemove[Constants.ROAD_LIST_KEY]                = new List<Actor>();
            _actorsToRemove[Constants.UNBUILT_ROAD_LIST_KEY]        = new List<Actor>();
            _actorsToRemove[Constants.FARM_LIST_KEY]                = new List<Actor>();
            _actorsToRemove[Constants.UNBUILT_FARM_LIST_KEY]        = new List<Actor>();
            _actorsToRemove[Constants.MINE_LIST_KEY]                = new List<Actor>();
            _actorsToRemove[Constants.UNBUILT_MINE_LIST_KEY]        = new List<Actor>();
            _actorsToRemove[Constants.RESOURCES_LIST_KEY]           = new List<Actor>();
            _actorsToRemove[Constants.POP_LIST_KEY]                 = new List<Actor>();
            _actorsToRemove[Constants.ACTIONBAR_LIST_KEY]           = new List<Actor>();

        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            _cast = cast;

            RemoveActorsFromCast();
            AddActorsToCast();
            
            EmptyActorsToRemove();
            EmptyActorsToAdd();
        }

        public void AddActor(Actor actor, string key)
        {
            _actorsToAdd[key].Add(actor);
        }

        public void RemoveUnbuiltSettlement(int actorNum)
        {
            int actorIndex = IdentifyUnbuiltSettlementIndex(actorNum);
            _actorsToRemove[Constants.UNBUILT_SETTLEMENT_LIST_KEY].Add(
                _cast[Constants.UNBUILT_SETTLEMENT_LIST_KEY][actorIndex]
            );
        }

        private void RemoveActorsFromCast()
        {
            foreach (string key in _cast.Keys)
            {
                foreach (Actor actor in _actorsToRemove[key])
                {
                    _cast[key].Remove(actor);
                }
            }
        }

        private void AddActorsToCast()
        {
            foreach (string key in _cast.Keys)
            {
                foreach (Actor actor in _actorsToAdd[key])
                {
                    _cast[key].Add(actor);
                }
            }
        }

        private int IdentifyUnbuiltSettlementIndex(int actorNum)
        {
            int i = 0;
            foreach (UnbuiltSettlement actor in 
                _cast[Constants.UNBUILT_SETTLEMENT_LIST_KEY])
            {
                int settlementNum = actor.GetSettlementNum();
                if (settlementNum == actorNum)
                {
                    return i;
                } 
                else i++;
            }
            throw new NotImplementedException();
        }

        private void EmptyActorsToRemove()
        {
            foreach (List<Actor> group in _actorsToRemove.Values)
            {
                foreach (Actor actor in group)
                {
                    group.Remove(actor);
                }
            }
        }

        private void EmptyActorsToAdd()
        {
            foreach (List<Actor> group in _actorsToAdd.Values)
            {
                foreach (Actor actor in group)
                {
                    group.Remove(actor);
                }
            }
        }
    }
}