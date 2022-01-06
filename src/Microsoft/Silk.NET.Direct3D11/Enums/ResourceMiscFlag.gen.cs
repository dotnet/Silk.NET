// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_RESOURCE_MISC_FLAG")]
    public enum ResourceMiscFlag : int
    {
        [NativeName("Name", "D3D11_RESOURCE_MISC_GENERATE_MIPS")]
        ResourceMiscGenerateMips = 0x1,
        [NativeName("Name", "D3D11_RESOURCE_MISC_SHARED")]
        ResourceMiscShared = 0x2,
        [NativeName("Name", "D3D11_RESOURCE_MISC_TEXTURECUBE")]
        ResourceMiscTexturecube = 0x4,
        [NativeName("Name", "D3D11_RESOURCE_MISC_DRAWINDIRECT_ARGS")]
        ResourceMiscDrawindirectArgs = 0x10,
        [NativeName("Name", "D3D11_RESOURCE_MISC_BUFFER_ALLOW_RAW_VIEWS")]
        ResourceMiscBufferAllowRawViews = 0x20,
        [NativeName("Name", "D3D11_RESOURCE_MISC_BUFFER_STRUCTURED")]
        ResourceMiscBufferStructured = 0x40,
        [NativeName("Name", "D3D11_RESOURCE_MISC_RESOURCE_CLAMP")]
        ResourceMiscResourceClamp = 0x80,
        [NativeName("Name", "D3D11_RESOURCE_MISC_SHARED_KEYEDMUTEX")]
        ResourceMiscSharedKeyedmutex = 0x100,
        [NativeName("Name", "D3D11_RESOURCE_MISC_GDI_COMPATIBLE")]
        ResourceMiscGdiCompatible = 0x200,
        [NativeName("Name", "D3D11_RESOURCE_MISC_SHARED_NTHANDLE")]
        ResourceMiscSharedNthandle = 0x800,
        [NativeName("Name", "D3D11_RESOURCE_MISC_RESTRICTED_CONTENT")]
        ResourceMiscRestrictedContent = 0x1000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_RESTRICT_SHARED_RESOURCE")]
        ResourceMiscRestrictSharedResource = 0x2000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_RESTRICT_SHARED_RESOURCE_DRIVER")]
        ResourceMiscRestrictSharedResourceDriver = 0x4000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_GUARDED")]
        ResourceMiscGuarded = 0x8000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_TILE_POOL")]
        ResourceMiscTilePool = 0x20000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_TILED")]
        ResourceMiscTiled = 0x40000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_HW_PROTECTED")]
        ResourceMiscHWProtected = 0x80000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_SHARED_DISPLAYABLE")]
        ResourceMiscSharedDisplayable = 0x100000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_SHARED_EXCLUSIVE_WRITER")]
        ResourceMiscSharedExclusiveWriter = 0x200000,
    }
}
