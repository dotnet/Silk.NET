// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum GpioPinDriveMode
{
    GpioPinDriveMode_Input = 0,
    GpioPinDriveMode_Output = 1,
    GpioPinDriveMode_InputPullUp = 2,
    GpioPinDriveMode_InputPullDown = 3,
    GpioPinDriveMode_OutputOpenDrain = 4,
    GpioPinDriveMode_OutputOpenDrainPullUp = 5,
    GpioPinDriveMode_OutputOpenSource = 6,
    GpioPinDriveMode_OutputOpenSourcePullDown = 7,
}
