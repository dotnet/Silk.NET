// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_SVG_VISIBILITY.xml' path='doc/member[@name="D2D1_SVG_VISIBILITY"]/*' />
public enum D2D1_SVG_VISIBILITY
{
    /// <include file='D2D1_SVG_VISIBILITY.xml' path='doc/member[@name="D2D1_SVG_VISIBILITY.D2D1_SVG_VISIBILITY_VISIBLE"]/*' />
    D2D1_SVG_VISIBILITY_VISIBLE = 0,

    /// <include file='D2D1_SVG_VISIBILITY.xml' path='doc/member[@name="D2D1_SVG_VISIBILITY.D2D1_SVG_VISIBILITY_HIDDEN"]/*' />
    D2D1_SVG_VISIBILITY_HIDDEN = 1,

    /// <include file='D2D1_SVG_VISIBILITY.xml' path='doc/member[@name="D2D1_SVG_VISIBILITY.D2D1_SVG_VISIBILITY_FORCE_DWORD"]/*' />
    D2D1_SVG_VISIBILITY_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
