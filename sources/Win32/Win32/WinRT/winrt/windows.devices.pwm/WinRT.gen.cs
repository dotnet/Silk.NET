// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.pwm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[35]")]
    public const string InterfaceName_Windows_Devices_Pwm_IPwmController =
        "Windows.Devices.Pwm.IPwmController";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Devices_Pwm_IPwmControllerStatics =
        "Windows.Devices.Pwm.IPwmControllerStatics";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Devices_Pwm_IPwmControllerStatics2 =
        "Windows.Devices.Pwm.IPwmControllerStatics2";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_Devices_Pwm_IPwmControllerStatics3 =
        "Windows.Devices.Pwm.IPwmControllerStatics3";

    [NativeTypeName("const WCHAR[28]")]
    public const string InterfaceName_Windows_Devices_Pwm_IPwmPin = "Windows.Devices.Pwm.IPwmPin";

    [NativeTypeName("const WCHAR[34]")]
    public const string RuntimeClass_Windows_Devices_Pwm_PwmController =
        "Windows.Devices.Pwm.PwmController";

    [NativeTypeName("const WCHAR[27]")]
    public const string RuntimeClass_Windows_Devices_Pwm_PwmPin = "Windows.Devices.Pwm.PwmPin";
}
