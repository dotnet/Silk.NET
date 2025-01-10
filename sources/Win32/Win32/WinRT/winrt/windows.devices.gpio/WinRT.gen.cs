// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[40]")]
    public const string InterfaceName_Windows_Devices_Gpio_IGpioChangeCounter =
        "Windows.Devices.Gpio.IGpioChangeCounter";

    [NativeTypeName("const WCHAR[47]")]
    public const string InterfaceName_Windows_Devices_Gpio_IGpioChangeCounterFactory =
        "Windows.Devices.Gpio.IGpioChangeCounterFactory";

    [NativeTypeName("const WCHAR[39]")]
    public const string InterfaceName_Windows_Devices_Gpio_IGpioChangeReader =
        "Windows.Devices.Gpio.IGpioChangeReader";

    [NativeTypeName("const WCHAR[46]")]
    public const string InterfaceName_Windows_Devices_Gpio_IGpioChangeReaderFactory =
        "Windows.Devices.Gpio.IGpioChangeReaderFactory";

    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Devices_Gpio_IGpioController =
        "Windows.Devices.Gpio.IGpioController";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_Devices_Gpio_IGpioControllerStatics =
        "Windows.Devices.Gpio.IGpioControllerStatics";

    [NativeTypeName("const WCHAR[45]")]
    public const string InterfaceName_Windows_Devices_Gpio_IGpioControllerStatics2 =
        "Windows.Devices.Gpio.IGpioControllerStatics2";

    [NativeTypeName("const WCHAR[30]")]
    public const string InterfaceName_Windows_Devices_Gpio_IGpioPin =
        "Windows.Devices.Gpio.IGpioPin";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Devices_Gpio_IGpioPinValueChangedEventArgs =
        "Windows.Devices.Gpio.IGpioPinValueChangedEventArgs";

    [NativeTypeName("const WCHAR[39]")]
    public const string RuntimeClass_Windows_Devices_Gpio_GpioChangeCounter =
        "Windows.Devices.Gpio.GpioChangeCounter";

    [NativeTypeName("const WCHAR[38]")]
    public const string RuntimeClass_Windows_Devices_Gpio_GpioChangeReader =
        "Windows.Devices.Gpio.GpioChangeReader";

    [NativeTypeName("const WCHAR[36]")]
    public const string RuntimeClass_Windows_Devices_Gpio_GpioController =
        "Windows.Devices.Gpio.GpioController";

    [NativeTypeName("const WCHAR[29]")]
    public const string RuntimeClass_Windows_Devices_Gpio_GpioPin = "Windows.Devices.Gpio.GpioPin";

    [NativeTypeName("const WCHAR[50]")]
    public const string RuntimeClass_Windows_Devices_Gpio_GpioPinValueChangedEventArgs =
        "Windows.Devices.Gpio.GpioPinValueChangedEventArgs";
}
