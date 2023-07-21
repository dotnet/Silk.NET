// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AM_DVD_YUV.xml' path='doc/member[@name="AM_DVD_YUV"]/*' />
public partial struct AM_DVD_YUV
{
    /// <include file='AM_DVD_YUV.xml' path='doc/member[@name="AM_DVD_YUV.Reserved"]/*' />
    [NativeTypeName("UCHAR")]
    public byte Reserved;

    /// <include file='AM_DVD_YUV.xml' path='doc/member[@name="AM_DVD_YUV.Y"]/*' />
    [NativeTypeName("UCHAR")]
    public byte Y;

    /// <include file='AM_DVD_YUV.xml' path='doc/member[@name="AM_DVD_YUV.U"]/*' />
    [NativeTypeName("UCHAR")]
    public byte U;

    /// <include file='AM_DVD_YUV.xml' path='doc/member[@name="AM_DVD_YUV.V"]/*' />
    [NativeTypeName("UCHAR")]
    public byte V;
}
