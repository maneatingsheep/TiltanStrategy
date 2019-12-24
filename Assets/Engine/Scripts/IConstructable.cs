
using UnityEngine;

namespace StrategyEngine {
    public interface IConstructable {

        void Build();

        bool CheckCollision();

        void SetConstructionLocation(Vector3 buildPoint);
    }
}
