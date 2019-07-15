// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Silk.NET.Input.Common;

namespace Silk.NET.Input.Desktop
{
    public class GlfwGamepad : IGamepad
    {
        public GlfwGamepad(int i)
        {
            Index = i;
        }

        public string Name => Util.Do(() => Util.Glfw.GetGamepadName(Index));
        public int Index { get; }
        public bool IsConnected => Util.Do(() => Util.Glfw.JoystickIsGamepad(Index));
        public event Action<IInputDevice, bool> ConnectionChanged;
        public IReadOnlyList<Button> Buttons { get; }
        public IReadOnlyList<Thumbstick> Thumbsticks { get; }
        public IReadOnlyList<Trigger> Triggers { get; }
        public Deadzone Deadzone { get; set; }
        public event Action<IGamepad, Button> ButtonDown;
        public event Action<IGamepad, Button> ButtonUp;
        public event Action<IGamepad, Thumbstick> ThumbstickMoved;
        public event Action<IGamepad, Trigger> TriggerMoved;
    }
}
