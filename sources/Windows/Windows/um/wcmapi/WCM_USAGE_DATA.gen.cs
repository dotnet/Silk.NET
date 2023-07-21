// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WCM_USAGE_DATA.xml' path='doc/member[@name="WCM_USAGE_DATA"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct WCM_USAGE_DATA
{
    /// <include file='WCM_USAGE_DATA.xml' path='doc/member[@name="WCM_USAGE_DATA.UsageInMegabytes"]/*' />
    [NativeTypeName("DWORD")]
    public uint UsageInMegabytes;

    /// <include file='WCM_USAGE_DATA.xml' path='doc/member[@name="WCM_USAGE_DATA.LastSyncTime"]/*' />
    public FILETIME LastSyncTime;
}
