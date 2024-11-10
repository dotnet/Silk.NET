// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core.Contexts
{
    /// <summary>
    /// Wraps any underlying native window handles a window (or window-like instance) may have. 
    /// </summary>
    public interface INativeWindow
    {
        /// <summary>
        /// Gets a bitmask enum representing the underlying platforms powering this window.
        /// </summary>
        public NativeWindowFlags Kind { get; }

        /// <summary>
        /// The X11 display pointer (Display*) and the window XID (Window) of the underlying X11 window. May be null,
        /// in which case the underlying window is not using X11.
        /// </summary>
        (nint Display, nuint Window)? X11 { get; }

        /// <summary>
        /// The Cocoa window (NSWindow*). May be null, in which case the underlying window is not using Cocoa.
        /// </summary>
        nint? Cocoa { get; }

        /// <summary>
        /// The Wayland display pointer (wl_display*) and surface pointer (wl_surface*). May be null, in which case the
        /// underlying window is not using Wayland.
        /// </summary>
        (nint Display, nint Surface)? Wayland { get; }

        /// <summary>
        /// The WinRT window's inspectable interface (IInspectable*). May be null, in which case the underlying window
        /// is not using WinRT.
        /// </summary>
        nint? WinRT { get; }

        /// <summary>
        /// The UIKit window pointer (UIWindow*), OpenGL framebuffer object, OpenGL renderbuffer object, and resolve
        /// color renderbuffer. May be null, in which case the underlying window is not using UIKit.
        /// </summary>
        (nint Window, uint Framebuffer, uint Colorbuffer, uint ResolveFramebuffer)? UIKit { get; }

        /// <summary>
        /// The Win32 window handle (HWND), display controller (HDC), and instance (HINSTANCE). May be null, in which
        /// case the underlying window is not using Win32.
        /// </summary>
        (nint Hwnd, nint HDC, nint HInstance)? Win32 { get; }

        /// <summary>
        /// The Vivante EGL display type (EGLNativeDisplayType) and EGL window type (EGLNativeWindowType). May be null,
        /// in which case the underlying window is not using Vivante.
        /// </summary>
        (nint Display, nint Window)? Vivante { get; }

        /// <summary>
        /// The Android native window pointer (ANativeWindow*) and EGL surface (EGLSurface). May be null, in which case
        /// the underlying window is not using Android.
        /// </summary>
        (nint Window, nint Surface)? Android { get; }

        /// <summary>
        /// The GLFW window handle (GLFWwindow* or WindowHandle* if using Silk.NET.GLFW). May be null, in which case the
        /// underlying window is not using GLFW.
        /// </summary>
        nint? Glfw { get; }

        /// <summary>
        /// The SDL window handle (SDL_Window* or Window* if using Silk.NET.SDL). May be null, in which case the
        /// underlying window is not using SDL.
        /// </summary>
        nint? Sdl { get; }

        /// <summary>
        /// The handle to use for DirectX applications. This will be the Win32 Hwnd on Windows, and it will be the GLFW
        /// or SDL handle on non-windows platforms for use with native builds of DXVK. May not be null.
        /// </summary>
        nint? DXHandle { get; }
        
        /// <summary>
        /// The handles for the EGL display and EGL surface. May not be null.
        /// </summary>
        (nint? Display, nint? Surface)? EGL { get; } 
    }
}
