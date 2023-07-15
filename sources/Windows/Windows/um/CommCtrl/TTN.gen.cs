// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class TTN
{
    [NativeTypeName("#define TTN_FIRST (0U-520U)")]
    public const uint TTN_FIRST = unchecked(0U - 520U);
    [NativeTypeName("#define TTN_LAST (0U-549U)")]
    public const uint TTN_LAST = unchecked(0U - 549U);
    [NativeTypeName("#define TTN_GETDISPINFOA (TTN_FIRST - 0)")]
    public const uint TTN_GETDISPINFOA = unchecked((0U - 520U) - 0);
    [NativeTypeName("#define TTN_GETDISPINFOW (TTN_FIRST - 10)")]
    public const uint TTN_GETDISPINFOW = unchecked((0U - 520U) - 10);
    [NativeTypeName("#define TTN_SHOW (TTN_FIRST - 1)")]
    public const uint TTN_SHOW = unchecked((0U - 520U) - 1);
    [NativeTypeName("#define TTN_POP (TTN_FIRST - 2)")]
    public const uint TTN_POP = unchecked((0U - 520U) - 2);
    [NativeTypeName("#define TTN_LINKCLICK (TTN_FIRST - 3)")]
    public const uint TTN_LINKCLICK = unchecked((0U - 520U) - 3);
    [NativeTypeName("#define TTN_GETDISPINFO TTN_GETDISPINFOW")]
    public const uint TTN_GETDISPINFO = unchecked((0U - 520U) - 10);
    [NativeTypeName("#define TTN_NEEDTEXT TTN_GETDISPINFO")]
    public const uint TTN_NEEDTEXT = unchecked((0U - 520U) - 10);
    [NativeTypeName("#define TTN_NEEDTEXTA TTN_GETDISPINFOA")]
    public const uint TTN_NEEDTEXTA = unchecked((0U - 520U) - 0);
    [NativeTypeName("#define TTN_NEEDTEXTW TTN_GETDISPINFOW")]
    public const uint TTN_NEEDTEXTW = unchecked((0U - 520U) - 10);
}