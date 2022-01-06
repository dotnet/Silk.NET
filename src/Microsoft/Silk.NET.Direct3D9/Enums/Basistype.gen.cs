// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DBASISTYPE")]
    public enum Basistype : int
    {
        [NativeName("Name", "D3DBASIS_BEZIER")]
        BasisBezier = 0x0,
        [NativeName("Name", "D3DBASIS_BSPLINE")]
        BasisBspline = 0x1,
        [NativeName("Name", "D3DBASIS_CATMULL_ROM")]
        BasisCatmullRom = 0x2,
        [NativeName("Name", "D3DBASIS_FORCE_DWORD")]
        BasisForceDword = 0x7FFFFFFF,
    }
}
