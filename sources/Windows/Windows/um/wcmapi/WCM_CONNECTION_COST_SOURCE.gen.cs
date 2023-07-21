// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WCM_CONNECTION_COST_SOURCE.xml' path='doc/member[@name="WCM_CONNECTION_COST_SOURCE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum WCM_CONNECTION_COST_SOURCE
{
    /// <include file='WCM_CONNECTION_COST_SOURCE.xml' path='doc/member[@name="WCM_CONNECTION_COST_SOURCE.WCM_CONNECTION_COST_SOURCE_DEFAULT"]/*' />
    WCM_CONNECTION_COST_SOURCE_DEFAULT = 0,

    /// <include file='WCM_CONNECTION_COST_SOURCE.xml' path='doc/member[@name="WCM_CONNECTION_COST_SOURCE.WCM_CONNECTION_COST_SOURCE_GP"]/*' />
    WCM_CONNECTION_COST_SOURCE_GP = 1,

    /// <include file='WCM_CONNECTION_COST_SOURCE.xml' path='doc/member[@name="WCM_CONNECTION_COST_SOURCE.WCM_CONNECTION_COST_SOURCE_USER"]/*' />
    WCM_CONNECTION_COST_SOURCE_USER = 2,

    /// <include file='WCM_CONNECTION_COST_SOURCE.xml' path='doc/member[@name="WCM_CONNECTION_COST_SOURCE.WCM_CONNECTION_COST_SOURCE_OPERATOR"]/*' />
    WCM_CONNECTION_COST_SOURCE_OPERATOR = 3,
}
