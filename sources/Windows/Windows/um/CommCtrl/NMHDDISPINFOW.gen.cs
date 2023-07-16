// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NMHDDISPINFOW.xml' path='doc/member[@name="NMHDDISPINFOW"]/*'/>
public unsafe partial struct NMHDDISPINFOW
{
    /// <include file='NMHDDISPINFOW.xml' path='doc/member[@name="NMHDDISPINFOW.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMHDDISPINFOW.xml' path='doc/member[@name="NMHDDISPINFOW.iItem"]/*'/>
    public int iItem;
    /// <include file='NMHDDISPINFOW.xml' path='doc/member[@name="NMHDDISPINFOW.mask"]/*'/>
    public uint mask;
    /// <include file='NMHDDISPINFOW.xml' path='doc/member[@name="NMHDDISPINFOW.pszText"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;
    /// <include file='NMHDDISPINFOW.xml' path='doc/member[@name="NMHDDISPINFOW.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='NMHDDISPINFOW.xml' path='doc/member[@name="NMHDDISPINFOW.iImage"]/*'/>
    public int iImage;
    /// <include file='NMHDDISPINFOW.xml' path='doc/member[@name="NMHDDISPINFOW.lParam"]/*'/>
    public LPARAM lParam;
}