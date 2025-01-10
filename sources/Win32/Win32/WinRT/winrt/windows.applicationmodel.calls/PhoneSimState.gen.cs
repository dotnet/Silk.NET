// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PhoneSimState
{
    PhoneSimState_Unknown = 0,
    PhoneSimState_PinNotRequired = 1,
    PhoneSimState_PinUnlocked = 2,
    PhoneSimState_PinLocked = 3,
    PhoneSimState_PukLocked = 4,
    PhoneSimState_NotInserted = 5,
    PhoneSimState_Invalid = 6,
    PhoneSimState_Disabled = 7,
}
