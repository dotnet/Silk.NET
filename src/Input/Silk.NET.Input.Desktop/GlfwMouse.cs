// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Drawing;
using Silk.NET.GLFW;
using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop.Utilities;
using MouseButton = Silk.NET.Input.Common.MouseButton;

namespace Silk.NET.Input.Desktop
{
    internal class GlfwMouse : IMouse, IGlfwDevice, IGlfwSubscriber, IDisposable
    {
        public string Name { get; }
        public int Index { get; }
        public Action<bool> OnConnectionChange { get; set; }
        public bool IsConnected { get; }
        public IReadOnlyList<MouseButton> SupportedButtons { get; }
        public IReadOnlyList<ScrollWheel> ScrollWheels { get; }
        public PointF Position { get; set; }
        public bool IsButtonPressed(MouseButton btn)
        {
            throw new NotImplementedException();
        }

        public event Action<IMouse, MouseButton> MouseDown;
        public event Action<IMouse, MouseButton> MouseUp;
        public event Action<IMouse, PointF> MouseMove;
        public event Action<IMouse, ScrollWheel> Scroll;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Subscribe(GlfwEvents events)
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe(GlfwEvents events)
        {
            throw new NotImplementedException();
        }
    }
}
