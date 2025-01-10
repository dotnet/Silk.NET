// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum ColorTemperaturePreset
{
    ColorTemperaturePreset_Auto = 0,
    ColorTemperaturePreset_Manual = 1,
    ColorTemperaturePreset_Cloudy = 2,
    ColorTemperaturePreset_Daylight = 3,
    ColorTemperaturePreset_Flash = 4,
    ColorTemperaturePreset_Fluorescent = 5,
    ColorTemperaturePreset_Tungsten = 6,
    ColorTemperaturePreset_Candlelight = 7,
}
