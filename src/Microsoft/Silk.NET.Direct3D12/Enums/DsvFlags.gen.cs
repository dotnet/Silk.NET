// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DSV_FLAGS")]
    public enum DsvFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_DSV_FLAG_NONE")]
        DsvFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"ReadOnlyDepth\"")]
        [NativeName("Name", "D3D12_DSV_FLAG_READ_ONLY_DEPTH")]
        DsvFlagReadOnlyDepth = 0x1,
        [Obsolete("Deprecated in favour of \"ReadOnlyStencil\"")]
        [NativeName("Name", "D3D12_DSV_FLAG_READ_ONLY_STENCIL")]
        DsvFlagReadOnlyStencil = 0x2,
        [NativeName("Name", "D3D12_DSV_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_DSV_FLAG_READ_ONLY_DEPTH")]
        ReadOnlyDepth = 0x1,
        [NativeName("Name", "D3D12_DSV_FLAG_READ_ONLY_STENCIL")]
        ReadOnlyStencil = 0x2,
    }
}
