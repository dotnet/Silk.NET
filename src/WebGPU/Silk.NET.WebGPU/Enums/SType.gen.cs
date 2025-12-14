// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUSType")]
    public enum SType : int
    {
        [NativeName("Name", "WGPUSType_SurfaceSourceXCBWindow")]
        SurfaceSourceXcbWindow = 0x9,
        [NativeName("Name", "WGPUSType_RequestAdapterWebXROptions")]
        RequestAdapterWebXROptions = 0xB,
        [NativeName("Name", "WGPUSType_ShaderSourceSPIRV")]
        ShaderSourceSpirv = 0x1,
        [NativeName("Name", "WGPUSType_ShaderSourceWGSL")]
        ShaderSourceWgsl = 0x2,
        [NativeName("Name", "WGPUSType_RenderPassMaxDrawCount")]
        RenderPassMaxDrawCount = 0x3,
        [NativeName("Name", "WGPUSType_SurfaceSourceMetalLayer")]
        SurfaceSourceMetalLayer = 0x4,
        [NativeName("Name", "WGPUSType_SurfaceSourceWindowsHWND")]
        SurfaceSourceWindowsHwnd = 0x5,
        [NativeName("Name", "WGPUSType_SurfaceSourceXlibWindow")]
        SurfaceSourceXlibWindow = 0x6,
        [NativeName("Name", "WGPUSType_SurfaceSourceWaylandSurface")]
        SurfaceSourceWaylandSurface = 0x7,
        [NativeName("Name", "WGPUSType_SurfaceSourceAndroidNativeWindow")]
        SurfaceSourceAndroidNativeWindow = 0x8,
        [Obsolete("Deprecated in favour of \"SurfaceSourceXcbWindow\"")]
        [NativeName("Name", "WGPUSType_SurfaceSourceXCBWindow")]
        SurfaceSourceXcbwindow = 0x9,
        [NativeName("Name", "WGPUSType_SurfaceColorManagement")]
        SurfaceColorManagement = 0xA,
        [Obsolete("Deprecated in favour of \"RequestAdapterWebXROptions\"")]
        [NativeName("Name", "WGPUSType_RequestAdapterWebXROptions")]
        RequestAdapterWebXroptions = 0xB,
        [NativeName("Name", "WGPUSType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
