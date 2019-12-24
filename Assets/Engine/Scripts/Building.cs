using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StrategyEngine {
    public class Building : MonoBehaviour, IConstructable {

        private Transform _myTransform;

        void Start() {
            _myTransform = transform;
        }

        public void Build() {

        }

        public bool CheckCollision() {
            return false;
        }

        public void SetConstructionLocation(Vector3 buildPoint) {
            _myTransform.position = buildPoint;
        }

    }
}

