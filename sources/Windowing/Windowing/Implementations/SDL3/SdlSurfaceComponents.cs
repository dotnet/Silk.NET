// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

#pragma warning disable CS9113 // Parameter is unread.
internal partial class SdlSurfaceComponents(SdlSurface surface)
#pragma warning restore CS9113 // Parameter is unread.
{
    public bool IsChildrenEnabled { get; set; }
    public bool IsDisplayEnabled { get; set; }
    public bool IsOpenGLEnabled { get; set; }
    public bool IsScaleEnabled => true;
    public bool IsVulkanEnabled { get; set; }
    public bool IsWindowEnabled { get; set; }

    public void QueryFeatures()
    {
        IsOpenGLEnabled = Sdl.GLLoadLibrary(nullptr) == 1;
        IsVulkanEnabled = false; // TODO
        IsDisplayEnabled = true;

        // var props = Sdl.CreateProperties();
        // Sdl.SetProperty(props, )
        // Sdl.CreateWindowWithProperties()
    }
}
