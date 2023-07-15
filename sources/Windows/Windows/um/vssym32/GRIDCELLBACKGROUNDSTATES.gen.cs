// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='GRIDCELLBACKGROUNDSTATES.xml' path='doc/member[@name="GRIDCELLBACKGROUNDSTATES"]/*'/>
public enum GRIDCELLBACKGROUNDSTATES
{
    /// <include file='GRIDCELLBACKGROUNDSTATES.xml' path='doc/member[@name="GRIDCELLBACKGROUNDSTATES.MCGCB_SELECTED"]/*'/>
    MCGCB_SELECTED = 1,
    /// <include file='GRIDCELLBACKGROUNDSTATES.xml' path='doc/member[@name="GRIDCELLBACKGROUNDSTATES.MCGCB_HOT"]/*'/>
    MCGCB_HOT = 2,
    /// <include file='GRIDCELLBACKGROUNDSTATES.xml' path='doc/member[@name="GRIDCELLBACKGROUNDSTATES.MCGCB_SELECTEDHOT"]/*'/>
    MCGCB_SELECTEDHOT = 3,
    /// <include file='GRIDCELLBACKGROUNDSTATES.xml' path='doc/member[@name="GRIDCELLBACKGROUNDSTATES.MCGCB_SELECTEDNOTFOCUSED"]/*'/>
    MCGCB_SELECTEDNOTFOCUSED = 4,
    /// <include file='GRIDCELLBACKGROUNDSTATES.xml' path='doc/member[@name="GRIDCELLBACKGROUNDSTATES.MCGCB_TODAY"]/*'/>
    MCGCB_TODAY = 5,
    /// <include file='GRIDCELLBACKGROUNDSTATES.xml' path='doc/member[@name="GRIDCELLBACKGROUNDSTATES.MCGCB_TODAYSELECTED"]/*'/>
    MCGCB_TODAYSELECTED = 6,
}