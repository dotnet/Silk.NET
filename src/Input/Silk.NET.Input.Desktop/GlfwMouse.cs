// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using Silk.NET.GLFW;
using Silk.NET.Input.Common;
using MouseButton = Silk.NET.Input.Common.MouseButton;

namespace Silk.NET.Input.Desktop
{
    internal class GlfwMouse : IMouse, IGlfwDevice, IGlfwSubscriber, IDisposable
    {
        private static readonly MouseButton[] Buttons = ((MouseButton[]) Enum.GetValues(typeof(MouseButton)))
            .Where(x => x != (MouseButton) (-1))
            .ToArray();

        private unsafe WindowHandle* _handle;
        private readonly unsafe ScrollWheel* _scrollWheel;
        private GlfwCallbacks.ScrollCallback _scroll;
        private GlfwCallbacks.CursorPosCallback _cursorPos;
        private GlfwCallbacks.MouseButtonCallback _mouseButton;
        private bool _firstClick = true;
        private MouseButton? _firstClickButton = null;
        private PointF _firstClickPosition = PointF.Empty;
        private DateTime? _firstClickTime = null;

        public unsafe GlfwMouse()
        {
            _scrollWheel = (ScrollWheel*) Marshal.AllocHGlobal(sizeof(ScrollWheel));
            ScrollWheels = new GlfwReadOnlyList<ScrollWheel>(_scrollWheel, 1);
        }
        public string Name { get; } = "Silk.NET Mouse (via GLFW)";
        public int Index { get; } = 0;
        public bool IsConnected { get; } = true;
        public IReadOnlyList<MouseButton> SupportedButtons { get; } = Buttons;
        public IReadOnlyList<ScrollWheel> ScrollWheels { get; }

        public unsafe PointF Position
        {
            get
            {
                GlfwProvider.GLFW.Value.GetCursorPos(_handle, out var x, out var y);
                return new PointF((float) x, (float) y);
            }
            set => GlfwProvider.GLFW.Value.SetCursorPos(_handle, value.X, value.Y);
        }

        public ICursor Cursor { get; private set; }
        public int DoubleClickTime { get; set; } = 500;
        public int DoubleClickRange { get; set; } = 4;

        public unsafe bool IsButtonPressed(MouseButton button)
        {
            var index = GetButton(button);

            if (index == -1)
            {
                return false;
            }

            return GlfwProvider.GLFW.Value.GetMouseButton(_handle, index) == (int) InputAction.Press;
        }

        public event Action<IMouse, MouseButton> MouseDown;
        public event Action<IMouse, MouseButton> MouseUp;
        public event Action<IMouse, MouseButton> Click;
        public event Action<IMouse, MouseButton> DoubleClick;
        public event Action<IMouse, PointF> MouseMove;
        public event Action<IMouse, ScrollWheel> Scroll;

        public unsafe void Dispose()
        {
            Marshal.FreeHGlobal((IntPtr) _handle);
        }

        public unsafe void Subscribe(GlfwEvents events)
        {
            _handle = events.Handle;
            events.Scroll += _scroll = (_, x, y) => Scroll?.Invoke
                (this, _scrollWheel[0] = new ScrollWheel((float) x, (float) y));
            events.CursorPos += _cursorPos = (_, x, y) => MouseMove?.Invoke(this, new PointF((float) x, (float) y));
            events.MouseButton += _mouseButton = (_, btn, action, mods) =>
                (action switch
                {
                    InputAction.Press => HandleMouseDown,
                    InputAction.Release => MouseUp,
                    InputAction.Repeat => null,
                    _ => null
                })?.Invoke(this, GetButton(btn));
            Cursor = new GlfwCursor(_handle);
        }

        public void Unsubscribe(GlfwEvents events)
        {
            events.Scroll -= _scroll;
            events.CursorPos -= _cursorPos;
            events.MouseButton -= _mouseButton;
        }

        private void HandleMouseDown(IMouse mouse, MouseButton button)
        {
            MouseDown?.Invoke(mouse, button);

            if (_firstClick || (_firstClickButton != null && _firstClickButton != button))
            {
                // This is the first click with the given mouse button.
                _firstClickTime = null;

                if (!_firstClick)
                {
                    // Only the mouse buttons differ so treat last click as a single click.
                    Click?.Invoke(mouse, _firstClickButton.Value);
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
                        DoubleClick?.Invoke(mouse, button);
                    }
                    else
                    {
                        // Second click was in time but outside range -> single click.
                        // The second click is another "first click".
                        Click?.Invoke(mouse, button);
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

        private void ProcessFirstClick(MouseButton button)
        {
            _firstClick = false;
            _firstClickButton = button;
            _firstClickPosition = Position;
            _firstClickTime = DateTime.Now;
        }

        private void HandleDoubleClickTimeElapse()
        {
            _firstClickTime = null;
            _firstClick = true;
            Click?.Invoke(this, _firstClickButton.Value);
        }

        public void Update()
        {
            if (_firstClickTime != null &&
                (DateTime.Now - _firstClickTime.Value).TotalMilliseconds > DoubleClickTime)
            {
                // No second click in maximum double click time.
                HandleDoubleClickTimeElapse();
            }
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
