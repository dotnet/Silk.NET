// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HEADERDROPDOWNFILTERSTATES.xml' path='doc/member[@name="HEADERDROPDOWNFILTERSTATES"]/*' />
public enum HEADERDROPDOWNFILTERSTATES
{
    /// <include file='HEADERDROPDOWNFILTERSTATES.xml' path='doc/member[@name="HEADERDROPDOWNFILTERSTATES.HDDFS_NORMAL"]/*' />
    HDDFS_NORMAL = 1,

    /// <include file='HEADERDROPDOWNFILTERSTATES.xml' path='doc/member[@name="HEADERDROPDOWNFILTERSTATES.HDDFS_SOFTHOT"]/*' />
    HDDFS_SOFTHOT = 2,

    /// <include file='HEADERDROPDOWNFILTERSTATES.xml' path='doc/member[@name="HEADERDROPDOWNFILTERSTATES.HDDFS_HOT"]/*' />
    HDDFS_HOT = 3,
}
