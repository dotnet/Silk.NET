// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT"]/*'/>
public partial struct TOUCHINPUT
{
    /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.x"]/*'/>
    [NativeTypeName("LONG")]
    public int x;
    /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.y"]/*'/>
    [NativeTypeName("LONG")]
    public int y;
    /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.hSource"]/*'/>
    public HANDLE hSource;
    /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.dwID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwID;
    /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.dwMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMask;
    /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.dwTime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTime;
    /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.dwExtraInfo"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint dwExtraInfo;
    /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.cxContact"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cxContact;
    /// <include file='TOUCHINPUT.xml' path='doc/member[@name="TOUCHINPUT.cyContact"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cyContact;
}