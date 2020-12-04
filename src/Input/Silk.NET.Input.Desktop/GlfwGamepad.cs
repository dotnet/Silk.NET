// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Silk.NET.GLFW;
using Silk.NET.Input.Common;

namespace Silk.NET.Input.Desktop
{
    internal unsafe class GlfwGamepad : IGamepad, IGlfwDevice, IDisposable
    {
        private const int GamepadButtonCount = 15;
        private const int GamepadThumbstickCount = 2;
        private const int GamepadTriggerCount = 2;

        private readonly Button* _buttons;
        private readonly Thumbstick* _thumbsticks;
        private readonly Trigger* _triggers;
        private bool _connected;

        public GlfwGamepad(int i)
        {
            var hasState = GlfwProvider.GLFW.Value.GetGamepadState(i, out var state);

            Index = i;
            _buttons = (Button*) Marshal.AllocHGlobal(GamepadButtonCount * sizeof(Button));
            _thumbsticks = (Thumbstick*) Marshal.AllocHGlobal(GamepadThumbstickCount * sizeof(Thumbstick));
            _triggers = (Trigger*) Marshal.AllocHGlobal(GamepadTriggerCount * sizeof(Trigger));
            Buttons = new GlfwReadOnlyList<Button>(_buttons, GamepadButtonCount);
            Thumbsticks = new GlfwReadOnlyList<Thumbstick>(_thumbsticks, GamepadThumbstickCount);
            Triggers = new GlfwReadOnlyList<Trigger>(_triggers, GamepadTriggerCount);

            _connected = hasState;

            for (int j = 0; j < GamepadButtonCount; j++)
            {
                _buttons[j] = new Button((ButtonName) j, j, hasState && state.Buttons[j] == (int) InputAction.Press);
            }

            for (int j = 0; j < GamepadThumbstickCount; j++)
            {
                _thumbsticks[j] = new Thumbstick(j, 0, 0);
            }

            for (int j = 0; j < GamepadTriggerCount; j++)
            {
                _triggers[j] = new Trigger(j, 0);
            }
        }

        public string Name => GlfwProvider.GLFW.Value.GetGamepadName(Index) ?? "Silk.NET Gamepad (via GLFW)";
        public int Index { get; }
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
            if (!GlfwProvider.GLFW.Value.GetGamepadState(Index, out var state))
            {
                // Detect when this gamepad disconnects
                if (_connected)
                {
                    OnConnectionChanged?.Invoke(this, false);
                    _connected = false;
                }

                return;
            }

            // Detect when this gamepad connects
            if (!_connected)
            {
                OnConnectionChanged?.Invoke(this, true);
                _connected = true;
            }

            // Buttons
            for (var i = 0; i < GamepadButtonCount; i++)
            {
                if ((_buttons[i].Pressed ? 1 : 0) != state.Buttons[i])
                {
                    (_buttons[i].Pressed ? ButtonUp : ButtonDown)?.Invoke
                        (this, _buttons[i] = new Button((ButtonName) i, i, state.Buttons[i] == 1));
                }

                _buttons[i] = new Button((ButtonName) i, i, state.Buttons[i] == 1);
            }

            // Left Thumbstick
            var thumbstick0 = new Thumbstick(0, Deadzone.Apply(state.Axes[0]), Deadzone.Apply(state.Axes[1]));
            if (_thumbsticks[0].X != thumbstick0.X || _thumbsticks[0].Y != thumbstick0.Y)
            {
                ThumbstickMoved?.Invoke
                (
                    this,
                    thumbstick0
                );
            }

            _thumbsticks[0] = thumbstick0;

            // Right Thumbstick
            var thumbstick1 = new Thumbstick(1, Deadzone.Apply(state.Axes[2]), Deadzone.Apply(state.Axes[3]));
            if (_thumbsticks[1].X != thumbstick1.X || _thumbsticks[1].Y != thumbstick1.Y)
            {
                ThumbstickMoved?.Invoke
                (
                    this,
                    thumbstick1
                );
            }

            _thumbsticks[1] = thumbstick1;

            // Left Trigger
            var trigger0 = new Trigger(0, Deadzone.Apply(state.Axes[4]));
            if (_triggers[0].Position != trigger0.Position)
            {
                TriggerMoved?.Invoke(this, trigger0);
            }

            _triggers[0] = trigger0;

            // Right Trigger
            var trigger1 = new Trigger(1, Deadzone.Apply(state.Axes[5]));
            if (_triggers[1].Position != trigger1.Position)
            {
                TriggerMoved?.Invoke(this, trigger1);
            }

            _triggers[1] = trigger1;
        }

        public void Dispose()
        {
            Marshal.FreeHGlobal((IntPtr) _buttons);
            Marshal.FreeHGlobal((IntPtr) _thumbsticks);
            Marshal.FreeHGlobal((IntPtr) _triggers);
        }

        public Action<IInputDevice, bool> OnConnectionChanged { get; set; }
    }
}
