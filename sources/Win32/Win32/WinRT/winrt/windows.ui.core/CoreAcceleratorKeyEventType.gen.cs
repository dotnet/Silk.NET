// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum CoreAcceleratorKeyEventType
{
    CoreAcceleratorKeyEventType_Character = 2,
    CoreAcceleratorKeyEventType_DeadCharacter = 3,
    CoreAcceleratorKeyEventType_KeyDown = 0,
    CoreAcceleratorKeyEventType_KeyUp = 1,
    CoreAcceleratorKeyEventType_SystemCharacter = 6,
    CoreAcceleratorKeyEventType_SystemDeadCharacter = 7,
    CoreAcceleratorKeyEventType_SystemKeyDown = 4,
    CoreAcceleratorKeyEventType_SystemKeyUp = 5,
    CoreAcceleratorKeyEventType_UnicodeCharacter = 8,
}
