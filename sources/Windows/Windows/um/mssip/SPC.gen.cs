// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SPC
{
    [NativeTypeName("#define SPC_INC_PE_RESOURCES_FLAG 0x80")]
    public const int SPC_INC_PE_RESOURCES_FLAG = 0x80;

    [NativeTypeName("#define SPC_INC_PE_DEBUG_INFO_FLAG 0x40")]
    public const int SPC_INC_PE_DEBUG_INFO_FLAG = 0x40;

    [NativeTypeName("#define SPC_INC_PE_IMPORT_ADDR_TABLE_FLAG 0x20")]
    public const int SPC_INC_PE_IMPORT_ADDR_TABLE_FLAG = 0x20;

    [NativeTypeName("#define SPC_EXC_PE_PAGE_HASHES_FLAG 0x10")]
    public const int SPC_EXC_PE_PAGE_HASHES_FLAG = 0x10;

    [NativeTypeName("#define SPC_INC_PE_PAGE_HASHES_FLAG 0x100")]
    public const int SPC_INC_PE_PAGE_HASHES_FLAG = 0x100;

    [NativeTypeName("#define SPC_DIGEST_GENERATE_FLAG 0x200")]
    public const int SPC_DIGEST_GENERATE_FLAG = 0x200;

    [NativeTypeName("#define SPC_DIGEST_SIGN_FLAG 0x400")]
    public const int SPC_DIGEST_SIGN_FLAG = 0x400;

    [NativeTypeName("#define SPC_DIGEST_SIGN_EX_FLAG 0x4000")]
    public const int SPC_DIGEST_SIGN_EX_FLAG = 0x4000;

    [NativeTypeName("#define SPC_RELAXED_PE_MARKER_CHECK 0x800")]
    public const int SPC_RELAXED_PE_MARKER_CHECK = 0x800;

    [NativeTypeName("#define SPC_MARKER_CHECK_SKIP_SIP_INDIRECT_DATA_FLAG 0x00000001")]
    public const int SPC_MARKER_CHECK_SKIP_SIP_INDIRECT_DATA_FLAG = 0x00000001;

    [NativeTypeName("#define SPC_MARKER_CHECK_CURRENTLY_SUPPORTED_FLAGS SPC_MARKER_CHECK_SKIP_SIP_INDIRECT_DATA_FLAG")]
    public const int SPC_MARKER_CHECK_CURRENTLY_SUPPORTED_FLAGS = 0x00000001;
}
