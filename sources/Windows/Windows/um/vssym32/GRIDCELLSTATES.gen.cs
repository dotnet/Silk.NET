// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='GRIDCELLSTATES.xml' path='doc/member[@name="GRIDCELLSTATES"]/*'/>
public enum GRIDCELLSTATES
{
    /// <include file='GRIDCELLSTATES.xml' path='doc/member[@name="GRIDCELLSTATES.MCGC_HOT"]/*'/>
    MCGC_HOT = 1,
    /// <include file='GRIDCELLSTATES.xml' path='doc/member[@name="GRIDCELLSTATES.MCGC_HASSTATE"]/*'/>
    MCGC_HASSTATE = 2,
    /// <include file='GRIDCELLSTATES.xml' path='doc/member[@name="GRIDCELLSTATES.MCGC_HASSTATEHOT"]/*'/>
    MCGC_HASSTATEHOT = 3,
    /// <include file='GRIDCELLSTATES.xml' path='doc/member[@name="GRIDCELLSTATES.MCGC_TODAY"]/*'/>
    MCGC_TODAY = 4,
    /// <include file='GRIDCELLSTATES.xml' path='doc/member[@name="GRIDCELLSTATES.MCGC_TODAYSELECTED"]/*'/>
    MCGC_TODAYSELECTED = 5,
    /// <include file='GRIDCELLSTATES.xml' path='doc/member[@name="GRIDCELLSTATES.MCGC_SELECTED"]/*'/>
    MCGC_SELECTED = 6,
    /// <include file='GRIDCELLSTATES.xml' path='doc/member[@name="GRIDCELLSTATES.MCGC_SELECTEDHOT"]/*'/>
    MCGC_SELECTEDHOT = 7,
}