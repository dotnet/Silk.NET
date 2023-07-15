// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NMCBEENDEDITA.xml' path='doc/member[@name="NMCBEENDEDITA"]/*'/>
public unsafe partial struct NMCBEENDEDITA
{
    /// <include file='NMCBEENDEDITA.xml' path='doc/member[@name="NMCBEENDEDITA.hdr"]/*'/>
    public NMHDR hdr;
    /// <include file='NMCBEENDEDITA.xml' path='doc/member[@name="NMCBEENDEDITA.fChanged"]/*'/>
    public BOOL fChanged;
    /// <include file='NMCBEENDEDITA.xml' path='doc/member[@name="NMCBEENDEDITA.iNewSelection"]/*'/>
    public int iNewSelection;
    /// <include file='NMCBEENDEDITA.xml' path='doc/member[@name="NMCBEENDEDITA.szText"]/*'/>
    [NativeTypeName("char[260]")]
    public fixed sbyte szText[260];
    /// <include file='NMCBEENDEDITA.xml' path='doc/member[@name="NMCBEENDEDITA.iWhy"]/*'/>
    public int iWhy;
}