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
    /// <param name="view">The window to get the surface from</param>
    /// <returns>A newly created Surface*/</returns>
    /// <exception cref="NotSupportedException">Throws when an unsupported platform is detected.</exception>
    public static unsafe Surface* CreateWebGPUSurface(this IView view, NET.WebGPU.WebGPU wgpu, Instance* instance = null)
    {
        var descriptor = new SurfaceDescriptor();

        if (view.Native.X11 != null)
        {
            var xlibDescriptor = new SurfaceDescriptorFromXlibWindow
            {
                Chain = new ChainedStruct
                {
                    Next = null,
                    SType = SType.SurfaceDescriptorFromXlibWindow
                },
                Display = (void*) view.Native.X11.Value.Display,
                Window = (uint) view.Native.X11.Value.Window
            };

            descriptor.NextInChain = (ChainedStruct*) (&xlibDescriptor);
        }
        else if (view.Native.Cocoa != null)
        {
            throw new NotSupportedException("WebGPU on MacOS is not supported at this time!)");

            var cocoa = view.Native.Cocoa.Value;

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
        else if (view.Native.Wayland != null)
        {
            var waylandDescriptor = new SurfaceDescriptorFromWaylandSurface
            {
                Chain = new ChainedStruct
                {
                    Next = null,
                    SType = SType.SurfaceDescriptorFromWaylandSurface
                },
                Display = (void*) view.Native.Wayland.Value.Display,
                Surface = (void*) view.Native.Wayland.Value.Surface
            };

            descriptor.NextInChain = (ChainedStruct*) (&waylandDescriptor);
        }
        else if (view.Native.Win32 != null)
        {
            var win32Descriptor = new SurfaceDescriptorFromWindowsHWND
            {
                Chain = new ChainedStruct
                {
                    Next = null,
                    SType = SType.SurfaceDescriptorFromWindowsHwnd
                },
                Hwnd = (void*) view.Native.Win32.Value.Hwnd,
                Hinstance = (void*) view.Native.Win32.Value.HInstance
            };

            descriptor.NextInChain = (ChainedStruct*) (&win32Descriptor);
        }
        else if (view.Native.Android != null)
        {
            var androidDescriptor = new SurfaceDescriptorFromAndroidNativeWindow
            {
                Chain = new ChainedStruct
                {
                    Next = null,
                    SType = SType.SurfaceDescriptorFromAndroidNativeWindow
                },
                Window = (void*) view.Native.Android.Value.Window
            };

            descriptor.NextInChain = (ChainedStruct*) (&androidDescriptor);
        }
        else
        {
            throw new NotSupportedException($"Your platform is not supported! {view.Native.Kind}");
        }

        return wgpu.InstanceCreateSurface(instance, ref descriptor);
    }
}
