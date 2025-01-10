// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum FocusPreset
{
    FocusPreset_Auto = 0,
    FocusPreset_Manual = 1,
    FocusPreset_AutoMacro = 2,
    FocusPreset_AutoNormal = 3,
    FocusPreset_AutoInfinity = 4,
    FocusPreset_AutoHyperfocal = 5,
}
