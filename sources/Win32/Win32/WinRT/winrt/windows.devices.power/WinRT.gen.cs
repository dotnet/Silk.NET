// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.power.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[31]")]
    public const string InterfaceName_Windows_Devices_Power_IBattery =
        "Windows.Devices.Power.IBattery";

    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Devices_Power_IBatteryReport =
        "Windows.Devices.Power.IBatteryReport";

    [NativeTypeName("const WCHAR[38]")]
    public const string InterfaceName_Windows_Devices_Power_IBatteryStatics =
        "Windows.Devices.Power.IBatteryStatics";

    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Devices_Power_IPowerGridData =
        "Windows.Devices.Power.IPowerGridData";

    [NativeTypeName("const WCHAR[41]")]
    public const string InterfaceName_Windows_Devices_Power_IPowerGridForecast =
        "Windows.Devices.Power.IPowerGridForecast";

    [NativeTypeName("const WCHAR[48]")]
    public const string InterfaceName_Windows_Devices_Power_IPowerGridForecastStatics =
        "Windows.Devices.Power.IPowerGridForecastStatics";

    [NativeTypeName("const WCHAR[30]")]
    public const string RuntimeClass_Windows_Devices_Power_Battery =
        "Windows.Devices.Power.Battery";

    [NativeTypeName("const WCHAR[36]")]
    public const string RuntimeClass_Windows_Devices_Power_BatteryReport =
        "Windows.Devices.Power.BatteryReport";

    [NativeTypeName("const WCHAR[36]")]
    public const string RuntimeClass_Windows_Devices_Power_PowerGridData =
        "Windows.Devices.Power.PowerGridData";

    [NativeTypeName("const WCHAR[40]")]
    public const string RuntimeClass_Windows_Devices_Power_PowerGridForecast =
        "Windows.Devices.Power.PowerGridForecast";

    [NativeTypeName("#define WINDOWS_DEVICES_POWER_POWERGRIDAPICONTRACT_VERSION 0x10000")]
    public const int WINDOWS_DEVICES_POWER_POWERGRIDAPICONTRACT_VERSION = 0x10000;
}
