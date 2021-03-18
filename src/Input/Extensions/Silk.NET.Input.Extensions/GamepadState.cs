// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Input.Extensions
{
    public sealed class GamepadState : IDisposable
    {
        private readonly int _buttonCount, _thumbstickCount, _triggerCount;
        private readonly IMemoryOwner<byte> _buttons, _thumbsticks, _triggers;

        internal unsafe GamepadState(IGamepad gamepad, MemoryPool<byte> pool)
        {
            Name = gamepad.Name;
            Index = gamepad.Index;
            IsConnected = gamepad.IsConnected;
            var srcButtons = gamepad.Buttons;
            var srcThumbsticks = gamepad.Thumbsticks;
            var srcTriggers = gamepad.Triggers;
            _buttons = pool.Rent((_buttonCount = srcButtons.Count) * sizeof(Button));
            _thumbsticks = pool.Rent((_thumbstickCount = srcThumbsticks.Count) * sizeof(Thumbstick));
            _triggers = pool.Rent((_triggerCount = srcTriggers.Count) * sizeof(Trigger));
            var dstButtons = GetButtons();
            var dstThumbsticks = GetThumbsticks();
            var dstTriggers = GetTriggers();
            for (var i = 0; i < _buttonCount; i++)
            {
                dstButtons[i] = srcButtons[i];
            }

            for (var i = 0; i < _thumbstickCount; i++)
            {
                dstThumbsticks[i] = srcThumbsticks[i];
            }

            for (var i = 0; i < _triggerCount; i++)
            {
                dstTriggers[i] = srcTriggers[i];
            }
            Deadzone = gamepad.Deadzone;
        }

        public string Name { get; }
        public int Index { get; }
        public bool IsConnected { get; }
        public Deadzone Deadzone { get; }

        public unsafe Span<Button> GetButtons()
            => new(Unsafe.AsPointer(ref _buttons.Memory.Span.GetPinnableReference()), _buttonCount);
        public unsafe Span<Thumbstick> GetThumbsticks()
            => new(Unsafe.AsPointer(ref _thumbsticks.Memory.Span.GetPinnableReference()), _thumbstickCount);
        public unsafe Span<Trigger> GetTriggers()
            => new(Unsafe.AsPointer(ref _triggers.Memory.Span.GetPinnableReference()), _triggerCount);

        public void Dispose()
        {
            _buttons?.Dispose();
            _thumbsticks?.Dispose();
            _triggers?.Dispose();
        }
    }
}
