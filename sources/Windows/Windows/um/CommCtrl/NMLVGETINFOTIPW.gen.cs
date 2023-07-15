// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMLVGETINFOTIPW.xml' path='doc/member[@name="NMLVGETINFOTIPW"]/*'/>
public unsafe partial struct NMLVGETINFOTIPW
{
    /// <include file='NMLVGETINFOTIPW.xml' path='doc/member[@name="NMLVGETINFOTIPW.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMLVGETINFOTIPW.xml' path='doc/member[@name="NMLVGETINFOTIPW.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='NMLVGETINFOTIPW.xml' path='doc/member[@name="NMLVGETINFOTIPW.pszText"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;
    /// <include file='NMLVGETINFOTIPW.xml' path='doc/member[@name="NMLVGETINFOTIPW.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='NMLVGETINFOTIPW.xml' path='doc/member[@name="NMLVGETINFOTIPW.iItem"]/*'/>
    public int iItem;
    /// <include file='NMLVGETINFOTIPW.xml' path='doc/member[@name="NMLVGETINFOTIPW.iSubItem"]/*'/>
    public int iSubItem;
    /// <include file='NMLVGETINFOTIPW.xml' path='doc/member[@name="NMLVGETINFOTIPW.lParam"]/*'/>
    public LPARAM lParam;
}