// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='UNDOCK_REASON.xml' path='doc/member[@name="UNDOCK_REASON"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum UNDOCK_REASON
{
    /// <include file='UNDOCK_REASON.xml' path='doc/member[@name="UNDOCK_REASON.UR_RESOLUTION_CHANGE"]/*' />
    UR_RESOLUTION_CHANGE = 0,

    /// <include file='UNDOCK_REASON.xml' path='doc/member[@name="UNDOCK_REASON.UR_MONITOR_DISCONNECT"]/*' />
    UR_MONITOR_DISCONNECT = 1,
}
