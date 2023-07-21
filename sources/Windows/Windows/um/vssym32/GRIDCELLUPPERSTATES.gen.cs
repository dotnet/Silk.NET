// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='GRIDCELLUPPERSTATES.xml' path='doc/member[@name="GRIDCELLUPPERSTATES"]/*' />
public enum GRIDCELLUPPERSTATES
{
    /// <include file='GRIDCELLUPPERSTATES.xml' path='doc/member[@name="GRIDCELLUPPERSTATES.MCGCU_HOT"]/*' />
    MCGCU_HOT = 1,

    /// <include file='GRIDCELLUPPERSTATES.xml' path='doc/member[@name="GRIDCELLUPPERSTATES.MCGCU_HASSTATE"]/*' />
    MCGCU_HASSTATE = 2,

    /// <include file='GRIDCELLUPPERSTATES.xml' path='doc/member[@name="GRIDCELLUPPERSTATES.MCGCU_HASSTATEHOT"]/*' />
    MCGCU_HASSTATEHOT = 3,

    /// <include file='GRIDCELLUPPERSTATES.xml' path='doc/member[@name="GRIDCELLUPPERSTATES.MCGCU_SELECTED"]/*' />
    MCGCU_SELECTED = 4,

    /// <include file='GRIDCELLUPPERSTATES.xml' path='doc/member[@name="GRIDCELLUPPERSTATES.MCGCU_SELECTEDHOT"]/*' />
    MCGCU_SELECTEDHOT = 5,
}
