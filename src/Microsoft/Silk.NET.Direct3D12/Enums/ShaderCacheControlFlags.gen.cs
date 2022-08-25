// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_SHADER_CACHE_CONTROL_FLAGS")]
    public enum ShaderCacheControlFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Disable\"")]
        [NativeName("Name", "D3D12_SHADER_CACHE_CONTROL_FLAG_DISABLE")]
        ShaderCacheControlFlagDisable = 0x1,
        [Obsolete("Deprecated in favour of \"Enable\"")]
        [NativeName("Name", "D3D12_SHADER_CACHE_CONTROL_FLAG_ENABLE")]
        ShaderCacheControlFlagEnable = 0x2,
        [Obsolete("Deprecated in favour of \"Clear\"")]
        [NativeName("Name", "D3D12_SHADER_CACHE_CONTROL_FLAG_CLEAR")]
        ShaderCacheControlFlagClear = 0x4,
        [NativeName("Name", "D3D12_SHADER_CACHE_CONTROL_FLAG_DISABLE")]
        Disable = 0x1,
        [NativeName("Name", "D3D12_SHADER_CACHE_CONTROL_FLAG_ENABLE")]
        Enable = 0x2,
        [NativeName("Name", "D3D12_SHADER_CACHE_CONTROL_FLAG_CLEAR")]
        Clear = 0x4,
    }
}
