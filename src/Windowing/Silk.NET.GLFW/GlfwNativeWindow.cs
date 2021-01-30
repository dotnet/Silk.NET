// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
            var getHwnd = api.Context.GetProcAddress("glfwGetWin32Window");
            if (getHwnd != default)
            {
                var hwnd = ((delegate* unmanaged[Cdecl]<WindowHandle*, nint>) getHwnd)(window);
                Kind |= NativeWindowFlags.Win32;
                Win32 = (hwnd, Win32GetDC(hwnd), Win32GetWindowLongPtr(hwnd, GwlpHInstance));
                return;
            }

            var getCocoaId = api.Context.GetProcAddress("glfwGetCocoaWindow");
            if (getCocoaId != default)
            {
                Kind |= NativeWindowFlags.Cocoa;
                Cocoa = (nint) ((delegate* unmanaged[Cdecl]<WindowHandle*, void*>)getCocoaId)(window);
                return;
            }

            var getX11Display = api.Context.GetProcAddress("glfwGetX11Display");
            var getX11Window = api.Context.GetProcAddress("glfwGetX11Window");
            if (getX11Display != default && getX11Window != default)
            {
                Kind |= NativeWindowFlags.X11;
                X11 = ((nint) ((delegate* unmanaged[Cdecl]<void*>) getX11Display)(),
                    ((delegate* unmanaged[Cdecl]<WindowHandle*, nuint>) getX11Window)(window));
                return;
            }

            var getWaylandDisplay = api.Context.GetProcAddress("glfwGetWaylandDisplay");
            var getWaylandWindow = api.Context.GetProcAddress("glfwGetWaylandWindow");
            if (getWaylandDisplay != default && getWaylandWindow != default)
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
