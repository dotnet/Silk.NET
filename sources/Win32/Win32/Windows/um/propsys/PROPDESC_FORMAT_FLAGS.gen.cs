// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum PROPDESC_FORMAT_FLAGS
{
    PDFF_DEFAULT = 0,
    PDFF_PREFIXNAME = 0x1,
    PDFF_FILENAME = 0x2,
    PDFF_ALWAYSKB = 0x4,
    PDFF_RESERVED_RIGHTTOLEFT = 0x8,
    PDFF_SHORTTIME = 0x10,
    PDFF_LONGTIME = 0x20,
    PDFF_HIDETIME = 0x40,
    PDFF_SHORTDATE = 0x80,
    PDFF_LONGDATE = 0x100,
    PDFF_HIDEDATE = 0x200,
    PDFF_RELATIVEDATE = 0x400,
    PDFF_USEEDITINVITATION = 0x800,
    PDFF_READONLY = 0x1000,
    PDFF_NOAUTOREADINGORDER = 0x2000,
}
