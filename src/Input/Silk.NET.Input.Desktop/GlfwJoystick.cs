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
    internal class GlfwJoystick : IJoystick, IGlfwDevice, IDisposable
    {
        private unsafe Axis* _axes;
        private unsafe Button* _buttons;
        private unsafe Hat* _hats;
        private bool _connected;

        public unsafe GlfwJoystick(int i)
        {
            Index = i;
            _axes = (Axis*) Marshal.AllocHGlobal(0);
            _buttons = (Button*) Marshal.AllocHGlobal(0);
            _hats = (Hat*) Marshal.AllocHGlobal(0);
            Axes = new GlfwReadOnlyList<Axis>(_axes, 0);
            Buttons = new GlfwReadOnlyList<Button>(_buttons, 0);
            Hats = new GlfwReadOnlyList<Hat>(_hats, 0);

            _connected = IsConnected;
        }

        public string Name => GlfwProvider.GLFW.Value.GetJoystickName(Index) ?? "Silk.NET Joystick (via GLFW)";
        public int Index { get; }

        public bool IsConnected => GlfwProvider.GLFW.Value.JoystickPresent(Index) &&
                                   !GlfwProvider.GLFW.Value.JoystickIsGamepad(Index);
        public IReadOnlyList<Axis> Axes { get; private set; }
        public IReadOnlyList<Button> Buttons { get; private set; }
        public IReadOnlyList<Hat> Hats { get; private set; }
        public Deadzone Deadzone { get; set; }
        public event Action<IJoystick, Button> ButtonDown;
        public event Action<IJoystick, Button> ButtonUp;
        public event Action<IJoystick, Axis> AxisMoved;
        public event Action<IJoystick, Hat> HatMoved;
        public unsafe void Update()
        {
            if (!IsConnected)
            {
                if (_connected)
                {
                    OnConnectionChanged?.Invoke(this, _connected = false);
                }

                return;
            }

            var btn = GlfwProvider.GLFW.Value.GetJoystickButtons(Index, out var btnCount);
            var axes = GlfwProvider.GLFW.Value.GetJoystickAxes(Index, out var axisCount);
            var hats = GlfwProvider.GLFW.Value.GetJoystickHats(Index, out var hatCount);
            EnsureButtonSize(btnCount);
            EnsureAxesSize(axisCount);
            EnsureHatSize(hatCount);

            for (var i = 0; i < btnCount; i++)
            {
                _buttons[i] = new Button(ButtonName.Unknown, i, btn[i] == (int) InputAction.Press);
            }

            for (var i = 0; i < axisCount; i++)
            {
                _axes[i] = new Axis(i, axes[i]);
            }

            for (var i = 0; i < hatCount; i++)
            {
                _hats[i] = new Hat
                (
                    i, hats[i] switch
                    {
                        JoystickHats.Centered => Position2D.Centered,
                        JoystickHats.Up => Position2D.Up,
                        JoystickHats.Right => Position2D.Right,
                        JoystickHats.Down => Position2D.Down,
                        JoystickHats.Left => Position2D.Left,
                        JoystickHats.RightUp => Position2D.UpRight,
                        JoystickHats.RightDown => Position2D.DownRight,
                        JoystickHats.LeftUp => Position2D.UpLeft,
                        JoystickHats.LeftDown => Position2D.UpRight,
                        _ => Position2D.Centered
                    }
                );
            }

            if (!_connected)
            {
                OnConnectionChanged?.Invoke(this, _connected = true);
            }
        }

        public unsafe void EnsureAxesSize(int count)
        {
            if (Axes.Count == count)
            {
                return;
            }

            _axes = (Axis*) Marshal.ReAllocHGlobal((IntPtr) _axes, (IntPtr) count);
            Axes = new GlfwReadOnlyList<Axis>(_axes, count);
        }

        public unsafe void EnsureButtonSize(int count)
        {
            if (Buttons.Count == count)
            {
                return;
            }

            _buttons = (Button*) Marshal.ReAllocHGlobal((IntPtr) _buttons, (IntPtr) count);
            Buttons = new GlfwReadOnlyList<Button>(_buttons, count);
        }

        public unsafe void EnsureHatSize(int count)
        {
            if (Hats.Count == count)
            {
                return;
            }

            _hats = (Hat*) Marshal.ReAllocHGlobal((IntPtr) _hats, (IntPtr) count);
            Hats = new GlfwReadOnlyList<Hat>(_hats, count);
        }

        public unsafe void Dispose()
        {
            Marshal.FreeHGlobal((IntPtr) _axes);
            Marshal.FreeHGlobal((IntPtr) _buttons);
            Marshal.FreeHGlobal((IntPtr) _hats);
        }

        public Action<IInputDevice, bool> OnConnectionChanged { get; set; }
    }
}
