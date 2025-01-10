// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Devices_ILowLevelDevicesAggregateProvider =
        "Windows.Devices.ILowLevelDevicesAggregateProvider";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Devices_ILowLevelDevicesAggregateProviderFactory =
        "Windows.Devices.ILowLevelDevicesAggregateProviderFactory";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Devices_ILowLevelDevicesController =
        "Windows.Devices.ILowLevelDevicesController";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_Devices_ILowLevelDevicesControllerStatics =
        "Windows.Devices.ILowLevelDevicesControllerStatics";

    [NativeTypeName("const WCHAR[49]")]
    public const string RuntimeClass_Windows_Devices_LowLevelDevicesAggregateProvider =
        "Windows.Devices.LowLevelDevicesAggregateProvider";

    [NativeTypeName("const WCHAR[42]")]
    public const string RuntimeClass_Windows_Devices_LowLevelDevicesController =
        "Windows.Devices.LowLevelDevicesController";

    [NativeTypeName("#define WINDOWS_DEVICES_DEVICESLOWLEVELCONTRACT_VERSION 0x30000")]
    public const int WINDOWS_DEVICES_DEVICESLOWLEVELCONTRACT_VERSION = 0x30000;
}
