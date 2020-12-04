// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_RESOURCE_MISC_FLAG")]
    public enum ResourceMiscFlag
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
    }
}
