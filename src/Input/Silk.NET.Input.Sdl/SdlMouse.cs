using System;
using System.Collections.Generic;
using System.Drawing;

namespace Silk.NET.Input.Sdl
{
    internal class SdlMouse : IMouse
    {
        public SdlMouse(SdlInputContext sdlInputContext)
        {
            throw new NotImplementedException();
        }

        public string Name { get; }
        public int Index { get; }
        public bool IsConnected { get; }
        public IReadOnlyList<MouseButton> SupportedButtons { get; }
        public IReadOnlyList<ScrollWheel> ScrollWheels { get; }
        public PointF Position { get; set; }
        public ICursor Cursor { get; }
        public int DoubleClickTime { get; set; }
        public int DoubleClickRange { get; set; }
        public bool IsButtonPressed(MouseButton btn)
        {
            throw new NotImplementedException();
        }

        public event Action<IMouse, MouseButton> MouseDown;
        public event Action<IMouse, MouseButton> MouseUp;
        public event Action<IMouse, MouseButton, PointF> Click;
        public event Action<IMouse, MouseButton, PointF> DoubleClick;
        public event Action<IMouse, PointF> MouseMove;
        public event Action<IMouse, ScrollWheel> Scroll;
    }
}