// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum HLFNAMEF
{
    HLFNAMEF_DEFAULT = 0,
    HLFNAMEF_TRYCACHE = 0x1,
    HLFNAMEF_TRYPRETTYTARGET = 0x2,
    HLFNAMEF_TRYFULLTARGET = 0x4,
    HLFNAMEF_TRYWIN95SHORTCUT = 0x8,
}
