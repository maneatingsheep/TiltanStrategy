
using System;
using UnityEngine;

namespace StrategyEngine {
    public abstract class Constructable: MonoBehaviour {

        protected Transform _myTransform;

        public int InstID;
        public string DataID;

        public Action<int, string> Selected;

        public void Init(string dataID) {
            DataID = dataID;
            _myTransform = transform;
        }

        abstract public void Build();

        abstract public bool CheckCollision();

        abstract public void SetConstructionLocation(Vector3 buildPoint);
    }
}
