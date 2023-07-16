// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NMTVGETINFOTIPA.xml' path='doc/member[@name="NMTVGETINFOTIPA"]/*'/>
public unsafe partial struct NMTVGETINFOTIPA
{
    /// <include file='NMTVGETINFOTIPA.xml' path='doc/member[@name="NMTVGETINFOTIPA.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMTVGETINFOTIPA.xml' path='doc/member[@name="NMTVGETINFOTIPA.pszText"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszText;
    /// <include file='NMTVGETINFOTIPA.xml' path='doc/member[@name="NMTVGETINFOTIPA.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='NMTVGETINFOTIPA.xml' path='doc/member[@name="NMTVGETINFOTIPA.hItem"]/*'/>
    public HTREEITEM hItem;
    /// <include file='NMTVGETINFOTIPA.xml' path='doc/member[@name="NMTVGETINFOTIPA.lParam"]/*'/>
    public LPARAM lParam;
}