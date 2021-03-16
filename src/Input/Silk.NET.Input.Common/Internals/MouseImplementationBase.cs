// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Numerics;

namespace Silk.NET.Input.Internals
{
    internal abstract class MouseImplementationBase : IMouse
    {
        // Abstract members
        public abstract string Name { get; }
        public abstract int Index { get; }
        public abstract bool IsConnected { get; }
        public abstract IReadOnlyList<MouseButton> SupportedButtons { get; }
        public abstract IReadOnlyList<ScrollWheel> ScrollWheels { get; }
        public abstract Vector2 Position { get; set; }
        public abstract ICursor Cursor { get; }
        public int DoubleClickTime { get; set; } = 500;
        public int DoubleClickRange { get; set; } = 4;
        public abstract bool IsButtonPressed(MouseButton btn);
        public abstract event Action<IMouse, Vector2>? MouseMove;
        public abstract event Action<IMouse, ScrollWheel>? Scroll;

        // Fields
        private MouseButton? _firstClickButton;
        private Vector2 _firstClickPosition = Vector2.Zero;
        private DateTime? _firstClickTime;
        private bool _firstClick = true;

        // Events
        public event Action<IMouse, MouseButton>? MouseDown;
        public event Action<IMouse, MouseButton>? MouseUp;
        public event Action<IMouse, MouseButton, Vector2>? Click;
        public event Action<IMouse, MouseButton, Vector2>? DoubleClick;

        protected void HandleMouseDown(IMouse mouse, MouseButton button)
        {
            MouseDown?.Invoke(mouse, button);

            if (_firstClick || (_firstClickButton != null && _firstClickButton != button))
            {
                // This is the first click with the given mouse button.
                _firstClickTime = null;

                if (!_firstClick && !(_firstClickButton is null))
                {
                    // Only the mouse buttons differ so treat last click as a single click.
                    Click?.Invoke(mouse, _firstClickButton.Value, Position);
                }

                ProcessFirstClick(button);
            }
            else
            {
                // This is the second click with the same mouse button.
                if (_firstClickTime != null &&
                    (DateTime.Now - _firstClickTime.Value).TotalMilliseconds <= DoubleClickTime)
                {
                    // Within the maximum double click time.
                    _firstClickTime = null;

                    var position = Position;
                    if (Math.Abs(position.X - _firstClickPosition.X) < DoubleClickRange &&
                        Math.Abs(position.Y - _firstClickPosition.Y) < DoubleClickRange)
                    {
                        // Second click was in time and in range -> double click.
                        _firstClick = true;
                        DoubleClick?.Invoke(mouse, button, position);
                    }
                    else
                    {
                        // Second click was in time but outside range -> single click.
                        // The second click is another "first click".
                        Click?.Invoke(mouse, button, position);
                        ProcessFirstClick(button);
                    }
                }
                else
                {
                    // The double click time elapsed.

                    // If Update() would have detected the time elapse before,
                    // it would have set _firstClick back to true and we won't be here.
                    // Therefore Update() has not detected time elapse here and we have
                    // to handle it.
                    HandleDoubleClickTimeElapse();

                    // Now process the second click as another "first click".
                    ProcessFirstClick(button);
                }
            }
        }

        protected void ProcessFirstClick(MouseButton button)
        {
            _firstClick = false;
            _firstClickButton = button;
            _firstClickPosition = Position;
            _firstClickTime = DateTime.Now;
        }

        protected void HandleDoubleClickTimeElapse()
        {
            _firstClickTime = null;
            _firstClick = true;
            if (!(_firstClickButton is null))
            {
                Click?.Invoke(this, _firstClickButton.Value, Position);
            }
        }

        protected void HandleUpdate()
        {
            if (_firstClickTime != null &&
                (DateTime.Now - _firstClickTime.Value).TotalMilliseconds > DoubleClickTime)
            {
                // No second click in maximum double click time.
                HandleDoubleClickTimeElapse();
            }
        }

        protected void HandleMouseUp(IMouse mouse, MouseButton btn) => MouseUp?.Invoke(mouse, btn);
    }
}
