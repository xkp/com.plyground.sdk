using System;
using System.Collections.Generic;

namespace Plyground.Gameplay.Runtime
{
    public interface IGameplayAdapter
    {
        IReadOnlyCollection<Type> PublishedMessageTypes { get; }
        IReadOnlyCollection<Type> ConsumedMessageTypes { get; }
    }
}
