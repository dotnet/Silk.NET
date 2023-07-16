// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TITLEBARINFO.xml' path='doc/member[@name="TITLEBARINFO"]/*'/>
public unsafe partial struct TITLEBARINFO
{
    /// <include file='TITLEBARINFO.xml' path='doc/member[@name="TITLEBARINFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='TITLEBARINFO.xml' path='doc/member[@name="TITLEBARINFO.rcTitleBar"]/*'/>
    public RECT rcTitleBar;
    /// <include file='TITLEBARINFO.xml' path='doc/member[@name="TITLEBARINFO.rgstate"]/*'/>
    [NativeTypeName("DWORD[6]")]
    public fixed uint rgstate[6];
}