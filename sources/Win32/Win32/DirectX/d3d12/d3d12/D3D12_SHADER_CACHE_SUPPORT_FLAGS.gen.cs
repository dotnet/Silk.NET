// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
public enum D3D12_SHADER_CACHE_SUPPORT_FLAGS
{
    D3D12_SHADER_CACHE_SUPPORT_NONE = 0,
    D3D12_SHADER_CACHE_SUPPORT_SINGLE_PSO = 0x1,
    D3D12_SHADER_CACHE_SUPPORT_LIBRARY = 0x2,
    D3D12_SHADER_CACHE_SUPPORT_AUTOMATIC_INPROC_CACHE = 0x4,
    D3D12_SHADER_CACHE_SUPPORT_AUTOMATIC_DISK_CACHE = 0x8,
    D3D12_SHADER_CACHE_SUPPORT_DRIVER_MANAGED_CACHE = 0x10,
    D3D12_SHADER_CACHE_SUPPORT_SHADER_CONTROL_CLEAR = 0x20,
    D3D12_SHADER_CACHE_SUPPORT_SHADER_SESSION_DELETE = 0x40,
}
