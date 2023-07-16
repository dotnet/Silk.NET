// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.DirectX.D2D1_GAMMA;

namespace Silk.NET.DirectX;
/// <include file='D2D1_GAMMA1.xml' path='doc/member[@name="D2D1_GAMMA1"]/*'/>
public enum D2D1_GAMMA1
{
    /// <include file='D2D1_GAMMA1.xml' path='doc/member[@name="D2D1_GAMMA1.D2D1_GAMMA1_G22"]/*'/>
    D2D1_GAMMA1_G22 = D2D1_GAMMA_2_2,
    /// <include file='D2D1_GAMMA1.xml' path='doc/member[@name="D2D1_GAMMA1.D2D1_GAMMA1_G10"]/*'/>
    D2D1_GAMMA1_G10 = D2D1_GAMMA_1_0,
    /// <include file='D2D1_GAMMA1.xml' path='doc/member[@name="D2D1_GAMMA1.D2D1_GAMMA1_G2084"]/*'/>
    D2D1_GAMMA1_G2084 = 2,
    /// <include file='D2D1_GAMMA1.xml' path='doc/member[@name="D2D1_GAMMA1.D2D1_GAMMA1_FORCE_DWORD"]/*'/>
    D2D1_GAMMA1_FORCE_DWORD = unchecked((int)(0xffffffff)),
}