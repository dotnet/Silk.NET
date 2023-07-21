// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Gdiplus;

/// <include file='GpWrapMode.xml' path='doc/member[@name="GpWrapMode"]/*' />
public enum GpWrapMode
{
    /// <include file='GpWrapMode.xml' path='doc/member[@name="GpWrapMode.WrapModeTile"]/*' />
    WrapModeTile,

    /// <include file='GpWrapMode.xml' path='doc/member[@name="GpWrapMode.WrapModeTileFlipX"]/*' />
    WrapModeTileFlipX,

    /// <include file='GpWrapMode.xml' path='doc/member[@name="GpWrapMode.WrapModeTileFlipY"]/*' />
    WrapModeTileFlipY,

    /// <include file='GpWrapMode.xml' path='doc/member[@name="GpWrapMode.WrapModeTileFlipXY"]/*' />
    WrapModeTileFlipXY,

    /// <include file='GpWrapMode.xml' path='doc/member[@name="GpWrapMode.WrapModeClamp"]/*' />
    WrapModeClamp,
}
