// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_HEAP_FLAGS")]
    public enum HeapFlags : int
    {
        [NativeName("Name", "D3D12_HEAP_FLAG_NONE")]
        HeapFlagNone = 0x0,
        [NativeName("Name", "D3D12_HEAP_FLAG_SHARED")]
        HeapFlagShared = 0x1,
        [NativeName("Name", "D3D12_HEAP_FLAG_DENY_BUFFERS")]
        HeapFlagDenyBuffers = 0x4,
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_DISPLAY")]
        HeapFlagAllowDisplay = 0x8,
        [NativeName("Name", "D3D12_HEAP_FLAG_SHARED_CROSS_ADAPTER")]
        HeapFlagSharedCrossAdapter = 0x20,
        [NativeName("Name", "D3D12_HEAP_FLAG_DENY_RT_DS_TEXTURES")]
        HeapFlagDenyRTDSTextures = 0x40,
        [NativeName("Name", "D3D12_HEAP_FLAG_DENY_NON_RT_DS_TEXTURES")]
        HeapFlagDenyNonRTDSTextures = 0x80,
        [NativeName("Name", "D3D12_HEAP_FLAG_HARDWARE_PROTECTED")]
        HeapFlagHardwareProtected = 0x100,
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_WRITE_WATCH")]
        HeapFlagAllowWriteWatch = 0x200,
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_SHADER_ATOMICS")]
        HeapFlagAllowShaderAtomics = 0x400,
        [NativeName("Name", "D3D12_HEAP_FLAG_CREATE_NOT_RESIDENT")]
        HeapFlagCreateNotResident = 0x800,
        [NativeName("Name", "D3D12_HEAP_FLAG_CREATE_NOT_ZEROED")]
        HeapFlagCreateNotZeroed = 0x1000,
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_ALL_BUFFERS_AND_TEXTURES")]
        HeapFlagAllowAllBuffersAndTextures = 0x0,
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_ONLY_BUFFERS")]
        HeapFlagAllowOnlyBuffers = 0xC0,
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_ONLY_NON_RT_DS_TEXTURES")]
        HeapFlagAllowOnlyNonRTDSTextures = 0x44,
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_ONLY_RT_DS_TEXTURES")]
        HeapFlagAllowOnlyRTDSTextures = 0x84,
    }
}
