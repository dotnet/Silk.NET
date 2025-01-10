// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum tagMENUPOPUPPOPUPFLAGS
{
    MPPF_SETFOCUS = 0x1,
    MPPF_INITIALSELECT = 0x2,
    MPPF_NOANIMATE = 0x4,
    MPPF_KEYBOARD = 0x10,
    MPPF_REPOSITION = 0x20,
    MPPF_FORCEZORDER = 0x40,
    MPPF_FINALSELECT = 0x80,
    MPPF_TOP = 0x20000000,
    MPPF_LEFT = 0x40000000,
    MPPF_RIGHT = 0x60000000,
    MPPF_BOTTOM = unchecked((int)(0x80000000)),
    MPPF_POS_MASK = unchecked((int)(0xe0000000)),
    MPPF_ALIGN_LEFT = 0x2000000,
    MPPF_ALIGN_RIGHT = 0x4000000,
}
