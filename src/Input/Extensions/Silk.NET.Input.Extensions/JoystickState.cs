// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Input.Extensions
{
    public sealed class JoystickState : IDisposable
    {
        private readonly unsafe Axis* _axes;
        private readonly int _axisCount;
        private readonly int _buttonCount;
        private readonly unsafe Button* _buttons;
        private readonly int _hatCount;
        private readonly unsafe Hat* _hats;

        internal unsafe JoystickState(IJoystick joystick)
        {
            Name = joystick.Name;
            Index = joystick.Index;
            IsConnected = joystick.IsConnected;
            var axes = joystick.Axes;
            var buttons = joystick.Buttons;
            var hats = joystick.Hats;
            _axes = (Axis*) Marshal.AllocHGlobal((_axisCount = axes.Count) * sizeof(Axis));
            _buttons = (Button*) Marshal.AllocHGlobal((_buttonCount = buttons.Count) * sizeof(Button));
            _hats = (Hat*) Marshal.AllocHGlobal((_hatCount = hats.Count) * sizeof(Hat));
            for (var i = 0; i < _axisCount; i++)
            {
                _axes[i] = axes[i];
            }

            for (var i = 0; i < _buttonCount; i++)
            {
                _buttons[i] = buttons[i];
            }

            for (var i = 0; i < _hatCount; i++)
            {
                _hats[i] = hats[i];
            }

            Deadzone = joystick.Deadzone;
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

        public unsafe Span<Axis> GetAxes()
        {
            return new Span<Axis>(_axes, _axisCount);
        }

        public unsafe Span<Button> GetButtons()
        {
            return new Span<Button>(_buttons, _buttonCount);
        }

        public unsafe Span<Hat> GetHats()
        {
            return new Span<Hat>(_hats, _hatCount);
        }

        private unsafe void ReleaseUnmanagedResources()
        {
            Marshal.FreeHGlobal((IntPtr) _axes);
            Marshal.FreeHGlobal((IntPtr) _buttons);
            Marshal.FreeHGlobal((IntPtr) _hats);
        }

        ~JoystickState()
        {
            ReleaseUnmanagedResources();
        }
    }
}
