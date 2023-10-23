// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Silk.NET.WebGPU.Platforms.MacOS;

namespace Silk.NET.WebGPU;

/// <summary>
/// A helper class to aid in getting a WebGPU Surface* 
/// </summary>
public static class WebGPUSurface
{
    /// <summary>
    /// Creates a WebGPU surface from a window.
    /// </summary>
    /// <param name="wgpu">A WebGPU instance</param>
    /// <param name="view">The window to get the surface from</param>
    /// <returns>A newly created Surface*/</returns>
    /// <exception cref="NotSupportedException">Throws when an unsupported platform is detected.</exception>
    public static unsafe Surface* CreateWebGPUSurface(this INativeWindowSource view, NET.WebGPU.WebGPU wgpu, Instance* instance)
    {
        var descriptor = new SurfaceDescriptor();

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("BROWSER")))
        {
            var htmlDescriptor = new SurfaceDescriptorFromCanvasHTMLSelector
            {
                Chain = new ChainedStruct
                {
                    Next  = null,
                    SType = SType.SurfaceDescriptorFromCanvasHtmlSelector
                },
                Selector = (byte*) SilkMarshal.StringToPtr("canvas")
            };

            descriptor.NextInChain = (ChainedStruct*) (&htmlDescriptor); 
        }
        else if (view.Native.X11 != null)
        {
            var xlibDescriptor = new SurfaceDescriptorFromXlibWindow
            {
                Chain = new ChainedStruct
                {
                    Next  = null,
                    SType = SType.SurfaceDescriptorFromXlibWindow
                },
                Display = (void*) view.Native.X11.Value.Display,
                Window  = (uint) view.Native.X11.Value.Window
            };

            descriptor.NextInChain = (ChainedStruct*) (&xlibDescriptor);
        }
        else if (view.Native.Cocoa != null)
        {
            // Based on the Veldrid Metal bindings implementation:
            // https://github.com/veldrid/veldrid/tree/master/src/Veldrid.MetalBindings
            var cocoa = view.Native.Cocoa.Value;
            CAMetalLayer metalLayer = CAMetalLayer.New();
            NSWindow nsWindow = new(cocoa);
            var contentView = nsWindow.contentView;
            contentView.wantsLayer = true;
            contentView.layer = metalLayer.NativePtr;

            var cocoaDescriptor = new SurfaceDescriptorFromMetalLayer
            {
                Chain = new ChainedStruct
                {
                    Next  = null,
                    SType = SType.SurfaceDescriptorFromMetalLayer
                },
                Layer = (void*) metalLayer.NativePtr
            };
            
            descriptor.NextInChain = (ChainedStruct*) (&cocoaDescriptor);
        }
        else if (view.Native.Wayland != null)
        {
            var waylandDescriptor = new SurfaceDescriptorFromWaylandSurface
            {
                Chain = new ChainedStruct
                {
                    Next  = null,
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
                    Next  = null,
                    SType = SType.SurfaceDescriptorFromWindowsHwnd
                },
                Hwnd      = (void*) view.Native.Win32.Value.Hwnd,
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
                    Next  = null,
                    SType = SType.SurfaceDescriptorFromAndroidNativeWindow
                },
                Window = (void*) view.Native.Android.Value.Window
            };

            descriptor.NextInChain = (ChainedStruct*) (&androidDescriptor);
        }
        else
        {
            throw new PlatformNotSupportedException($"Your platform is not supported! {view.Native.Kind}");
        }

        var surface = wgpu.InstanceCreateSurface(instance, descriptor);

        if (descriptor.NextInChain->SType == SType.SurfaceDescriptorFromCanvasHtmlSelector)
        {
            var htmlDescriptor = (SurfaceDescriptorFromCanvasHTMLSelector*) descriptor.NextInChain;
            
            SilkMarshal.Free((IntPtr) htmlDescriptor->Selector);
        }
        
        return surface;
    }
}
