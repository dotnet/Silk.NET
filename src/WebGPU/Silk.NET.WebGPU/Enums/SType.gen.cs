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
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "WGPUSType_Invalid")]
        STypeInvalid = 0x0,
        [Obsolete("Deprecated in favour of \"SurfaceDescriptorFromMetalLayer\"")]
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromMetalLayer")]
        STypeSurfaceDescriptorFromMetalLayer = 0x1,
        [Obsolete("Deprecated in favour of \"SurfaceDescriptorFromWindowsHwnd\"")]
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromWindowsHWND")]
        STypeSurfaceDescriptorFromWindowsHwnd = 0x2,
        [Obsolete("Deprecated in favour of \"SurfaceDescriptorFromXlibWindow\"")]
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromXlibWindow")]
        STypeSurfaceDescriptorFromXlibWindow = 0x3,
        [Obsolete("Deprecated in favour of \"SurfaceDescriptorFromCanvasHtmlselector\"")]
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromCanvasHTMLSelector")]
        STypeSurfaceDescriptorFromCanvasHtmlselector = 0x4,
        [Obsolete("Deprecated in favour of \"ShaderModuleSpirvdescriptor\"")]
        [NativeName("Name", "WGPUSType_ShaderModuleSPIRVDescriptor")]
        STypeShaderModuleSpirvdescriptor = 0x5,
        [Obsolete("Deprecated in favour of \"ShaderModuleWgsldescriptor\"")]
        [NativeName("Name", "WGPUSType_ShaderModuleWGSLDescriptor")]
        STypeShaderModuleWgsldescriptor = 0x6,
        [Obsolete("Deprecated in favour of \"PrimitiveDepthClipControl\"")]
        [NativeName("Name", "WGPUSType_PrimitiveDepthClipControl")]
        STypePrimitiveDepthClipControl = 0x7,
        [Obsolete("Deprecated in favour of \"SurfaceDescriptorFromWaylandSurface\"")]
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromWaylandSurface")]
        STypeSurfaceDescriptorFromWaylandSurface = 0x8,
        [Obsolete("Deprecated in favour of \"SurfaceDescriptorFromAndroidNativeWindow\"")]
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromAndroidNativeWindow")]
        STypeSurfaceDescriptorFromAndroidNativeWindow = 0x9,
        [Obsolete("Deprecated in favour of \"SurfaceDescriptorFromXcbWindow\"")]
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromXcbWindow")]
        STypeSurfaceDescriptorFromXcbWindow = 0xA,
        [Obsolete("Deprecated in favour of \"RenderPassDescriptorMaxDrawCount\"")]
        [NativeName("Name", "WGPUSType_RenderPassDescriptorMaxDrawCount")]
        STypeRenderPassDescriptorMaxDrawCount = 0xF,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUSType_Force32")]
        STypeForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUSType_Invalid")]
        Invalid = 0x0,
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromMetalLayer")]
        SurfaceDescriptorFromMetalLayer = 0x1,
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromWindowsHWND")]
        SurfaceDescriptorFromWindowsHwnd = 0x2,
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromXlibWindow")]
        SurfaceDescriptorFromXlibWindow = 0x3,
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromCanvasHTMLSelector")]
        SurfaceDescriptorFromCanvasHtmlselector = 0x4,
        [NativeName("Name", "WGPUSType_ShaderModuleSPIRVDescriptor")]
        ShaderModuleSpirvdescriptor = 0x5,
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
