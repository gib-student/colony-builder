using System;
using System.Collections.Generic;

namespace colony_builder
{
    public class Constructions
    {
        // Settlements
        bool _defaultSettlementBuilt;
        private bool _settlement2Built;
        private bool _settlement3Built;
        private bool _settlement4Built;
        private bool _settlement5Built;

        private Dictionary<string, bool> _settlements = new Dictionary<string, bool>();

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

        // Farms
        private const int _maxVillagersPerFarm = 20;
        private bool _defaultFarmBuilt;
        private bool _farm2Built;
        private bool _farm3Built;
        private bool _farm4Built;
        private bool _farm5Built;
        private bool _farm6Built;
        private bool _farm7Built;
        private bool _farm8Built;
        private bool _farm9Built;

        // Mines
        private const int _maxVillagersPerMine = 20;
        private bool _defaultMineBuilt;
        private bool _mine2Built;
        private bool _mine3Built;
        private bool _mine4Built;
        private bool _mine5Built;
        private bool _mine6Built;
        private bool _mine7Built;

        public Constructions()
        {
            _defaultSettlementBuilt = true;
            _settlement2Built = false;
            _settlement3Built = false;
            _settlement4Built = false;
            _settlement5Built = false;

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

            _defaultFarmBuilt = true;
            _farm2Built = false;
            _farm3Built = false;
            _farm4Built = false;
            _farm5Built = false;
            _farm6Built = false;
            _farm7Built = false;
            _farm8Built = false;
            _farm9Built = false;

            _defaultMineBuilt = true;
            _mine2Built = false;
            _mine3Built = false;
            _mine4Built = false;
            _mine5Built = false;
            _mine6Built = false;
            _mine7Built = false;
        }

        public bool FarmSpaceAvailable()
        {
            throw new NotImplementedException();
        }
        
        public bool MineSpaceAvailable()
        {
            throw new NotImplementedException();
        }
    }
}