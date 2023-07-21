// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_INK_NIB_SHAPE.xml' path='doc/member[@name="D2D1_INK_NIB_SHAPE"]/*' />
public enum D2D1_INK_NIB_SHAPE
{
    /// <include file='D2D1_INK_NIB_SHAPE.xml' path='doc/member[@name="D2D1_INK_NIB_SHAPE.D2D1_INK_NIB_SHAPE_ROUND"]/*' />
    D2D1_INK_NIB_SHAPE_ROUND = 0,

    /// <include file='D2D1_INK_NIB_SHAPE.xml' path='doc/member[@name="D2D1_INK_NIB_SHAPE.D2D1_INK_NIB_SHAPE_SQUARE"]/*' />
    D2D1_INK_NIB_SHAPE_SQUARE = 1,

    /// <include file='D2D1_INK_NIB_SHAPE.xml' path='doc/member[@name="D2D1_INK_NIB_SHAPE.D2D1_INK_NIB_SHAPE_FORCE_DWORD"]/*' />
    D2D1_INK_NIB_SHAPE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
