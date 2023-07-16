// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SCROLLBARINFO.xml' path='doc/member[@name="SCROLLBARINFO"]/*'/>
public unsafe partial struct SCROLLBARINFO
{
    /// <include file='SCROLLBARINFO.xml' path='doc/member[@name="SCROLLBARINFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='SCROLLBARINFO.xml' path='doc/member[@name="SCROLLBARINFO.rcScrollBar"]/*'/>
    public RECT rcScrollBar;
    /// <include file='SCROLLBARINFO.xml' path='doc/member[@name="SCROLLBARINFO.dxyLineButton"]/*'/>
    public int dxyLineButton;
    /// <include file='SCROLLBARINFO.xml' path='doc/member[@name="SCROLLBARINFO.xyThumbTop"]/*'/>
    public int xyThumbTop;
    /// <include file='SCROLLBARINFO.xml' path='doc/member[@name="SCROLLBARINFO.xyThumbBottom"]/*'/>
    public int xyThumbBottom;
    /// <include file='SCROLLBARINFO.xml' path='doc/member[@name="SCROLLBARINFO.reserved"]/*'/>
    public int reserved;
    /// <include file='SCROLLBARINFO.xml' path='doc/member[@name="SCROLLBARINFO.rgstate"]/*'/>
    [NativeTypeName("DWORD[6]")]
    public fixed uint rgstate[6];
}