// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TILE_MAPPING_FLAG")]
    public enum TileMappingFlag : int
    {
        [Obsolete("Deprecated in favour of \"NoOverwrite\"")]
        [NativeName("Name", "D3D11_TILE_MAPPING_NO_OVERWRITE")]
        TileMappingNoOverwrite = 0x1,
        [NativeName("Name", "D3D11_TILE_MAPPING_NO_OVERWRITE")]
        NoOverwrite = 0x1,
    }
}
