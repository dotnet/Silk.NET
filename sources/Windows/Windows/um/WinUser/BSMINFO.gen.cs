// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='BSMINFO.xml' path='doc/member[@name="BSMINFO"]/*'/>
public partial struct BSMINFO
{
    /// <include file='BSMINFO.xml' path='doc/member[@name="BSMINFO.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='BSMINFO.xml' path='doc/member[@name="BSMINFO.hdesk"]/*'/>
    public HDESK hdesk;
    /// <include file='BSMINFO.xml' path='doc/member[@name="BSMINFO.hwnd"]/*'/>
    public HWND hwnd;
    /// <include file='BSMINFO.xml' path='doc/member[@name="BSMINFO.luid"]/*'/>
    public LUID luid;
}