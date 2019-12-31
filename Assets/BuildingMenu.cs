using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StrategyEngine {
    public class BuildingMenu : MonoBehaviour {

        public EntitiesDB EntitiesDBRef;
        public Action<int, string> MenuItemClicked;


        private MenuButton[] _buttons;
        private int _entityID;


        public void Init() {
            _buttons = GetComponentsInChildren<MenuButton>();
            foreach(MenuButton mb in _buttons) {
                mb.MenuAction += ButtonClicked;
            }
        }

        public void FillItems(int entityID, List<string> dataIDs) {

            gameObject.SetActive(dataIDs != null);

            if (dataIDs == null) {
                return;
            }

            _entityID = entityID;

            for (int i = 0; i < _buttons.Length; i++) {
                if (i < dataIDs.Count) {
                    _buttons[i].gameObject.SetActive(true);
                    _buttons[i].SetData(EntitiesDBRef.GetDataByID(dataIDs[i]));
                } else {
                    _buttons[i].gameObject.SetActive(false);
                }
            }
        }


        private void ButtonClicked(string dataID) {
            MenuItemClicked(_entityID, dataID);
        }
    }
}
