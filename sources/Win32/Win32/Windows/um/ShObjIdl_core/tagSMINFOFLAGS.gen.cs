// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum tagSMINFOFLAGS
{
    SMIF_ICON = 0x1,
    SMIF_ACCELERATOR = 0x2,
    SMIF_DROPTARGET = 0x4,
    SMIF_SUBMENU = 0x8,
    SMIF_CHECKED = 0x20,
    SMIF_DROPCASCADE = 0x40,
    SMIF_HIDDEN = 0x80,
    SMIF_DISABLED = 0x100,
    SMIF_TRACKPOPUP = 0x200,
    SMIF_DEMOTED = 0x400,
    SMIF_ALTSTATE = 0x800,
    SMIF_DRAGNDROP = 0x1000,
    SMIF_NEW = 0x2000,
}
