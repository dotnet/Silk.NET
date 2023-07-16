// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HARDWAREHOOKSTRUCT.xml' path='doc/member[@name="HARDWAREHOOKSTRUCT"]/*'/>
public partial struct HARDWAREHOOKSTRUCT
{
    /// <include file='HARDWAREHOOKSTRUCT.xml' path='doc/member[@name="HARDWAREHOOKSTRUCT.hwnd"]/*'/>
    public HWND hwnd;
    /// <include file='HARDWAREHOOKSTRUCT.xml' path='doc/member[@name="HARDWAREHOOKSTRUCT.message"]/*'/>
    public uint message;
    /// <include file='HARDWAREHOOKSTRUCT.xml' path='doc/member[@name="HARDWAREHOOKSTRUCT.wParam"]/*'/>
    public WPARAM wParam;
    /// <include file='HARDWAREHOOKSTRUCT.xml' path='doc/member[@name="HARDWAREHOOKSTRUCT.lParam"]/*'/>
    public LPARAM lParam;
}