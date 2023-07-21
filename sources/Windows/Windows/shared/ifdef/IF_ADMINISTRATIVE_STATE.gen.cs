// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IF_ADMINISTRATIVE_STATE.xml' path='doc/member[@name="IF_ADMINISTRATIVE_STATE"]/*' />
public enum IF_ADMINISTRATIVE_STATE
{
    /// <include file='IF_ADMINISTRATIVE_STATE.xml' path='doc/member[@name="IF_ADMINISTRATIVE_STATE.IF_ADMINISTRATIVE_DISABLED"]/*' />
    IF_ADMINISTRATIVE_DISABLED,

    /// <include file='IF_ADMINISTRATIVE_STATE.xml' path='doc/member[@name="IF_ADMINISTRATIVE_STATE.IF_ADMINISTRATIVE_ENABLED"]/*' />
    IF_ADMINISTRATIVE_ENABLED,

    /// <include file='IF_ADMINISTRATIVE_STATE.xml' path='doc/member[@name="IF_ADMINISTRATIVE_STATE.IF_ADMINISTRATIVE_DEMANDDIAL"]/*' />
    IF_ADMINISTRATIVE_DEMANDDIAL,
}
