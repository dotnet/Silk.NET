// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_TEXTURE_BARRIER_FLAGS")]
    public enum TextureBarrierFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_TEXTURE_BARRIER_FLAG_NONE")]
        TextureBarrierFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Discard\"")]
        [NativeName("Name", "D3D12_TEXTURE_BARRIER_FLAG_DISCARD")]
        TextureBarrierFlagDiscard = 0x1,
        [NativeName("Name", "D3D12_TEXTURE_BARRIER_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_TEXTURE_BARRIER_FLAG_DISCARD")]
        Discard = 0x1,
    }
}
