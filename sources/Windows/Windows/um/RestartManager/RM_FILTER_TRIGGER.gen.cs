// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='RM_FILTER_TRIGGER.xml' path='doc/member[@name="RM_FILTER_TRIGGER"]/*' />
public enum RM_FILTER_TRIGGER
{
    /// <include file='RM_FILTER_TRIGGER.xml' path='doc/member[@name="RM_FILTER_TRIGGER.RmFilterTriggerInvalid"]/*' />
    RmFilterTriggerInvalid = 0,

    /// <include file='RM_FILTER_TRIGGER.xml' path='doc/member[@name="RM_FILTER_TRIGGER.RmFilterTriggerFile"]/*' />
    RmFilterTriggerFile,

    /// <include file='RM_FILTER_TRIGGER.xml' path='doc/member[@name="RM_FILTER_TRIGGER.RmFilterTriggerProcess"]/*' />
    RmFilterTriggerProcess,

    /// <include file='RM_FILTER_TRIGGER.xml' path='doc/member[@name="RM_FILTER_TRIGGER.RmFilterTriggerService"]/*' />
    RmFilterTriggerService,
}
