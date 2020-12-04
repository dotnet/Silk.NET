// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SHADER_CACHE_SUPPORT_FLAGS")]
    public enum ShaderCacheSupportFlags
    {
        [NativeName("Name", "D3D12_SHADER_CACHE_SUPPORT_NONE")]
        ShaderCacheSupportNone = 0x0,
        [NativeName("Name", "D3D12_SHADER_CACHE_SUPPORT_SINGLE_PSO")]
        ShaderCacheSupportSinglePso = 0x1,
        [NativeName("Name", "D3D12_SHADER_CACHE_SUPPORT_LIBRARY")]
        ShaderCacheSupportLibrary = 0x2,
        [NativeName("Name", "D3D12_SHADER_CACHE_SUPPORT_AUTOMATIC_INPROC_CACHE")]
        ShaderCacheSupportAutomaticInprocCache = 0x4,
        [NativeName("Name", "D3D12_SHADER_CACHE_SUPPORT_AUTOMATIC_DISK_CACHE")]
        ShaderCacheSupportAutomaticDiskCache = 0x8,
    }
}
