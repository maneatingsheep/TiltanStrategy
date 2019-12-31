
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyEngine {
    public class EntitiesDB : MonoBehaviour {

        public List<EntityData> Database;

        internal EntityData GetDataByID(string ID) {
            for (int i = 0; i < Database.Count; i++) {
                if (Database[i].DataID == ID) {
                    return Database[i];
                }
            }

            return null;
        }
    }
}
