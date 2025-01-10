// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wpframework.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum PM_INTERFACE_ID_ENUM
{
    PM_LISTENER_CHANNEL_MANAGER_ID = 1,
    PM_HEALTH_AND_IDLE_MONITOR_ID,
    PM_CUSTOM_ACTIONS_ID,
    PM_APPLICATION_PRELOAD_ID,
    PM_IDLE_TIMEOUT_ID,
}
