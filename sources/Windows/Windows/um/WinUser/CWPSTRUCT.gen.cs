// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CWPSTRUCT.xml' path='doc/member[@name="CWPSTRUCT"]/*'/>
public partial struct CWPSTRUCT
{
    /// <include file='CWPSTRUCT.xml' path='doc/member[@name="CWPSTRUCT.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='CWPSTRUCT.xml' path='doc/member[@name="CWPSTRUCT.wParam"]/*'/>
    public WPARAM wParam;
    /// <include file='CWPSTRUCT.xml' path='doc/member[@name="CWPSTRUCT.message"]/*'/>
    public uint message;
    /// <include file='CWPSTRUCT.xml' path='doc/member[@name="CWPSTRUCT.hwnd"]/*'/>
    public HWND hwnd;
}