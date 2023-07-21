// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='COWAIT_FLAGS.xml' path='doc/member[@name="COWAIT_FLAGS"]/*' />
[Flags]
public enum COWAIT_FLAGS
{
    /// <include file='COWAIT_FLAGS.xml' path='doc/member[@name="COWAIT_FLAGS.COWAIT_DEFAULT"]/*' />
    COWAIT_DEFAULT = 0,

    /// <include file='COWAIT_FLAGS.xml' path='doc/member[@name="COWAIT_FLAGS.COWAIT_WAITALL"]/*' />
    COWAIT_WAITALL = 1,

    /// <include file='COWAIT_FLAGS.xml' path='doc/member[@name="COWAIT_FLAGS.COWAIT_ALERTABLE"]/*' />
    COWAIT_ALERTABLE = 2,

    /// <include file='COWAIT_FLAGS.xml' path='doc/member[@name="COWAIT_FLAGS.COWAIT_INPUTAVAILABLE"]/*' />
    COWAIT_INPUTAVAILABLE = 4,

    /// <include file='COWAIT_FLAGS.xml' path='doc/member[@name="COWAIT_FLAGS.COWAIT_DISPATCH_CALLS"]/*' />
    COWAIT_DISPATCH_CALLS = 8,

    /// <include file='COWAIT_FLAGS.xml' path='doc/member[@name="COWAIT_FLAGS.COWAIT_DISPATCH_WINDOW_MESSAGES"]/*' />
    COWAIT_DISPATCH_WINDOW_MESSAGES = 0x10,
}
