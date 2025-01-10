// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum GROUPHEADERLINESTATES
{
    LVGHL_OPEN = 1,
    LVGHL_OPENHOT = 2,
    LVGHL_OPENSELECTED = 3,
    LVGHL_OPENSELECTEDHOT = 4,
    LVGHL_OPENSELECTEDNOTFOCUSED = 5,
    LVGHL_OPENSELECTEDNOTFOCUSEDHOT = 6,
    LVGHL_OPENMIXEDSELECTION = 7,
    LVGHL_OPENMIXEDSELECTIONHOT = 8,
    LVGHL_CLOSE = 9,
    LVGHL_CLOSEHOT = 10,
    LVGHL_CLOSESELECTED = 11,
    LVGHL_CLOSESELECTEDHOT = 12,
    LVGHL_CLOSESELECTEDNOTFOCUSED = 13,
    LVGHL_CLOSESELECTEDNOTFOCUSEDHOT = 14,
    LVGHL_CLOSEMIXEDSELECTION = 15,
    LVGHL_CLOSEMIXEDSELECTIONHOT = 16,
}
