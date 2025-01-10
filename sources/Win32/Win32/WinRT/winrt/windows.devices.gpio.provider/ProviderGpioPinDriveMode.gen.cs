// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.gpio.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum ProviderGpioPinDriveMode
{
    ProviderGpioPinDriveMode_Input = 0,
    ProviderGpioPinDriveMode_Output = 1,
    ProviderGpioPinDriveMode_InputPullUp = 2,
    ProviderGpioPinDriveMode_InputPullDown = 3,
    ProviderGpioPinDriveMode_OutputOpenDrain = 4,
    ProviderGpioPinDriveMode_OutputOpenDrainPullUp = 5,
    ProviderGpioPinDriveMode_OutputOpenSource = 6,
    ProviderGpioPinDriveMode_OutputOpenSourcePullDown = 7,
}
