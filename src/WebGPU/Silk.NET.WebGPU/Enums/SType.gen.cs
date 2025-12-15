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
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromCanvasHTMLSelector")]
        SurfaceDescriptorFromCanvasHtmlSelector = 0x4,
        [NativeName("Name", "WGPUSType_ShaderModuleSPIRVDescriptor")]
        ShaderModuleSpirvDescriptor = 0x5,
        [NativeName("Name", "WGPUSType_ShaderModuleWGSLDescriptor")]
        ShaderModuleWgslDescriptor = 0x6,
        [NativeName("Name", "WGPUSType_Invalid")]
        Invalid = 0x0,
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromMetalLayer")]
        SurfaceDescriptorFromMetalLayer = 0x1,
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromWindowsHWND")]
        SurfaceDescriptorFromWindowsHwnd = 0x2,
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromXlibWindow")]
        SurfaceDescriptorFromXlibWindow = 0x3,
        [Obsolete("Deprecated in favour of \"SurfaceDescriptorFromCanvasHtmlSelector\"")]
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromCanvasHTMLSelector")]
        SurfaceDescriptorFromCanvasHtmlselector = 0x4,
        [Obsolete("Deprecated in favour of \"ShaderModuleSpirvDescriptor\"")]
        [NativeName("Name", "WGPUSType_ShaderModuleSPIRVDescriptor")]
        ShaderModuleSpirvdescriptor = 0x5,
        [Obsolete("Deprecated in favour of \"ShaderModuleWgslDescriptor\"")]
        [NativeName("Name", "WGPUSType_ShaderModuleWGSLDescriptor")]
        ShaderModuleWgsldescriptor = 0x6,
        [NativeName("Name", "WGPUSType_PrimitiveDepthClipControl")]
        PrimitiveDepthClipControl = 0x7,
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromWaylandSurface")]
        SurfaceDescriptorFromWaylandSurface = 0x8,
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromAndroidNativeWindow")]
        SurfaceDescriptorFromAndroidNativeWindow = 0x9,
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromXcbWindow")]
        SurfaceDescriptorFromXcbWindow = 0xA,
        [NativeName("Name", "WGPUSType_RenderPassDescriptorMaxDrawCount")]
        RenderPassDescriptorMaxDrawCount = 0xF,
        [NativeName("Name", "WGPUSType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
