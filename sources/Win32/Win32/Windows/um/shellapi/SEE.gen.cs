// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SEE
{
    [NativeTypeName("#define SEE_MASK_DEFAULT 0x00000000")]
    public const int SEE_MASK_DEFAULT = 0x00000000;

    [NativeTypeName("#define SEE_MASK_CLASSNAME 0x00000001")]
    public const int SEE_MASK_CLASSNAME = 0x00000001;

    [NativeTypeName("#define SEE_MASK_CLASSKEY 0x00000003")]
    public const int SEE_MASK_CLASSKEY = 0x00000003;

    [NativeTypeName("#define SEE_MASK_IDLIST 0x00000004")]
    public const int SEE_MASK_IDLIST = 0x00000004;

    [NativeTypeName("#define SEE_MASK_INVOKEIDLIST 0x0000000c")]
    public const int SEE_MASK_INVOKEIDLIST = 0x0000000c;

    [NativeTypeName("#define SEE_MASK_HOTKEY 0x00000020")]
    public const int SEE_MASK_HOTKEY = 0x00000020;

    [NativeTypeName("#define SEE_MASK_NOCLOSEPROCESS 0x00000040")]
    public const int SEE_MASK_NOCLOSEPROCESS = 0x00000040;

    [NativeTypeName("#define SEE_MASK_CONNECTNETDRV 0x00000080")]
    public const int SEE_MASK_CONNECTNETDRV = 0x00000080;

    [NativeTypeName("#define SEE_MASK_NOASYNC 0x00000100")]
    public const int SEE_MASK_NOASYNC = 0x00000100;

    [NativeTypeName("#define SEE_MASK_FLAG_DDEWAIT SEE_MASK_NOASYNC")]
    public const int SEE_MASK_FLAG_DDEWAIT = 0x00000100;

    [NativeTypeName("#define SEE_MASK_DOENVSUBST 0x00000200")]
    public const int SEE_MASK_DOENVSUBST = 0x00000200;

    [NativeTypeName("#define SEE_MASK_FLAG_NO_UI 0x00000400")]
    public const int SEE_MASK_FLAG_NO_UI = 0x00000400;

    [NativeTypeName("#define SEE_MASK_UNICODE 0x00004000")]
    public const int SEE_MASK_UNICODE = 0x00004000;

    [NativeTypeName("#define SEE_MASK_NO_CONSOLE 0x00008000")]
    public const int SEE_MASK_NO_CONSOLE = 0x00008000;

    [NativeTypeName("#define SEE_MASK_ASYNCOK 0x00100000")]
    public const int SEE_MASK_ASYNCOK = 0x00100000;

    [NativeTypeName("#define SEE_MASK_HMONITOR 0x00200000")]
    public const int SEE_MASK_HMONITOR = 0x00200000;

    [NativeTypeName("#define SEE_MASK_NOZONECHECKS 0x00800000")]
    public const int SEE_MASK_NOZONECHECKS = 0x00800000;

    [NativeTypeName("#define SEE_MASK_NOQUERYCLASSSTORE 0x01000000")]
    public const int SEE_MASK_NOQUERYCLASSSTORE = 0x01000000;

    [NativeTypeName("#define SEE_MASK_WAITFORINPUTIDLE 0x02000000")]
    public const int SEE_MASK_WAITFORINPUTIDLE = 0x02000000;

    [NativeTypeName("#define SEE_MASK_FLAG_LOG_USAGE 0x04000000")]
    public const int SEE_MASK_FLAG_LOG_USAGE = 0x04000000;

    [NativeTypeName("#define SEE_MASK_FLAG_HINST_IS_SITE 0x08000000")]
    public const int SEE_MASK_FLAG_HINST_IS_SITE = 0x08000000;
}
