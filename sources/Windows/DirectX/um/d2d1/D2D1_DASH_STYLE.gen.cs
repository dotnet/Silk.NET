// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_DASH_STYLE.xml' path='doc/member[@name="D2D1_DASH_STYLE"]/*' />
public enum D2D1_DASH_STYLE
{
    /// <include file='D2D1_DASH_STYLE.xml' path='doc/member[@name="D2D1_DASH_STYLE.D2D1_DASH_STYLE_SOLID"]/*' />
    D2D1_DASH_STYLE_SOLID = 0,

    /// <include file='D2D1_DASH_STYLE.xml' path='doc/member[@name="D2D1_DASH_STYLE.D2D1_DASH_STYLE_DASH"]/*' />
    D2D1_DASH_STYLE_DASH = 1,

    /// <include file='D2D1_DASH_STYLE.xml' path='doc/member[@name="D2D1_DASH_STYLE.D2D1_DASH_STYLE_DOT"]/*' />
    D2D1_DASH_STYLE_DOT = 2,

    /// <include file='D2D1_DASH_STYLE.xml' path='doc/member[@name="D2D1_DASH_STYLE.D2D1_DASH_STYLE_DASH_DOT"]/*' />
    D2D1_DASH_STYLE_DASH_DOT = 3,

    /// <include file='D2D1_DASH_STYLE.xml' path='doc/member[@name="D2D1_DASH_STYLE.D2D1_DASH_STYLE_DASH_DOT_DOT"]/*' />
    D2D1_DASH_STYLE_DASH_DOT_DOT = 4,

    /// <include file='D2D1_DASH_STYLE.xml' path='doc/member[@name="D2D1_DASH_STYLE.D2D1_DASH_STYLE_CUSTOM"]/*' />
    D2D1_DASH_STYLE_CUSTOM = 5,

    /// <include file='D2D1_DASH_STYLE.xml' path='doc/member[@name="D2D1_DASH_STYLE.D2D1_DASH_STYLE_FORCE_DWORD"]/*' />
    D2D1_DASH_STYLE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
