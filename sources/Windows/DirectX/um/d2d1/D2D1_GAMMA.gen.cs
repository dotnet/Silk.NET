// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_GAMMA.xml' path='doc/member[@name="D2D1_GAMMA"]/*' />
public enum D2D1_GAMMA
{
    /// <include file='D2D1_GAMMA.xml' path='doc/member[@name="D2D1_GAMMA.D2D1_GAMMA_2_2"]/*' />
    D2D1_GAMMA_2_2 = 0,

    /// <include file='D2D1_GAMMA.xml' path='doc/member[@name="D2D1_GAMMA.D2D1_GAMMA_1_0"]/*' />
    D2D1_GAMMA_1_0 = 1,

    /// <include file='D2D1_GAMMA.xml' path='doc/member[@name="D2D1_GAMMA.D2D1_GAMMA_FORCE_DWORD"]/*' />
    D2D1_GAMMA_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
