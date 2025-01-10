// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum TransportState
{
    TransportState_Unknown = 0,
    TransportState_Stopped = 1,
    TransportState_Playing = 2,
    TransportState_Transitioning = 3,
    TransportState_Paused = 4,
    TransportState_Recording = 5,
    TransportState_NoMediaPresent = 6,
    TransportState_Last = 7,
}
