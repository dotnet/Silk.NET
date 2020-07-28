// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Silk.NET.Input.Extensions
{
    public sealed class MouseState : IDisposable
    {
        private readonly int _buttonCount;
        private readonly unsafe MouseButton* _buttons;
        private readonly int _pressedButtonCount;
        private readonly unsafe MouseButton* _pressedButtons;
        private readonly int _scrollWheelCount;
        private readonly unsafe ScrollWheel* _scrollWheels;

        internal unsafe MouseState(IMouse mouse)
        {
            Name = mouse.Name;
            Index = mouse.Index;
            IsConnected = mouse.IsConnected;
            var buttons = mouse.SupportedButtons;
            _buttonCount = buttons.Count;
            _buttons = (MouseButton*) Marshal.AllocHGlobal(_buttonCount * sizeof(MouseButton));
            _pressedButtons = (MouseButton*) Marshal.AllocHGlobal(_buttonCount * sizeof(MouseButton));
            _pressedButtonCount = 0;
            for (var i = 0; i < _buttonCount; i++)
            {
                _buttons[i] = buttons[i];
                if (mouse.IsButtonPressed(_buttons[i]))
                {
                    _pressedButtons[_pressedButtonCount++] = _buttons[i];
                }
            }

            _pressedButtons = (MouseButton*) Marshal.ReAllocHGlobal
                ((IntPtr) _pressedButtons, (IntPtr) (_pressedButtonCount * sizeof(MouseButton)));
            var wheels = mouse.ScrollWheels;
            _scrollWheelCount = wheels.Count;
            _scrollWheels = (ScrollWheel*) Marshal.AllocHGlobal(_scrollWheelCount * sizeof(ScrollWheel));
            for (var i = 0; i < _scrollWheelCount; i++)
            {
                _scrollWheels[i] = wheels[i];
            }

            Position = mouse.Position;
        }

        public string Name { get; }
        public int Index { get; }
        public bool IsConnected { get; }
        public PointF Position { get; }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        public unsafe Span<MouseButton> GetSupportedButtons()
        {
            return new Span<MouseButton>(_buttons, _buttonCount);
        }

        public unsafe Span<MouseButton> GetPressedButtons()
        {
            return new Span<MouseButton>(_pressedButtons, _pressedButtonCount);
        }

        public unsafe Span<ScrollWheel> GetScrollWheels()
        {
            return new Span<ScrollWheel>(_scrollWheels, _scrollWheelCount);
        }

        public unsafe bool IsButtonPressed(MouseButton btn)
        {
            for (var i = 0; i < _pressedButtonCount; i++)
            {
                if (_pressedButtons[i] == btn)
                {
                    return true;
                }
            }

            return false;
        }

        private unsafe void ReleaseUnmanagedResources()
        {
            Marshal.FreeHGlobal((IntPtr) _buttons);
            Marshal.FreeHGlobal((IntPtr) _pressedButtons);
            Marshal.FreeHGlobal((IntPtr) _scrollWheels);
        }

        ~MouseState()
        {
            ReleaseUnmanagedResources();
        }
    }
}
