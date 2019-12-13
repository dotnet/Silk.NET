// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop.Collections;

namespace Silk.NET.Input.Desktop
{
    /// <summary>
    /// A GLFW-based gamepad.
    /// </summary>
    internal class GlfwGamepad : IGamepad
    {
        private List<Button> _cachedButtons = new List<Button>();
        private List<Thumbstick> _cachedThumbsticks = new List<Thumbstick>();
        private List<Trigger> _cachedTriggers = new List<Trigger>();
        
        internal GlfwGamepad(int i)
        {
            Index = i;
        }

        /// <inheritdoc />
        public string Name => Util.Glfw.GetGamepadName(Index);
        
        /// <inheritdoc />
        public int Index { get; }
        
        /// <inheritdoc />
        public bool IsConnected => Util.Glfw.JoystickIsGamepad(Index) && Util.Glfw.JoystickIsGamepad(Index);
        
        /// <inheritdoc />
        public IReadOnlyList<Button> Buttons => IsConnected ? GetButtons(Index) : null;
        
        /// <inheritdoc />
        public IReadOnlyList<Thumbstick> Thumbsticks => IsConnected ? GetThumbsticks(Index) : null;
        
        /// <inheritdoc />
        public IReadOnlyList<Trigger> Triggers => IsConnected ? GetTriggers(Index) : null;
        
        // TODO GLFW doesn't support haptics. When they add support for vibration, add it here.
        /// <inheritdoc />
        public IReadOnlyList<IMotor> VibrationMotors { get; } = new IMotor[0];
        
        /// <inheritdoc />
        public Deadzone Deadzone { get; set; }
        
        /// <inheritdoc />
        public event Action<IGamepad, Button> ButtonDown;
        
        /// <inheritdoc />
        public event Action<IGamepad, Button> ButtonUp;
        
        /// <inheritdoc />
        public event Action<IGamepad, Thumbstick> ThumbstickMoved;
        
        /// <inheritdoc />
        public event Action<IGamepad, Trigger> TriggerMoved;

        /// <summary>
        /// Update the status of this gamepad.
        /// </summary>
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
            var bytes = Util.Glfw.GetJoystickButtons(i, out var count);
            if (count != _cachedButtons.Count)
            {
                _cachedButtons = new List<Button>();
                _cachedButtons.AddRange(Enumerable.Range(0, count).Select(_ => (Button)default));
            }
            return new GlfwButtonCollection(bytes, count);
        }
        private unsafe IReadOnlyList<Thumbstick> GetThumbsticks(int i)
        {
            var floats = Util.Glfw.GetJoystickAxes(i, out var count);
            if (count != _cachedThumbsticks.Count)
            {
                _cachedThumbsticks = new List<Thumbstick>();
                _cachedThumbsticks.AddRange(Enumerable.Range(0, count).Select(_ => (Thumbstick)default));
            }
            fixed(float* x = new[] { floats[0], floats[2] }, y = new[] { floats[1], floats[3] })
            {
                return new GlfwThumbstickCollection(x, y, count);
            }
        }
        private unsafe IReadOnlyList<Trigger> GetTriggers(int i)
        {
            var floats = Util.Glfw.GetJoystickAxes(i, out var count);
            if (count != _cachedTriggers.Count)
            {
                _cachedTriggers = new List<Trigger>();
                _cachedTriggers.AddRange(Enumerable.Range(0, count).Select(_ => (Trigger)default));
            }
            fixed(float* triggers = new[] { floats[4], floats[5] })
            {
                return new GlfwTriggerCollection(triggers, count);
            }
        }
    }
}