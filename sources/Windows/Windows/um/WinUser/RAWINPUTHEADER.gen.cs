// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='RAWINPUTHEADER.xml' path='doc/member[@name="RAWINPUTHEADER"]/*'/>
public partial struct RAWINPUTHEADER
{
    /// <include file='RAWINPUTHEADER.xml' path='doc/member[@name="RAWINPUTHEADER.dwType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwType;
    /// <include file='RAWINPUTHEADER.xml' path='doc/member[@name="RAWINPUTHEADER.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='RAWINPUTHEADER.xml' path='doc/member[@name="RAWINPUTHEADER.hDevice"]/*'/>
    public HANDLE hDevice;
    /// <include file='RAWINPUTHEADER.xml' path='doc/member[@name="RAWINPUTHEADER.wParam"]/*'/>
    public WPARAM wParam;
}