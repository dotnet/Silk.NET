// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Silk.NET.GLFW;

namespace Silk.NET.Input.Glfw
{
    internal class GlfwJoystick : IJoystick, IDisposable
    {
        private bool _connected;

        public GlfwJoystick(int i)
        {
            Index = i;
            Axes = new Axis[0];
            Buttons = new Button[0];
            Hats = new Hat[0];

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
        public event Action<IJoystick, Button>? ButtonDown;
        public event Action<IJoystick, Button>? ButtonUp;
        public event Action<IJoystick, Axis>? AxisMoved;
        public event Action<IJoystick, Hat>? HatMoved;

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
                var thisBtn = new Button(ButtonName.Unknown, i, btn[i] == (int) InputAction.Press);
                var shouldInvoke = ((Button[]) Buttons)[i].Pressed != thisBtn.Pressed;
                ((Button[]) Buttons)[i] = thisBtn;
                if (shouldInvoke)
                {
                    (thisBtn.Pressed ? ButtonDown : ButtonUp)?.Invoke(this, thisBtn);
                }
            }

            for (var i = 0; i < axisCount; i++)
            {
                var thisAxis = new Axis(i, Deadzone.Apply(axes[i]));
                var shouldInvoke = ((Axis[]) Axes)[i].Position != thisAxis.Position;
                ((Axis[]) Axes)[i] = thisAxis;
                if (shouldInvoke)
                {
                    AxisMoved?.Invoke(this, thisAxis);
                }
            }

            for (var i = 0; i < hatCount; i++)
            {
                var thisHat = new Hat
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
                        JoystickHats.LeftDown => Position2D.DownLeft,
                        _ => Position2D.Centered
                    }
                );
                var shouldInvoke = ((Hat[]) Hats)[i].Position != thisHat.Position;
                ((Hat[]) Hats)[i] = thisHat;
                if (shouldInvoke)
                {
                    HatMoved?.Invoke(this, thisHat);
                }
            }

            if (!_connected)
            {
                OnConnectionChanged?.Invoke(this, _connected = true);
            }
        }

        public void EnsureAxesSize(int count)
        {
            if (Axes.Count == count)
            {
                return;
            }

            var axes = (Axis[]) Axes;
            Array.Resize(ref axes, count);
            Axes = axes;
        }

        public void EnsureButtonSize(int count)
        {
            if (Buttons.Count == count)
            {
                return;
            }

            var buttons = (Button[]) Buttons;
            Array.Resize(ref buttons, count);
            Buttons = buttons;
        }

        public void EnsureHatSize(int count)
        {
            if (Hats.Count == count)
            {
                return;
            }

            var hats = (Hat[]) Hats;
            Array.Resize(ref hats, count);
            Hats = hats;
        }

        public void Dispose()
        {
        }

        public Action<IInputDevice, bool>? OnConnectionChanged { get; set; }
    }
}
