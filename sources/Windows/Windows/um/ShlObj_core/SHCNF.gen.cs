// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SHCNF
{
    [NativeTypeName("#define SHCNF_IDLIST 0x0000")]
    public const int SHCNF_IDLIST = 0x0000;

    [NativeTypeName("#define SHCNF_PATHA 0x0001")]
    public const int SHCNF_PATHA = 0x0001;

    [NativeTypeName("#define SHCNF_PRINTERA 0x0002")]
    public const int SHCNF_PRINTERA = 0x0002;

    [NativeTypeName("#define SHCNF_DWORD 0x0003")]
    public const int SHCNF_DWORD = 0x0003;

    [NativeTypeName("#define SHCNF_PATHW 0x0005")]
    public const int SHCNF_PATHW = 0x0005;

    [NativeTypeName("#define SHCNF_PRINTERW 0x0006")]
    public const int SHCNF_PRINTERW = 0x0006;

    [NativeTypeName("#define SHCNF_TYPE 0x00FF")]
    public const int SHCNF_TYPE = 0x00FF;

    [NativeTypeName("#define SHCNF_FLUSH 0x1000")]
    public const int SHCNF_FLUSH = 0x1000;

    [NativeTypeName("#define SHCNF_FLUSHNOWAIT 0x3000")]
    public const int SHCNF_FLUSHNOWAIT = 0x3000;

    [NativeTypeName("#define SHCNF_NOTIFYRECURSIVE 0x10000")]
    public const int SHCNF_NOTIFYRECURSIVE = 0x10000;

    [NativeTypeName("#define SHCNF_PATH SHCNF_PATHW")]
    public const int SHCNF_PATH = 0x0005;

    [NativeTypeName("#define SHCNF_PRINTER SHCNF_PRINTERW")]
    public const int SHCNF_PRINTER = 0x0006;
}
