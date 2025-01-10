// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/tlogstg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum tagTLENUMF
{
    TLEF_RELATIVE_INCLUDE_CURRENT = 0x1,
    TLEF_RELATIVE_BACK = 0x10,
    TLEF_RELATIVE_FORE = 0x20,
    TLEF_INCLUDE_UNINVOKEABLE = 0x40,
    TLEF_ABSOLUTE = 0x31,
    TLEF_EXCLUDE_SUBFRAME_ENTRIES = 0x80,
    TLEF_EXCLUDE_ABOUT_PAGES = 0x100,
}
