// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WCM_POLICY_VALUE.xml' path='doc/member[@name="WCM_POLICY_VALUE"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct WCM_POLICY_VALUE
{
    /// <include file='WCM_POLICY_VALUE.xml' path='doc/member[@name="WCM_POLICY_VALUE.fValue"]/*' />
    public BOOL fValue;

    /// <include file='WCM_POLICY_VALUE.xml' path='doc/member[@name="WCM_POLICY_VALUE.fIsGroupPolicy"]/*' />
    public BOOL fIsGroupPolicy;
}
