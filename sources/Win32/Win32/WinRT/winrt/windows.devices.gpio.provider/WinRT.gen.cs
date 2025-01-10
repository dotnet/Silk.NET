// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.gpio.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_Devices_Gpio_Provider_IGpioControllerProvider =
        "Windows.Devices.Gpio.Provider.IGpioControllerProvider";

    [NativeTypeName("const WCHAR[47]")]
    public const string InterfaceName_Windows_Devices_Gpio_Provider_IGpioPinProvider =
        "Windows.Devices.Gpio.Provider.IGpioPinProvider";

    [NativeTypeName("const WCHAR[68]")]
    public const string InterfaceName_Windows_Devices_Gpio_Provider_IGpioPinProviderValueChangedEventArgs =
        "Windows.Devices.Gpio.Provider.IGpioPinProviderValueChangedEventArgs";

    [NativeTypeName("const WCHAR[75]")]
    public const string InterfaceName_Windows_Devices_Gpio_Provider_IGpioPinProviderValueChangedEventArgsFactory =
        "Windows.Devices.Gpio.Provider.IGpioPinProviderValueChangedEventArgsFactory";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_Devices_Gpio_Provider_IGpioProvider =
        "Windows.Devices.Gpio.Provider.IGpioProvider";

    [NativeTypeName("const WCHAR[67]")]
    public const string RuntimeClass_Windows_Devices_Gpio_Provider_GpioPinProviderValueChangedEventArgs =
        "Windows.Devices.Gpio.Provider.GpioPinProviderValueChangedEventArgs";
}
