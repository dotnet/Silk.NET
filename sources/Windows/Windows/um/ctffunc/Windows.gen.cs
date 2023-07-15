// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class Windows
{
    [NativeTypeName("#define TKBL_UNDEFINED 0")]
    public const int TKBL_UNDEFINED = 0;
    [NativeTypeName("#define TKBL_CLASSIC_TRADITIONAL_CHINESE_PHONETIC 0x0404")]
    public const int TKBL_CLASSIC_TRADITIONAL_CHINESE_PHONETIC = 0x0404;
    [NativeTypeName("#define TKBL_CLASSIC_TRADITIONAL_CHINESE_CHANGJIE 0xF042")]
    public const int TKBL_CLASSIC_TRADITIONAL_CHINESE_CHANGJIE = 0xF042;
    [NativeTypeName("#define TKBL_CLASSIC_TRADITIONAL_CHINESE_DAYI 0xF043")]
    public const int TKBL_CLASSIC_TRADITIONAL_CHINESE_DAYI = 0xF043;
    [NativeTypeName("#define TKBL_OPT_JAPANESE_ABC 0x0411")]
    public const int TKBL_OPT_JAPANESE_ABC = 0x0411;
    [NativeTypeName("#define TKBL_OPT_KOREAN_HANGUL_2_BULSIK 0x0412")]
    public const int TKBL_OPT_KOREAN_HANGUL_2_BULSIK = 0x0412;
    [NativeTypeName("#define TKBL_OPT_SIMPLIFIED_CHINESE_PINYIN 0x0804")]
    public const int TKBL_OPT_SIMPLIFIED_CHINESE_PINYIN = 0x0804;
    [NativeTypeName("#define TKBL_OPT_TRADITIONAL_CHINESE_PHONETIC 0x0404")]
    public const int TKBL_OPT_TRADITIONAL_CHINESE_PHONETIC = 0x0404;
}