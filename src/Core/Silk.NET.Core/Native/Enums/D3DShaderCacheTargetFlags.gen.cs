// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_SHADER_CACHE_TARGET_FLAGS")]
    public enum D3DShaderCacheTargetFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D_SHADER_CACHE_TARGET_FLAG_NONE")]
        D3DShaderCacheTargetFlagNone = 0x0,
        [NativeName("Name", "D3D_SHADER_CACHE_TARGET_FLAG_NONE")]
        None = 0x0,
    }
}
