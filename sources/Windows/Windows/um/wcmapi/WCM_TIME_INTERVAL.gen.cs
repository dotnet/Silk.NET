// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WCM_TIME_INTERVAL.xml' path='doc/member[@name="WCM_TIME_INTERVAL"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct WCM_TIME_INTERVAL
{
    /// <include file='WCM_TIME_INTERVAL.xml' path='doc/member[@name="WCM_TIME_INTERVAL.wYear"]/*' />
    [NativeTypeName("WORD")]
    public ushort wYear;

    /// <include file='WCM_TIME_INTERVAL.xml' path='doc/member[@name="WCM_TIME_INTERVAL.wMonth"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMonth;

    /// <include file='WCM_TIME_INTERVAL.xml' path='doc/member[@name="WCM_TIME_INTERVAL.wDay"]/*' />
    [NativeTypeName("WORD")]
    public ushort wDay;

    /// <include file='WCM_TIME_INTERVAL.xml' path='doc/member[@name="WCM_TIME_INTERVAL.wHour"]/*' />
    [NativeTypeName("WORD")]
    public ushort wHour;

    /// <include file='WCM_TIME_INTERVAL.xml' path='doc/member[@name="WCM_TIME_INTERVAL.wMinute"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMinute;

    /// <include file='WCM_TIME_INTERVAL.xml' path='doc/member[@name="WCM_TIME_INTERVAL.wSecond"]/*' />
    [NativeTypeName("WORD")]
    public ushort wSecond;

    /// <include file='WCM_TIME_INTERVAL.xml' path='doc/member[@name="WCM_TIME_INTERVAL.wMilliseconds"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMilliseconds;
}
