// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WBEM_COMPILER_OPTIONS
{
    WBEM_FLAG_CHECK_ONLY = 0x1,
    WBEM_FLAG_AUTORECOVER = 0x2,
    WBEM_FLAG_WMI_CHECK = 0x4,
    WBEM_FLAG_CONSOLE_PRINT = 0x8,
    WBEM_FLAG_DONT_ADD_TO_LIST = 0x10,
    WBEM_FLAG_SPLIT_FILES = 0x20,
    WBEM_FLAG_STORE_FILE = 0x100,
}
