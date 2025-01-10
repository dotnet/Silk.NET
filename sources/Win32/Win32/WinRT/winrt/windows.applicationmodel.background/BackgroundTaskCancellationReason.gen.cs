// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum BackgroundTaskCancellationReason
{
    BackgroundTaskCancellationReason_Abort = 0,
    BackgroundTaskCancellationReason_Terminating = 1,
    BackgroundTaskCancellationReason_LoggingOff = 2,
    BackgroundTaskCancellationReason_ServicingUpdate = 3,
    BackgroundTaskCancellationReason_IdleTask = 4,
    BackgroundTaskCancellationReason_Uninstall = 5,
    BackgroundTaskCancellationReason_ConditionLoss = 6,
    BackgroundTaskCancellationReason_SystemPolicy = 7,

    [Obsolete("QuietHoursEntered is deprecated after Windows 8.1")]
    BackgroundTaskCancellationReason_QuietHoursEntered = 8,
    BackgroundTaskCancellationReason_ExecutionTimeExceeded = 9,
    BackgroundTaskCancellationReason_ResourceRevocation = 10,
    BackgroundTaskCancellationReason_EnergySaver = 11,
}
