// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Silk.NET.GLFW;
using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop.Collections;
using Ultz.Dispatcher.Unsafe;

namespace Silk.NET.Input.Desktop
{
    public class GlfwJoystick : IJoystick
    {
        private List<Axis> _cachedAxes = new List<Axis>();
        private List<Button> _cachedButtons = new List<Button>();
        private List<Hat> _cachedHats = new List<Hat>();
        public GlfwJoystick(int i)
        {
            Index = i;
        }

        public string Name => Util.Glfw.GetJoystickName(Index);
        public int Index { get; }
        public bool IsConnected => Util.Glfw.JoystickPresent(Index) && !Util.Glfw.JoystickIsGamepad(Index);
        public IReadOnlyList<Axis> Axes => GetAxes(Index);
        public IReadOnlyList<Button> Buttons => GetButtons(Index);
        public IReadOnlyList<Hat> Hats => GetHats(Index);
        public Deadzone Deadzone { get; set; }
        public event Action<IJoystick, Button> ButtonDown;
        public event Action<IJoystick, Button> ButtonUp;
        public event Action<IJoystick, Axis> AxisMoved;
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
            var count = 0;
            var floats = Util.Glfw.GetJoystickAxes(i, out count);
            return new GlfwAxisCollection(floats, count);
        }

        private static unsafe IReadOnlyList<Button> GetButtons(int i)
        {
            var count = 0;
            var bytes = Util.Glfw.GetJoystickButtons(i, out count);
            return new GlfwButtonCollection(bytes, count);
        }

        private static unsafe IReadOnlyList<Hat> GetHats(int i)
        {
            var count = 0;
            var hats = Util.Glfw.GetJoystickHats(i, out count);
            return new GlfwHatCollection((Position2D*)hats, count);
        }
    }
}
