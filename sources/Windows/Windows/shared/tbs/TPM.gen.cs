// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class TPM
{
    [NativeTypeName("#define TPM_WNF_INFO_CLEAR_SUCCESSFUL 0x00000001")]
    public const int TPM_WNF_INFO_CLEAR_SUCCESSFUL = 0x00000001;

    [NativeTypeName("#define TPM_WNF_INFO_OWNERSHIP_SUCCESSFUL 0x00000002")]
    public const int TPM_WNF_INFO_OWNERSHIP_SUCCESSFUL = 0x00000002;

    [NativeTypeName("#define TPM_WNF_INFO_NO_REBOOT_REQUIRED 1")]
    public const int TPM_WNF_INFO_NO_REBOOT_REQUIRED = 1;

    [NativeTypeName("#define TPM_VERSION_UNKNOWN 0")]
    public const int TPM_VERSION_UNKNOWN = 0;

    [NativeTypeName("#define TPM_VERSION_12 1")]
    public const int TPM_VERSION_12 = 1;

    [NativeTypeName("#define TPM_VERSION_20 2")]
    public const int TPM_VERSION_20 = 2;

    [NativeTypeName("#define TPM_IFTYPE_UNKNOWN 0")]
    public const int TPM_IFTYPE_UNKNOWN = 0;

    [NativeTypeName("#define TPM_IFTYPE_1 1")]
    public const int TPM_IFTYPE_1 = 1;

    [NativeTypeName("#define TPM_IFTYPE_TRUSTZONE 2")]
    public const int TPM_IFTYPE_TRUSTZONE = 2;

    [NativeTypeName("#define TPM_IFTYPE_HW 3")]
    public const int TPM_IFTYPE_HW = 3;

    [NativeTypeName("#define TPM_IFTYPE_EMULATOR 4")]
    public const int TPM_IFTYPE_EMULATOR = 4;

    [NativeTypeName("#define TPM_IFTYPE_SPB 5")]
    public const int TPM_IFTYPE_SPB = 5;
}
