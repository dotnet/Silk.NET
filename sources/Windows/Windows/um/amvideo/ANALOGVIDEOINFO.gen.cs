// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ANALOGVIDEOINFO.xml' path='doc/member[@name="ANALOGVIDEOINFO"]/*'/>
public partial struct ANALOGVIDEOINFO
{
    /// <include file='ANALOGVIDEOINFO.xml' path='doc/member[@name="ANALOGVIDEOINFO.rcSource"]/*'/>
    public RECT rcSource;
    /// <include file='ANALOGVIDEOINFO.xml' path='doc/member[@name="ANALOGVIDEOINFO.rcTarget"]/*'/>
    public RECT rcTarget;
    /// <include file='ANALOGVIDEOINFO.xml' path='doc/member[@name="ANALOGVIDEOINFO.dwActiveWidth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwActiveWidth;
    /// <include file='ANALOGVIDEOINFO.xml' path='doc/member[@name="ANALOGVIDEOINFO.dwActiveHeight"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwActiveHeight;
    /// <include file='ANALOGVIDEOINFO.xml' path='doc/member[@name="ANALOGVIDEOINFO.AvgTimePerFrame"]/*'/>
    [NativeTypeName("REFERENCE_TIME")]
    public long AvgTimePerFrame;
}