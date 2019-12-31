using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyEngine {
    public class GameManager : MonoBehaviour {

        //refs
        //model
        public EntitiesDB EntitiesDBRef;

        //view
        public BuildingMenu BuildingMenuRef;

        public Building BuildingPF;
        
        

        private List<Constructable> _constructables;
        private Constructable _underConstruction;
        private int _idCount;


        void Start() {
            //model
            _constructables = new List<Constructable>();



            //view 
            BuildingMenuRef.MenuItemClicked += MenuItemClicked;
            BuildingMenuRef.Init();


            //testing and debug
            BuildingMenuRef.FillItems(-1, new List<string>() { "barraks", "soldier" });

           
        }

        private void MenuItemClicked(int senderInstID, string dataID) {
            Constructable buildingToPlace = Instantiate<Constructable>(EntitiesDBRef.GetDataByID(dataID).Prefab);
            buildingToPlace.Init(dataID);
            StartPlacingBuilding(buildingToPlace);
            BuildingMenuRef.FillItems(-1, null);
        }

        void Update() {
            if (_underConstruction != null) {
                Ray pointerRay = Camera.main.ScreenPointToRay(Input.mousePosition);

                Physics.Raycast(pointerRay, out RaycastHit hit, 1000, LayerMask.GetMask("floor"));

                _underConstruction.SetConstructionLocation(hit.point);
                
                if (hit.collider !=  null && Input.GetMouseButtonDown(0)) {
                    _underConstruction.InstID = _idCount++;
                    _underConstruction.Selected += BuildingSelected;
                    _constructables.Add(_underConstruction);
                    _underConstruction = null;
                    BuildingMenuRef.FillItems(-1, new List<string>() { "barraks", "soldier" });
                }
            }
            
        }


        private void StartPlacingBuilding(Constructable building) {
            _underConstruction = building;
        }

        private void BuildingSelected(int instID, string dataID) {
            List<string> items = EntitiesDBRef.GetDataByID(dataID).ConstructionOptinons;
            BuildingMenuRef.FillItems(instID, items);
        }
    }
}
