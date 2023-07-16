// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='RAWINPUTDEVICELIST.xml' path='doc/member[@name="RAWINPUTDEVICELIST"]/*'/>
public partial struct RAWINPUTDEVICELIST
{
    /// <include file='RAWINPUTDEVICELIST.xml' path='doc/member[@name="RAWINPUTDEVICELIST.hDevice"]/*'/>
    public HANDLE hDevice;
    /// <include file='RAWINPUTDEVICELIST.xml' path='doc/member[@name="RAWINPUTDEVICELIST.dwType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwType;
}