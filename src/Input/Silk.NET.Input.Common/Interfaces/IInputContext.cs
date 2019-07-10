// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;

namespace Silk.NET.Input.Common
{
    public interface IInputContext
    {
        IntPtr Handle { get; }
        IReadOnlyCollection<IGamepad> Gamepads { get; }
        IReadOnlyCollection<IJoystick> Joysticks { get; }
        IReadOnlyCollection<IKeyboard> Keyboards { get; }
        IReadOnlyCollection<IMouse> Mice { get; }
        IReadOnlyCollection<IInputDevice> OtherDevices { get; }
    }
}