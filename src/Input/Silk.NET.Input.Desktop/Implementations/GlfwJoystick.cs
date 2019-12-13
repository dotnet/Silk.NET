// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop.Collections;

namespace Silk.NET.Input.Desktop
{
    /// <summary>
    /// A GLFW-based joystick.
    /// </summary>
    internal class GlfwJoystick : IJoystick
    {
        private readonly List<Axis> _cachedAxes = new List<Axis>();
        private readonly List<Button> _cachedButtons = new List<Button>();
        private readonly List<Hat> _cachedHats = new List<Hat>();
        
        internal GlfwJoystick(int i)
        {
            Index = i;
        }

        /// <inheritdoc />
        public string Name => Util.Glfw.GetJoystickName(Index);
        
        /// <inheritdoc />
        public int Index { get; }
        
        /// <inheritdoc />
        public bool IsConnected => Util.Glfw.JoystickPresent(Index) && !Util.Glfw.JoystickIsGamepad(Index);
        
        /// <inheritdoc />
        public IReadOnlyList<Axis> Axes => GetAxes(Index);
        
        /// <inheritdoc />
        public IReadOnlyList<Button> Buttons => GetButtons(Index);
        
        /// <inheritdoc />
        public IReadOnlyList<Hat> Hats => GetHats(Index);
        
        /// <inheritdoc />
        public Deadzone Deadzone { get; set; }
        
        /// <inheritdoc />
        public event Action<IJoystick, Button> ButtonDown;
        
        /// <inheritdoc />
        public event Action<IJoystick, Button> ButtonUp;
        
        /// <inheritdoc />
        public event Action<IJoystick, Axis> AxisMoved;
        
        /// <inheritdoc />
        public event Action<IJoystick, Hat> HatMoved;
        
        public void Update()
        {
            if (Util.Glfw.JoystickIsGamepad(Index))
            {
                return;
            }

            var axes = Axes;
            for (var i = 0; i < axes.Count; i++)
            {
                if (axes[i].Position != (_cachedAxes.Count > i ? _cachedAxes[i] : axes[i]).Position)
                {
                    _cachedAxes[i] = axes[i];
                    AxisMoved?.Invoke(this, Util.ApplyDeadzone(axes[i], Deadzone));
                }
            }
            var buttons = Buttons;
            for (var i = 0; i < buttons.Count; i++)
            {
                if (buttons[i].Pressed != (_cachedButtons.Count > i ? _cachedButtons[i] : buttons[i]).Pressed)
                {
                    _cachedButtons[i] = buttons[i];
                    (buttons[i].Pressed ? ButtonDown : ButtonUp)?.Invoke(this, buttons[i]);
                }
            }
            var hats = Hats;
            for (var i = 0; i < hats.Count; i++)
            {
                if (hats[i].Position != (_cachedHats.Count > i ? _cachedHats[i] : hats[i]).Position)
                {
                    _cachedHats[i] = hats[i];
                    HatMoved?.Invoke(this, hats[i]);
                }
            }
        }

        private static unsafe IReadOnlyList<Axis> GetAxes(int i)
        {
            var floats = Util.Glfw.GetJoystickAxes(i, out var count);
            return new GlfwAxisCollection(floats, count);
        }

        private static unsafe IReadOnlyList<Button> GetButtons(int i)
        {
            var bytes = Util.Glfw.GetJoystickButtons(i, out var count);
            return new GlfwButtonCollection(bytes, count);
        }

        private static unsafe IReadOnlyList<Hat> GetHats(int i)
        {
            var hats = Util.Glfw.GetJoystickHats(i, out var count);
            return new GlfwHatCollection((Position2D*)hats, count);
        }
    }
}
