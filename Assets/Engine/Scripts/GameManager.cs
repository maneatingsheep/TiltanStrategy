using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyEngine {
    public class GameManager : MonoBehaviour {

        public Building BuildingPF;

        private List<IConstructable> _constructables;
        private IConstructable _underConstruction;

        void Start() {
            _constructables = new List<IConstructable>();

            Building buildingToPlace = Instantiate<Building>(BuildingPF);

            StartPlacingBuilding(buildingToPlace);
        }

        
        void Update() {

        }


        void StartPlacingBuilding(IConstructable building) {

        }
    }
}
