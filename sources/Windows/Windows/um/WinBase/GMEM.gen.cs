// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class GMEM
{
    [NativeTypeName("#define GMEM_FIXED 0x0000")]
    public const int GMEM_FIXED = 0x0000;
    [NativeTypeName("#define GMEM_MOVEABLE 0x0002")]
    public const int GMEM_MOVEABLE = 0x0002;
    [NativeTypeName("#define GMEM_NOCOMPACT 0x0010")]
    public const int GMEM_NOCOMPACT = 0x0010;
    [NativeTypeName("#define GMEM_NODISCARD 0x0020")]
    public const int GMEM_NODISCARD = 0x0020;
    [NativeTypeName("#define GMEM_ZEROINIT 0x0040")]
    public const int GMEM_ZEROINIT = 0x0040;
    [NativeTypeName("#define GMEM_MODIFY 0x0080")]
    public const int GMEM_MODIFY = 0x0080;
    [NativeTypeName("#define GMEM_DISCARDABLE 0x0100")]
    public const int GMEM_DISCARDABLE = 0x0100;
    [NativeTypeName("#define GMEM_NOT_BANKED 0x1000")]
    public const int GMEM_NOT_BANKED = 0x1000;
    [NativeTypeName("#define GMEM_SHARE 0x2000")]
    public const int GMEM_SHARE = 0x2000;
    [NativeTypeName("#define GMEM_DDESHARE 0x2000")]
    public const int GMEM_DDESHARE = 0x2000;
    [NativeTypeName("#define GMEM_NOTIFY 0x4000")]
    public const int GMEM_NOTIFY = 0x4000;
    [NativeTypeName("#define GMEM_LOWER GMEM_NOT_BANKED")]
    public const int GMEM_LOWER = 0x1000;
    [NativeTypeName("#define GMEM_VALID_FLAGS 0x7F72")]
    public const int GMEM_VALID_FLAGS = 0x7F72;
    [NativeTypeName("#define GMEM_INVALID_HANDLE 0x8000")]
    public const int GMEM_INVALID_HANDLE = 0x8000;
    [NativeTypeName("#define GMEM_DISCARDED 0x4000")]
    public const int GMEM_DISCARDED = 0x4000;
    [NativeTypeName("#define GMEM_LOCKCOUNT 0x00FF")]
    public const int GMEM_LOCKCOUNT = 0x00FF;
}