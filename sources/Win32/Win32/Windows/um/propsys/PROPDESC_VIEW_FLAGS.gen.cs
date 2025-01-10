// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum PROPDESC_VIEW_FLAGS
{
    PDVF_DEFAULT = 0,
    PDVF_CENTERALIGN = 0x1,
    PDVF_RIGHTALIGN = 0x2,
    PDVF_BEGINNEWGROUP = 0x4,
    PDVF_FILLAREA = 0x8,
    PDVF_SORTDESCENDING = 0x10,
    PDVF_SHOWONLYIFPRESENT = 0x20,
    PDVF_SHOWBYDEFAULT = 0x40,
    PDVF_SHOWINPRIMARYLIST = 0x80,
    PDVF_SHOWINSECONDARYLIST = 0x100,
    PDVF_HIDELABEL = 0x200,
    PDVF_HIDDEN = 0x800,
    PDVF_CANWRAP = 0x1000,
    PDVF_MASK_ALL = 0x1bff,
}
