// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='DWRITE_INLINE_OBJECT_METRICS.xml' path='doc/member[@name="DWRITE_INLINE_OBJECT_METRICS"]/*' />
public partial struct DWRITE_INLINE_OBJECT_METRICS
{
    /// <include file='DWRITE_INLINE_OBJECT_METRICS.xml' path='doc/member[@name="DWRITE_INLINE_OBJECT_METRICS.width"]/*' />
    public float width;

    /// <include file='DWRITE_INLINE_OBJECT_METRICS.xml' path='doc/member[@name="DWRITE_INLINE_OBJECT_METRICS.height"]/*' />
    public float height;

    /// <include file='DWRITE_INLINE_OBJECT_METRICS.xml' path='doc/member[@name="DWRITE_INLINE_OBJECT_METRICS.baseline"]/*' />
    public float baseline;

    /// <include file='DWRITE_INLINE_OBJECT_METRICS.xml' path='doc/member[@name="DWRITE_INLINE_OBJECT_METRICS.supportsSideways"]/*' />
    public BOOL supportsSideways;
}
