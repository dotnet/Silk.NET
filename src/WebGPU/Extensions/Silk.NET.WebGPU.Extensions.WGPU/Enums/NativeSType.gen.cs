// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUNativeSType")]
    public enum NativeSType : int
    {
        [NativeName("Name", "WGPUSType_DeviceExtras")]
        STypeDeviceExtras = 0x30001,
        [NativeName("Name", "WGPUSType_RequiredLimitsExtras")]
        STypeRequiredLimitsExtras = 0x30002,
        [NativeName("Name", "WGPUSType_PipelineLayoutExtras")]
        STypePipelineLayoutExtras = 0x30003,
        [NativeName("Name", "WGPUSType_ShaderModuleGLSLDescriptor")]
        STypeShaderModuleGlsldescriptor = 0x30004,
        [NativeName("Name", "WGPUSType_SupportedLimitsExtras")]
        STypeSupportedLimitsExtras = 0x30005,
        [NativeName("Name", "WGPUSType_InstanceExtras")]
        STypeInstanceExtras = 0x30006,
        [NativeName("Name", "WGPUSType_BindGroupEntryExtras")]
        STypeBindGroupEntryExtras = 0x30007,
        [NativeName("Name", "WGPUSType_BindGroupLayoutEntryExtras")]
        STypeBindGroupLayoutEntryExtras = 0x30008,
        [NativeName("Name", "WGPUSType_QuerySetDescriptorExtras")]
        STypeQuerySetDescriptorExtras = 0x30009,
        [NativeName("Name", "WGPUSType_SurfaceConfigurationExtras")]
        STypeSurfaceConfigurationExtras = 0x3000A,
        [NativeName("Name", "WGPUNativeSType_Force32")]
        NativeSTypeForce32 = 0x7FFFFFFF,
    }
}
