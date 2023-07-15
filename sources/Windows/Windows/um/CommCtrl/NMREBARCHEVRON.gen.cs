// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMREBARCHEVRON.xml' path='doc/member[@name="NMREBARCHEVRON"]/*'/>
public partial struct NMREBARCHEVRON
{
    /// <include file='NMREBARCHEVRON.xml' path='doc/member[@name="NMREBARCHEVRON.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMREBARCHEVRON.xml' path='doc/member[@name="NMREBARCHEVRON.uBand"]/*'/>
    public uint uBand;
    /// <include file='NMREBARCHEVRON.xml' path='doc/member[@name="NMREBARCHEVRON.wID"]/*'/>
    public uint wID;
    /// <include file='NMREBARCHEVRON.xml' path='doc/member[@name="NMREBARCHEVRON.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='NMREBARCHEVRON.xml' path='doc/member[@name="NMREBARCHEVRON.rc"]/*'/>
    public RECT rc;
    /// <include file='NMREBARCHEVRON.xml' path='doc/member[@name="NMREBARCHEVRON.lParamNM"]/*'/>
    public LPARAM lParamNM;
}