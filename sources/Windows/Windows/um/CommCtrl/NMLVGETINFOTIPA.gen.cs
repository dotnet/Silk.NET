// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NMLVGETINFOTIPA.xml' path='doc/member[@name="NMLVGETINFOTIPA"]/*'/>
public unsafe partial struct NMLVGETINFOTIPA
{
    /// <include file='NMLVGETINFOTIPA.xml' path='doc/member[@name="NMLVGETINFOTIPA.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMLVGETINFOTIPA.xml' path='doc/member[@name="NMLVGETINFOTIPA.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='NMLVGETINFOTIPA.xml' path='doc/member[@name="NMLVGETINFOTIPA.pszText"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszText;
    /// <include file='NMLVGETINFOTIPA.xml' path='doc/member[@name="NMLVGETINFOTIPA.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='NMLVGETINFOTIPA.xml' path='doc/member[@name="NMLVGETINFOTIPA.iItem"]/*'/>
    public int iItem;
    /// <include file='NMLVGETINFOTIPA.xml' path='doc/member[@name="NMLVGETINFOTIPA.iSubItem"]/*'/>
    public int iSubItem;
    /// <include file='NMLVGETINFOTIPA.xml' path='doc/member[@name="NMLVGETINFOTIPA.lParam"]/*'/>
    public LPARAM lParam;
}