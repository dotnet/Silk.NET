// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_CULL_MODE")]
    public enum CullMode : int
    {
        [NativeName("Name", "D3D12_CULL_MODE_NONE")]
        CullModeNone = 0x1,
        [NativeName("Name", "D3D12_CULL_MODE_FRONT")]
        CullModeFront = 0x2,
        [NativeName("Name", "D3D12_CULL_MODE_BACK")]
        CullModeBack = 0x3,
    }
}
