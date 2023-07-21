// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='CM_STATE.xml' path='doc/member[@name="CM_STATE"]/*' />
[Flags]
public enum CM_STATE
{
    /// <include file='CM_STATE.xml' path='doc/member[@name="CM_STATE.CM_STATE_NONE"]/*' />
    CM_STATE_NONE = 0,

    /// <include file='CM_STATE.xml' path='doc/member[@name="CM_STATE.CM_STATE_VISIBLE"]/*' />
    CM_STATE_VISIBLE = 0x1,

    /// <include file='CM_STATE.xml' path='doc/member[@name="CM_STATE.CM_STATE_FIXEDWIDTH"]/*' />
    CM_STATE_FIXEDWIDTH = 0x2,

    /// <include file='CM_STATE.xml' path='doc/member[@name="CM_STATE.CM_STATE_NOSORTBYFOLDERNESS"]/*' />
    CM_STATE_NOSORTBYFOLDERNESS = 0x4,

    /// <include file='CM_STATE.xml' path='doc/member[@name="CM_STATE.CM_STATE_ALWAYSVISIBLE"]/*' />
    CM_STATE_ALWAYSVISIBLE = 0x8,
}
