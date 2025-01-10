// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SVSIF
{
    SVSI_DESELECT = 0,
    SVSI_SELECT = 0x1,
    SVSI_EDIT = 0x3,
    SVSI_DESELECTOTHERS = 0x4,
    SVSI_ENSUREVISIBLE = 0x8,
    SVSI_FOCUSED = 0x10,
    SVSI_TRANSLATEPT = 0x20,
    SVSI_SELECTIONMARK = 0x40,
    SVSI_POSITIONITEM = 0x80,
    SVSI_CHECK = 0x100,
    SVSI_CHECK2 = 0x200,
    SVSI_KEYBOARDSELECT = 0x401,
    SVSI_NOTAKEFOCUS = 0x40000000,
}
