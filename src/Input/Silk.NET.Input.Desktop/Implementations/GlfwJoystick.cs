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
        public bool IsConnected => Util.Do(() => Util.Glfw.JoystickPresent(Index) && !Util.Glfw.JoystickIsGamepad(Index));
        public IReadOnlyList<Axis> Axes => GetAxes(Index, this);
        private List<Axis> _cachedAxes = new List<Axis>();
        public IReadOnlyList<Button> Buttons { get; }
        private List<Button> _cachedButtons = new List<Button>();
        public IReadOnlyList<Hat> Hats { get; }
        private List<Hat> _cachedHats = new List<Hat>();
        public Deadzone Deadzone { get; set; }
        public event Action<IJoystick, Button> ButtonDown;
        public event Action<IJoystick, Button> ButtonUp;
        public event Action<IJoystick, Axis> AxisMoved;
        public event Action<IJoystick, Hat> HatMoved;

        public void Update()
        {
            if (!Util.Glfw.JoystickIsGamepad(Index))
            {
                return;
            }

            IReadOnlyList<Axis> axes = Axes;
            for (int i = 0; i < axes.Count; i++)
            {
                if (!axes[i].Equals(_cachedAxes.Count > i ? _cachedAxes[i] : axes[i]))
                {
                    _cachedAxes[i] = axes[i];
                    AxisMoved?.Invoke(this, axes[i]);
                }
            }
            IReadOnlyList<Button> buttons = Buttons;
            for (int i = 0; i < buttons.Count; i++)
            {
                if (!buttons[i].Equals(_cachedButtons.Count > i ? _cachedButtons[i] : buttons[i]))
                {
                    _cachedButtons[i] = buttons[i];
                    (buttons[i].Pressed ? ButtonDown : ButtonUp)?.Invoke(this, buttons[i]);
                }
            }
            IReadOnlyList<Hat> hats = Hats;
            for (int i = 0; i < hats.Count; i++)
            {
                if (!hats[i].Equals(_cachedHats.Count > i ? _cachedHats[i] : hats[i]))
                {
                    _cachedHats[i] = hats[i];
                    HatMoved?.Invoke(this, hats[i]);
                }
            }
        }

        private static unsafe IReadOnlyList<Axis> GetAxes(int i, GlfwJoystick joystick)
        {
            var count = 0;
            var floats = Util.Do(() => (UnsafeDispatch<float>)Util.Glfw.GetJoystickAxes(i, out count));
            return new GlfwAxisCollection(floats, count, joystick);
        }
    }
}
