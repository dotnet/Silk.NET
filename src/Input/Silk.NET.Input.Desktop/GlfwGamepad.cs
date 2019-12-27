// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Silk.NET.GLFW;
using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop.Utilities;

namespace Silk.NET.Input.Desktop
{
    internal unsafe class GlfwGamepad : IGamepad, IGlfwDevice, IGlfwUpdatable, IDisposable
    {
        public const int GamepadButtonCount = 15;
        public const int GamepadThumbstickCount = 2;
        public const int GamepadTriggerCount = 2;
        
        private Button* _buttons;
        private Thumbstick* _thumbsticks;
        private Trigger* _triggers;
        private bool _connected;

        public GlfwGamepad(int i)
        {
            Index = i;
            _buttons = (Button*) Marshal.AllocHGlobal(GamepadButtonCount * sizeof(Button));
            _thumbsticks = (Thumbstick*) Marshal.AllocHGlobal(GamepadThumbstickCount * sizeof(Thumbstick));
            _triggers = (Trigger*) Marshal.AllocHGlobal(GamepadTriggerCount * sizeof(Trigger));
            Buttons = new GlfwReadOnlyList<Button>(_buttons, GamepadButtonCount);
            Thumbsticks = new GlfwReadOnlyList<Thumbstick>(_thumbsticks, GamepadThumbstickCount);
            Triggers = new GlfwReadOnlyList<Trigger>(_triggers, GamepadTriggerCount);
        }
        public string Name => GlfwProvider.GLFW.Value.GetGamepadName(Index);
        public int Index { get; }
        public Action<bool> OnConnectionChange { get; set; }
        public bool IsConnected => GlfwProvider.GLFW.Value.JoystickIsGamepad(Index);
        public IReadOnlyList<Button> Buttons { get; }
        public IReadOnlyList<Thumbstick> Thumbsticks { get; }
        public IReadOnlyList<Trigger> Triggers { get; }
        public IReadOnlyList<IMotor> VibrationMotors { get; } = new IMotor[0];
        public Deadzone Deadzone { get; set; }
        public event Action<IGamepad, Button> ButtonDown;
        public event Action<IGamepad, Button> ButtonUp;
        public event Action<IGamepad, Thumbstick> ThumbstickMoved;
        public event Action<IGamepad, Trigger> TriggerMoved;
        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Marshal.FreeHGlobal((IntPtr) _buttons);
            Marshal.FreeHGlobal((IntPtr) _thumbsticks);
            Marshal.FreeHGlobal((IntPtr) _triggers);
        }
    }
}
