// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_SVG_OVERFLOW.xml' path='doc/member[@name="D2D1_SVG_OVERFLOW"]/*' />
public enum D2D1_SVG_OVERFLOW
{
    /// <include file='D2D1_SVG_OVERFLOW.xml' path='doc/member[@name="D2D1_SVG_OVERFLOW.D2D1_SVG_OVERFLOW_VISIBLE"]/*' />
    D2D1_SVG_OVERFLOW_VISIBLE = 0,

    /// <include file='D2D1_SVG_OVERFLOW.xml' path='doc/member[@name="D2D1_SVG_OVERFLOW.D2D1_SVG_OVERFLOW_HIDDEN"]/*' />
    D2D1_SVG_OVERFLOW_HIDDEN = 1,

    /// <include file='D2D1_SVG_OVERFLOW.xml' path='doc/member[@name="D2D1_SVG_OVERFLOW.D2D1_SVG_OVERFLOW_FORCE_DWORD"]/*' />
    D2D1_SVG_OVERFLOW_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
