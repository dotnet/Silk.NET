// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Drawing;
using Silk.NET.GLFW;
using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop.Collections;
using MouseButton = Silk.NET.Input.Common.MouseButton;

namespace Silk.NET.Input.Desktop
{
    public class GlfwMouse : IMouse
    {
        private readonly GlfwInputContext _inputContext;
        private List<MouseButton> _down = new List<MouseButton>();
        internal ScrollWheel _wheel;
        public GlfwMouse(GlfwInputContext inputContext)
        {
            _inputContext = inputContext;
            ScrollWheels = new GlfwWheelCollection(this);
        }

        public string Name { get; } = "Silk.NET Mouse (GLFW)";
        public int Index { get; } = 0;
        public bool IsConnected { get; } = true;
        public IReadOnlyList<MouseButton> SupportedButtons { get; } = Util.SupportedButtons;
        public IReadOnlyList<ScrollWheel> ScrollWheels { get; }

        public unsafe PointF Position
        {
            get
            {
                Util.Glfw.GetCursorPos((WindowHandle*) _inputContext._window.Handle, out var x, out var y);
                return new PointF((float) x, (float) y);
            }
            set => Util.Glfw.SetCursorPos((WindowHandle*) _inputContext._window.Handle, value.X, value.Y);
        }

        public bool IsButtonPressed(MouseButton btn)
        {
            return _down.Contains(btn);
        }

        public event Action<IMouse, MouseButton> MouseDown;
        public event Action<IMouse, MouseButton> MouseUp;
        public event Action<IMouse, PointF> MouseMove;
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

        internal void RaiseMouseMove(PointF pos)
        {
            MouseMove?.Invoke(this, pos);
        }
    }
}
