// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_COMPOSITE_MODE.xml' path='doc/member[@name="D2D1_COMPOSITE_MODE"]/*' />
public enum D2D1_COMPOSITE_MODE
{
    /// <include file='D2D1_COMPOSITE_MODE.xml' path='doc/member[@name="D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_SOURCE_OVER"]/*' />
    D2D1_COMPOSITE_MODE_SOURCE_OVER = 0,

    /// <include file='D2D1_COMPOSITE_MODE.xml' path='doc/member[@name="D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_DESTINATION_OVER"]/*' />
    D2D1_COMPOSITE_MODE_DESTINATION_OVER = 1,

    /// <include file='D2D1_COMPOSITE_MODE.xml' path='doc/member[@name="D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_SOURCE_IN"]/*' />
    D2D1_COMPOSITE_MODE_SOURCE_IN = 2,

    /// <include file='D2D1_COMPOSITE_MODE.xml' path='doc/member[@name="D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_DESTINATION_IN"]/*' />
    D2D1_COMPOSITE_MODE_DESTINATION_IN = 3,

    /// <include file='D2D1_COMPOSITE_MODE.xml' path='doc/member[@name="D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_SOURCE_OUT"]/*' />
    D2D1_COMPOSITE_MODE_SOURCE_OUT = 4,

    /// <include file='D2D1_COMPOSITE_MODE.xml' path='doc/member[@name="D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_DESTINATION_OUT"]/*' />
    D2D1_COMPOSITE_MODE_DESTINATION_OUT = 5,

    /// <include file='D2D1_COMPOSITE_MODE.xml' path='doc/member[@name="D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_SOURCE_ATOP"]/*' />
    D2D1_COMPOSITE_MODE_SOURCE_ATOP = 6,

    /// <include file='D2D1_COMPOSITE_MODE.xml' path='doc/member[@name="D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_DESTINATION_ATOP"]/*' />
    D2D1_COMPOSITE_MODE_DESTINATION_ATOP = 7,

    /// <include file='D2D1_COMPOSITE_MODE.xml' path='doc/member[@name="D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_XOR"]/*' />
    D2D1_COMPOSITE_MODE_XOR = 8,

    /// <include file='D2D1_COMPOSITE_MODE.xml' path='doc/member[@name="D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_PLUS"]/*' />
    D2D1_COMPOSITE_MODE_PLUS = 9,

    /// <include file='D2D1_COMPOSITE_MODE.xml' path='doc/member[@name="D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_SOURCE_COPY"]/*' />
    D2D1_COMPOSITE_MODE_SOURCE_COPY = 10,

    /// <include file='D2D1_COMPOSITE_MODE.xml' path='doc/member[@name="D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_BOUNDED_SOURCE_COPY"]/*' />
    D2D1_COMPOSITE_MODE_BOUNDED_SOURCE_COPY = 11,

    /// <include file='D2D1_COMPOSITE_MODE.xml' path='doc/member[@name="D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_MASK_INVERT"]/*' />
    D2D1_COMPOSITE_MODE_MASK_INVERT = 12,

    /// <include file='D2D1_COMPOSITE_MODE.xml' path='doc/member[@name="D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_FORCE_DWORD"]/*' />
    D2D1_COMPOSITE_MODE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
