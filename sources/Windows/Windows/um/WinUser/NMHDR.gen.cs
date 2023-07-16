// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NMHDR.xml' path='doc/member[@name="NMHDR"]/*'/>
public partial struct NMHDR
{
    /// <include file='NMHDR.xml' path='doc/member[@name="NMHDR.hwndFrom"]/*'/>
    public HWND hwndFrom;
    /// <include file='NMHDR.xml' path='doc/member[@name="NMHDR.idFrom"]/*'/>
    [NativeTypeName("UINT_PTR")]
    public nuint idFrom;
    /// <include file='NMHDR.xml' path='doc/member[@name="NMHDR.code"]/*'/>
    public uint code;
}