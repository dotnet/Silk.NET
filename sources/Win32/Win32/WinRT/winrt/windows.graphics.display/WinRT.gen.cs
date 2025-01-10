// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_Graphics_Display_IAdvancedColorInfo =
        "Windows.Graphics.Display.IAdvancedColorInfo";

    [NativeTypeName("const WCHAR[45]")]
    public const string InterfaceName_Windows_Graphics_Display_IBrightnessOverride =
        "Windows.Graphics.Display.IBrightnessOverride";

    [NativeTypeName("const WCHAR[53]")]
    public const string InterfaceName_Windows_Graphics_Display_IBrightnessOverrideSettings =
        "Windows.Graphics.Display.IBrightnessOverrideSettings";

    [NativeTypeName("const WCHAR[60]")]
    public const string InterfaceName_Windows_Graphics_Display_IBrightnessOverrideSettingsStatics =
        "Windows.Graphics.Display.IBrightnessOverrideSettingsStatics";

    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Graphics_Display_IBrightnessOverrideStatics =
        "Windows.Graphics.Display.IBrightnessOverrideStatics";

    [NativeTypeName("const WCHAR[48]")]
    public const string InterfaceName_Windows_Graphics_Display_IColorOverrideSettings =
        "Windows.Graphics.Display.IColorOverrideSettings";

    [NativeTypeName("const WCHAR[55]")]
    public const string InterfaceName_Windows_Graphics_Display_IColorOverrideSettingsStatics =
        "Windows.Graphics.Display.IColorOverrideSettingsStatics";

    [NativeTypeName("const WCHAR[53]")]
    public const string InterfaceName_Windows_Graphics_Display_IDisplayEnhancementOverride =
        "Windows.Graphics.Display.IDisplayEnhancementOverride";

    [NativeTypeName("const WCHAR[65]")]
    public const string InterfaceName_Windows_Graphics_Display_IDisplayEnhancementOverrideCapabilities =
        "Windows.Graphics.Display.IDisplayEnhancementOverrideCapabilities";

    [NativeTypeName("const WCHAR[81]")]
    public const string InterfaceName_Windows_Graphics_Display_IDisplayEnhancementOverrideCapabilitiesChangedEventArgs =
        "Windows.Graphics.Display.IDisplayEnhancementOverrideCapabilitiesChangedEventArgs";

    [NativeTypeName("const WCHAR[60]")]
    public const string InterfaceName_Windows_Graphics_Display_IDisplayEnhancementOverrideStatics =
        "Windows.Graphics.Display.IDisplayEnhancementOverrideStatics";

    [NativeTypeName("const WCHAR[45]")]
    public const string InterfaceName_Windows_Graphics_Display_IDisplayInformation =
        "Windows.Graphics.Display.IDisplayInformation";

    [NativeTypeName("const WCHAR[46]")]
    public const string InterfaceName_Windows_Graphics_Display_IDisplayInformation2 =
        "Windows.Graphics.Display.IDisplayInformation2";

    [NativeTypeName("const WCHAR[46]")]
    public const string InterfaceName_Windows_Graphics_Display_IDisplayInformation3 =
        "Windows.Graphics.Display.IDisplayInformation3";

    [NativeTypeName("const WCHAR[46]")]
    public const string InterfaceName_Windows_Graphics_Display_IDisplayInformation4 =
        "Windows.Graphics.Display.IDisplayInformation4";

    [NativeTypeName("const WCHAR[46]")]
    public const string InterfaceName_Windows_Graphics_Display_IDisplayInformation5 =
        "Windows.Graphics.Display.IDisplayInformation5";

    [NativeTypeName("const WCHAR[52]")]
    public const string InterfaceName_Windows_Graphics_Display_IDisplayInformationStatics =
        "Windows.Graphics.Display.IDisplayInformationStatics";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_Graphics_Display_IDisplayPropertiesStatics =
        "Windows.Graphics.Display.IDisplayPropertiesStatics";

    [NativeTypeName("const WCHAR[42]")]
    public const string InterfaceName_Windows_Graphics_Display_IDisplayServices =
        "Windows.Graphics.Display.IDisplayServices";

    [NativeTypeName("const WCHAR[49]")]
    public const string InterfaceName_Windows_Graphics_Display_IDisplayServicesStatics =
        "Windows.Graphics.Display.IDisplayServicesStatics";

    [NativeTypeName("const WCHAR[43]")]
    public const string RuntimeClass_Windows_Graphics_Display_AdvancedColorInfo =
        "Windows.Graphics.Display.AdvancedColorInfo";

    [NativeTypeName("const WCHAR[44]")]
    public const string RuntimeClass_Windows_Graphics_Display_BrightnessOverride =
        "Windows.Graphics.Display.BrightnessOverride";

    [NativeTypeName("const WCHAR[52]")]
    public const string RuntimeClass_Windows_Graphics_Display_BrightnessOverrideSettings =
        "Windows.Graphics.Display.BrightnessOverrideSettings";

    [NativeTypeName("const WCHAR[47]")]
    public const string RuntimeClass_Windows_Graphics_Display_ColorOverrideSettings =
        "Windows.Graphics.Display.ColorOverrideSettings";

    [NativeTypeName("const WCHAR[52]")]
    public const string RuntimeClass_Windows_Graphics_Display_DisplayEnhancementOverride =
        "Windows.Graphics.Display.DisplayEnhancementOverride";

    [NativeTypeName("const WCHAR[64]")]
    public const string RuntimeClass_Windows_Graphics_Display_DisplayEnhancementOverrideCapabilities =
        "Windows.Graphics.Display.DisplayEnhancementOverrideCapabilities";

    [NativeTypeName("const WCHAR[80]")]
    public const string RuntimeClass_Windows_Graphics_Display_DisplayEnhancementOverrideCapabilitiesChangedEventArgs =
        "Windows.Graphics.Display.DisplayEnhancementOverrideCapabilitiesChangedEventArgs";

    [NativeTypeName("const WCHAR[44]")]
    public const string RuntimeClass_Windows_Graphics_Display_DisplayInformation =
        "Windows.Graphics.Display.DisplayInformation";

    [NativeTypeName("const WCHAR[43]")]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public const string RuntimeClass_Windows_Graphics_Display_DisplayProperties =
        "Windows.Graphics.Display.DisplayProperties";

    [NativeTypeName("const WCHAR[41]")]
    public const string RuntimeClass_Windows_Graphics_Display_DisplayServices =
        "Windows.Graphics.Display.DisplayServices";
}
