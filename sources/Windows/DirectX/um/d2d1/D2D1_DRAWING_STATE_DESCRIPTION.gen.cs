// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_DRAWING_STATE_DESCRIPTION.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION"]/*' />
public partial struct D2D1_DRAWING_STATE_DESCRIPTION
{
    /// <include file='D2D1_DRAWING_STATE_DESCRIPTION.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION.antialiasMode"]/*' />
    public D2D1_ANTIALIAS_MODE antialiasMode;

    /// <include file='D2D1_DRAWING_STATE_DESCRIPTION.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION.textAntialiasMode"]/*' />
    public D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode;

    /// <include file='D2D1_DRAWING_STATE_DESCRIPTION.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION.tag1"]/*' />
    [NativeTypeName("D2D1_TAG")]
    public ulong tag1;

    /// <include file='D2D1_DRAWING_STATE_DESCRIPTION.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION.tag2"]/*' />
    [NativeTypeName("D2D1_TAG")]
    public ulong tag2;

    /// <include file='D2D1_DRAWING_STATE_DESCRIPTION.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION.transform"]/*' />
    [NativeTypeName("D2D1_MATRIX_3X2_F")]
    public D2D_MATRIX_3X2_F transform;
}
