// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DWRITE_PIXEL_GEOMETRY.xml' path='doc/member[@name="DWRITE_PIXEL_GEOMETRY"]/*' />
public enum DWRITE_PIXEL_GEOMETRY
{
    /// <include file='DWRITE_PIXEL_GEOMETRY.xml' path='doc/member[@name="DWRITE_PIXEL_GEOMETRY.DWRITE_PIXEL_GEOMETRY_FLAT"]/*' />
    DWRITE_PIXEL_GEOMETRY_FLAT,

    /// <include file='DWRITE_PIXEL_GEOMETRY.xml' path='doc/member[@name="DWRITE_PIXEL_GEOMETRY.DWRITE_PIXEL_GEOMETRY_RGB"]/*' />
    DWRITE_PIXEL_GEOMETRY_RGB,

    /// <include file='DWRITE_PIXEL_GEOMETRY.xml' path='doc/member[@name="DWRITE_PIXEL_GEOMETRY.DWRITE_PIXEL_GEOMETRY_BGR"]/*' />
    DWRITE_PIXEL_GEOMETRY_BGR,
}
