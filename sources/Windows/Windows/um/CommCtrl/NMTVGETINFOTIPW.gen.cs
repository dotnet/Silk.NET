// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NMTVGETINFOTIPW.xml' path='doc/member[@name="NMTVGETINFOTIPW"]/*'/>
public unsafe partial struct NMTVGETINFOTIPW
{
    /// <include file='NMTVGETINFOTIPW.xml' path='doc/member[@name="NMTVGETINFOTIPW.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMTVGETINFOTIPW.xml' path='doc/member[@name="NMTVGETINFOTIPW.pszText"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;
    /// <include file='NMTVGETINFOTIPW.xml' path='doc/member[@name="NMTVGETINFOTIPW.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='NMTVGETINFOTIPW.xml' path='doc/member[@name="NMTVGETINFOTIPW.hItem"]/*'/>
    public HTREEITEM hItem;
    /// <include file='NMTVGETINFOTIPW.xml' path='doc/member[@name="NMTVGETINFOTIPW.lParam"]/*'/>
    public LPARAM lParam;
}