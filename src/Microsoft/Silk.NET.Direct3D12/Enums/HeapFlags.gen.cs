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
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_NONE")]
        HeapFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Shared\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_SHARED")]
        HeapFlagShared = 0x1,
        [Obsolete("Deprecated in favour of \"DenyBuffers\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_DENY_BUFFERS")]
        HeapFlagDenyBuffers = 0x4,
        [Obsolete("Deprecated in favour of \"AllowDisplay\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_DISPLAY")]
        HeapFlagAllowDisplay = 0x8,
        [Obsolete("Deprecated in favour of \"SharedCrossAdapter\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_SHARED_CROSS_ADAPTER")]
        HeapFlagSharedCrossAdapter = 0x20,
        [Obsolete("Deprecated in favour of \"DenyRTDSTextures\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_DENY_RT_DS_TEXTURES")]
        HeapFlagDenyRTDSTextures = 0x40,
        [Obsolete("Deprecated in favour of \"DenyNonRTDSTextures\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_DENY_NON_RT_DS_TEXTURES")]
        HeapFlagDenyNonRTDSTextures = 0x80,
        [Obsolete("Deprecated in favour of \"HardwareProtected\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_HARDWARE_PROTECTED")]
        HeapFlagHardwareProtected = 0x100,
        [Obsolete("Deprecated in favour of \"AllowWriteWatch\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_WRITE_WATCH")]
        HeapFlagAllowWriteWatch = 0x200,
        [Obsolete("Deprecated in favour of \"AllowShaderAtomics\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_SHADER_ATOMICS")]
        HeapFlagAllowShaderAtomics = 0x400,
        [Obsolete("Deprecated in favour of \"CreateNotResident\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_CREATE_NOT_RESIDENT")]
        HeapFlagCreateNotResident = 0x800,
        [Obsolete("Deprecated in favour of \"CreateNotZeroed\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_CREATE_NOT_ZEROED")]
        HeapFlagCreateNotZeroed = 0x1000,
        [Obsolete("Deprecated in favour of \"ToolsUseManualWriteTracking\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_TOOLS_USE_MANUAL_WRITE_TRACKING")]
        HeapFlagToolsUseManualWriteTracking = 0x2000,
        [Obsolete("Deprecated in favour of \"AllowAllBuffersAndTextures\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_ALL_BUFFERS_AND_TEXTURES")]
        HeapFlagAllowAllBuffersAndTextures = 0x0,
        [Obsolete("Deprecated in favour of \"AllowOnlyBuffers\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_ONLY_BUFFERS")]
        HeapFlagAllowOnlyBuffers = 0xC0,
        [Obsolete("Deprecated in favour of \"AllowOnlyNonRTDSTextures\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_ONLY_NON_RT_DS_TEXTURES")]
        HeapFlagAllowOnlyNonRTDSTextures = 0x44,
        [Obsolete("Deprecated in favour of \"AllowOnlyRTDSTextures\"")]
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_ONLY_RT_DS_TEXTURES")]
        HeapFlagAllowOnlyRTDSTextures = 0x84,
        [NativeName("Name", "D3D12_HEAP_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_HEAP_FLAG_SHARED")]
        Shared = 0x1,
        [NativeName("Name", "D3D12_HEAP_FLAG_DENY_BUFFERS")]
        DenyBuffers = 0x4,
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_DISPLAY")]
        AllowDisplay = 0x8,
        [NativeName("Name", "D3D12_HEAP_FLAG_SHARED_CROSS_ADAPTER")]
        SharedCrossAdapter = 0x20,
        [NativeName("Name", "D3D12_HEAP_FLAG_DENY_RT_DS_TEXTURES")]
        DenyRTDSTextures = 0x40,
        [NativeName("Name", "D3D12_HEAP_FLAG_DENY_NON_RT_DS_TEXTURES")]
        DenyNonRTDSTextures = 0x80,
        [NativeName("Name", "D3D12_HEAP_FLAG_HARDWARE_PROTECTED")]
        HardwareProtected = 0x100,
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_WRITE_WATCH")]
        AllowWriteWatch = 0x200,
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_SHADER_ATOMICS")]
        AllowShaderAtomics = 0x400,
        [NativeName("Name", "D3D12_HEAP_FLAG_CREATE_NOT_RESIDENT")]
        CreateNotResident = 0x800,
        [NativeName("Name", "D3D12_HEAP_FLAG_CREATE_NOT_ZEROED")]
        CreateNotZeroed = 0x1000,
        [NativeName("Name", "D3D12_HEAP_FLAG_TOOLS_USE_MANUAL_WRITE_TRACKING")]
        ToolsUseManualWriteTracking = 0x2000,
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_ALL_BUFFERS_AND_TEXTURES")]
        AllowAllBuffersAndTextures = 0x0,
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_ONLY_BUFFERS")]
        AllowOnlyBuffers = 0xC0,
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_ONLY_NON_RT_DS_TEXTURES")]
        AllowOnlyNonRTDSTextures = 0x44,
        [NativeName("Name", "D3D12_HEAP_FLAG_ALLOW_ONLY_RT_DS_TEXTURES")]
        AllowOnlyRTDSTextures = 0x84,
    }
}
