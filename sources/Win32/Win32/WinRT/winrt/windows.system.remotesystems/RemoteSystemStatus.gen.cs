// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum RemoteSystemStatus
{
    RemoteSystemStatus_Unavailable = 0,
    RemoteSystemStatus_DiscoveringAvailability = 1,
    RemoteSystemStatus_Available = 2,
    RemoteSystemStatus_Unknown = 3,
}
