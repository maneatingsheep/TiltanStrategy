using System;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyEngine {

    [Serializable]
    public class EntityData {

        public enum EntityType { Building, Unit};

        public string DataID;
        public string Name;
        public string Description;
        public EntityType Type;
        public Sprite Image;
        public Constructable Prefab;
        public List<string> ConstructionOptinons;
    }
}
