// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_SHADER_CACHE_FLAGS")]
    public enum ShaderCacheFlags : int
    {
        [NativeName("Name", "D3D12_SHADER_CACHE_FLAG_NONE")]
        ShaderCacheFlagNone = 0x0,
        [NativeName("Name", "D3D12_SHADER_CACHE_FLAG_DRIVER_VERSIONED")]
        ShaderCacheFlagDriverVersioned = 0x1,
        [NativeName("Name", "D3D12_SHADER_CACHE_FLAG_USE_WORKING_DIR")]
        ShaderCacheFlagUseWorkingDir = 0x2,
    }
}
