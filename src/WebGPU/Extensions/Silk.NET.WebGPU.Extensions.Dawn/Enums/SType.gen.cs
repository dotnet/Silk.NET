// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
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
        [Obsolete("Deprecated in favour of \"SurfaceDescriptorFromWindowsCoreWindow\"")]
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromWindowsCoreWindow")]
        STypeSurfaceDescriptorFromWindowsCoreWindow = 0xB,
        [Obsolete("Deprecated in favour of \"ExternalTextureBindingEntry\"")]
        [NativeName("Name", "WGPUSType_ExternalTextureBindingEntry")]
        STypeExternalTextureBindingEntry = 0xC,
        [Obsolete("Deprecated in favour of \"ExternalTextureBindingLayout\"")]
        [NativeName("Name", "WGPUSType_ExternalTextureBindingLayout")]
        STypeExternalTextureBindingLayout = 0xD,
        [Obsolete("Deprecated in favour of \"SurfaceDescriptorFromWindowsSwapChainPanel\"")]
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromWindowsSwapChainPanel")]
        STypeSurfaceDescriptorFromWindowsSwapChainPanel = 0xE,
        [Obsolete("Deprecated in favour of \"RenderPassDescriptorMaxDrawCount\"")]
        [NativeName("Name", "WGPUSType_RenderPassDescriptorMaxDrawCount")]
        STypeRenderPassDescriptorMaxDrawCount = 0xF,
        [Obsolete("Deprecated in favour of \"DawnTextureInternalUsageDescriptor\"")]
        [NativeName("Name", "WGPUSType_DawnTextureInternalUsageDescriptor")]
        STypeDawnTextureInternalUsageDescriptor = 0x3E8,
        [Obsolete("Deprecated in favour of \"DawnTogglesDeviceDescriptor\"")]
        [NativeName("Name", "WGPUSType_DawnTogglesDeviceDescriptor")]
        STypeDawnTogglesDeviceDescriptor = 0x3EA,
        [Obsolete("Deprecated in favour of \"DawnEncoderInternalUsageDescriptor\"")]
        [NativeName("Name", "WGPUSType_DawnEncoderInternalUsageDescriptor")]
        STypeDawnEncoderInternalUsageDescriptor = 0x3EB,
        [Obsolete("Deprecated in favour of \"DawnInstanceDescriptor\"")]
        [NativeName("Name", "WGPUSType_DawnInstanceDescriptor")]
        STypeDawnInstanceDescriptor = 0x3EC,
        [Obsolete("Deprecated in favour of \"DawnCacheDeviceDescriptor\"")]
        [NativeName("Name", "WGPUSType_DawnCacheDeviceDescriptor")]
        STypeDawnCacheDeviceDescriptor = 0x3ED,
        [Obsolete("Deprecated in favour of \"DawnAdapterPropertiesPowerPreference\"")]
        [NativeName("Name", "WGPUSType_DawnAdapterPropertiesPowerPreference")]
        STypeDawnAdapterPropertiesPowerPreference = 0x3EE,
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
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromWindowsCoreWindow")]
        SurfaceDescriptorFromWindowsCoreWindow = 0xB,
        [NativeName("Name", "WGPUSType_ExternalTextureBindingEntry")]
        ExternalTextureBindingEntry = 0xC,
        [NativeName("Name", "WGPUSType_ExternalTextureBindingLayout")]
        ExternalTextureBindingLayout = 0xD,
        [NativeName("Name", "WGPUSType_SurfaceDescriptorFromWindowsSwapChainPanel")]
        SurfaceDescriptorFromWindowsSwapChainPanel = 0xE,
        [NativeName("Name", "WGPUSType_RenderPassDescriptorMaxDrawCount")]
        RenderPassDescriptorMaxDrawCount = 0xF,
        [NativeName("Name", "WGPUSType_DawnTextureInternalUsageDescriptor")]
        DawnTextureInternalUsageDescriptor = 0x3E8,
        [NativeName("Name", "WGPUSType_DawnTogglesDeviceDescriptor")]
        DawnTogglesDeviceDescriptor = 0x3EA,
        [NativeName("Name", "WGPUSType_DawnEncoderInternalUsageDescriptor")]
        DawnEncoderInternalUsageDescriptor = 0x3EB,
        [NativeName("Name", "WGPUSType_DawnInstanceDescriptor")]
        DawnInstanceDescriptor = 0x3EC,
        [NativeName("Name", "WGPUSType_DawnCacheDeviceDescriptor")]
        DawnCacheDeviceDescriptor = 0x3ED,
        [NativeName("Name", "WGPUSType_DawnAdapterPropertiesPowerPreference")]
        DawnAdapterPropertiesPowerPreference = 0x3EE,
        [NativeName("Name", "WGPUSType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
