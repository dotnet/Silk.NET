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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"GenerateMips\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_GENERATE_MIPS")]
        ResourceMiscGenerateMips = 0x1,
        [Obsolete("Deprecated in favour of \"Shared\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_SHARED")]
        ResourceMiscShared = 0x2,
        [Obsolete("Deprecated in favour of \"Texturecube\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_TEXTURECUBE")]
        ResourceMiscTexturecube = 0x4,
        [Obsolete("Deprecated in favour of \"DrawindirectArgs\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_DRAWINDIRECT_ARGS")]
        ResourceMiscDrawindirectArgs = 0x10,
        [Obsolete("Deprecated in favour of \"BufferAllowRawViews\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_BUFFER_ALLOW_RAW_VIEWS")]
        ResourceMiscBufferAllowRawViews = 0x20,
        [Obsolete("Deprecated in favour of \"BufferStructured\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_BUFFER_STRUCTURED")]
        ResourceMiscBufferStructured = 0x40,
        [Obsolete("Deprecated in favour of \"ResourceClamp\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_RESOURCE_CLAMP")]
        ResourceMiscResourceClamp = 0x80,
        [Obsolete("Deprecated in favour of \"SharedKeyedmutex\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_SHARED_KEYEDMUTEX")]
        ResourceMiscSharedKeyedmutex = 0x100,
        [Obsolete("Deprecated in favour of \"GdiCompatible\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_GDI_COMPATIBLE")]
        ResourceMiscGdiCompatible = 0x200,
        [Obsolete("Deprecated in favour of \"SharedNthandle\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_SHARED_NTHANDLE")]
        ResourceMiscSharedNthandle = 0x800,
        [Obsolete("Deprecated in favour of \"RestrictedContent\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_RESTRICTED_CONTENT")]
        ResourceMiscRestrictedContent = 0x1000,
        [Obsolete("Deprecated in favour of \"RestrictSharedResource\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_RESTRICT_SHARED_RESOURCE")]
        ResourceMiscRestrictSharedResource = 0x2000,
        [Obsolete("Deprecated in favour of \"RestrictSharedResourceDriver\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_RESTRICT_SHARED_RESOURCE_DRIVER")]
        ResourceMiscRestrictSharedResourceDriver = 0x4000,
        [Obsolete("Deprecated in favour of \"Guarded\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_GUARDED")]
        ResourceMiscGuarded = 0x8000,
        [Obsolete("Deprecated in favour of \"TilePool\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_TILE_POOL")]
        ResourceMiscTilePool = 0x20000,
        [Obsolete("Deprecated in favour of \"Tiled\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_TILED")]
        ResourceMiscTiled = 0x40000,
        [Obsolete("Deprecated in favour of \"HWProtected\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_HW_PROTECTED")]
        ResourceMiscHWProtected = 0x80000,
        [Obsolete("Deprecated in favour of \"SharedDisplayable\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_SHARED_DISPLAYABLE")]
        ResourceMiscSharedDisplayable = 0x100000,
        [Obsolete("Deprecated in favour of \"SharedExclusiveWriter\"")]
        [NativeName("Name", "D3D11_RESOURCE_MISC_SHARED_EXCLUSIVE_WRITER")]
        ResourceMiscSharedExclusiveWriter = 0x200000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_GENERATE_MIPS")]
        GenerateMips = 0x1,
        [NativeName("Name", "D3D11_RESOURCE_MISC_SHARED")]
        Shared = 0x2,
        [NativeName("Name", "D3D11_RESOURCE_MISC_TEXTURECUBE")]
        Texturecube = 0x4,
        [NativeName("Name", "D3D11_RESOURCE_MISC_DRAWINDIRECT_ARGS")]
        DrawindirectArgs = 0x10,
        [NativeName("Name", "D3D11_RESOURCE_MISC_BUFFER_ALLOW_RAW_VIEWS")]
        BufferAllowRawViews = 0x20,
        [NativeName("Name", "D3D11_RESOURCE_MISC_BUFFER_STRUCTURED")]
        BufferStructured = 0x40,
        [NativeName("Name", "D3D11_RESOURCE_MISC_RESOURCE_CLAMP")]
        ResourceClamp = 0x80,
        [NativeName("Name", "D3D11_RESOURCE_MISC_SHARED_KEYEDMUTEX")]
        SharedKeyedmutex = 0x100,
        [NativeName("Name", "D3D11_RESOURCE_MISC_GDI_COMPATIBLE")]
        GdiCompatible = 0x200,
        [NativeName("Name", "D3D11_RESOURCE_MISC_SHARED_NTHANDLE")]
        SharedNthandle = 0x800,
        [NativeName("Name", "D3D11_RESOURCE_MISC_RESTRICTED_CONTENT")]
        RestrictedContent = 0x1000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_RESTRICT_SHARED_RESOURCE")]
        RestrictSharedResource = 0x2000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_RESTRICT_SHARED_RESOURCE_DRIVER")]
        RestrictSharedResourceDriver = 0x4000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_GUARDED")]
        Guarded = 0x8000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_TILE_POOL")]
        TilePool = 0x20000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_TILED")]
        Tiled = 0x40000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_HW_PROTECTED")]
        HWProtected = 0x80000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_SHARED_DISPLAYABLE")]
        SharedDisplayable = 0x100000,
        [NativeName("Name", "D3D11_RESOURCE_MISC_SHARED_EXCLUSIVE_WRITER")]
        SharedExclusiveWriter = 0x200000,
    }
}
