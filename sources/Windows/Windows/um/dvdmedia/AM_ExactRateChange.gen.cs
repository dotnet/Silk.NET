// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AM_ExactRateChange.xml' path='doc/member[@name="AM_ExactRateChange"]/*' />
public partial struct AM_ExactRateChange
{
    /// <include file='AM_ExactRateChange.xml' path='doc/member[@name="AM_ExactRateChange.OutputZeroTime"]/*' />
    [NativeTypeName("REFERENCE_TIME")]
    public long OutputZeroTime;

    /// <include file='AM_ExactRateChange.xml' path='doc/member[@name="AM_ExactRateChange.Rate"]/*' />
    [NativeTypeName("LONG")]
    public int Rate;
}
