// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Buffers;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Input.Extensions
{
    public sealed class MouseState : IDisposable
    {
        private readonly int _buttonCount, _pressedButtonCount, _scrollWheelCount;
        private readonly IMemoryOwner<byte> _buttons, _pressedButtons, _scrollWheels;

        internal unsafe MouseState(IMouse mouse, MemoryPool<byte> pool)
        {
            // Set properties
            Name = mouse.Name;
            Index = mouse.Index;
            IsConnected = mouse.IsConnected;
            
            // Initial rentals
            var srcButtons = mouse.SupportedButtons; // get the source's supported buttons
            _buttonCount = srcButtons.Count; // assign the button count
            _buttons = pool.Rent(_buttonCount * sizeof(MouseButton)); // do a full rental of all supported buttons
            // we don't know how many buttons are pressed, do a full rental
            _pressedButtons = pool.Rent(_buttonCount * sizeof(MouseButton));
            _pressedButtonCount = _buttonCount; // set the pressed button count to span the entire initial rental
            var buttons = GetSupportedButtons(); // get the span over the supported buttons
            var pressedButtons = GetPressedButtons(); // get the full span of the initial rental of the pressed buttons
            _pressedButtonCount = 0; // set the pressed button count to zero to actually count how many are pressed
            for (var i = 0; i < _buttonCount; i++)
            {
                buttons[i] = srcButtons[i];
                if (mouse.IsButtonPressed(buttons[i]))
                {
                    pressedButtons[_pressedButtonCount++] = buttons[i];
                }
            }

            // Trim the pressed button rental
            using var wip = _pressedButtons; // get the original rental, and dispose of it when we're done
            var wipSpan = GetPressedButtons(); // get the trimmed span over the full initial rental
            _pressedButtons = pool.Rent(_pressedButtonCount * sizeof(MouseButton)); // create the trimmed rental
            pressedButtons = GetPressedButtons(); // get the span over the trimmed rental
            wipSpan.CopyTo(pressedButtons); // copy the trimmed span over the full rental to the trimmed rental
            
            // Scroll wheels
            var srcWheels = mouse.ScrollWheels;
            _scrollWheelCount = srcWheels.Count;
            _scrollWheels = pool.Rent(_scrollWheelCount * sizeof(ScrollWheel));
            var dstWheels = GetScrollWheels();
            for (var i = 0; i < _scrollWheelCount; i++)
            {
                dstWheels[i] = srcWheels[i];
            }

            Position = mouse.Position;
        }

        public string Name { get; }
        public int Index { get; }
        public bool IsConnected { get; }
        public Vector2 Position { get; }

        public unsafe Span<MouseButton> GetSupportedButtons()
            => new(Unsafe.AsPointer(ref _buttons.Memory.Span.GetPinnableReference()), _buttonCount);

        public unsafe Span<MouseButton> GetPressedButtons()
            => new(Unsafe.AsPointer(ref _pressedButtons.Memory.Span.GetPinnableReference()), _pressedButtonCount);

        public unsafe Span<ScrollWheel> GetScrollWheels()
            => new(Unsafe.AsPointer(ref _scrollWheels.Memory.Span.GetPinnableReference()), _scrollWheelCount);

        public bool IsButtonPressed(MouseButton btn)
        {
            foreach (var pressedButton in GetPressedButtons())
            {
                if (pressedButton == btn)
                {
                    return true;
                }
            }

            return false;
        }

        public void Dispose()
        {
            _buttons?.Dispose();
            _pressedButtons?.Dispose();
            _scrollWheels?.Dispose();
        }
    }
}
