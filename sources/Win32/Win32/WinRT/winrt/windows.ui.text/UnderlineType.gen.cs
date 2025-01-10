// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum UnderlineType
{
    UnderlineType_Undefined = 0,
    UnderlineType_None = 1,
    UnderlineType_Single = 2,
    UnderlineType_Words = 3,
    UnderlineType_Double = 4,
    UnderlineType_Dotted = 5,
    UnderlineType_Dash = 6,
    UnderlineType_DashDot = 7,
    UnderlineType_DashDotDot = 8,
    UnderlineType_Wave = 9,
    UnderlineType_Thick = 10,
    UnderlineType_Thin = 11,
    UnderlineType_DoubleWave = 12,
    UnderlineType_HeavyWave = 13,
    UnderlineType_LongDash = 14,
    UnderlineType_ThickDash = 15,
    UnderlineType_ThickDashDot = 16,
    UnderlineType_ThickDashDotDot = 17,
    UnderlineType_ThickDotted = 18,
    UnderlineType_ThickLongDash = 19,
}
