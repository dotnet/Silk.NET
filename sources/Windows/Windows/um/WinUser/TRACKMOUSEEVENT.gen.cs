// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TRACKMOUSEEVENT.xml' path='doc/member[@name="TRACKMOUSEEVENT"]/*'/>
public partial struct TRACKMOUSEEVENT
{
    /// <include file='TRACKMOUSEEVENT.xml' path='doc/member[@name="TRACKMOUSEEVENT.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='TRACKMOUSEEVENT.xml' path='doc/member[@name="TRACKMOUSEEVENT.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='TRACKMOUSEEVENT.xml' path='doc/member[@name="TRACKMOUSEEVENT.hwndTrack"]/*'/>
    public HWND hwndTrack;
    /// <include file='TRACKMOUSEEVENT.xml' path='doc/member[@name="TRACKMOUSEEVENT.dwHoverTime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwHoverTime;
}