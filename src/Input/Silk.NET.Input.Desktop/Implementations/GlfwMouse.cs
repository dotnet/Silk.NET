// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Silk.NET.Input.Common;

namespace Silk.NET.Input.Desktop
{
    public class GlfwMouse : IMouse
    {
        public GlfwMouse(GlfwInputContext inputContext)
        {
        }

        public string Name { get; } = "Silk.NET Mouse (GLFW)";
        public int Index { get; } = 0;
        public bool IsConnected { get; } = true;
        public IReadOnlyList<MouseButton> SupportedButtons { get; }
        public IReadOnlyList<ScrollWheel> ScrollWheels { get; }
        public bool IsButtonPressed(MouseButton btn)
        {
            throw new NotImplementedException();
        }

        public event Action<IMouse, MouseButton> MouseDown;
        public event Action<IMouse, MouseButton> MouseUp;
        public event Action<IMouse, ScrollWheel> Scroll;

        internal void RaiseMouseDown(MouseButton btn)
        {
            MouseDown?.Invoke(this, btn);
        }

        internal void RaiseMouseUp(MouseButton btn)
        {
            MouseUp?.Invoke(this, btn);
        }

        internal void RaiseScroll(ScrollWheel wheel)
        {
            Scroll?.Invoke(this, wheel);
        }
    }
}
