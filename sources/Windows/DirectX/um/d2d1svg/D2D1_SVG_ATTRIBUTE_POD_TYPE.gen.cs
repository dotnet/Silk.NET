// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_SVG_ATTRIBUTE_POD_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_POD_TYPE"]/*' />
public enum D2D1_SVG_ATTRIBUTE_POD_TYPE
{
    /// <include file='D2D1_SVG_ATTRIBUTE_POD_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_POD_TYPE.D2D1_SVG_ATTRIBUTE_POD_TYPE_FLOAT"]/*' />
    D2D1_SVG_ATTRIBUTE_POD_TYPE_FLOAT = 0,

    /// <include file='D2D1_SVG_ATTRIBUTE_POD_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_POD_TYPE.D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR"]/*' />
    D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR = 1,

    /// <include file='D2D1_SVG_ATTRIBUTE_POD_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_POD_TYPE.D2D1_SVG_ATTRIBUTE_POD_TYPE_FILL_MODE"]/*' />
    D2D1_SVG_ATTRIBUTE_POD_TYPE_FILL_MODE = 2,

    /// <include file='D2D1_SVG_ATTRIBUTE_POD_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_POD_TYPE.D2D1_SVG_ATTRIBUTE_POD_TYPE_DISPLAY"]/*' />
    D2D1_SVG_ATTRIBUTE_POD_TYPE_DISPLAY = 3,

    /// <include file='D2D1_SVG_ATTRIBUTE_POD_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_POD_TYPE.D2D1_SVG_ATTRIBUTE_POD_TYPE_OVERFLOW"]/*' />
    D2D1_SVG_ATTRIBUTE_POD_TYPE_OVERFLOW = 4,

    /// <include file='D2D1_SVG_ATTRIBUTE_POD_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_POD_TYPE.D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_CAP"]/*' />
    D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_CAP = 5,

    /// <include file='D2D1_SVG_ATTRIBUTE_POD_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_POD_TYPE.D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_JOIN"]/*' />
    D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_JOIN = 6,

    /// <include file='D2D1_SVG_ATTRIBUTE_POD_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_POD_TYPE.D2D1_SVG_ATTRIBUTE_POD_TYPE_VISIBILITY"]/*' />
    D2D1_SVG_ATTRIBUTE_POD_TYPE_VISIBILITY = 7,

    /// <include file='D2D1_SVG_ATTRIBUTE_POD_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_POD_TYPE.D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX"]/*' />
    D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX = 8,

    /// <include file='D2D1_SVG_ATTRIBUTE_POD_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_POD_TYPE.D2D1_SVG_ATTRIBUTE_POD_TYPE_UNIT_TYPE"]/*' />
    D2D1_SVG_ATTRIBUTE_POD_TYPE_UNIT_TYPE = 9,

    /// <include file='D2D1_SVG_ATTRIBUTE_POD_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_POD_TYPE.D2D1_SVG_ATTRIBUTE_POD_TYPE_EXTEND_MODE"]/*' />
    D2D1_SVG_ATTRIBUTE_POD_TYPE_EXTEND_MODE = 10,

    /// <include file='D2D1_SVG_ATTRIBUTE_POD_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_POD_TYPE.D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO"]/*' />
    D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO = 11,

    /// <include file='D2D1_SVG_ATTRIBUTE_POD_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_POD_TYPE.D2D1_SVG_ATTRIBUTE_POD_TYPE_VIEWBOX"]/*' />
    D2D1_SVG_ATTRIBUTE_POD_TYPE_VIEWBOX = 12,

    /// <include file='D2D1_SVG_ATTRIBUTE_POD_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_POD_TYPE.D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH"]/*' />
    D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH = 13,

    /// <include file='D2D1_SVG_ATTRIBUTE_POD_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_POD_TYPE.D2D1_SVG_ATTRIBUTE_POD_TYPE_FORCE_DWORD"]/*' />
    D2D1_SVG_ATTRIBUTE_POD_TYPE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
