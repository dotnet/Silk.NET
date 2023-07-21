// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MF_CUSTOM_DECODE_UNIT_TYPE.xml' path='doc/member[@name="MF_CUSTOM_DECODE_UNIT_TYPE"]/*' />
public enum MF_CUSTOM_DECODE_UNIT_TYPE
{
    /// <include file='MF_CUSTOM_DECODE_UNIT_TYPE.xml' path='doc/member[@name="MF_CUSTOM_DECODE_UNIT_TYPE.MF_DECODE_UNIT_NAL"]/*' />
    MF_DECODE_UNIT_NAL = 0,

    /// <include file='MF_CUSTOM_DECODE_UNIT_TYPE.xml' path='doc/member[@name="MF_CUSTOM_DECODE_UNIT_TYPE.MF_DECODE_UNIT_SEI"]/*' />
    MF_DECODE_UNIT_SEI = 1,
}
