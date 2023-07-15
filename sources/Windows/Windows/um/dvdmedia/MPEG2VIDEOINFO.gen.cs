// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MPEG2VIDEOINFO.xml' path='doc/member[@name="MPEG2VIDEOINFO"]/*'/>
public unsafe partial struct MPEG2VIDEOINFO
{
    /// <include file='MPEG2VIDEOINFO.xml' path='doc/member[@name="MPEG2VIDEOINFO.hdr"]/*'/>
    public VIDEOINFOHEADER2 hdr;
    /// <include file='MPEG2VIDEOINFO.xml' path='doc/member[@name="MPEG2VIDEOINFO.dwStartTimeCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStartTimeCode;
    /// <include file='MPEG2VIDEOINFO.xml' path='doc/member[@name="MPEG2VIDEOINFO.cbSequenceHeader"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSequenceHeader;
    /// <include file='MPEG2VIDEOINFO.xml' path='doc/member[@name="MPEG2VIDEOINFO.dwProfile"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwProfile;
    /// <include file='MPEG2VIDEOINFO.xml' path='doc/member[@name="MPEG2VIDEOINFO.dwLevel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLevel;
    /// <include file='MPEG2VIDEOINFO.xml' path='doc/member[@name="MPEG2VIDEOINFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='MPEG2VIDEOINFO.xml' path='doc/member[@name="MPEG2VIDEOINFO.dwSequenceHeader"]/*'/>
    [NativeTypeName("DWORD[1]")]
    public fixed uint dwSequenceHeader[1];
}