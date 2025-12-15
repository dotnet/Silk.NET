// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [Flags]
    [NativeName("Name", "WGPUInstanceBackend")]
    public enum InstanceBackend : int
    {
        [NativeName("Name", "WGPUInstanceBackend_All")]
        All = 0x0,
        [NativeName("Name", "WGPUInstanceBackend_Vulkan")]
        Vulkan = 0x1,
        [NativeName("Name", "WGPUInstanceBackend_GL")]
        GL = 0x2,
        [NativeName("Name", "WGPUInstanceBackend_Metal")]
        Metal = 0x4,
        [NativeName("Name", "WGPUInstanceBackend_DX12")]
        DX12 = 0x8,
        [NativeName("Name", "WGPUInstanceBackend_DX11")]
        DX11 = 0x10,
        [NativeName("Name", "WGPUInstanceBackend_BrowserWebGPU")]
        BrowserWebGpu = 0x20,
        [NativeName("Name", "WGPUInstanceBackend_Primary")]
        Primary = 0x2D,
        [NativeName("Name", "WGPUInstanceBackend_Secondary")]
        Secondary = 0x12,
        [NativeName("Name", "WGPUInstanceBackend_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
