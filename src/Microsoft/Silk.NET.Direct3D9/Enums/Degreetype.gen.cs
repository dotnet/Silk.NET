// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DDEGREETYPE")]
    public enum Degreetype : int
    {
        [NativeName("Name", "D3DDEGREE_LINEAR")]
        DegreeLinear = 0x1,
        [NativeName("Name", "D3DDEGREE_QUADRATIC")]
        DegreeQuadratic = 0x2,
        [NativeName("Name", "D3DDEGREE_CUBIC")]
        DegreeCubic = 0x3,
        [NativeName("Name", "D3DDEGREE_QUINTIC")]
        DegreeQuintic = 0x5,
        [NativeName("Name", "D3DDEGREE_FORCE_DWORD")]
        DegreeForceDword = 0x7FFFFFFF,
    }
}
