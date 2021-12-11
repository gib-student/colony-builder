using System;
using System.Collections.Generic;

namespace colony_builder
{
    public class Constructions
    {
        // Settlements
        private bool _defaultSettlementBuilt;
        private bool _settlement2Built;
        private bool _settlement3Built;
        private bool _settlement4Built;
        private bool _settlement5Built;
        private List<bool> _settlementsBuilt = new List<bool>();
        private const int _maxVillagersPerSettlement = 100;

        // Roads
        private bool _defaultRoadBuilt;
        private bool _road2Built;
        private bool _road3Built;
        private bool _road4Built;
        private bool _road5Built;
        private bool _road6Built;
        private bool _road7Built;
        private bool _road8Built;
        private bool _road9Built;
        private bool _road10Built;
        private List<bool> _roadsBuilt = new List<bool>();

        // Farms
        private bool _defaultFarmBuilt;
        private bool _farm2Built;
        private bool _farm3Built;
        private bool _farm4Built;
        private bool _farm5Built;
        private bool _farm6Built;
        private bool _farm7Built;
        private bool _farm8Built;
        private bool _farm9Built;
        private List<bool> _farmsBuilt = new List<bool>();
        private const int _maxVillagersPerFarm = 20;

        // Mines
        private bool _defaultMineBuilt;
        private bool _mine2Built;
        private bool _mine3Built;
        private bool _mine4Built;
        private bool _mine5Built;
        private bool _mine6Built;
        private bool _mine7Built;
        private List<bool> _minesBuilt = new List<bool>();
        private const int _maxVillagersPerMine = 20;

        public Constructions()
        {
            _defaultSettlementBuilt = true;
            _settlement2Built = false;
            _settlement3Built = false;
            _settlement4Built = false;
            _settlement5Built = false;
            _settlementsBuilt.Add(_defaultSettlementBuilt);
            _settlementsBuilt.Add(_settlement2Built);
            _settlementsBuilt.Add(_settlement3Built);
            _settlementsBuilt.Add(_settlement4Built);
            _settlementsBuilt.Add(_settlement5Built);

            _defaultRoadBuilt = true;
            _road2Built = false;
            _road3Built = false;
            _road4Built = false;
            _road5Built = false;
            _road6Built = false;
            _road7Built = false;
            _road8Built = false;
            _road9Built = false;
            _road10Built = false;
            _roadsBuilt.Add(_defaultRoadBuilt);
            _roadsBuilt.Add(_road2Built);
            _roadsBuilt.Add(_road3Built);
            _roadsBuilt.Add(_road4Built);
            _roadsBuilt.Add(_road5Built);
            _roadsBuilt.Add(_road6Built);
            _roadsBuilt.Add(_road7Built);
            _roadsBuilt.Add(_road8Built);
            _roadsBuilt.Add(_road9Built);
            _roadsBuilt.Add(_road10Built);

            _defaultFarmBuilt = true;
            _farm2Built = false;
            _farm3Built = false;
            _farm4Built = false;
            _farm5Built = false;
            _farm6Built = false;
            _farm7Built = false;
            _farm8Built = false;
            _farm9Built = false;
            _farmsBuilt.Add(_defaultFarmBuilt);
            _farmsBuilt.Add(_farm2Built);
            _farmsBuilt.Add(_farm3Built);
            _farmsBuilt.Add(_farm4Built);
            _farmsBuilt.Add(_farm5Built);
            _farmsBuilt.Add(_farm6Built);
            _farmsBuilt.Add(_farm7Built);
            _farmsBuilt.Add(_farm8Built);
            _farmsBuilt.Add(_farm9Built);

            _defaultMineBuilt = true;
            _mine2Built = false;
            _mine3Built = false;
            _mine4Built = false;
            _mine5Built = false;
            _mine6Built = false;
            _mine7Built = false;
            _minesBuilt.Add(_defaultMineBuilt);
            _minesBuilt.Add(_mine2Built);
            _minesBuilt.Add(_mine3Built);
            _minesBuilt.Add(_mine4Built);
            _minesBuilt.Add(_mine5Built);
            _minesBuilt.Add(_mine6Built);
            _minesBuilt.Add(_mine7Built);

        }

        public void SetSettlementIsBuilt(int settlementNum, bool isBuilt)
        {
            switch (settlementNum)
            {
                case Constants.SETTLEMENT_2_NUM:
                    _settlement2Built = isBuilt;
                    break;
                case Constants.SETTLEMENT_3_NUM:
                    _settlement3Built = isBuilt;
                    break;
                case Constants.SETTLEMENT_4_NUM:
                    _settlement4Built = isBuilt;
                    break;
            }
        }
        
        public void SetRoadIsBuilt(int roadNum, bool isBuilt)
        {
            _roadsBuilt[roadNum - 1] = isBuilt;
        }

        public void SetFarmIsBuilt(int farmNum, bool isBuilt)
        {
            switch (farmNum)
            {
                case Constants.FARM_2_NUM:
                    _farm2Built = isBuilt;
                    break;
                case Constants.FARM_3_NUM:
                    _farm3Built = isBuilt;
                    break;
                case Constants.FARM_4_NUM:
                    _farm4Built = isBuilt;
                    break;
            }
        }

        public void SetMineIsBuilt(int mineNum, bool isBuilt)
        {
            switch (mineNum)
            {
                case Constants.MINE_2_NUM:
                    _mine2Built = isBuilt;
                    break;
                case Constants.MINE_3_NUM:
                    _mine3Built = isBuilt;
                    break;
                case Constants.MINE_4_NUM:
                    _mine4Built = isBuilt;
                    break;
            }
        }


        public int GetLivingSpace()
        {
            int livingSpace = 0;
            foreach (bool settlementBuilt in _settlementsBuilt)
            {
                livingSpace += _maxVillagersPerSettlement;
            }
            return livingSpace;
        }

        public bool FarmSpaceAvailable(int farmSpaceTaken)
        {
            int numFarmsBuilt = 0;
            foreach (bool farmBuilt in _farmsBuilt)
            {
                if (farmBuilt)
                {
                    numFarmsBuilt++;
                }
            }

            int totalFarmSpace = numFarmsBuilt * _maxVillagersPerFarm;
            return farmSpaceTaken < totalFarmSpace;
        }
        
        public bool MineSpaceAvailable(int mineSpaceTaken)
        {
            int numMinesBuilt = 0;
            foreach (bool mineBuilt in _minesBuilt)
            {
                if (mineBuilt)
                {
                    numMinesBuilt++;
                }
            }

            int totalMineSpace = numMinesBuilt * _maxVillagersPerMine;
            return mineSpaceTaken < totalMineSpace;
        }

        public bool RoadsAreBuilt(List<int> roadNums)
        {
            foreach (int roadNum in roadNums)
            {
                if (!RoadIsBuilt(roadNum)) return false;
            }
            
            return true;
        }

        private bool RoadIsBuilt(int roadNum)
        {
            int actualRoadNum = roadNum - 1;
            if (Debug.debug){
                Console.WriteLine($"Constructions: _roadsBuilt[{actualRoadNum}]: {_roadsBuilt[roadNum - 1]}");
            }
            return _roadsBuilt[actualRoadNum];
        }
    }
}