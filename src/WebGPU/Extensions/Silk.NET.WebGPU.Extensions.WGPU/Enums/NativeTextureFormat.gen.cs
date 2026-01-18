// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUNativeTextureFormat")]
    public enum NativeTextureFormat : int
    {
        [NativeName("Name", "WGPUNativeTextureFormat_R16Unorm")]
        R16Unorm = 0x30001,
        [NativeName("Name", "WGPUNativeTextureFormat_R16Snorm")]
        R16Snorm = 0x30002,
        [NativeName("Name", "WGPUNativeTextureFormat_Rg16Unorm")]
        Rg16Unorm = 0x30003,
        [NativeName("Name", "WGPUNativeTextureFormat_Rg16Snorm")]
        Rg16Snorm = 0x30004,
        [NativeName("Name", "WGPUNativeTextureFormat_Rgba16Unorm")]
        Rgba16Unorm = 0x30005,
        [NativeName("Name", "WGPUNativeTextureFormat_Rgba16Snorm")]
        Rgba16Snorm = 0x30006,
        [NativeName("Name", "WGPUNativeTextureFormat_NV12")]
        NV12 = 0x30007,
    }
}
