// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.pwm.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Devices_Pwm_Provider_IPwmControllerProvider =
        "Windows.Devices.Pwm.Provider.IPwmControllerProvider";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Devices_Pwm_Provider_IPwmProvider =
        "Windows.Devices.Pwm.Provider.IPwmProvider";
}
