// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Contexts;
using Silk.NET.WebGPU;
using Silk.NET.Windowing;

namespace Silk.NET.Windowing.Extensions.WebGPU;
/// <inheritdoc/>

public static class WebGPUWindow
{
    /// <summary>
    /// Creates a WebGPU surface from a window.
    /// </summary>
    /// <param name="wgpu">A WebGPU instance</param>
    /// <param name="window">The window to get the surface from</param>
    /// <returns>A newly created Surface*/</returns>
    /// <exception cref="NotSupportedException">Throws when an unsupported platform is detected.</exception>
    public static unsafe Surface* CreateSurface(NET.WebGPU.WebGPU wgpu, IWindow window)
    {
        var descriptor = new SurfaceDescriptor();

        if (window.Native.X11 != null)
        {
            var xlibDescriptor = new SurfaceDescriptorFromXlibWindow
            {
                Chain = new ChainedStruct
                {
                    Next = null,
                    SType = SType.SurfaceDescriptorFromXlibWindow
                },
                Display = (void*) window.Native.X11.Value.Display,
                Window = (uint) window.Native.X11.Value.Window
            };

            descriptor.NextInChain = (ChainedStruct*) (&xlibDescriptor);
        }
        else if (window.Native.Cocoa != null)
        {
            throw new NotSupportedException("WebGPU on MacOS is not supported at this time!)");

            var cocoa = window.Native.Cocoa.Value;

            var cocoaDescriptor = new SurfaceDescriptorFromMetalLayer
            {
                Chain = new ChainedStruct
                {
                    Next = null,
                    SType = SType.SurfaceDescriptorFromMetalLayer
                },
                Layer = null //TODO: Get the layer from the window
            };
        }
        else if (window.Native.Wayland != null)
        {
            var waylandDescriptor = new SurfaceDescriptorFromWaylandSurface
            {
                Chain = new ChainedStruct
                {
                    Next = null,
                    SType = SType.SurfaceDescriptorFromWaylandSurface
                },
                Display = (void*) window.Native.Wayland.Value.Display,
                Surface = (void*) window.Native.Wayland.Value.Surface
            };

            descriptor.NextInChain = (ChainedStruct*) (&waylandDescriptor);
        }
        else if (window.Native.Win32 != null)
        {
            var win32Descriptor = new SurfaceDescriptorFromWindowsHWND
            {
                Chain = new ChainedStruct
                {
                    Next = null,
                    SType = SType.SurfaceDescriptorFromWindowsHwnd
                },
                Hwnd = (void*) window.Native.Win32.Value.Hwnd,
                Hinstance = (void*) window.Native.Win32.Value.HInstance
            };

            descriptor.NextInChain = (ChainedStruct*) (&win32Descriptor);
        }
        else
        {
            throw new NotSupportedException($"Your platform is not supported! {window.Native.Kind}");
        }

        return wgpu.InstanceCreateSurface(null, ref descriptor);
    }
}
