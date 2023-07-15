// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMTBGETINFOTIPA.xml' path='doc/member[@name="NMTBGETINFOTIPA"]/*'/>
public unsafe partial struct NMTBGETINFOTIPA
{
    /// <include file='NMTBGETINFOTIPA.xml' path='doc/member[@name="NMTBGETINFOTIPA.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMTBGETINFOTIPA.xml' path='doc/member[@name="NMTBGETINFOTIPA.pszText"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszText;
    /// <include file='NMTBGETINFOTIPA.xml' path='doc/member[@name="NMTBGETINFOTIPA.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='NMTBGETINFOTIPA.xml' path='doc/member[@name="NMTBGETINFOTIPA.iItem"]/*'/>
    public int iItem;
    /// <include file='NMTBGETINFOTIPA.xml' path='doc/member[@name="NMTBGETINFOTIPA.lParam"]/*'/>
    public LPARAM lParam;
}