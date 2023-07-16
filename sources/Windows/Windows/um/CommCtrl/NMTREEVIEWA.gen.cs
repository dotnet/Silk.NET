// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NMTREEVIEWA.xml' path='doc/member[@name="NMTREEVIEWA"]/*'/>
public partial struct NMTREEVIEWA
{
    /// <include file='NMTREEVIEWA.xml' path='doc/member[@name="NMTREEVIEWA.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMTREEVIEWA.xml' path='doc/member[@name="NMTREEVIEWA.action"]/*'/>
    public uint action;
    /// <include file='NMTREEVIEWA.xml' path='doc/member[@name="NMTREEVIEWA.itemOld"]/*'/>
    public TVITEMA itemOld;
    /// <include file='NMTREEVIEWA.xml' path='doc/member[@name="NMTREEVIEWA.itemNew"]/*'/>
    public TVITEMA itemNew;
    /// <include file='NMTREEVIEWA.xml' path='doc/member[@name="NMTREEVIEWA.ptDrag"]/*'/>
    public POINT ptDrag;
}