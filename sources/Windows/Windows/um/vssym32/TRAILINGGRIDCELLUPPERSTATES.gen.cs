// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TRAILINGGRIDCELLUPPERSTATES.xml' path='doc/member[@name="TRAILINGGRIDCELLUPPERSTATES"]/*'/>
public enum TRAILINGGRIDCELLUPPERSTATES
{
    /// <include file='TRAILINGGRIDCELLUPPERSTATES.xml' path='doc/member[@name="TRAILINGGRIDCELLUPPERSTATES.MCTGCU_HOT"]/*'/>
    MCTGCU_HOT = 1,
    /// <include file='TRAILINGGRIDCELLUPPERSTATES.xml' path='doc/member[@name="TRAILINGGRIDCELLUPPERSTATES.MCTGCU_HASSTATE"]/*'/>
    MCTGCU_HASSTATE = 2,
    /// <include file='TRAILINGGRIDCELLUPPERSTATES.xml' path='doc/member[@name="TRAILINGGRIDCELLUPPERSTATES.MCTGCU_HASSTATEHOT"]/*'/>
    MCTGCU_HASSTATEHOT = 3,
    /// <include file='TRAILINGGRIDCELLUPPERSTATES.xml' path='doc/member[@name="TRAILINGGRIDCELLUPPERSTATES.MCTGCU_SELECTED"]/*'/>
    MCTGCU_SELECTED = 4,
    /// <include file='TRAILINGGRIDCELLUPPERSTATES.xml' path='doc/member[@name="TRAILINGGRIDCELLUPPERSTATES.MCTGCU_SELECTEDHOT"]/*'/>
    MCTGCU_SELECTEDHOT = 5,
}