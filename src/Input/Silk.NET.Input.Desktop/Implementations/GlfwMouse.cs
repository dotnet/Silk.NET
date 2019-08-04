// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop.Collections;

namespace Silk.NET.Input.Desktop
{
    public class GlfwMouse : IMouse
    {
        private List<MouseButton> _down = new List<MouseButton>();
        internal ScrollWheel _wheel;
        public GlfwMouse(GlfwInputContext inputContext)
        {
            ScrollWheels = new GlfwWheelCollection(this);
        }

        public string Name { get; } = "Silk.NET Mouse (GLFW)";
        public int Index { get; } = 0;
        public bool IsConnected { get; } = true;
        public IReadOnlyList<MouseButton> SupportedButtons { get; } = Util.SupportedButtons;
        public IReadOnlyList<ScrollWheel> ScrollWheels { get; }
        public bool IsButtonPressed(MouseButton btn)
        {
            return _down.Contains(btn);
        }

        public event Action<IMouse, MouseButton> MouseDown;
        public event Action<IMouse, MouseButton> MouseUp;
        public event Action<IMouse, ScrollWheel> Scroll;

        internal void RaiseMouseDown(MouseButton btn)
        {
            _down.Add(btn);
            MouseDown?.Invoke(this, btn);
        }

        internal void RaiseMouseUp(MouseButton btn)
        {
            _down.Remove(btn);
            MouseUp?.Invoke(this, btn);
        }

        internal void RaiseScroll(ScrollWheel wheel)
        {
            _wheel = wheel;
            Scroll?.Invoke(this, wheel);
        }
    }
}
