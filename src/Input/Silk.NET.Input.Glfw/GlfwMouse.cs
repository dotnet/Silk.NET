// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using Silk.NET.GLFW;
using Silk.NET.Input.Internals;

namespace Silk.NET.Input.Glfw
{
    internal class GlfwMouse : MouseImplementationBase, IGlfwSubscriber, IDisposable
    {
        private static readonly MouseButton[] _buttons = ((MouseButton[]) Enum.GetValues(typeof(MouseButton)))
            .Where(x => x != (MouseButton) (-1))
            .ToArray();

        private unsafe WindowHandle* _handle;
        private GlfwCallbacks.ScrollCallback? _scroll;
        private GlfwCallbacks.CursorPosCallback? _cursorPos;
        private GlfwCallbacks.MouseButtonCallback? _mouseButton;
        private bool _scrollModified = false;
        private ICursor? _cursor;

        public unsafe GlfwMouse()
        {
            ScrollWheels = new ScrollWheel[1];
        }

        public override string Name { get; } = "Silk.NET Mouse (via GLFW)";
        public override int Index { get; } = 0;
        public override bool IsConnected { get; } = true;
        public override IReadOnlyList<MouseButton> SupportedButtons { get; } = _buttons;
        public override IReadOnlyList<ScrollWheel> ScrollWheels { get; }

        public override unsafe Vector2 Position
        {
            get
            {
                GlfwProvider.GLFW.Value.GetCursorPos(_handle, out var x, out var y);
                return new Vector2((float) x, (float) y);
            }
            set => GlfwProvider.GLFW.Value.SetCursorPos(_handle, value.X, value.Y);
        }

        public override ICursor Cursor => _cursor!;

        public override unsafe bool IsButtonPressed(MouseButton button)
        {
            var index = GetButton(button);

            if (index == -1)
            {
                return false;
            }

            return GlfwProvider.GLFW.Value.GetMouseButton(_handle, index) == (int) InputAction.Press;
        }

        public override event Action<IMouse, Vector2>? MouseMove;
        public override event Action<IMouse, ScrollWheel>? Scroll;

        public unsafe void Dispose()
        {
        }

        public unsafe void Subscribe(GlfwEvents events)
        {
            _handle = events.Handle;
            events.Scroll += _scroll = (_, x, y) =>
            {
                var val = new ScrollWheel((float) x, (float) y);
                if (ScrollWheels[0].X != val.X || ScrollWheels[0].Y != val.Y)
                {
                    _scrollModified = true;
                }

                ((ScrollWheel[]) ScrollWheels)[0] = val;
                Scroll?.Invoke(this, val);
            };
            events.CursorPos += _cursorPos = (_, x, y) => MouseMove?.Invoke(this, new Vector2((float) x, (float) y));
            events.MouseButton += _mouseButton = (_, btn, action, mods) =>
            {
                switch (action)
                {
                    case InputAction.Press:
                    {
                        HandleMouseDown(this, GetButton(btn));
                        break;
                    }
                    case InputAction.Release:
                    {
                        HandleMouseUp(this, GetButton(btn));
                        break;
                    }
                }
            };
            _cursor = new GlfwCursor(_handle);
        }

        public void Unsubscribe(GlfwEvents events)
        {
            events.Scroll -= _scroll;
            events.CursorPos -= _cursorPos;
            events.MouseButton -= _mouseButton;
        }

        public void Update()
        {
            if (!_scrollModified)
            {
                ((ScrollWheel[]) ScrollWheels)[0] = default;
            }

            _scrollModified = false;
            HandleUpdate();
        }

        private static int GetButton(MouseButton btn) => btn switch
        {
            MouseButton.Left => (int) GLFW.MouseButton.Left,
            MouseButton.Right => (int) GLFW.MouseButton.Right,
            MouseButton.Middle => (int) GLFW.MouseButton.Middle,
            MouseButton.Button4 => (int) GLFW.MouseButton.Button4,
            MouseButton.Button5 => (int) GLFW.MouseButton.Button5,
            MouseButton.Button6 => (int) GLFW.MouseButton.Button6,
            MouseButton.Button7 => (int) GLFW.MouseButton.Button7,
            MouseButton.Button8 => (int) GLFW.MouseButton.Button8,
            MouseButton.Button9 => -1,
            MouseButton.Button10 => -1,
            MouseButton.Button11 => -1,
            MouseButton.Button12 => -1,
            _ => -1
        };

        private static MouseButton GetButton(GLFW.MouseButton btn) => btn switch
        {
            GLFW.MouseButton.Left => MouseButton.Left,
            GLFW.MouseButton.Right => MouseButton.Right,
            GLFW.MouseButton.Middle => MouseButton.Middle,
            GLFW.MouseButton.Button4 => MouseButton.Button4,
            GLFW.MouseButton.Button5 => MouseButton.Button5,
            GLFW.MouseButton.Button6 => MouseButton.Button6,
            GLFW.MouseButton.Button7 => MouseButton.Button7,
            GLFW.MouseButton.Button8 => MouseButton.Button8,
            _ => MouseButton.Unknown
        };
    }
}
