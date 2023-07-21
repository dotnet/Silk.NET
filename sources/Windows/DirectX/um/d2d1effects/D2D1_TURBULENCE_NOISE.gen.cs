// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_TURBULENCE_NOISE.xml' path='doc/member[@name="D2D1_TURBULENCE_NOISE"]/*' />
public enum D2D1_TURBULENCE_NOISE
{
    /// <include file='D2D1_TURBULENCE_NOISE.xml' path='doc/member[@name="D2D1_TURBULENCE_NOISE.D2D1_TURBULENCE_NOISE_FRACTAL_SUM"]/*' />
    D2D1_TURBULENCE_NOISE_FRACTAL_SUM = 0,

    /// <include file='D2D1_TURBULENCE_NOISE.xml' path='doc/member[@name="D2D1_TURBULENCE_NOISE.D2D1_TURBULENCE_NOISE_TURBULENCE"]/*' />
    D2D1_TURBULENCE_NOISE_TURBULENCE = 1,

    /// <include file='D2D1_TURBULENCE_NOISE.xml' path='doc/member[@name="D2D1_TURBULENCE_NOISE.D2D1_TURBULENCE_NOISE_FORCE_DWORD"]/*' />
    D2D1_TURBULENCE_NOISE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
