// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;

namespace Silk.NET.Input.Common
{
    public interface IJoystick : IInputDevice
    {
        IReadOnlyCollection<Axis> Axes { get; }
        IReadOnlyCollection<Button> Buttons { get; }
        IReadOnlyCollection<Hat> Hats { get; }
        Deadzone Deadzone { get; set; }
        event Action<IJoystick, Button> ButtonDown;
        event Action<IJoystick, Button> ButtonUp;
        event Action<IJoystick, Axis> AxisMoved;
        event Action<IJoystick, Hat> HatMoved;
    }
}