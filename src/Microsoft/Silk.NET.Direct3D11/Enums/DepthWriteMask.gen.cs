// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_DEPTH_WRITE_MASK")]
    public enum DepthWriteMask : int
    {
        [Obsolete("Deprecated in favour of \"Zero\"")]
        [NativeName("Name", "D3D11_DEPTH_WRITE_MASK_ZERO")]
        DepthWriteMaskZero = 0x0,
        [Obsolete("Deprecated in favour of \"All\"")]
        [NativeName("Name", "D3D11_DEPTH_WRITE_MASK_ALL")]
        DepthWriteMaskAll = 0x1,
        [NativeName("Name", "D3D11_DEPTH_WRITE_MASK_ZERO")]
        Zero = 0x0,
        [NativeName("Name", "D3D11_DEPTH_WRITE_MASK_ALL")]
        All = 0x1,
    }
}
