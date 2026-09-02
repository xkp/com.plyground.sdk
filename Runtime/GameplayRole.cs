using System;

namespace Plyground.Gameplay.Runtime
{
    [Flags]
    public enum GameplayRole
    {
        None = 0,
        Player = 1 << 0,
        Enemy = 1 << 1,
        Collectible = 1 << 2,
        Objective = 1 << 3,
        Zone = 1 << 4,
        SpawnPoint = 1 << 5
    }
}
