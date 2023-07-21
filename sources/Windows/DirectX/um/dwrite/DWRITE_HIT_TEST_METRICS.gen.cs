// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='DWRITE_HIT_TEST_METRICS.xml' path='doc/member[@name="DWRITE_HIT_TEST_METRICS"]/*' />
public partial struct DWRITE_HIT_TEST_METRICS
{
    /// <include file='DWRITE_HIT_TEST_METRICS.xml' path='doc/member[@name="DWRITE_HIT_TEST_METRICS.textPosition"]/*' />
    [NativeTypeName("UINT32")]
    public uint textPosition;

    /// <include file='DWRITE_HIT_TEST_METRICS.xml' path='doc/member[@name="DWRITE_HIT_TEST_METRICS.length"]/*' />
    [NativeTypeName("UINT32")]
    public uint length;

    /// <include file='DWRITE_HIT_TEST_METRICS.xml' path='doc/member[@name="DWRITE_HIT_TEST_METRICS.left"]/*' />
    public float left;

    /// <include file='DWRITE_HIT_TEST_METRICS.xml' path='doc/member[@name="DWRITE_HIT_TEST_METRICS.top"]/*' />
    public float top;

    /// <include file='DWRITE_HIT_TEST_METRICS.xml' path='doc/member[@name="DWRITE_HIT_TEST_METRICS.width"]/*' />
    public float width;

    /// <include file='DWRITE_HIT_TEST_METRICS.xml' path='doc/member[@name="DWRITE_HIT_TEST_METRICS.height"]/*' />
    public float height;

    /// <include file='DWRITE_HIT_TEST_METRICS.xml' path='doc/member[@name="DWRITE_HIT_TEST_METRICS.bidiLevel"]/*' />
    [NativeTypeName("UINT32")]
    public uint bidiLevel;

    /// <include file='DWRITE_HIT_TEST_METRICS.xml' path='doc/member[@name="DWRITE_HIT_TEST_METRICS.isText"]/*' />
    public BOOL isText;

    /// <include file='DWRITE_HIT_TEST_METRICS.xml' path='doc/member[@name="DWRITE_HIT_TEST_METRICS.isTrimmed"]/*' />
    public BOOL isTrimmed;
}
