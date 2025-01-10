// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AppResourceGroupInfoWatcherStatus
{
    AppResourceGroupInfoWatcherStatus_Created = 0,
    AppResourceGroupInfoWatcherStatus_Started = 1,
    AppResourceGroupInfoWatcherStatus_EnumerationCompleted = 2,
    AppResourceGroupInfoWatcherStatus_Stopping = 3,
    AppResourceGroupInfoWatcherStatus_Stopped = 4,
    AppResourceGroupInfoWatcherStatus_Aborted = 5,
}
