// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DCULL")]
    public enum Cull : int
    {
        [NativeName("Name", "D3DCULL_NONE")]
        CullNone = 0x1,
        [NativeName("Name", "D3DCULL_CW")]
        CullCW = 0x2,
        [NativeName("Name", "D3DCULL_CCW")]
        CullCcw = 0x3,
        [NativeName("Name", "D3DCULL_FORCE_DWORD")]
        CullForceDword = 0x7FFFFFFF,
    }
}
