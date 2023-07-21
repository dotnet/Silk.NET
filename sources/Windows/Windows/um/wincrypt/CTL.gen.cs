// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static unsafe partial class CTL
{
    [NativeTypeName("#define CTL_V1 0")]
    public const int CTL_V1 = 0;

    [NativeTypeName("#define CTL_ENTRY_FROM_PROP_CHAIN_FLAG 0x1")]
    public const int CTL_ENTRY_FROM_PROP_CHAIN_FLAG = 0x1;

    [NativeTypeName("#define CTL_ANY_SUBJECT_TYPE 1")]
    public const int CTL_ANY_SUBJECT_TYPE = 1;

    [NativeTypeName("#define CTL_CERT_SUBJECT_TYPE 2")]
    public const int CTL_CERT_SUBJECT_TYPE = 2;

    [NativeTypeName("#define CTL_FIND_ANY 0")]
    public const int CTL_FIND_ANY = 0;

    [NativeTypeName("#define CTL_FIND_SHA1_HASH 1")]
    public const int CTL_FIND_SHA1_HASH = 1;

    [NativeTypeName("#define CTL_FIND_MD5_HASH 2")]
    public const int CTL_FIND_MD5_HASH = 2;

    [NativeTypeName("#define CTL_FIND_USAGE 3")]
    public const int CTL_FIND_USAGE = 3;

    [NativeTypeName("#define CTL_FIND_SUBJECT 4")]
    public const int CTL_FIND_SUBJECT = 4;

    [NativeTypeName("#define CTL_FIND_EXISTING 5")]
    public const int CTL_FIND_EXISTING = 5;

    [NativeTypeName("#define CTL_FIND_NO_LIST_ID_CBDATA 0xFFFFFFFF")]
    public const uint CTL_FIND_NO_LIST_ID_CBDATA = 0xFFFFFFFF;

    [NativeTypeName("#define CTL_FIND_NO_SIGNER_PTR ((PCERT_INFO) -1)")]
    public static CERT_INFO* CTL_FIND_NO_SIGNER_PTR => unchecked((CERT_INFO*)(-1));

    [NativeTypeName("#define CTL_FIND_SAME_USAGE_FLAG 0x1")]
    public const int CTL_FIND_SAME_USAGE_FLAG = 0x1;
}
