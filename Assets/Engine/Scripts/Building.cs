using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StrategyEngine {
    public class Building : Constructable {

        override public void Build() {

        }

        override public bool CheckCollision() {
            return false;
        }

        override public void SetConstructionLocation(Vector3 buildPoint) {
            _myTransform.position = buildPoint;
        }

        private void OnMouseDown() {
            Selected(InstID, DataID);
        }
    }
}

