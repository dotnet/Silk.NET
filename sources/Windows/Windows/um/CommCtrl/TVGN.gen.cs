// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class TVGN
{
    [NativeTypeName("#define TVGN_ROOT 0x0000")]
    public const int TVGN_ROOT = 0x0000;
    [NativeTypeName("#define TVGN_NEXT 0x0001")]
    public const int TVGN_NEXT = 0x0001;
    [NativeTypeName("#define TVGN_PREVIOUS 0x0002")]
    public const int TVGN_PREVIOUS = 0x0002;
    [NativeTypeName("#define TVGN_PARENT 0x0003")]
    public const int TVGN_PARENT = 0x0003;
    [NativeTypeName("#define TVGN_CHILD 0x0004")]
    public const int TVGN_CHILD = 0x0004;
    [NativeTypeName("#define TVGN_FIRSTVISIBLE 0x0005")]
    public const int TVGN_FIRSTVISIBLE = 0x0005;
    [NativeTypeName("#define TVGN_NEXTVISIBLE 0x0006")]
    public const int TVGN_NEXTVISIBLE = 0x0006;
    [NativeTypeName("#define TVGN_PREVIOUSVISIBLE 0x0007")]
    public const int TVGN_PREVIOUSVISIBLE = 0x0007;
    [NativeTypeName("#define TVGN_DROPHILITE 0x0008")]
    public const int TVGN_DROPHILITE = 0x0008;
    [NativeTypeName("#define TVGN_CARET 0x0009")]
    public const int TVGN_CARET = 0x0009;
    [NativeTypeName("#define TVGN_LASTVISIBLE 0x000A")]
    public const int TVGN_LASTVISIBLE = 0x000A;
    [NativeTypeName("#define TVGN_NEXTSELECTED 0x000B")]
    public const int TVGN_NEXTSELECTED = 0x000B;
}