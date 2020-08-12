using System;
using System.Collections.Generic;

namespace Silk.NET.Input.Sdl
{
    internal class SdlJoystick : IJoystick
    {
        public string Name { get; }
        public int Index { get; }
        public bool IsConnected { get; }
        public IReadOnlyList<Axis> Axes { get; }
        public IReadOnlyList<Button> Buttons { get; }
        public IReadOnlyList<Hat> Hats { get; }
        public Deadzone Deadzone { get; set; }
        public event Action<IJoystick, Button>? ButtonDown;
        public event Action<IJoystick, Button>? ButtonUp;
        public event Action<IJoystick, Axis>? AxisMoved;
        public event Action<IJoystick, Hat>? HatMoved;
    }
}