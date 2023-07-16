// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CWPRETSTRUCT.xml' path='doc/member[@name="CWPRETSTRUCT"]/*'/>
public partial struct CWPRETSTRUCT
{
    /// <include file='CWPRETSTRUCT.xml' path='doc/member[@name="CWPRETSTRUCT.lResult"]/*'/>
    public LRESULT lResult;
    /// <include file='CWPRETSTRUCT.xml' path='doc/member[@name="CWPRETSTRUCT.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='CWPRETSTRUCT.xml' path='doc/member[@name="CWPRETSTRUCT.wParam"]/*'/>
    public WPARAM wParam;
    /// <include file='CWPRETSTRUCT.xml' path='doc/member[@name="CWPRETSTRUCT.message"]/*'/>
    public uint message;
    /// <include file='CWPRETSTRUCT.xml' path='doc/member[@name="CWPRETSTRUCT.hwnd"]/*'/>
    public HWND hwnd;
}