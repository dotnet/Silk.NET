// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;

namespace Silk.NET.Input.Common
{
    public interface IGamepad : IInputDevice
    {
        IReadOnlyCollection<Button> Buttons { get; }
        IReadOnlyCollection<Thumbstick> Thumbsticks { get; }
        IReadOnlyCollection<Trigger> Triggers { get; }
        Deadzone Deadzone { get; set; }
        event Action<IGamepad, Button> ButtonDown;
        event Action<IGamepad, Button> ButtonUp;
        event Action<IGamepad, Thumbstick> ThumbstickMoved;
        event Action<IGamepad, Thumbstick> TriggerMoved;
    }
}