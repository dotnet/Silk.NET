// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_BLEND.xml' path='doc/member[@name="D2D1_BLEND"]/*' />
public enum D2D1_BLEND
{
    /// <include file='D2D1_BLEND.xml' path='doc/member[@name="D2D1_BLEND.D2D1_BLEND_ZERO"]/*' />
    D2D1_BLEND_ZERO = 1,

    /// <include file='D2D1_BLEND.xml' path='doc/member[@name="D2D1_BLEND.D2D1_BLEND_ONE"]/*' />
    D2D1_BLEND_ONE = 2,

    /// <include file='D2D1_BLEND.xml' path='doc/member[@name="D2D1_BLEND.D2D1_BLEND_SRC_COLOR"]/*' />
    D2D1_BLEND_SRC_COLOR = 3,

    /// <include file='D2D1_BLEND.xml' path='doc/member[@name="D2D1_BLEND.D2D1_BLEND_INV_SRC_COLOR"]/*' />
    D2D1_BLEND_INV_SRC_COLOR = 4,

    /// <include file='D2D1_BLEND.xml' path='doc/member[@name="D2D1_BLEND.D2D1_BLEND_SRC_ALPHA"]/*' />
    D2D1_BLEND_SRC_ALPHA = 5,

    /// <include file='D2D1_BLEND.xml' path='doc/member[@name="D2D1_BLEND.D2D1_BLEND_INV_SRC_ALPHA"]/*' />
    D2D1_BLEND_INV_SRC_ALPHA = 6,

    /// <include file='D2D1_BLEND.xml' path='doc/member[@name="D2D1_BLEND.D2D1_BLEND_DEST_ALPHA"]/*' />
    D2D1_BLEND_DEST_ALPHA = 7,

    /// <include file='D2D1_BLEND.xml' path='doc/member[@name="D2D1_BLEND.D2D1_BLEND_INV_DEST_ALPHA"]/*' />
    D2D1_BLEND_INV_DEST_ALPHA = 8,

    /// <include file='D2D1_BLEND.xml' path='doc/member[@name="D2D1_BLEND.D2D1_BLEND_DEST_COLOR"]/*' />
    D2D1_BLEND_DEST_COLOR = 9,

    /// <include file='D2D1_BLEND.xml' path='doc/member[@name="D2D1_BLEND.D2D1_BLEND_INV_DEST_COLOR"]/*' />
    D2D1_BLEND_INV_DEST_COLOR = 10,

    /// <include file='D2D1_BLEND.xml' path='doc/member[@name="D2D1_BLEND.D2D1_BLEND_SRC_ALPHA_SAT"]/*' />
    D2D1_BLEND_SRC_ALPHA_SAT = 11,

    /// <include file='D2D1_BLEND.xml' path='doc/member[@name="D2D1_BLEND.D2D1_BLEND_BLEND_FACTOR"]/*' />
    D2D1_BLEND_BLEND_FACTOR = 14,

    /// <include file='D2D1_BLEND.xml' path='doc/member[@name="D2D1_BLEND.D2D1_BLEND_INV_BLEND_FACTOR"]/*' />
    D2D1_BLEND_INV_BLEND_FACTOR = 15,

    /// <include file='D2D1_BLEND.xml' path='doc/member[@name="D2D1_BLEND.D2D1_BLEND_FORCE_DWORD"]/*' />
    D2D1_BLEND_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
