// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DWRITE_FONT_AXIS_RANGE.xml' path='doc/member[@name="DWRITE_FONT_AXIS_RANGE"]/*' />
public partial struct DWRITE_FONT_AXIS_RANGE
{
    /// <include file='DWRITE_FONT_AXIS_RANGE.xml' path='doc/member[@name="DWRITE_FONT_AXIS_RANGE.axisTag"]/*' />
    public DWRITE_FONT_AXIS_TAG axisTag;

    /// <include file='DWRITE_FONT_AXIS_RANGE.xml' path='doc/member[@name="DWRITE_FONT_AXIS_RANGE.minValue"]/*' />
    public float minValue;

    /// <include file='DWRITE_FONT_AXIS_RANGE.xml' path='doc/member[@name="DWRITE_FONT_AXIS_RANGE.maxValue"]/*' />
    public float maxValue;
}
