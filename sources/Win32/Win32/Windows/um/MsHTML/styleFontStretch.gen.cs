// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum styleFontStretch
{
    styleFontStretchNotSet = 0,
    styleFontStretchWider = 1,
    styleFontStretchNarrower = 2,
    styleFontStretchUltraCondensed = 3,
    styleFontStretchExtraCondensed = 4,
    styleFontStretchCondensed = 5,
    styleFontStretchSemiCondensed = 6,
    styleFontStretchNormal = 7,
    styleFontStretchSemiExpanded = 8,
    styleFontStretchExpanded = 9,
    styleFontStretchExtraExpanded = 10,
    styleFontStretchUltraExpanded = 11,
    styleFontStretch_Max = 2147483647,
}
