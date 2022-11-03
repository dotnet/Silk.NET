// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_SHADER_CACHE_KIND_FLAGS")]
    public enum ShaderCacheKindFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ImplicitD3DCacheForDriver\"")]
        [NativeName("Name", "D3D12_SHADER_CACHE_KIND_FLAG_IMPLICIT_D3D_CACHE_FOR_DRIVER")]
        ShaderCacheKindFlagImplicitD3DCacheForDriver = 0x1,
        [Obsolete("Deprecated in favour of \"ImplicitD3DConversions\"")]
        [NativeName("Name", "D3D12_SHADER_CACHE_KIND_FLAG_IMPLICIT_D3D_CONVERSIONS")]
        ShaderCacheKindFlagImplicitD3DConversions = 0x2,
        [Obsolete("Deprecated in favour of \"ImplicitDriverManaged\"")]
        [NativeName("Name", "D3D12_SHADER_CACHE_KIND_FLAG_IMPLICIT_DRIVER_MANAGED")]
        ShaderCacheKindFlagImplicitDriverManaged = 0x4,
        [Obsolete("Deprecated in favour of \"ApplicationManaged\"")]
        [NativeName("Name", "D3D12_SHADER_CACHE_KIND_FLAG_APPLICATION_MANAGED")]
        ShaderCacheKindFlagApplicationManaged = 0x8,
        [NativeName("Name", "D3D12_SHADER_CACHE_KIND_FLAG_IMPLICIT_D3D_CACHE_FOR_DRIVER")]
        ImplicitD3DCacheForDriver = 0x1,
        [NativeName("Name", "D3D12_SHADER_CACHE_KIND_FLAG_IMPLICIT_D3D_CONVERSIONS")]
        ImplicitD3DConversions = 0x2,
        [NativeName("Name", "D3D12_SHADER_CACHE_KIND_FLAG_IMPLICIT_DRIVER_MANAGED")]
        ImplicitDriverManaged = 0x4,
        [NativeName("Name", "D3D12_SHADER_CACHE_KIND_FLAG_APPLICATION_MANAGED")]
        ApplicationManaged = 0x8,
    }
}
