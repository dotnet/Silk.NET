using System;
using System.Collections.Generic;

namespace Silk.NET.Input.Sdl
{
    internal class SdlGamepad : IGamepad
    {
        public string Name { get; }
        public int Index { get; }
        public bool IsConnected { get; }
        public IReadOnlyList<Button> Buttons { get; }
        public IReadOnlyList<Thumbstick> Thumbsticks { get; }
        public IReadOnlyList<Trigger> Triggers { get; }
        public IReadOnlyList<IMotor> VibrationMotors { get; }
        public Deadzone Deadzone { get; set; }
        public event Action<IGamepad, Button>? ButtonDown;
        public event Action<IGamepad, Button>? ButtonUp;
        public event Action<IGamepad, Thumbstick>? ThumbstickMoved;
        public event Action<IGamepad, Trigger>? TriggerMoved;
    }
}