// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/timezoneapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TIME_ZONE_INFORMATION.xml' path='doc/member[@name="TIME_ZONE_INFORMATION"]/*' />
public unsafe partial struct TIME_ZONE_INFORMATION
{
    /// <include file='TIME_ZONE_INFORMATION.xml' path='doc/member[@name="TIME_ZONE_INFORMATION.Bias"]/*' />
    [NativeTypeName("LONG")]
    public int Bias;

    /// <include file='TIME_ZONE_INFORMATION.xml' path='doc/member[@name="TIME_ZONE_INFORMATION.StandardName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort StandardName[32];

    /// <include file='TIME_ZONE_INFORMATION.xml' path='doc/member[@name="TIME_ZONE_INFORMATION.StandardDate"]/*' />
    public SYSTEMTIME StandardDate;

    /// <include file='TIME_ZONE_INFORMATION.xml' path='doc/member[@name="TIME_ZONE_INFORMATION.StandardBias"]/*' />
    [NativeTypeName("LONG")]
    public int StandardBias;

    /// <include file='TIME_ZONE_INFORMATION.xml' path='doc/member[@name="TIME_ZONE_INFORMATION.DaylightName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort DaylightName[32];

    /// <include file='TIME_ZONE_INFORMATION.xml' path='doc/member[@name="TIME_ZONE_INFORMATION.DaylightDate"]/*' />
    public SYSTEMTIME DaylightDate;

    /// <include file='TIME_ZONE_INFORMATION.xml' path='doc/member[@name="TIME_ZONE_INFORMATION.DaylightBias"]/*' />
    [NativeTypeName("LONG")]
    public int DaylightBias;
}
