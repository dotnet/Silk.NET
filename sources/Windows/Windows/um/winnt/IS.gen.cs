// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class IS
{
    [NativeTypeName("#define IS_TEXT_UNICODE_ASCII16 0x0001")]
    public const int IS_TEXT_UNICODE_ASCII16 = 0x0001;
    [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_ASCII16 0x0010")]
    public const int IS_TEXT_UNICODE_REVERSE_ASCII16 = 0x0010;
    [NativeTypeName("#define IS_TEXT_UNICODE_STATISTICS 0x0002")]
    public const int IS_TEXT_UNICODE_STATISTICS = 0x0002;
    [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_STATISTICS 0x0020")]
    public const int IS_TEXT_UNICODE_REVERSE_STATISTICS = 0x0020;
    [NativeTypeName("#define IS_TEXT_UNICODE_CONTROLS 0x0004")]
    public const int IS_TEXT_UNICODE_CONTROLS = 0x0004;
    [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_CONTROLS 0x0040")]
    public const int IS_TEXT_UNICODE_REVERSE_CONTROLS = 0x0040;
    [NativeTypeName("#define IS_TEXT_UNICODE_SIGNATURE 0x0008")]
    public const int IS_TEXT_UNICODE_SIGNATURE = 0x0008;
    [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_SIGNATURE 0x0080")]
    public const int IS_TEXT_UNICODE_REVERSE_SIGNATURE = 0x0080;
    [NativeTypeName("#define IS_TEXT_UNICODE_ILLEGAL_CHARS 0x0100")]
    public const int IS_TEXT_UNICODE_ILLEGAL_CHARS = 0x0100;
    [NativeTypeName("#define IS_TEXT_UNICODE_ODD_LENGTH 0x0200")]
    public const int IS_TEXT_UNICODE_ODD_LENGTH = 0x0200;
    [NativeTypeName("#define IS_TEXT_UNICODE_DBCS_LEADBYTE 0x0400")]
    public const int IS_TEXT_UNICODE_DBCS_LEADBYTE = 0x0400;
    [NativeTypeName("#define IS_TEXT_UNICODE_UTF8 0x0800")]
    public const int IS_TEXT_UNICODE_UTF8 = 0x0800;
    [NativeTypeName("#define IS_TEXT_UNICODE_NULL_BYTES 0x1000")]
    public const int IS_TEXT_UNICODE_NULL_BYTES = 0x1000;
    [NativeTypeName("#define IS_TEXT_UNICODE_UNICODE_MASK 0x000F")]
    public const int IS_TEXT_UNICODE_UNICODE_MASK = 0x000F;
    [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_MASK 0x00F0")]
    public const int IS_TEXT_UNICODE_REVERSE_MASK = 0x00F0;
    [NativeTypeName("#define IS_TEXT_UNICODE_NOT_UNICODE_MASK 0x0F00")]
    public const int IS_TEXT_UNICODE_NOT_UNICODE_MASK = 0x0F00;
    [NativeTypeName("#define IS_TEXT_UNICODE_NOT_ASCII_MASK 0xF000")]
    public const int IS_TEXT_UNICODE_NOT_ASCII_MASK = 0xF000;
}