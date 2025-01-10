// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum RemoteSystemSessionParticipantWatcherStatus
{
    RemoteSystemSessionParticipantWatcherStatus_Created = 0,
    RemoteSystemSessionParticipantWatcherStatus_Started = 1,
    RemoteSystemSessionParticipantWatcherStatus_EnumerationCompleted = 2,
    RemoteSystemSessionParticipantWatcherStatus_Stopping = 3,
    RemoteSystemSessionParticipantWatcherStatus_Stopped = 4,
    RemoteSystemSessionParticipantWatcherStatus_Aborted = 5,
}
