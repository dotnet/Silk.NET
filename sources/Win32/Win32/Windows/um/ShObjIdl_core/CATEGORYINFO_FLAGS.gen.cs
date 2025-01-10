// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum CATEGORYINFO_FLAGS
{
    CATINFO_NORMAL = 0,
    CATINFO_COLLAPSED = 0x1,
    CATINFO_HIDDEN = 0x2,
    CATINFO_EXPANDED = 0x4,
    CATINFO_NOHEADER = 0x8,
    CATINFO_NOTCOLLAPSIBLE = 0x10,
    CATINFO_NOHEADERCOUNT = 0x20,
    CATINFO_SUBSETTED = 0x40,
    CATINFO_SEPARATE_IMAGES = 0x80,
    CATINFO_SHOWEMPTY = 0x100,
}
