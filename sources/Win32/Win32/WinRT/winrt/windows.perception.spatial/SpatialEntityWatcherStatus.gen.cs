// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SpatialEntityWatcherStatus
{
    SpatialEntityWatcherStatus_Created = 0,
    SpatialEntityWatcherStatus_Started = 1,
    SpatialEntityWatcherStatus_EnumerationCompleted = 2,
    SpatialEntityWatcherStatus_Stopping = 3,
    SpatialEntityWatcherStatus_Stopped = 4,
    SpatialEntityWatcherStatus_Aborted = 5,
}
