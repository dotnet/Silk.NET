// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MSLLHOOKSTRUCT.xml' path='doc/member[@name="MSLLHOOKSTRUCT"]/*'/>
public partial struct MSLLHOOKSTRUCT
{
    /// <include file='MSLLHOOKSTRUCT.xml' path='doc/member[@name="MSLLHOOKSTRUCT.pt"]/*'/>
    public POINT pt;
    /// <include file='MSLLHOOKSTRUCT.xml' path='doc/member[@name="MSLLHOOKSTRUCT.mouseData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint mouseData;
    /// <include file='MSLLHOOKSTRUCT.xml' path='doc/member[@name="MSLLHOOKSTRUCT.flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint flags;
    /// <include file='MSLLHOOKSTRUCT.xml' path='doc/member[@name="MSLLHOOKSTRUCT.time"]/*'/>
    [NativeTypeName("DWORD")]
    public uint time;
    /// <include file='MSLLHOOKSTRUCT.xml' path='doc/member[@name="MSLLHOOKSTRUCT.dwExtraInfo"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint dwExtraInfo;
}