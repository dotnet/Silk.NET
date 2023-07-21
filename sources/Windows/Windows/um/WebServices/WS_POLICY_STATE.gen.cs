// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_POLICY_STATE.xml' path='doc/member[@name="WS_POLICY_STATE"]/*' />
public enum WS_POLICY_STATE
{
    /// <include file='WS_POLICY_STATE.xml' path='doc/member[@name="WS_POLICY_STATE.WS_POLICY_STATE_CREATED"]/*' />
    WS_POLICY_STATE_CREATED = 1,

    /// <include file='WS_POLICY_STATE.xml' path='doc/member[@name="WS_POLICY_STATE.WS_POLICY_STATE_FAULTED"]/*' />
    WS_POLICY_STATE_FAULTED = 2,
}
