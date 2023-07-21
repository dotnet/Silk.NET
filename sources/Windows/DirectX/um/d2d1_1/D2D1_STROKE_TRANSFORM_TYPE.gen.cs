// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_STROKE_TRANSFORM_TYPE.xml' path='doc/member[@name="D2D1_STROKE_TRANSFORM_TYPE"]/*' />
public enum D2D1_STROKE_TRANSFORM_TYPE
{
    /// <include file='D2D1_STROKE_TRANSFORM_TYPE.xml' path='doc/member[@name="D2D1_STROKE_TRANSFORM_TYPE.D2D1_STROKE_TRANSFORM_TYPE_NORMAL"]/*' />
    D2D1_STROKE_TRANSFORM_TYPE_NORMAL = 0,

    /// <include file='D2D1_STROKE_TRANSFORM_TYPE.xml' path='doc/member[@name="D2D1_STROKE_TRANSFORM_TYPE.D2D1_STROKE_TRANSFORM_TYPE_FIXED"]/*' />
    D2D1_STROKE_TRANSFORM_TYPE_FIXED = 1,

    /// <include file='D2D1_STROKE_TRANSFORM_TYPE.xml' path='doc/member[@name="D2D1_STROKE_TRANSFORM_TYPE.D2D1_STROKE_TRANSFORM_TYPE_HAIRLINE"]/*' />
    D2D1_STROKE_TRANSFORM_TYPE_HAIRLINE = 2,

    /// <include file='D2D1_STROKE_TRANSFORM_TYPE.xml' path='doc/member[@name="D2D1_STROKE_TRANSFORM_TYPE.D2D1_STROKE_TRANSFORM_TYPE_FORCE_DWORD"]/*' />
    D2D1_STROKE_TRANSFORM_TYPE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
