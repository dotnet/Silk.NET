// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_TURBULENCE_NOISE")]
    public enum TurbulenceNoise : int
    {
        [NativeName("Name", "D2D1_TURBULENCE_NOISE_FRACTAL_SUM")]
        FractalSum = 0x0,
        [NativeName("Name", "D2D1_TURBULENCE_NOISE_TURBULENCE")]
        Turbulence = 0x1,
        [NativeName("Name", "D2D1_TURBULENCE_NOISE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
