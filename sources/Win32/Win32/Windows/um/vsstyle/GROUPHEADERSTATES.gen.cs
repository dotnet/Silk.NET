// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum GROUPHEADERSTATES
{
    LVGH_OPEN = 1,
    LVGH_OPENHOT = 2,
    LVGH_OPENSELECTED = 3,
    LVGH_OPENSELECTEDHOT = 4,
    LVGH_OPENSELECTEDNOTFOCUSED = 5,
    LVGH_OPENSELECTEDNOTFOCUSEDHOT = 6,
    LVGH_OPENMIXEDSELECTION = 7,
    LVGH_OPENMIXEDSELECTIONHOT = 8,
    LVGH_CLOSE = 9,
    LVGH_CLOSEHOT = 10,
    LVGH_CLOSESELECTED = 11,
    LVGH_CLOSESELECTEDHOT = 12,
    LVGH_CLOSESELECTEDNOTFOCUSED = 13,
    LVGH_CLOSESELECTEDNOTFOCUSEDHOT = 14,
    LVGH_CLOSEMIXEDSELECTION = 15,
    LVGH_CLOSEMIXEDSELECTIONHOT = 16,
}
