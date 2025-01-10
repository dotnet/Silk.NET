// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.casting.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum CastingConnectionState
{
    CastingConnectionState_Disconnected = 0,
    CastingConnectionState_Connected = 1,
    CastingConnectionState_Rendering = 2,
    CastingConnectionState_Disconnecting = 3,
    CastingConnectionState_Connecting = 4,
}
