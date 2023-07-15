// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMCBEENDEDITW.xml' path='doc/member[@name="NMCBEENDEDITW"]/*'/>
public unsafe partial struct NMCBEENDEDITW
{
    /// <include file='NMCBEENDEDITW.xml' path='doc/member[@name="NMCBEENDEDITW.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMCBEENDEDITW.xml' path='doc/member[@name="NMCBEENDEDITW.fChanged"]/*'/>
    public BOOL fChanged;
    /// <include file='NMCBEENDEDITW.xml' path='doc/member[@name="NMCBEENDEDITW.iNewSelection"]/*'/>
    public int iNewSelection;
    /// <include file='NMCBEENDEDITW.xml' path='doc/member[@name="NMCBEENDEDITW.szText"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort szText[260];
    /// <include file='NMCBEENDEDITW.xml' path='doc/member[@name="NMCBEENDEDITW.iWhy"]/*'/>
    public int iWhy;
}