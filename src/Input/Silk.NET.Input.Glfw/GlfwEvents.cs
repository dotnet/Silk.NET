// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.GLFW;

namespace Silk.NET.Input.Glfw
{
    internal class GlfwEvents : IDisposable
    {
        public unsafe GlfwEvents(WindowHandle* handle)
        {
            Handle = handle;
            GlfwProvider.GLFW.Value.SetCharCallback(handle, (a, b) => Char?.Invoke(a, b));
            GlfwProvider.GLFW.Value.SetKeyCallback(handle, (a, b, c, d, e) => Key?.Invoke(a, b, c, d, e));
            GlfwProvider.GLFW.Value.SetMouseButtonCallback(handle, (a, b, c, d) => MouseButton?.Invoke(a, b, c, d));
            GlfwProvider.GLFW.Value.SetCursorEnterCallback(handle, (a, b) => CursorEnter?.Invoke(a, b));
            GlfwProvider.GLFW.Value.SetCursorPosCallback(handle, (a, b, c) => CursorPos?.Invoke(a, b, c));
            GlfwProvider.GLFW.Value.SetScrollCallback(handle, (a, b, c) => Scroll?.Invoke(a, b, c));
        }

        public unsafe WindowHandle* Handle { get; }
        public event GlfwCallbacks.KeyCallback Key;
        public event GlfwCallbacks.CharCallback Char;
        public event GlfwCallbacks.MouseButtonCallback MouseButton;
        public event GlfwCallbacks.CursorEnterCallback CursorEnter;
        public event GlfwCallbacks.CursorPosCallback CursorPos;
        public event GlfwCallbacks.ScrollCallback Scroll;

        public unsafe void Dispose()
        {
            GlfwProvider.GLFW.Value.SetCharCallback(Handle, null);
            GlfwProvider.GLFW.Value.SetKeyCallback(Handle, null);
            GlfwProvider.GLFW.Value.SetMouseButtonCallback(Handle, null);
            GlfwProvider.GLFW.Value.SetCursorEnterCallback(Handle, null);
            GlfwProvider.GLFW.Value.SetCursorPosCallback(Handle, null);
            GlfwProvider.GLFW.Value.SetScrollCallback(Handle, null);
        }
    }
}
