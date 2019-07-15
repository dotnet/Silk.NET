// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop.Collections;
using Ultz.Dispatcher.Unsafe;

namespace Silk.NET.Input.Desktop
{
    public class GlfwJoystick : IJoystick
    {
        public GlfwJoystick(int i)
        {
            Index = i;
        }

        public string Name => Util.Do(() => Util.Glfw.GetJoystickName(Index));
        public int Index { get; }
        public bool IsConnected => Util.Do(() => Util.Glfw.JoystickPresent(Index));
        public event Action<IInputDevice, bool> ConnectionChanged;
        public IReadOnlyList<Axis> Axes => GetAxes(Index, this);
        public IReadOnlyList<Button> Buttons { get; }
        public IReadOnlyList<Hat> Hats { get; }
        public Deadzone Deadzone { get; set; }
        public event Action<IJoystick, Button> ButtonDown;
        public event Action<IJoystick, Button> ButtonUp;
        public event Action<IJoystick, Axis> AxisMoved;
        public event Action<IJoystick, Hat> HatMoved;

        private static unsafe IReadOnlyList<Axis> GetAxes(int i, GlfwJoystick joystick)
        {
            var count = 0;
            var floats = Util.Do(() => (UnsafeDispatch<float>)Util.Glfw.GetJoystickAxes(i, out count));
            return new GlfwAxisCollection(floats, count, joystick);
        }
    }
}
