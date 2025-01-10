// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.spi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[32]")]
    public const string InterfaceName_Windows_Devices_Spi_ISpiBusInfo =
        "Windows.Devices.Spi.ISpiBusInfo";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Devices_Spi_ISpiConnectionSettings =
        "Windows.Devices.Spi.ISpiConnectionSettings";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Devices_Spi_ISpiConnectionSettingsFactory =
        "Windows.Devices.Spi.ISpiConnectionSettingsFactory";

    [NativeTypeName("const WCHAR[35]")]
    public const string InterfaceName_Windows_Devices_Spi_ISpiController =
        "Windows.Devices.Spi.ISpiController";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Devices_Spi_ISpiControllerStatics =
        "Windows.Devices.Spi.ISpiControllerStatics";

    [NativeTypeName("const WCHAR[31]")]
    public const string InterfaceName_Windows_Devices_Spi_ISpiDevice =
        "Windows.Devices.Spi.ISpiDevice";

    [NativeTypeName("const WCHAR[38]")]
    public const string InterfaceName_Windows_Devices_Spi_ISpiDeviceStatics =
        "Windows.Devices.Spi.ISpiDeviceStatics";

    [NativeTypeName("const WCHAR[31]")]
    public const string RuntimeClass_Windows_Devices_Spi_SpiBusInfo =
        "Windows.Devices.Spi.SpiBusInfo";

    [NativeTypeName("const WCHAR[42]")]
    public const string RuntimeClass_Windows_Devices_Spi_SpiConnectionSettings =
        "Windows.Devices.Spi.SpiConnectionSettings";

    [NativeTypeName("const WCHAR[34]")]
    public const string RuntimeClass_Windows_Devices_Spi_SpiController =
        "Windows.Devices.Spi.SpiController";

    [NativeTypeName("const WCHAR[30]")]
    public const string RuntimeClass_Windows_Devices_Spi_SpiDevice =
        "Windows.Devices.Spi.SpiDevice";
}
