// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFVideoPrimaries.xml' path='doc/member[@name="MFVideoPrimaries"]/*' />
public enum MFVideoPrimaries
{
    /// <include file='MFVideoPrimaries.xml' path='doc/member[@name="MFVideoPrimaries.MFVideoPrimaries_Unknown"]/*' />
    MFVideoPrimaries_Unknown = 0,

    /// <include file='MFVideoPrimaries.xml' path='doc/member[@name="MFVideoPrimaries.MFVideoPrimaries_reserved"]/*' />
    MFVideoPrimaries_reserved = 1,

    /// <include file='MFVideoPrimaries.xml' path='doc/member[@name="MFVideoPrimaries.MFVideoPrimaries_BT709"]/*' />
    MFVideoPrimaries_BT709 = 2,

    /// <include file='MFVideoPrimaries.xml' path='doc/member[@name="MFVideoPrimaries.MFVideoPrimaries_BT470_2_SysM"]/*' />
    MFVideoPrimaries_BT470_2_SysM = 3,

    /// <include file='MFVideoPrimaries.xml' path='doc/member[@name="MFVideoPrimaries.MFVideoPrimaries_BT470_2_SysBG"]/*' />
    MFVideoPrimaries_BT470_2_SysBG = 4,

    /// <include file='MFVideoPrimaries.xml' path='doc/member[@name="MFVideoPrimaries.MFVideoPrimaries_SMPTE170M"]/*' />
    MFVideoPrimaries_SMPTE170M = 5,

    /// <include file='MFVideoPrimaries.xml' path='doc/member[@name="MFVideoPrimaries.MFVideoPrimaries_SMPTE240M"]/*' />
    MFVideoPrimaries_SMPTE240M = 6,

    /// <include file='MFVideoPrimaries.xml' path='doc/member[@name="MFVideoPrimaries.MFVideoPrimaries_EBU3213"]/*' />
    MFVideoPrimaries_EBU3213 = 7,

    /// <include file='MFVideoPrimaries.xml' path='doc/member[@name="MFVideoPrimaries.MFVideoPrimaries_SMPTE_C"]/*' />
    MFVideoPrimaries_SMPTE_C = 8,

    /// <include file='MFVideoPrimaries.xml' path='doc/member[@name="MFVideoPrimaries.MFVideoPrimaries_BT2020"]/*' />
    MFVideoPrimaries_BT2020 = 9,

    /// <include file='MFVideoPrimaries.xml' path='doc/member[@name="MFVideoPrimaries.MFVideoPrimaries_XYZ"]/*' />
    MFVideoPrimaries_XYZ = 10,

    /// <include file='MFVideoPrimaries.xml' path='doc/member[@name="MFVideoPrimaries.MFVideoPrimaries_DCI_P3"]/*' />
    MFVideoPrimaries_DCI_P3 = 11,

    /// <include file='MFVideoPrimaries.xml' path='doc/member[@name="MFVideoPrimaries.MFVideoPrimaries_ACES"]/*' />
    MFVideoPrimaries_ACES = 12,

    /// <include file='MFVideoPrimaries.xml' path='doc/member[@name="MFVideoPrimaries.MFVideoPrimaries_Last"]/*' />
    MFVideoPrimaries_Last = (MFVideoPrimaries_ACES + 1),

    /// <include file='MFVideoPrimaries.xml' path='doc/member[@name="MFVideoPrimaries.MFVideoPrimaries_ForceDWORD"]/*' />
    MFVideoPrimaries_ForceDWORD = 0x7fffffff,
}
