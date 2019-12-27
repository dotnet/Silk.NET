// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop.Utilities;

namespace Silk.NET.Input.Desktop
{
    internal class GlfwJoystick : IJoystick, IGlfwDevice, IGlfwUpdatable, IDisposable
    {
        public GlfwJoystick(int i)
        {
            throw new NotImplementedException();
        }

        public string Name { get; }
        public int Index { get; }
        public Action<bool> OnConnectionChange { get; set; }
        public bool IsConnected { get; }
        public IReadOnlyList<Axis> Axes { get; }
        public IReadOnlyList<Button> Buttons { get; }
        public IReadOnlyList<Hat> Hats { get; }
        public Deadzone Deadzone { get; set; }
        public event Action<IJoystick, Button> ButtonDown;
        public event Action<IJoystick, Button> ButtonUp;
        public event Action<IJoystick, Axis> AxisMoved;
        public event Action<IJoystick, Hat> HatMoved;
        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
