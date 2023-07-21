// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusinit.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Gdiplus;

/// <include file='GdiplusStartupParams.xml' path='doc/member[@name="GdiplusStartupParams"]/*' />
public enum GdiplusStartupParams
{
    /// <include file='GdiplusStartupParams.xml' path='doc/member[@name="GdiplusStartupParams.GdiplusStartupDefault"]/*' />
    GdiplusStartupDefault = 0,

    /// <include file='GdiplusStartupParams.xml' path='doc/member[@name="GdiplusStartupParams.GdiplusStartupNoSetRound"]/*' />
    GdiplusStartupNoSetRound = 1,

    /// <include file='GdiplusStartupParams.xml' path='doc/member[@name="GdiplusStartupParams.GdiplusStartupSetPSValue"]/*' />
    GdiplusStartupSetPSValue = 2,

    /// <include file='GdiplusStartupParams.xml' path='doc/member[@name="GdiplusStartupParams.GdiplusStartupTransparencyMask"]/*' />
    GdiplusStartupTransparencyMask = unchecked((int)(0xFF000000)),
}
