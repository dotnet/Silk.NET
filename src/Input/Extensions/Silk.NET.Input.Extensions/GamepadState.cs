// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Input.Extensions
{
    public sealed class GamepadState : IDisposable
    {
        private readonly int _buttonCount;
        private readonly unsafe Button* _buttons;
        private readonly int _thumbstickCount;
        private readonly unsafe Thumbstick* _thumbsticks;
        private readonly int _triggerCount;
        private readonly unsafe Trigger* _triggers;

        internal unsafe GamepadState(IGamepad gamepad)
        {
            Name = gamepad.Name;
            Index = gamepad.Index;
            IsConnected = gamepad.IsConnected;
            var buttons = gamepad.Buttons;
            var thumbsticks = gamepad.Thumbsticks;
            var triggers = gamepad.Triggers;
            _buttons = (Button*) Marshal.AllocHGlobal((_buttonCount = buttons.Count) * sizeof(Button));
            _thumbsticks = (Thumbstick*) Marshal.AllocHGlobal
                ((_thumbstickCount = thumbsticks.Count) * sizeof(Thumbstick));
            _triggers = (Trigger*) Marshal.AllocHGlobal((_triggerCount = triggers.Count) * sizeof(Trigger));
            Deadzone = gamepad.Deadzone;
        }

        public string Name { get; }
        public int Index { get; }
        public bool IsConnected { get; }
        public Deadzone Deadzone { get; }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        public unsafe Span<Button> GetButtons()
        {
            return new Span<Button>(_buttons, _buttonCount);
        }

        public unsafe Span<Thumbstick> GetThumbsticks()
        {
            return new Span<Thumbstick>(_thumbsticks, _thumbstickCount);
        }

        public unsafe Span<Trigger> GetTriggers()
        {
            return new Span<Trigger>(_triggers, _triggerCount);
        }

        private unsafe void ReleaseUnmanagedResources()
        {
            Marshal.FreeHGlobal((IntPtr) _buttons);
            Marshal.FreeHGlobal((IntPtr) _thumbsticks);
            Marshal.FreeHGlobal((IntPtr) _triggers);
        }

        ~GamepadState()
        {
            ReleaseUnmanagedResources();
        }
    }
}
