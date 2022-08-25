// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_MAP_FLAG")]
    public enum MapFlag : int
    {
        [Obsolete("Deprecated in favour of \"DONotWait\"")]
        [NativeName("Name", "D3D11_MAP_FLAG_DO_NOT_WAIT")]
        MapFlagDONotWait = 0x100000,
        [NativeName("Name", "D3D11_MAP_FLAG_DO_NOT_WAIT")]
        DONotWait = 0x100000,
    }
}
