// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Obsolete(
    "IsoSpeedPreset may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead"
)]
public enum IsoSpeedPreset
{
    IsoSpeedPreset_Auto = 0,
    IsoSpeedPreset_Iso50 = 1,
    IsoSpeedPreset_Iso80 = 2,
    IsoSpeedPreset_Iso100 = 3,
    IsoSpeedPreset_Iso200 = 4,
    IsoSpeedPreset_Iso400 = 5,
    IsoSpeedPreset_Iso800 = 6,
    IsoSpeedPreset_Iso1600 = 7,
    IsoSpeedPreset_Iso3200 = 8,
    IsoSpeedPreset_Iso6400 = 9,
    IsoSpeedPreset_Iso12800 = 10,
    IsoSpeedPreset_Iso25600 = 11,
}
