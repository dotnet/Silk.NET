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


        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        private static extern nint GetWindowLongPtr32(nint hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr")]
        private static extern nint GetWindowLongPtr64(nint hWnd, int nIndex);

        // This static method is required because Win32 does not support
        // GetWindowLongPtr directly
        private static unsafe nint GetWindowLongPtr(nint hWnd, int nIndex)
        {
            if (sizeof(nint) == 8)
                return GetWindowLongPtr64(hWnd, nIndex);
            else
                return GetWindowLongPtr32(hWnd, nIndex);
        }

        public unsafe GlfwNativeWindow(Glfw api, WindowHandle* window) : this()
        {
            Kind |= NativeWindowFlags.Glfw;
            Glfw = (nint) window;
            DXHandle = (nint)window;
            if (api.Context.TryGetProcAddress("glfwGetWin32Window", out var getHwnd))
            {
                var hwnd = ((delegate* unmanaged[Cdecl]<WindowHandle*, nint>) getHwnd)(window);
                Kind |= NativeWindowFlags.Win32;
                Win32 = (hwnd, Win32GetDC(hwnd), GetWindowLongPtr(hwnd, GwlpHInstance));
                DXHandle = hwnd;
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
                var x11Display = (nint) ((delegate* unmanaged[Cdecl]<void*>) getX11Display)();
                var x11Window = ((delegate* unmanaged[Cdecl]<WindowHandle*, nuint>) getX11Window)(window);
                
                if (x11Display != 0 && x11Window != 0)
                {
                    Kind |= NativeWindowFlags.X11;
                
                    X11 = (x11Display, x11Window);
                    return;
                }
            }

            if (api.Context.TryGetProcAddress("glfwGetWaylandDisplay", out var getWaylandDisplay) && 
                api.Context.TryGetProcAddress("glfwGetWaylandWindow", out var getWaylandWindow))
            {
                Kind |= NativeWindowFlags.Wayland;
                Wayland = ((nint) ((delegate* unmanaged[Cdecl]<void*>) getWaylandDisplay)(),
                           (nint) ((delegate* unmanaged[Cdecl]<WindowHandle*, void*>) getWaylandWindow)(window));
            }
            
            if (api.Context.TryGetProcAddress("glfwGetEGLDisplay", out var getEGLDisplay) && 
                api.Context.TryGetProcAddress("glfwGetEGLSurface", out var getEGLSurface))
            {
                Kind |= NativeWindowFlags.EGL;
                EGL = ((nint) ((delegate* unmanaged[Cdecl]<void*>) getEGLDisplay)(),
                           (nint) ((delegate* unmanaged[Cdecl]<WindowHandle*, void*>) getEGLSurface)(window));
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
        public nint? DXHandle { get; }
        public (nint? Display, nint? Surface)? EGL { get; }
    }
}
