// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[70]")]
    public const string InterfaceName_Windows_Devices_Haptics_IKnownSimpleHapticsControllerWaveformsStatics =
        "Windows.Devices.Haptics.IKnownSimpleHapticsControllerWaveformsStatics";

    [NativeTypeName("const WCHAR[71]")]
    public const string InterfaceName_Windows_Devices_Haptics_IKnownSimpleHapticsControllerWaveformsStatics2 =
        "Windows.Devices.Haptics.IKnownSimpleHapticsControllerWaveformsStatics2";

    [NativeTypeName("const WCHAR[49]")]
    public const string InterfaceName_Windows_Devices_Haptics_ISimpleHapticsController =
        "Windows.Devices.Haptics.ISimpleHapticsController";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_Devices_Haptics_ISimpleHapticsControllerFeedback =
        "Windows.Devices.Haptics.ISimpleHapticsControllerFeedback";

    [NativeTypeName("const WCHAR[41]")]
    public const string InterfaceName_Windows_Devices_Haptics_IVibrationDevice =
        "Windows.Devices.Haptics.IVibrationDevice";

    [NativeTypeName("const WCHAR[48]")]
    public const string InterfaceName_Windows_Devices_Haptics_IVibrationDeviceStatics =
        "Windows.Devices.Haptics.IVibrationDeviceStatics";

    [NativeTypeName("const WCHAR[62]")]
    public const string RuntimeClass_Windows_Devices_Haptics_KnownSimpleHapticsControllerWaveforms =
        "Windows.Devices.Haptics.KnownSimpleHapticsControllerWaveforms";

    [NativeTypeName("const WCHAR[48]")]
    public const string RuntimeClass_Windows_Devices_Haptics_SimpleHapticsController =
        "Windows.Devices.Haptics.SimpleHapticsController";

    [NativeTypeName("const WCHAR[56]")]
    public const string RuntimeClass_Windows_Devices_Haptics_SimpleHapticsControllerFeedback =
        "Windows.Devices.Haptics.SimpleHapticsControllerFeedback";

    [NativeTypeName("const WCHAR[40]")]
    public const string RuntimeClass_Windows_Devices_Haptics_VibrationDevice =
        "Windows.Devices.Haptics.VibrationDevice";
}
