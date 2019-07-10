// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;

namespace Silk.NET.Input.Common
{
    public interface IMouse : IInputDevice
    {
        IReadOnlyCollection<MouseButton> SupportedButtons { get; }
        IReadOnlyCollection<ScrollWheel> ScrollWheels { get; }
        bool IsButtonPressed(MouseButton btn);
        event Action<IMouse, MouseButton> MouseDown;
        event Action<IMouse, MouseButton> MouseUp;
        event Action<IMouse, ScrollWheel> Scroll;
    }
}