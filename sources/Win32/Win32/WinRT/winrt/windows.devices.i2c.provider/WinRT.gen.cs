// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.i2c.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Devices_I2c_Provider_II2cControllerProvider =
        "Windows.Devices.I2c.Provider.II2cControllerProvider";

    [NativeTypeName("const WCHAR[48]")]
    public const string InterfaceName_Windows_Devices_I2c_Provider_II2cDeviceProvider =
        "Windows.Devices.I2c.Provider.II2cDeviceProvider";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Devices_I2c_Provider_II2cProvider =
        "Windows.Devices.I2c.Provider.II2cProvider";

    [NativeTypeName("const WCHAR[60]")]
    public const string InterfaceName_Windows_Devices_I2c_Provider_IProviderI2cConnectionSettings =
        "Windows.Devices.I2c.Provider.IProviderI2cConnectionSettings";

    [NativeTypeName("const WCHAR[59]")]
    public const string RuntimeClass_Windows_Devices_I2c_Provider_ProviderI2cConnectionSettings =
        "Windows.Devices.I2c.Provider.ProviderI2cConnectionSettings";
}
