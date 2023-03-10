// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_GAMMA")]
    public enum Gamma : int
    {
        [NativeName("Name", "D2D1_GAMMA_2_2")]
        Gamma22 = 0x0,
        [NativeName("Name", "D2D1_GAMMA_1_0")]
        Gamma10 = 0x1,
        [NativeName("Name", "D2D1_GAMMA_FORCE_DWORD")]
        GammaForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
