// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_SHADER_CACHE_SUPPORT_FLAGS")]
    public enum ShaderCacheSupportFlags : int
    {
        [NativeName("Name", "D3D11_SHADER_CACHE_SUPPORT_NONE")]
        ShaderCacheSupportNone = 0x0,
        [NativeName("Name", "D3D11_SHADER_CACHE_SUPPORT_AUTOMATIC_INPROC_CACHE")]
        ShaderCacheSupportAutomaticInprocCache = 0x1,
        [NativeName("Name", "D3D11_SHADER_CACHE_SUPPORT_AUTOMATIC_DISK_CACHE")]
        ShaderCacheSupportAutomaticDiskCache = 0x2,
    }
}
