// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMREBARCHILDSIZE.xml' path='doc/member[@name="NMREBARCHILDSIZE"]/*'/>
public partial struct NMREBARCHILDSIZE
{
    /// <include file='NMREBARCHILDSIZE.xml' path='doc/member[@name="NMREBARCHILDSIZE.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMREBARCHILDSIZE.xml' path='doc/member[@name="NMREBARCHILDSIZE.uBand"]/*'/>
    public uint uBand;
    /// <include file='NMREBARCHILDSIZE.xml' path='doc/member[@name="NMREBARCHILDSIZE.wID"]/*'/>
    public uint wID;
    /// <include file='NMREBARCHILDSIZE.xml' path='doc/member[@name="NMREBARCHILDSIZE.rcChild"]/*'/>
    public RECT rcChild;
    /// <include file='NMREBARCHILDSIZE.xml' path='doc/member[@name="NMREBARCHILDSIZE.rcBand"]/*'/>
    public RECT rcBand;
}