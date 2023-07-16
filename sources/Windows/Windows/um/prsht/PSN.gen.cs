// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/prsht.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class PSN
{
    [NativeTypeName("#define PSN_FIRST (0U-200U)")]
    public const uint PSN_FIRST = unchecked(0U - 200U);
    [NativeTypeName("#define PSN_LAST (0U-299U)")]
    public const uint PSN_LAST = unchecked(0U - 299U);
    [NativeTypeName("#define PSN_SETACTIVE (PSN_FIRST-0)")]
    public const uint PSN_SETACTIVE = unchecked((0U - 200U) - 0);
    [NativeTypeName("#define PSN_KILLACTIVE (PSN_FIRST-1)")]
    public const uint PSN_KILLACTIVE = unchecked((0U - 200U) - 1);
    [NativeTypeName("#define PSN_APPLY (PSN_FIRST-2)")]
    public const uint PSN_APPLY = unchecked((0U - 200U) - 2);
    [NativeTypeName("#define PSN_RESET (PSN_FIRST-3)")]
    public const uint PSN_RESET = unchecked((0U - 200U) - 3);
    [NativeTypeName("#define PSN_HELP (PSN_FIRST-5)")]
    public const uint PSN_HELP = unchecked((0U - 200U) - 5);
    [NativeTypeName("#define PSN_WIZBACK (PSN_FIRST-6)")]
    public const uint PSN_WIZBACK = unchecked((0U - 200U) - 6);
    [NativeTypeName("#define PSN_WIZNEXT (PSN_FIRST-7)")]
    public const uint PSN_WIZNEXT = unchecked((0U - 200U) - 7);
    [NativeTypeName("#define PSN_WIZFINISH (PSN_FIRST-8)")]
    public const uint PSN_WIZFINISH = unchecked((0U - 200U) - 8);
    [NativeTypeName("#define PSN_QUERYCANCEL (PSN_FIRST-9)")]
    public const uint PSN_QUERYCANCEL = unchecked((0U - 200U) - 9);
    [NativeTypeName("#define PSN_GETOBJECT (PSN_FIRST-10)")]
    public const uint PSN_GETOBJECT = unchecked((0U - 200U) - 10);
    [NativeTypeName("#define PSN_TRANSLATEACCELERATOR (PSN_FIRST-12)")]
    public const uint PSN_TRANSLATEACCELERATOR = unchecked((0U - 200U) - 12);
    [NativeTypeName("#define PSN_QUERYINITIALFOCUS (PSN_FIRST-13)")]
    public const uint PSN_QUERYINITIALFOCUS = unchecked((0U - 200U) - 13);
}