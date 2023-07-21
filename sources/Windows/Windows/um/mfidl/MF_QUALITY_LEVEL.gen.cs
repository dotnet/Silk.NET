// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MF_QUALITY_LEVEL.xml' path='doc/member[@name="MF_QUALITY_LEVEL"]/*' />
public enum MF_QUALITY_LEVEL
{
    /// <include file='MF_QUALITY_LEVEL.xml' path='doc/member[@name="MF_QUALITY_LEVEL.MF_QUALITY_NORMAL"]/*' />
    MF_QUALITY_NORMAL = 0,

    /// <include file='MF_QUALITY_LEVEL.xml' path='doc/member[@name="MF_QUALITY_LEVEL.MF_QUALITY_NORMAL_MINUS_1"]/*' />
    MF_QUALITY_NORMAL_MINUS_1 = 0x1,

    /// <include file='MF_QUALITY_LEVEL.xml' path='doc/member[@name="MF_QUALITY_LEVEL.MF_QUALITY_NORMAL_MINUS_2"]/*' />
    MF_QUALITY_NORMAL_MINUS_2 = 0x2,

    /// <include file='MF_QUALITY_LEVEL.xml' path='doc/member[@name="MF_QUALITY_LEVEL.MF_QUALITY_NORMAL_MINUS_3"]/*' />
    MF_QUALITY_NORMAL_MINUS_3 = 0x3,

    /// <include file='MF_QUALITY_LEVEL.xml' path='doc/member[@name="MF_QUALITY_LEVEL.MF_QUALITY_NORMAL_MINUS_4"]/*' />
    MF_QUALITY_NORMAL_MINUS_4 = 0x4,

    /// <include file='MF_QUALITY_LEVEL.xml' path='doc/member[@name="MF_QUALITY_LEVEL.MF_QUALITY_NORMAL_MINUS_5"]/*' />
    MF_QUALITY_NORMAL_MINUS_5 = 0x5,

    /// <include file='MF_QUALITY_LEVEL.xml' path='doc/member[@name="MF_QUALITY_LEVEL.MF_NUM_QUALITY_LEVELS"]/*' />
    MF_NUM_QUALITY_LEVELS = 0x6,
}
