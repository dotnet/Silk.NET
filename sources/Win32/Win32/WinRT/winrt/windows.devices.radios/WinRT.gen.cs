// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.radios.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[30]")]
    public const string InterfaceName_Windows_Devices_Radios_IRadio =
        "Windows.Devices.Radios.IRadio";

    [NativeTypeName("const WCHAR[37]")]
    public const string InterfaceName_Windows_Devices_Radios_IRadioStatics =
        "Windows.Devices.Radios.IRadioStatics";

    [NativeTypeName("const WCHAR[29]")]
    public const string RuntimeClass_Windows_Devices_Radios_Radio = "Windows.Devices.Radios.Radio";
}
