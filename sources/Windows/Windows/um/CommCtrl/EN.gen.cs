// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class EN
{
    [NativeTypeName("#define EN_FIRST (0U-1520U)")]
    public const uint EN_FIRST = unchecked(0U - 1520U);
    [NativeTypeName("#define EN_LAST (0U-1540U)")]
    public const uint EN_LAST = unchecked(0U - 1540U);
    [NativeTypeName("#define EN_SEARCHWEB (EN_FIRST - 0)")]
    public const uint EN_SEARCHWEB = unchecked((0U - 1520U) - 0);
}