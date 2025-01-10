// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SmartCardTriggerType
{
    SmartCardTriggerType_EmulatorTransaction = 0,
    SmartCardTriggerType_EmulatorNearFieldEntry = 1,
    SmartCardTriggerType_EmulatorNearFieldExit = 2,
    SmartCardTriggerType_EmulatorHostApplicationActivated = 3,
    SmartCardTriggerType_EmulatorAppletIdGroupRegistrationChanged = 4,
    SmartCardTriggerType_ReaderCardAdded = 5,
}
