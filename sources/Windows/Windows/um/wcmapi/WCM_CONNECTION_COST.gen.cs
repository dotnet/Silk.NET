// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='WCM_CONNECTION_COST.xml' path='doc/member[@name="WCM_CONNECTION_COST"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum WCM_CONNECTION_COST
{
    /// <include file='WCM_CONNECTION_COST.xml' path='doc/member[@name="WCM_CONNECTION_COST.WCM_CONNECTION_COST_UNKNOWN"]/*'/>
    WCM_CONNECTION_COST_UNKNOWN = 0x0,
    /// <include file='WCM_CONNECTION_COST.xml' path='doc/member[@name="WCM_CONNECTION_COST.WCM_CONNECTION_COST_UNRESTRICTED"]/*'/>
    WCM_CONNECTION_COST_UNRESTRICTED = 0x1,
    /// <include file='WCM_CONNECTION_COST.xml' path='doc/member[@name="WCM_CONNECTION_COST.WCM_CONNECTION_COST_FIXED"]/*'/>
    WCM_CONNECTION_COST_FIXED = 0x2,
    /// <include file='WCM_CONNECTION_COST.xml' path='doc/member[@name="WCM_CONNECTION_COST.WCM_CONNECTION_COST_VARIABLE"]/*'/>
    WCM_CONNECTION_COST_VARIABLE = 0x4,
    /// <include file='WCM_CONNECTION_COST.xml' path='doc/member[@name="WCM_CONNECTION_COST.WCM_CONNECTION_COST_OVERDATALIMIT"]/*'/>
    WCM_CONNECTION_COST_OVERDATALIMIT = 0x10000,
    /// <include file='WCM_CONNECTION_COST.xml' path='doc/member[@name="WCM_CONNECTION_COST.WCM_CONNECTION_COST_CONGESTED"]/*'/>
    WCM_CONNECTION_COST_CONGESTED = 0x20000,
    /// <include file='WCM_CONNECTION_COST.xml' path='doc/member[@name="WCM_CONNECTION_COST.WCM_CONNECTION_COST_ROAMING"]/*'/>
    WCM_CONNECTION_COST_ROAMING = 0x40000,
    /// <include file='WCM_CONNECTION_COST.xml' path='doc/member[@name="WCM_CONNECTION_COST.WCM_CONNECTION_COST_APPROACHINGDATALIMIT"]/*'/>
    WCM_CONNECTION_COST_APPROACHINGDATALIMIT = 0x80000,
}