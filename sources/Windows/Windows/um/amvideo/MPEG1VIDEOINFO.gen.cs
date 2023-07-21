// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MPEG1VIDEOINFO.xml' path='doc/member[@name="MPEG1VIDEOINFO"]/*' />
public unsafe partial struct MPEG1VIDEOINFO
{
    /// <include file='MPEG1VIDEOINFO.xml' path='doc/member[@name="MPEG1VIDEOINFO.hdr"]/*' />
    public VIDEOINFOHEADER hdr;

    /// <include file='MPEG1VIDEOINFO.xml' path='doc/member[@name="MPEG1VIDEOINFO.dwStartTimeCode"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStartTimeCode;

    /// <include file='MPEG1VIDEOINFO.xml' path='doc/member[@name="MPEG1VIDEOINFO.cbSequenceHeader"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSequenceHeader;

    /// <include file='MPEG1VIDEOINFO.xml' path='doc/member[@name="MPEG1VIDEOINFO.bSequenceHeader"]/*' />
    [NativeTypeName("BYTE[1]")]
    public fixed byte bSequenceHeader[1];
}
