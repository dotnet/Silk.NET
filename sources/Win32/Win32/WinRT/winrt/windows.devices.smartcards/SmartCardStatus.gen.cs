// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SmartCardStatus
{
    SmartCardStatus_Disconnected = 0,
    SmartCardStatus_Ready = 1,
    SmartCardStatus_Shared = 2,
    SmartCardStatus_Exclusive = 3,
    SmartCardStatus_Unresponsive = 4,
}
