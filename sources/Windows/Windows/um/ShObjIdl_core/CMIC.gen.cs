// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class CMIC
{
    [NativeTypeName("#define CMIC_MASK_HOTKEY SEE_MASK_HOTKEY")]
    public const int CMIC_MASK_HOTKEY = 0x00000020;
    [NativeTypeName("#define CMIC_MASK_FLAG_NO_UI SEE_MASK_FLAG_NO_UI")]
    public const int CMIC_MASK_FLAG_NO_UI = 0x00000400;
    [NativeTypeName("#define CMIC_MASK_UNICODE SEE_MASK_UNICODE")]
    public const int CMIC_MASK_UNICODE = 0x00004000;
    [NativeTypeName("#define CMIC_MASK_NO_CONSOLE SEE_MASK_NO_CONSOLE")]
    public const int CMIC_MASK_NO_CONSOLE = 0x00008000;
    [NativeTypeName("#define CMIC_MASK_ASYNCOK SEE_MASK_ASYNCOK")]
    public const int CMIC_MASK_ASYNCOK = 0x00100000;
    [NativeTypeName("#define CMIC_MASK_NOASYNC SEE_MASK_NOASYNC")]
    public const int CMIC_MASK_NOASYNC = 0x00000100;
    [NativeTypeName("#define CMIC_MASK_SHIFT_DOWN 0x10000000")]
    public const int CMIC_MASK_SHIFT_DOWN = 0x10000000;
    [NativeTypeName("#define CMIC_MASK_CONTROL_DOWN 0x40000000")]
    public const int CMIC_MASK_CONTROL_DOWN = 0x40000000;
    [NativeTypeName("#define CMIC_MASK_FLAG_LOG_USAGE SEE_MASK_FLAG_LOG_USAGE")]
    public const int CMIC_MASK_FLAG_LOG_USAGE = 0x04000000;
    [NativeTypeName("#define CMIC_MASK_NOZONECHECKS SEE_MASK_NOZONECHECKS")]
    public const int CMIC_MASK_NOZONECHECKS = 0x00800000;
    [NativeTypeName("#define CMIC_MASK_PTINVOKE 0x20000000")]
    public const int CMIC_MASK_PTINVOKE = 0x20000000;
}