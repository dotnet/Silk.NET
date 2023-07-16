// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FLASHWINFO.xml' path='doc/member[@name="FLASHWINFO"]/*'/>
public partial struct FLASHWINFO
{
    /// <include file='FLASHWINFO.xml' path='doc/member[@name="FLASHWINFO.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='FLASHWINFO.xml' path='doc/member[@name="FLASHWINFO.hwnd"]/*'/>
    public HWND hwnd;
    /// <include file='FLASHWINFO.xml' path='doc/member[@name="FLASHWINFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='FLASHWINFO.xml' path='doc/member[@name="FLASHWINFO.uCount"]/*'/>
    public uint uCount;
    /// <include file='FLASHWINFO.xml' path='doc/member[@name="FLASHWINFO.dwTimeout"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTimeout;
}