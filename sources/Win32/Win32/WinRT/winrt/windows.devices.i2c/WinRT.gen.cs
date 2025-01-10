// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.i2c.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Devices_I2c_II2cConnectionSettings =
        "Windows.Devices.I2c.II2cConnectionSettings";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Devices_I2c_II2cConnectionSettingsFactory =
        "Windows.Devices.I2c.II2cConnectionSettingsFactory";

    [NativeTypeName("const WCHAR[35]")]
    public const string InterfaceName_Windows_Devices_I2c_II2cController =
        "Windows.Devices.I2c.II2cController";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Devices_I2c_II2cControllerStatics =
        "Windows.Devices.I2c.II2cControllerStatics";

    [NativeTypeName("const WCHAR[31]")]
    public const string InterfaceName_Windows_Devices_I2c_II2cDevice =
        "Windows.Devices.I2c.II2cDevice";

    [NativeTypeName("const WCHAR[38]")]
    public const string InterfaceName_Windows_Devices_I2c_II2cDeviceStatics =
        "Windows.Devices.I2c.II2cDeviceStatics";

    [NativeTypeName("const WCHAR[42]")]
    public const string RuntimeClass_Windows_Devices_I2c_I2cConnectionSettings =
        "Windows.Devices.I2c.I2cConnectionSettings";

    [NativeTypeName("const WCHAR[34]")]
    public const string RuntimeClass_Windows_Devices_I2c_I2cController =
        "Windows.Devices.I2c.I2cController";

    [NativeTypeName("const WCHAR[30]")]
    public const string RuntimeClass_Windows_Devices_I2c_I2cDevice =
        "Windows.Devices.I2c.I2cDevice";
}
