// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_TURBULENCE_NOISE")]
    public enum TurbulenceNoise : int
    {
        [Obsolete("Deprecated in favour of \"FractalSum\"")]
        [NativeName("Name", "D2D1_TURBULENCE_NOISE_FRACTAL_SUM")]
        TurbulenceNoiseFractalSum = 0x0,
        [Obsolete("Deprecated in favour of \"Turbulence\"")]
        [NativeName("Name", "D2D1_TURBULENCE_NOISE_TURBULENCE")]
        TurbulenceNoiseTurbulence = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_TURBULENCE_NOISE_FORCE_DWORD")]
        TurbulenceNoiseForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_TURBULENCE_NOISE_FRACTAL_SUM")]
        FractalSum = 0x0,
        [NativeName("Name", "D2D1_TURBULENCE_NOISE_TURBULENCE")]
        Turbulence = 0x1,
        [NativeName("Name", "D2D1_TURBULENCE_NOISE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
