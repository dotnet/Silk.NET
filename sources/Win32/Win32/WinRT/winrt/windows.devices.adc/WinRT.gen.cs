// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.adc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[32]")]
    public const string InterfaceName_Windows_Devices_Adc_IAdcChannel =
        "Windows.Devices.Adc.IAdcChannel";

    [NativeTypeName("const WCHAR[35]")]
    public const string InterfaceName_Windows_Devices_Adc_IAdcController =
        "Windows.Devices.Adc.IAdcController";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Devices_Adc_IAdcControllerStatics =
        "Windows.Devices.Adc.IAdcControllerStatics";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Devices_Adc_IAdcControllerStatics2 =
        "Windows.Devices.Adc.IAdcControllerStatics2";

    [NativeTypeName("const WCHAR[31]")]
    public const string RuntimeClass_Windows_Devices_Adc_AdcChannel =
        "Windows.Devices.Adc.AdcChannel";

    [NativeTypeName("const WCHAR[34]")]
    public const string RuntimeClass_Windows_Devices_Adc_AdcController =
        "Windows.Devices.Adc.AdcController";
}
