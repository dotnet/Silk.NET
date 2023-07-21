// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AM_PROPERTY_DVD_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_DVD_RATE_CHANGE"]/*' />
public enum AM_PROPERTY_DVD_RATE_CHANGE
{
    /// <include file='AM_PROPERTY_DVD_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_DVD_RATE_CHANGE.AM_RATE_ChangeRate"]/*' />
    AM_RATE_ChangeRate = 1,

    /// <include file='AM_PROPERTY_DVD_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_DVD_RATE_CHANGE.AM_RATE_FullDataRateMax"]/*' />
    AM_RATE_FullDataRateMax = 2,

    /// <include file='AM_PROPERTY_DVD_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_DVD_RATE_CHANGE.AM_RATE_ReverseDecode"]/*' />
    AM_RATE_ReverseDecode = 3,

    /// <include file='AM_PROPERTY_DVD_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_DVD_RATE_CHANGE.AM_RATE_DecoderPosition"]/*' />
    AM_RATE_DecoderPosition = 4,

    /// <include file='AM_PROPERTY_DVD_RATE_CHANGE.xml' path='doc/member[@name="AM_PROPERTY_DVD_RATE_CHANGE.AM_RATE_DecoderVersion"]/*' />
    AM_RATE_DecoderVersion = 5,
}
