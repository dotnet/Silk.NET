// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='RM_APP_STATUS.xml' path='doc/member[@name="RM_APP_STATUS"]/*' />
[Flags]
public enum RM_APP_STATUS
{
    /// <include file='RM_APP_STATUS.xml' path='doc/member[@name="RM_APP_STATUS.RmStatusUnknown"]/*' />
    RmStatusUnknown = 0x0,

    /// <include file='RM_APP_STATUS.xml' path='doc/member[@name="RM_APP_STATUS.RmStatusRunning"]/*' />
    RmStatusRunning = 0x1,

    /// <include file='RM_APP_STATUS.xml' path='doc/member[@name="RM_APP_STATUS.RmStatusStopped"]/*' />
    RmStatusStopped = 0x2,

    /// <include file='RM_APP_STATUS.xml' path='doc/member[@name="RM_APP_STATUS.RmStatusStoppedOther"]/*' />
    RmStatusStoppedOther = 0x4,

    /// <include file='RM_APP_STATUS.xml' path='doc/member[@name="RM_APP_STATUS.RmStatusRestarted"]/*' />
    RmStatusRestarted = 0x8,

    /// <include file='RM_APP_STATUS.xml' path='doc/member[@name="RM_APP_STATUS.RmStatusErrorOnStop"]/*' />
    RmStatusErrorOnStop = 0x10,

    /// <include file='RM_APP_STATUS.xml' path='doc/member[@name="RM_APP_STATUS.RmStatusErrorOnRestart"]/*' />
    RmStatusErrorOnRestart = 0x20,

    /// <include file='RM_APP_STATUS.xml' path='doc/member[@name="RM_APP_STATUS.RmStatusShutdownMasked"]/*' />
    RmStatusShutdownMasked = 0x40,

    /// <include file='RM_APP_STATUS.xml' path='doc/member[@name="RM_APP_STATUS.RmStatusRestartMasked"]/*' />
    RmStatusRestartMasked = 0x80,
}
