// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NMHDDISPINFOA.xml' path='doc/member[@name="NMHDDISPINFOA"]/*'/>
public unsafe partial struct NMHDDISPINFOA
{
    /// <include file='NMHDDISPINFOA.xml' path='doc/member[@name="NMHDDISPINFOA.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMHDDISPINFOA.xml' path='doc/member[@name="NMHDDISPINFOA.iItem"]/*'/>
    public int iItem;
    /// <include file='NMHDDISPINFOA.xml' path='doc/member[@name="NMHDDISPINFOA.mask"]/*'/>
    public uint mask;
    /// <include file='NMHDDISPINFOA.xml' path='doc/member[@name="NMHDDISPINFOA.pszText"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszText;
    /// <include file='NMHDDISPINFOA.xml' path='doc/member[@name="NMHDDISPINFOA.cchTextMax"]/*'/>
    public int cchTextMax;
    /// <include file='NMHDDISPINFOA.xml' path='doc/member[@name="NMHDDISPINFOA.iImage"]/*'/>
    public int iImage;
    /// <include file='NMHDDISPINFOA.xml' path='doc/member[@name="NMHDDISPINFOA.lParam"]/*'/>
    public LPARAM lParam;
}