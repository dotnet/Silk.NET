// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICPixelFormatNumericRepresentation.xml' path='doc/member[@name="WICPixelFormatNumericRepresentation"]/*' />
public enum WICPixelFormatNumericRepresentation
{
    /// <include file='WICPixelFormatNumericRepresentation.xml' path='doc/member[@name="WICPixelFormatNumericRepresentation.WICPixelFormatNumericRepresentationUnspecified"]/*' />
    WICPixelFormatNumericRepresentationUnspecified = 0,

    /// <include file='WICPixelFormatNumericRepresentation.xml' path='doc/member[@name="WICPixelFormatNumericRepresentation.WICPixelFormatNumericRepresentationIndexed"]/*' />
    WICPixelFormatNumericRepresentationIndexed = 0x1,

    /// <include file='WICPixelFormatNumericRepresentation.xml' path='doc/member[@name="WICPixelFormatNumericRepresentation.WICPixelFormatNumericRepresentationUnsignedInteger"]/*' />
    WICPixelFormatNumericRepresentationUnsignedInteger = 0x2,

    /// <include file='WICPixelFormatNumericRepresentation.xml' path='doc/member[@name="WICPixelFormatNumericRepresentation.WICPixelFormatNumericRepresentationSignedInteger"]/*' />
    WICPixelFormatNumericRepresentationSignedInteger = 0x3,

    /// <include file='WICPixelFormatNumericRepresentation.xml' path='doc/member[@name="WICPixelFormatNumericRepresentation.WICPixelFormatNumericRepresentationFixed"]/*' />
    WICPixelFormatNumericRepresentationFixed = 0x4,

    /// <include file='WICPixelFormatNumericRepresentation.xml' path='doc/member[@name="WICPixelFormatNumericRepresentation.WICPixelFormatNumericRepresentationFloat"]/*' />
    WICPixelFormatNumericRepresentationFloat = 0x5,

    /// <include file='WICPixelFormatNumericRepresentation.xml' path='doc/member[@name="WICPixelFormatNumericRepresentation.WICPixelFormatNumericRepresentation_FORCE_DWORD"]/*' />
    WICPixelFormatNumericRepresentation_FORCE_DWORD = 0x7fffffff,
}
