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
            Ray pointerRay = Camera.main.ScreenPointToRay(Input.mousePosition);
             
            Physics.Raycast(pointerRay, out RaycastHit hit);

            _underConstruction.SetConstructionLocation( hit.point);
        }


        void StartPlacingBuilding(IConstructable building) {
            _underConstruction = building;
        }
    }
}
