// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DFOGMODE")]
    public enum Fogmode : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3DFOG_NONE")]
        FogNone = 0x0,
        [Obsolete("Deprecated in favour of \"Exp\"")]
        [NativeName("Name", "D3DFOG_EXP")]
        FogExp = 0x1,
        [Obsolete("Deprecated in favour of \"Exp2\"")]
        [NativeName("Name", "D3DFOG_EXP2")]
        FogExp2 = 0x2,
        [Obsolete("Deprecated in favour of \"Linear\"")]
        [NativeName("Name", "D3DFOG_LINEAR")]
        FogLinear = 0x3,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DFOG_FORCE_DWORD")]
        FogForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DFOG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3DFOG_EXP")]
        Exp = 0x1,
        [NativeName("Name", "D3DFOG_EXP2")]
        Exp2 = 0x2,
        [NativeName("Name", "D3DFOG_LINEAR")]
        Linear = 0x3,
        [NativeName("Name", "D3DFOG_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
