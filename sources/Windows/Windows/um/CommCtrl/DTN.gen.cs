// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class DTN
{
    [NativeTypeName("#define DTN_FIRST (0U-740U)")]
    public const uint DTN_FIRST = unchecked(0U - 740U);
    [NativeTypeName("#define DTN_LAST (0U-745U)")]
    public const uint DTN_LAST = unchecked(0U - 745U);
    [NativeTypeName("#define DTN_FIRST2 (0U-753U)")]
    public const uint DTN_FIRST2 = unchecked(0U - 753U);
    [NativeTypeName("#define DTN_LAST2 (0U-799U)")]
    public const uint DTN_LAST2 = unchecked(0U - 799U);
    [NativeTypeName("#define DTN_DATETIMECHANGE (DTN_FIRST2 - 6)")]
    public const uint DTN_DATETIMECHANGE = unchecked((0U - 753U) - 6);
    [NativeTypeName("#define DTN_USERSTRINGA (DTN_FIRST2 - 5)")]
    public const uint DTN_USERSTRINGA = unchecked((0U - 753U) - 5);
    [NativeTypeName("#define DTN_USERSTRINGW (DTN_FIRST - 5)")]
    public const uint DTN_USERSTRINGW = unchecked((0U - 740U) - 5);
    [NativeTypeName("#define DTN_USERSTRING DTN_USERSTRINGW")]
    public const uint DTN_USERSTRING = unchecked((0U - 740U) - 5);
    [NativeTypeName("#define DTN_WMKEYDOWNA (DTN_FIRST2 - 4)")]
    public const uint DTN_WMKEYDOWNA = unchecked((0U - 753U) - 4);
    [NativeTypeName("#define DTN_WMKEYDOWNW (DTN_FIRST - 4)")]
    public const uint DTN_WMKEYDOWNW = unchecked((0U - 740U) - 4);
    [NativeTypeName("#define DTN_WMKEYDOWN DTN_WMKEYDOWNW")]
    public const uint DTN_WMKEYDOWN = unchecked((0U - 740U) - 4);
    [NativeTypeName("#define DTN_FORMATA (DTN_FIRST2 - 3)")]
    public const uint DTN_FORMATA = unchecked((0U - 753U) - 3);
    [NativeTypeName("#define DTN_FORMATW (DTN_FIRST - 3)")]
    public const uint DTN_FORMATW = unchecked((0U - 740U) - 3);
    [NativeTypeName("#define DTN_FORMAT DTN_FORMATW")]
    public const uint DTN_FORMAT = unchecked((0U - 740U) - 3);
    [NativeTypeName("#define DTN_FORMATQUERYA (DTN_FIRST2 - 2)")]
    public const uint DTN_FORMATQUERYA = unchecked((0U - 753U) - 2);
    [NativeTypeName("#define DTN_FORMATQUERYW (DTN_FIRST - 2)")]
    public const uint DTN_FORMATQUERYW = unchecked((0U - 740U) - 2);
    [NativeTypeName("#define DTN_FORMATQUERY DTN_FORMATQUERYW")]
    public const uint DTN_FORMATQUERY = unchecked((0U - 740U) - 2);
    [NativeTypeName("#define DTN_DROPDOWN (DTN_FIRST2 - 1)")]
    public const uint DTN_DROPDOWN = unchecked((0U - 753U) - 1);
    [NativeTypeName("#define DTN_CLOSEUP (DTN_FIRST2)")]
    public const uint DTN_CLOSEUP = unchecked((0U - 753U));
}