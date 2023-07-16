// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TRAILINGGRIDCELLSTATES.xml' path='doc/member[@name="TRAILINGGRIDCELLSTATES"]/*'/>
public enum TRAILINGGRIDCELLSTATES
{
    /// <include file='TRAILINGGRIDCELLSTATES.xml' path='doc/member[@name="TRAILINGGRIDCELLSTATES.MCTGC_HOT"]/*'/>
    MCTGC_HOT = 1,
    /// <include file='TRAILINGGRIDCELLSTATES.xml' path='doc/member[@name="TRAILINGGRIDCELLSTATES.MCTGC_HASSTATE"]/*'/>
    MCTGC_HASSTATE = 2,
    /// <include file='TRAILINGGRIDCELLSTATES.xml' path='doc/member[@name="TRAILINGGRIDCELLSTATES.MCTGC_HASSTATEHOT"]/*'/>
    MCTGC_HASSTATEHOT = 3,
    /// <include file='TRAILINGGRIDCELLSTATES.xml' path='doc/member[@name="TRAILINGGRIDCELLSTATES.MCTGC_TODAY"]/*'/>
    MCTGC_TODAY = 4,
    /// <include file='TRAILINGGRIDCELLSTATES.xml' path='doc/member[@name="TRAILINGGRIDCELLSTATES.MCTGC_TODAYSELECTED"]/*'/>
    MCTGC_TODAYSELECTED = 5,
    /// <include file='TRAILINGGRIDCELLSTATES.xml' path='doc/member[@name="TRAILINGGRIDCELLSTATES.MCTGC_SELECTED"]/*'/>
    MCTGC_SELECTED = 6,
    /// <include file='TRAILINGGRIDCELLSTATES.xml' path='doc/member[@name="TRAILINGGRIDCELLSTATES.MCTGC_SELECTEDHOT"]/*'/>
    MCTGC_SELECTEDHOT = 7,
}