// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_BITMAP_BRUSH_PROPERTIES1.xml' path='doc/member[@name="D2D1_BITMAP_BRUSH_PROPERTIES1"]/*' />
public partial struct D2D1_BITMAP_BRUSH_PROPERTIES1
{
    /// <include file='D2D1_BITMAP_BRUSH_PROPERTIES1.xml' path='doc/member[@name="D2D1_BITMAP_BRUSH_PROPERTIES1.extendModeX"]/*' />
    public D2D1_EXTEND_MODE extendModeX;

    /// <include file='D2D1_BITMAP_BRUSH_PROPERTIES1.xml' path='doc/member[@name="D2D1_BITMAP_BRUSH_PROPERTIES1.extendModeY"]/*' />
    public D2D1_EXTEND_MODE extendModeY;

    /// <include file='D2D1_BITMAP_BRUSH_PROPERTIES1.xml' path='doc/member[@name="D2D1_BITMAP_BRUSH_PROPERTIES1.interpolationMode"]/*' />
    public D2D1_INTERPOLATION_MODE interpolationMode;
}
