// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Input.Extensions
{
    public sealed class JoystickState : IDisposable
    {
        private readonly int _axisCount, _buttonCount, _hatCount;
        private readonly IMemoryOwner<byte> _axes, _buttons, _hats;

        internal unsafe JoystickState(IJoystick joystick, MemoryPool<byte> pool)
        {
            Name = joystick.Name;
            Index = joystick.Index;
            IsConnected = joystick.IsConnected;
            var srcAxes = joystick.Axes;
            var srcButtons = joystick.Buttons;
            var srcHats = joystick.Hats;
            _axes = pool.Rent((_axisCount = srcAxes.Count) * sizeof(Axis));
            _buttons = pool.Rent((_buttonCount = srcButtons.Count) * sizeof(Button));
            _hats = pool.Rent((_hatCount = srcHats.Count) * sizeof(Hat));
            var dstAxes = GetAxes();
            var dstButtons = GetButtons();
            var dstHats = GetHats();
            for (var i = 0; i < _axisCount; i++)
            {
                dstAxes[i] = srcAxes[i];
            }

            for (var i = 0; i < _buttonCount; i++)
            {
                dstButtons[i] = srcButtons[i];
            }

            for (var i = 0; i < _hatCount; i++)
            {
                dstHats[i] = srcHats[i];
            }

            Deadzone = joystick.Deadzone;
        }

        public string Name { get; }
        public int Index { get; }
        public bool IsConnected { get; }
        public Deadzone Deadzone { get; }

        public unsafe Span<Axis> GetAxes()
            => new(Unsafe.AsPointer(ref _axes.Memory.Span.GetPinnableReference()), _axisCount);
        public unsafe Span<Button> GetButtons()
            => new(Unsafe.AsPointer(ref _buttons.Memory.Span.GetPinnableReference()), _buttonCount);
        public unsafe Span<Hat> GetHats()
            => new(Unsafe.AsPointer(ref _hats.Memory.Span.GetPinnableReference()), _hatCount);

        public void Dispose()
        {
            _axes?.Dispose();
            _buttons?.Dispose();
            _hats?.Dispose();
        }
    }
}
