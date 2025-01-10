// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.power.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[53]")]
    public const string InterfaceName_Windows_System_Power_IBackgroundEnergyManagerStatics =
        "Windows.System.Power.IBackgroundEnergyManagerStatics";

    [NativeTypeName("const WCHAR[53]")]
    public const string InterfaceName_Windows_System_Power_IForegroundEnergyManagerStatics =
        "Windows.System.Power.IForegroundEnergyManagerStatics";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_System_Power_IPowerManagerStatics =
        "Windows.System.Power.IPowerManagerStatics";

    [NativeTypeName("const WCHAR[45]")]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public const string RuntimeClass_Windows_System_Power_BackgroundEnergyManager =
        "Windows.System.Power.BackgroundEnergyManager";

    [NativeTypeName("const WCHAR[45]")]
    [Obsolete("Foreground Energy Manager has been deprecated. For more info, see MSDN.")]
    public const string RuntimeClass_Windows_System_Power_ForegroundEnergyManager =
        "Windows.System.Power.ForegroundEnergyManager";

    [NativeTypeName("const WCHAR[34]")]
    public const string RuntimeClass_Windows_System_Power_PowerManager =
        "Windows.System.Power.PowerManager";
}
