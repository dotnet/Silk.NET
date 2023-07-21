// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='UMS_SCHEDULER_REASON.xml' path='doc/member[@name="UMS_SCHEDULER_REASON"]/*' />
public enum UMS_SCHEDULER_REASON
{
    /// <include file='UMS_SCHEDULER_REASON.xml' path='doc/member[@name="UMS_SCHEDULER_REASON.UmsSchedulerStartup"]/*' />
    UmsSchedulerStartup = 0,

    /// <include file='UMS_SCHEDULER_REASON.xml' path='doc/member[@name="UMS_SCHEDULER_REASON.UmsSchedulerThreadBlocked"]/*' />
    UmsSchedulerThreadBlocked,

    /// <include file='UMS_SCHEDULER_REASON.xml' path='doc/member[@name="UMS_SCHEDULER_REASON.UmsSchedulerThreadYield"]/*' />
    UmsSchedulerThreadYield,
}
