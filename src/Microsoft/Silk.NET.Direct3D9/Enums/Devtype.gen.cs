// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DDEVTYPE")]
    public enum Devtype : int
    {
        [NativeName("Name", "D3DDEVTYPE_HAL")]
        DevtypeHal = 0x1,
        [NativeName("Name", "D3DDEVTYPE_REF")]
        DevtypeRef = 0x2,
        [NativeName("Name", "D3DDEVTYPE_SW")]
        DevtypeSW = 0x3,
        [NativeName("Name", "D3DDEVTYPE_NULLREF")]
        DevtypeNullref = 0x4,
        [NativeName("Name", "D3DDEVTYPE_FORCE_DWORD")]
        DevtypeForceDword = 0x7FFFFFFF,
    }
}
