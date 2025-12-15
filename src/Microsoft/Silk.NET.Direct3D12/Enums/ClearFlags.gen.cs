// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_CLEAR_FLAGS")]
    public enum ClearFlags : int
    {
        [Obsolete("Deprecated in favour of \"Depth\"")]
        [NativeName("Name", "D3D12_CLEAR_FLAG_DEPTH")]
        ClearFlagDepth = 0x1,
        [Obsolete("Deprecated in favour of \"Stencil\"")]
        [NativeName("Name", "D3D12_CLEAR_FLAG_STENCIL")]
        ClearFlagStencil = 0x2,
        [NativeName("Name", "D3D12_CLEAR_FLAG_DEPTH")]
        Depth = 0x1,
        [NativeName("Name", "D3D12_CLEAR_FLAG_STENCIL")]
        Stencil = 0x2,
    }
}
