// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MOUSEINPUT.xml' path='doc/member[@name="MOUSEINPUT"]/*'/>
public partial struct MOUSEINPUT
{
    /// <include file='MOUSEINPUT.xml' path='doc/member[@name="MOUSEINPUT.dx"]/*'/>
    [NativeTypeName("LONG")]
    public int dx;
    /// <include file='MOUSEINPUT.xml' path='doc/member[@name="MOUSEINPUT.dy"]/*'/>
    [NativeTypeName("LONG")]
    public int dy;
    /// <include file='MOUSEINPUT.xml' path='doc/member[@name="MOUSEINPUT.mouseData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint mouseData;
    /// <include file='MOUSEINPUT.xml' path='doc/member[@name="MOUSEINPUT.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='MOUSEINPUT.xml' path='doc/member[@name="MOUSEINPUT.time"]/*'/>
    [NativeTypeName("DWORD")]
    public uint time;
    /// <include file='MOUSEINPUT.xml' path='doc/member[@name="MOUSEINPUT.dwExtraInfo"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint dwExtraInfo;
}