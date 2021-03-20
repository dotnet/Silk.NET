// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using Silk.NET.Core.Contexts;

namespace Silk.NET.GLFW
{
    public struct GlfwNativeWindow : INativeWindow
    {
        private const int GwlpHInstance = -6;
    
        [DllImport("user32", EntryPoint = "GetDC")]
        private static extern nint Win32GetDC(nint hwnd);

        [DllImport("user32", EntryPoint = "GetWindowLongPtrA")]
        private static extern nint Win32GetWindowLongPtr(nint hwnd, int index);
    
        public unsafe GlfwNativeWindow(Glfw api, WindowHandle* window) : this()
        {
            Kind |= NativeWindowFlags.Glfw;
            Glfw = (nint) window;
            if (api.Context.TryGetProcAddress("glfwGetWin32Window", out var getHwnd))
            {
                var hwnd = ((delegate* unmanaged[Cdecl]<WindowHandle*, nint>) getHwnd)(window);
                Kind |= NativeWindowFlags.Win32;
                Win32 = (hwnd, Win32GetDC(hwnd), Win32GetWindowLongPtr(hwnd, GwlpHInstance));
                return;
            }

            if (api.Context.TryGetProcAddress("glfwGetCocoaWindow", out var getCocoaId))
            {
                Kind |= NativeWindowFlags.Cocoa;
                Cocoa = (nint) ((delegate* unmanaged[Cdecl]<WindowHandle*, void*>)getCocoaId)(window);
                return;
            }

            if (api.Context.TryGetProcAddress("glfwGetX11Display", out var getX11Display) && 
                api.Context.TryGetProcAddress("glfwGetX11Window", out var getX11Window))
            {
                Kind |= NativeWindowFlags.X11;
                X11 = ((nint) ((delegate* unmanaged[Cdecl]<void*>) getX11Display)(),
                    ((delegate* unmanaged[Cdecl]<WindowHandle*, nuint>) getX11Window)(window));
                return;
            }

            if (api.Context.TryGetProcAddress("glfwGetWaylandDisplay", out var getWaylandDisplay) && 
                api.Context.TryGetProcAddress("glfwGetWaylandWindow", out var getWaylandWindow))
            {
                Kind |= NativeWindowFlags.Wayland;
                Wayland = ((nint) ((delegate* unmanaged[Cdecl]<void*>) getWaylandDisplay)(),
                    (nint) ((delegate* unmanaged[Cdecl]<WindowHandle*, void*>) getWaylandWindow)(window));
            }
        }
        public NativeWindowFlags Kind { get; }
        public (nint Display, nuint Window)? X11 { get; }
        public nint? Cocoa { get; }
        public (nint Display, nint Surface)? Wayland { get; }
        public nint? WinRT { get; }
        public (nint Window, uint Framebuffer, uint Colorbuffer, uint ResolveFramebuffer)? UIKit { get; }
        public (nint Hwnd, nint HDC, nint HInstance)? Win32 { get; }
        public (nint Display, nint Window)? Vivante { get; }
        public (nint Window, nint Surface)? Android { get; }
        public nint? Glfw { get; }
        public nint? Sdl { get; }
    }
}
