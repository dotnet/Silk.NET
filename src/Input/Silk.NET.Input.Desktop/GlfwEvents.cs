// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.GLFW;

namespace Silk.NET.Input.Desktop
{
    internal class GlfwEvents : IDisposable
    {
        private unsafe WindowHandle* _handle;

        public unsafe GlfwEvents(WindowHandle* handle)
        {
            _handle = handle;
            GlfwProvider.GLFW.Value.SetCharCallback(handle, (a, b) => Char?.Invoke(a, b));
            GlfwProvider.GLFW.Value.SetKeyCallback(handle, (a, b, c, d, e) => Key?.Invoke(a, b, c, d, e));
            GlfwProvider.GLFW.Value.SetMouseButtonCallback(handle, (a, b, c, d) => MouseButton?.Invoke(a, b, c, d));
            GlfwProvider.GLFW.Value.SetCursorEnterCallback(handle, (a, b) => CursorEnter?.Invoke(a, b));
            GlfwProvider.GLFW.Value.SetCursorPosCallback(handle, (a, b,c) => CursorPos?.Invoke(a, b, c));
        }

        public event GlfwCallbacks.KeyCallback Key;
        public event GlfwCallbacks.CharCallback Char;
        public event GlfwCallbacks.MouseButtonCallback MouseButton;
        public event GlfwCallbacks.CursorEnterCallback CursorEnter;
        public event GlfwCallbacks.CursorPosCallback CursorPos;
        public event GlfwCallbacks.JoystickCallback Joystick;

        public unsafe void Dispose()
        {
            GlfwProvider.GLFW.Value.SetCharCallback(_handle, null);
            GlfwProvider.GLFW.Value.SetKeyCallback(_handle, null);
            GlfwProvider.GLFW.Value.SetMouseButtonCallback(_handle, null);
            GlfwProvider.GLFW.Value.SetCursorEnterCallback(_handle, null);
            GlfwProvider.GLFW.Value.SetCursorPosCallback(_handle, null);
        }

        public void InvokeJoystick(int joystick, ConnectedState state)
        {
            Joystick?.Invoke(joystick, state);
        }
    }
}
