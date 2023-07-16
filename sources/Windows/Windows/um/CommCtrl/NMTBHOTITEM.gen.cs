// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NMTBHOTITEM.xml' path='doc/member[@name="NMTBHOTITEM"]/*'/>
public partial struct NMTBHOTITEM
{
    /// <include file='NMTBHOTITEM.xml' path='doc/member[@name="NMTBHOTITEM.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMTBHOTITEM.xml' path='doc/member[@name="NMTBHOTITEM.idOld"]/*'/>
    public int idOld;
    /// <include file='NMTBHOTITEM.xml' path='doc/member[@name="NMTBHOTITEM.idNew"]/*'/>
    public int idNew;
    /// <include file='NMTBHOTITEM.xml' path='doc/member[@name="NMTBHOTITEM.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}