// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop.Collections;

namespace Silk.NET.Input.Desktop
{
    public class GlfwGamepad : IGamepad
    {
        private List<Button> _cachedButtons = new List<Button>();
        private List<Thumbstick> _cachedThumbsticks = new List<Thumbstick>();
        private List<Trigger> _cachedTriggers = new List<Trigger>();

        public GlfwGamepad(int i)
        {
            Index = i;
        }

        public string Name => Util.Glfw.GetGamepadName(Index);
        public int Index { get; }
        public bool IsConnected => Util.Glfw.JoystickIsGamepad(Index);
        public IReadOnlyList<Button> Buttons => IsConnected ? GetButtons(Index) : null;
        public IReadOnlyList<Thumbstick> Thumbsticks => IsConnected ? GetThumbsticks(Index) : null;

        public IReadOnlyList<Trigger> Triggers => IsConnected ? GetTriggers(Index) : null;

        // TODO GLFW doesn't support haptics. When they add support for vibration, add it here.
        public IReadOnlyList<IMotor> VibrationMotors { get; } = new IMotor[0];
        public Deadzone Deadzone { get; set; }
        public event Action<IGamepad, Button> ButtonDown;
        public event Action<IGamepad, Button> ButtonUp;
        public event Action<IGamepad, Thumbstick> ThumbstickMoved;
        public event Action<IGamepad, Trigger> TriggerMoved;

        public void Update()
        {
            if (!Util.Glfw.JoystickIsGamepad(Index))
            {
                return;
            }

            var buttons = Buttons;
            for (var i = 0; i < buttons.Count; i++)
            {
                if (_cachedButtons.Count <= i)
                {
                    _cachedButtons[i] = default;
                }

                if (buttons[i].Pressed != _cachedButtons[i].Pressed)
                {
                    _cachedButtons[i] = buttons[i];
                    (buttons[i].Pressed ? ButtonDown : ButtonUp)?.Invoke(this, buttons[i]);
                }
            }

            var thumbsticks = Thumbsticks;
            for (var i = 0; i < thumbsticks.Count; i++)
            {
                if (_cachedThumbsticks.Count <= i)
                {
                    _cachedThumbsticks[i] = default;
                }

                if (thumbsticks[i].X != _cachedThumbsticks[i].X || thumbsticks[i].Y != _cachedThumbsticks[i].Y)
                {
                    _cachedThumbsticks[i] = thumbsticks[i];
                    ThumbstickMoved?.Invoke(this, Util.ApplyDeadzone(thumbsticks[i], Deadzone));
                }
            }

            var triggers = Triggers;
            for (var i = 0; i < triggers.Count; i++)
            {
                if (_cachedTriggers.Count <= i)
                {
                    _cachedTriggers[i] = default;
                }

                if (triggers[i].Position != _cachedTriggers[i].Position)
                {
                    _cachedTriggers[i] = triggers[i];
                    TriggerMoved?.Invoke(this, triggers[i]);
                }
            }
        }

        private unsafe IReadOnlyList<Button> GetButtons(int i)
        {
            const int count = 15;
            var ret = Util.Glfw.GetGamepadState(i, out var state);
            var b = new Span<byte>(state.Buttons, 15);

            if (count != _cachedButtons.Count)
            {
                _cachedButtons = new List<Button>();
                _cachedButtons.AddRange(new Button[count]);
            }

            return new GlfwButtonCollection(state.Buttons, count);
        }

        private unsafe IReadOnlyList<Thumbstick> GetThumbsticks(int i)
        {
            Util.Glfw.GetGamepadState(i, out var state);
            var floats = state.Axes;
            if (2 != _cachedThumbsticks.Count)
            {
                _cachedThumbsticks = new List<Thumbstick>();
                _cachedThumbsticks.AddRange(new Thumbstick[2]);
            }

            fixed (float* x = new[] {floats[0], floats[2]}, y = new[] {floats[1], floats[3]})
            {
                return new GlfwThumbstickCollection(x, y, 2);
            }
        }

        private unsafe IReadOnlyList<Trigger> GetTriggers(int i)
        {
            Util.Glfw.GetGamepadState(i, out var state);
            var floats = state.Axes;
            if (2 != _cachedTriggers.Count)
            {
                _cachedTriggers = new List<Trigger>();
                _cachedTriggers.AddRange(new Trigger[2]);
            }

            fixed (float* triggers = new[] {floats[4], floats[5]})
            {
                return new GlfwTriggerCollection(triggers, 2);
            }
        }
    }
}
