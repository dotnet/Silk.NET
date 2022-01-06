// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_CLEAR_FLAGS")]
    public enum ClearFlags : int
    {
        [NativeName("Name", "D3D12_CLEAR_FLAG_DEPTH")]
        ClearFlagDepth = 0x1,
        [NativeName("Name", "D3D12_CLEAR_FLAG_STENCIL")]
        ClearFlagStencil = 0x2,
    }
}
