// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_FILL_MODE")]
    public enum FillMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Wireframe\"")]
        [NativeName("Name", "D3D12_FILL_MODE_WIREFRAME")]
        FillModeWireframe = 0x2,
        [Obsolete("Deprecated in favour of \"Solid\"")]
        [NativeName("Name", "D3D12_FILL_MODE_SOLID")]
        FillModeSolid = 0x3,
        [NativeName("Name", "D3D12_FILL_MODE_WIREFRAME")]
        Wireframe = 0x2,
        [NativeName("Name", "D3D12_FILL_MODE_SOLID")]
        Solid = 0x3,
    }
}
