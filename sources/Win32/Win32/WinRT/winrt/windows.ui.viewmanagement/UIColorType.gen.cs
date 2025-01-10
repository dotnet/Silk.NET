// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum UIColorType
{
    UIColorType_Background = 0,
    UIColorType_Foreground = 1,
    UIColorType_AccentDark3 = 2,
    UIColorType_AccentDark2 = 3,
    UIColorType_AccentDark1 = 4,
    UIColorType_Accent = 5,
    UIColorType_AccentLight1 = 6,
    UIColorType_AccentLight2 = 7,
    UIColorType_AccentLight3 = 8,
    UIColorType_Complement = 9,
}
