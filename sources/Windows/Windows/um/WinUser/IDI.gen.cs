// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static unsafe partial class IDI
{
    [NativeTypeName("#define IDI_APPLICATION MAKEINTRESOURCE(32512)")]
    public static ushort* IDI_APPLICATION => ((ushort*)((nuint)((ushort)(32512))));

    [NativeTypeName("#define IDI_HAND MAKEINTRESOURCE(32513)")]
    public static ushort* IDI_HAND => ((ushort*)((nuint)((ushort)(32513))));

    [NativeTypeName("#define IDI_QUESTION MAKEINTRESOURCE(32514)")]
    public static ushort* IDI_QUESTION => ((ushort*)((nuint)((ushort)(32514))));

    [NativeTypeName("#define IDI_EXCLAMATION MAKEINTRESOURCE(32515)")]
    public static ushort* IDI_EXCLAMATION => ((ushort*)((nuint)((ushort)(32515))));

    [NativeTypeName("#define IDI_ASTERISK MAKEINTRESOURCE(32516)")]
    public static ushort* IDI_ASTERISK => ((ushort*)((nuint)((ushort)(32516))));

    [NativeTypeName("#define IDI_WINLOGO MAKEINTRESOURCE(32517)")]
    public static ushort* IDI_WINLOGO => ((ushort*)((nuint)((ushort)(32517))));

    [NativeTypeName("#define IDI_SHIELD MAKEINTRESOURCE(32518)")]
    public static ushort* IDI_SHIELD => ((ushort*)((nuint)((ushort)(32518))));

    [NativeTypeName("#define IDI_WARNING IDI_EXCLAMATION")]
    public static ushort* IDI_WARNING => ((ushort*)((nuint)((ushort)(32515))));

    [NativeTypeName("#define IDI_ERROR IDI_HAND")]
    public static ushort* IDI_ERROR => ((ushort*)((nuint)((ushort)(32513))));

    [NativeTypeName("#define IDI_INFORMATION IDI_ASTERISK")]
    public static ushort* IDI_INFORMATION => ((ushort*)((nuint)((ushort)(32516))));
}