// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MOUSEHOOKSTRUCT.xml' path='doc/member[@name="MOUSEHOOKSTRUCT"]/*'/>
public partial struct MOUSEHOOKSTRUCT
{
    /// <include file='MOUSEHOOKSTRUCT.xml' path='doc/member[@name="MOUSEHOOKSTRUCT.pt"]/*'/>
    public POINT pt;
    /// <include file='MOUSEHOOKSTRUCT.xml' path='doc/member[@name="MOUSEHOOKSTRUCT.hwnd"]/*'/>
    public HWND hwnd;
    /// <include file='MOUSEHOOKSTRUCT.xml' path='doc/member[@name="MOUSEHOOKSTRUCT.wHitTestCode"]/*'/>
    public uint wHitTestCode;
    /// <include file='MOUSEHOOKSTRUCT.xml' path='doc/member[@name="MOUSEHOOKSTRUCT.dwExtraInfo"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint dwExtraInfo;
}