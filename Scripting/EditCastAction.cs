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
            int actorIndex = GetUnbuiltSettlementIndex(actorNum);
            _actorsToRemove[Constants.UNBUILT_SETTLEMENT_LIST_KEY].Add(
                _cast[Constants.UNBUILT_SETTLEMENT_LIST_KEY][actorIndex]
            );
        }

        public void RemoveUnbuiltRoad(int actorNum)
        {
            int actorIndex = GetUnbuiltRoadIndex(actorNum);
            _actorsToRemove[Constants.UNBUILT_ROAD_LIST_KEY].Add(
                _cast[Constants.UNBUILT_ROAD_LIST_KEY][actorIndex]
            );
        }

        public void RemoveUnbuiltFarm (int actorNum)
        {
            int actorIndex = GetUnbuiltFarmIndex(actorNum);
            _actorsToRemove[Constants.UNBUILT_FARM_LIST_KEY].Add(
                _cast[Constants.UNBUILT_FARM_LIST_KEY][actorIndex]
            );
        }

        public void RemoveUnbuiltMine(int actorNum)
        {
            int actorIndex = GetUnbuiltMineIndex(actorNum);
            _actorsToRemove[Constants.UNBUILT_MINE_LIST_KEY].Add(
                _cast[Constants.UNBUILT_MINE_LIST_KEY][actorIndex]
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

        private int GetUnbuiltSettlementIndex(int actorNum)
        {
            int i = 0;
            foreach (UnbuiltSettlement unbuiltSettlement in 
                _cast[Constants.UNBUILT_SETTLEMENT_LIST_KEY])
            {
                int settlementNum = unbuiltSettlement.GetSettlementNum();
                if (settlementNum == actorNum)
                {
                    return i;
                } 
                else i++;
            }
            throw new NotImplementedException();
        }

        private int GetUnbuiltRoadIndex(int actorNum)
        {
            int i = 0;
            foreach (UnbuiltRoad unbuiltRoad in 
                _cast[Constants.UNBUILT_ROAD_LIST_KEY])
            {
                int roadNum = unbuiltRoad.GetRoadNum();
                if (roadNum == actorNum)
                {
                    return i;
                }
                else i++;
            }
            throw new NotImplementedException();
        }

        private int GetUnbuiltFarmIndex(int actorNum)
        {
            int i = 0;
            foreach(UnbuiltFarm unbuiltFarm in 
                _cast[Constants.UNBUILT_FARM_LIST_KEY])
            {
                int farmNum = unbuiltFarm.GetFarmNum();
                if (farmNum == actorNum)
                {
                    return i;
                }
                else i++;
            }
            throw new NotImplementedException();
        }

        private int GetUnbuiltMineIndex(int actorNum)
        {
            int i = 0;
            foreach(UnbuiltMine unbuiltMine in
                _cast[Constants.UNBUILT_MINE_LIST_KEY])
            {
                int mineNum = unbuiltMine.GetMineNum();
                if (mineNum == actorNum)
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
                List<Actor> removeList = new List<Actor>();
                foreach (Actor actor in group)
                {
                    removeList.Add(actor);
                }

                foreach(Actor actor in removeList)
                {
                    group.Remove(actor);
                }
            }
        }

        private void EmptyActorsToAdd()
        {
            foreach (List<Actor> group in _actorsToAdd.Values)
            {
                List<Actor> removeList = new List<Actor>();
                foreach(Actor actor in group)
                {
                    removeList.Add(actor);
                }
                
                foreach (Actor actor in removeList)
                {
                    group.Remove(actor);
                }
            }
        }
    }
}