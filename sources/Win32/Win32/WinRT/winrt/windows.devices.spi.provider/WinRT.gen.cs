// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.spi.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[60]")]
    public const string InterfaceName_Windows_Devices_Spi_Provider_IProviderSpiConnectionSettings =
        "Windows.Devices.Spi.Provider.IProviderSpiConnectionSettings";

    [NativeTypeName("const WCHAR[67]")]
    public const string InterfaceName_Windows_Devices_Spi_Provider_IProviderSpiConnectionSettingsFactory =
        "Windows.Devices.Spi.Provider.IProviderSpiConnectionSettingsFactory";

    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Devices_Spi_Provider_ISpiControllerProvider =
        "Windows.Devices.Spi.Provider.ISpiControllerProvider";

    [NativeTypeName("const WCHAR[48]")]
    public const string InterfaceName_Windows_Devices_Spi_Provider_ISpiDeviceProvider =
        "Windows.Devices.Spi.Provider.ISpiDeviceProvider";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Devices_Spi_Provider_ISpiProvider =
        "Windows.Devices.Spi.Provider.ISpiProvider";

    [NativeTypeName("const WCHAR[59]")]
    public const string RuntimeClass_Windows_Devices_Spi_Provider_ProviderSpiConnectionSettings =
        "Windows.Devices.Spi.Provider.ProviderSpiConnectionSettings";
}
