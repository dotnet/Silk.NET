// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CPD
{
    [NativeTypeName("#define CPD_CHOICE_SIP 1")]
    public const int CPD_CHOICE_SIP = 1;

    [NativeTypeName("#define CPD_USE_NT5_CHAIN_FLAG 0x80000000")]
    public const uint CPD_USE_NT5_CHAIN_FLAG = 0x80000000;

    [NativeTypeName("#define CPD_REVOCATION_CHECK_NONE 0x00010000")]
    public const int CPD_REVOCATION_CHECK_NONE = 0x00010000;

    [NativeTypeName("#define CPD_REVOCATION_CHECK_END_CERT 0x00020000")]
    public const int CPD_REVOCATION_CHECK_END_CERT = 0x00020000;

    [NativeTypeName("#define CPD_REVOCATION_CHECK_CHAIN 0x00040000")]
    public const int CPD_REVOCATION_CHECK_CHAIN = 0x00040000;

    [NativeTypeName("#define CPD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT 0x00080000")]
    public const int CPD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 0x00080000;

    [NativeTypeName("#define CPD_RETURN_LOWER_QUALITY_CHAINS 0x00100000")]
    public const int CPD_RETURN_LOWER_QUALITY_CHAINS = 0x00100000;

    [NativeTypeName("#define CPD_RFC3161v21 0x00200000")]
    public const int CPD_RFC3161v21 = 0x00200000;

    [NativeTypeName("#define CPD_UISTATE_MODE_PROMPT 0x00000000")]
    public const int CPD_UISTATE_MODE_PROMPT = 0x00000000;

    [NativeTypeName("#define CPD_UISTATE_MODE_BLOCK 0x00000001")]
    public const int CPD_UISTATE_MODE_BLOCK = 0x00000001;

    [NativeTypeName("#define CPD_UISTATE_MODE_ALLOW 0x00000002")]
    public const int CPD_UISTATE_MODE_ALLOW = 0x00000002;

    [NativeTypeName("#define CPD_UISTATE_MODE_MASK 0x00000003")]
    public const int CPD_UISTATE_MODE_MASK = 0x00000003;
}
