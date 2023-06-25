// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUBackendType")]
    public enum BackendType : int
    {
        [NativeName("Name", "WGPUBackendType_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUBackendType_Null")]
        Null = 0x1,
        [NativeName("Name", "WGPUBackendType_WebGPU")]
        WebGpu = 0x2,
        [NativeName("Name", "WGPUBackendType_D3D11")]
        D3D11 = 0x3,
        [NativeName("Name", "WGPUBackendType_D3D12")]
        D3D12 = 0x4,
        [NativeName("Name", "WGPUBackendType_Metal")]
        Metal = 0x5,
        [NativeName("Name", "WGPUBackendType_Vulkan")]
        Vulkan = 0x6,
        [NativeName("Name", "WGPUBackendType_OpenGL")]
        OpenGL = 0x7,
        [NativeName("Name", "WGPUBackendType_OpenGLES")]
        OpenGles = 0x8,
        [NativeName("Name", "WGPUBackendType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
