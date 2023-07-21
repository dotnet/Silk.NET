// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WCM_BILLING_CYCLE_INFO.xml' path='doc/member[@name="WCM_BILLING_CYCLE_INFO"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct WCM_BILLING_CYCLE_INFO
{
    /// <include file='WCM_BILLING_CYCLE_INFO.xml' path='doc/member[@name="WCM_BILLING_CYCLE_INFO.StartDate"]/*' />
    public FILETIME StartDate;

    /// <include file='WCM_BILLING_CYCLE_INFO.xml' path='doc/member[@name="WCM_BILLING_CYCLE_INFO.Duration"]/*' />
    public WCM_TIME_INTERVAL Duration;

    /// <include file='WCM_BILLING_CYCLE_INFO.xml' path='doc/member[@name="WCM_BILLING_CYCLE_INFO.Reset"]/*' />
    public BOOL Reset;
}
