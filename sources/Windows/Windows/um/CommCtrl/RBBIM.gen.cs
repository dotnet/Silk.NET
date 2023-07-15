// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class RBBIM
{
    [NativeTypeName("#define RBBIM_STYLE 0x00000001")]
    public const int RBBIM_STYLE = 0x00000001;
    [NativeTypeName("#define RBBIM_COLORS 0x00000002")]
    public const int RBBIM_COLORS = 0x00000002;
    [NativeTypeName("#define RBBIM_TEXT 0x00000004")]
    public const int RBBIM_TEXT = 0x00000004;
    [NativeTypeName("#define RBBIM_IMAGE 0x00000008")]
    public const int RBBIM_IMAGE = 0x00000008;
    [NativeTypeName("#define RBBIM_CHILD 0x00000010")]
    public const int RBBIM_CHILD = 0x00000010;
    [NativeTypeName("#define RBBIM_CHILDSIZE 0x00000020")]
    public const int RBBIM_CHILDSIZE = 0x00000020;
    [NativeTypeName("#define RBBIM_SIZE 0x00000040")]
    public const int RBBIM_SIZE = 0x00000040;
    [NativeTypeName("#define RBBIM_BACKGROUND 0x00000080")]
    public const int RBBIM_BACKGROUND = 0x00000080;
    [NativeTypeName("#define RBBIM_ID 0x00000100")]
    public const int RBBIM_ID = 0x00000100;
    [NativeTypeName("#define RBBIM_IDEALSIZE 0x00000200")]
    public const int RBBIM_IDEALSIZE = 0x00000200;
    [NativeTypeName("#define RBBIM_LPARAM 0x00000400")]
    public const int RBBIM_LPARAM = 0x00000400;
    [NativeTypeName("#define RBBIM_HEADERSIZE 0x00000800")]
    public const int RBBIM_HEADERSIZE = 0x00000800;
    [NativeTypeName("#define RBBIM_CHEVRONLOCATION 0x00001000")]
    public const int RBBIM_CHEVRONLOCATION = 0x00001000;
    [NativeTypeName("#define RBBIM_CHEVRONSTATE 0x00002000")]
    public const int RBBIM_CHEVRONSTATE = 0x00002000;
}