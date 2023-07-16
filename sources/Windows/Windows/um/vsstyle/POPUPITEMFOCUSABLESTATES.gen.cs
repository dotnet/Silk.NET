// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='POPUPITEMFOCUSABLESTATES.xml' path='doc/member[@name="POPUPITEMFOCUSABLESTATES"]/*'/>
public enum POPUPITEMFOCUSABLESTATES
{
    /// <include file='POPUPITEMFOCUSABLESTATES.xml' path='doc/member[@name="POPUPITEMFOCUSABLESTATES.MPIF_NORMAL"]/*'/>
    MPIF_NORMAL = 1,
    /// <include file='POPUPITEMFOCUSABLESTATES.xml' path='doc/member[@name="POPUPITEMFOCUSABLESTATES.MPIF_HOT"]/*'/>
    MPIF_HOT = 2,
    /// <include file='POPUPITEMFOCUSABLESTATES.xml' path='doc/member[@name="POPUPITEMFOCUSABLESTATES.MPIF_DISABLED"]/*'/>
    MPIF_DISABLED = 3,
    /// <include file='POPUPITEMFOCUSABLESTATES.xml' path='doc/member[@name="POPUPITEMFOCUSABLESTATES.MPIF_DISABLEDHOT"]/*'/>
    MPIF_DISABLEDHOT = 4,
}