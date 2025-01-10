// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AppBroadcastTerminationReason
{
    AppBroadcastTerminationReason_NormalTermination = 0,
    AppBroadcastTerminationReason_LostConnectionToService = 1,
    AppBroadcastTerminationReason_NoNetworkConnectivity = 2,
    AppBroadcastTerminationReason_ServiceAbort = 3,
    AppBroadcastTerminationReason_ServiceError = 4,
    AppBroadcastTerminationReason_ServiceUnavailable = 5,
    AppBroadcastTerminationReason_InternalError = 6,
    AppBroadcastTerminationReason_UnsupportedFormat = 7,
    AppBroadcastTerminationReason_BackgroundTaskTerminated = 8,
    AppBroadcastTerminationReason_BackgroundTaskUnresponsive = 9,
}
