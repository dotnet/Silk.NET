// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum FontStretch
{
    FontStretch_Undefined = 0,
    FontStretch_UltraCondensed = 1,
    FontStretch_ExtraCondensed = 2,
    FontStretch_Condensed = 3,
    FontStretch_SemiCondensed = 4,
    FontStretch_Normal = 5,
    FontStretch_SemiExpanded = 6,
    FontStretch_Expanded = 7,
    FontStretch_ExtraExpanded = 8,
    FontStretch_UltraExpanded = 9,
}
