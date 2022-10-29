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
        [Obsolete("Deprecated in favour of \"Null\"")]
        [NativeName("Name", "WGPUBackendType_Null")]
        BackendTypeNull = 0x0,
        [Obsolete("Deprecated in favour of \"WebGpu\"")]
        [NativeName("Name", "WGPUBackendType_WebGPU")]
        BackendTypeWebGpu = 0x1,
        [Obsolete("Deprecated in favour of \"D3D11\"")]
        [NativeName("Name", "WGPUBackendType_D3D11")]
        BackendTypeD3D11 = 0x2,
        [Obsolete("Deprecated in favour of \"D3D12\"")]
        [NativeName("Name", "WGPUBackendType_D3D12")]
        BackendTypeD3D12 = 0x3,
        [Obsolete("Deprecated in favour of \"Metal\"")]
        [NativeName("Name", "WGPUBackendType_Metal")]
        BackendTypeMetal = 0x4,
        [Obsolete("Deprecated in favour of \"Vulkan\"")]
        [NativeName("Name", "WGPUBackendType_Vulkan")]
        BackendTypeVulkan = 0x5,
        [Obsolete("Deprecated in favour of \"OpenGL\"")]
        [NativeName("Name", "WGPUBackendType_OpenGL")]
        BackendTypeOpenGL = 0x6,
        [Obsolete("Deprecated in favour of \"OpenGles\"")]
        [NativeName("Name", "WGPUBackendType_OpenGLES")]
        BackendTypeOpenGles = 0x7,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUBackendType_Force32")]
        BackendTypeForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUBackendType_Null")]
        Null = 0x0,
        [NativeName("Name", "WGPUBackendType_WebGPU")]
        WebGpu = 0x1,
        [NativeName("Name", "WGPUBackendType_D3D11")]
        D3D11 = 0x2,
        [NativeName("Name", "WGPUBackendType_D3D12")]
        D3D12 = 0x3,
        [NativeName("Name", "WGPUBackendType_Metal")]
        Metal = 0x4,
        [NativeName("Name", "WGPUBackendType_Vulkan")]
        Vulkan = 0x5,
        [NativeName("Name", "WGPUBackendType_OpenGL")]
        OpenGL = 0x6,
        [NativeName("Name", "WGPUBackendType_OpenGLES")]
        OpenGles = 0x7,
        [NativeName("Name", "WGPUBackendType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
