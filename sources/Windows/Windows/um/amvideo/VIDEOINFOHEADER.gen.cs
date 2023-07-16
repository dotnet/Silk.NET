// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='VIDEOINFOHEADER.xml' path='doc/member[@name="VIDEOINFOHEADER"]/*'/>
public partial struct VIDEOINFOHEADER
{
    /// <include file='VIDEOINFOHEADER.xml' path='doc/member[@name="VIDEOINFOHEADER.rcSource"]/*'/>
    public RECT rcSource;
    /// <include file='VIDEOINFOHEADER.xml' path='doc/member[@name="VIDEOINFOHEADER.rcTarget"]/*'/>
    public RECT rcTarget;
    /// <include file='VIDEOINFOHEADER.xml' path='doc/member[@name="VIDEOINFOHEADER.dwBitRate"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBitRate;
    /// <include file='VIDEOINFOHEADER.xml' path='doc/member[@name="VIDEOINFOHEADER.dwBitErrorRate"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBitErrorRate;
    /// <include file='VIDEOINFOHEADER.xml' path='doc/member[@name="VIDEOINFOHEADER.AvgTimePerFrame"]/*'/>
    [NativeTypeName("REFERENCE_TIME")]
    public long AvgTimePerFrame;
    /// <include file='VIDEOINFOHEADER.xml' path='doc/member[@name="VIDEOINFOHEADER.bmiHeader"]/*'/>
    public BITMAPINFOHEADER bmiHeader;
}