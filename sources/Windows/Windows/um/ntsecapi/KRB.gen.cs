// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class KRB
{
    [NativeTypeName("#define KRB_NT_UNKNOWN 0")]
    public const int KRB_NT_UNKNOWN = 0;

    [NativeTypeName("#define KRB_NT_PRINCIPAL 1")]
    public const int KRB_NT_PRINCIPAL = 1;

    [NativeTypeName("#define KRB_NT_PRINCIPAL_AND_ID -131")]
    public const int KRB_NT_PRINCIPAL_AND_ID = -131;

    [NativeTypeName("#define KRB_NT_SRV_INST 2")]
    public const int KRB_NT_SRV_INST = 2;

    [NativeTypeName("#define KRB_NT_SRV_INST_AND_ID -132")]
    public const int KRB_NT_SRV_INST_AND_ID = -132;

    [NativeTypeName("#define KRB_NT_SRV_HST 3")]
    public const int KRB_NT_SRV_HST = 3;

    [NativeTypeName("#define KRB_NT_SRV_XHST 4")]
    public const int KRB_NT_SRV_XHST = 4;

    [NativeTypeName("#define KRB_NT_UID 5")]
    public const int KRB_NT_UID = 5;

    [NativeTypeName("#define KRB_NT_ENTERPRISE_PRINCIPAL 10")]
    public const int KRB_NT_ENTERPRISE_PRINCIPAL = 10;

    [NativeTypeName("#define KRB_NT_WELLKNOWN 11")]
    public const int KRB_NT_WELLKNOWN = 11;

    [NativeTypeName("#define KRB_NT_ENT_PRINCIPAL_AND_ID -130")]
    public const int KRB_NT_ENT_PRINCIPAL_AND_ID = -130;

    [NativeTypeName("#define KRB_NT_MS_PRINCIPAL -128")]
    public const int KRB_NT_MS_PRINCIPAL = -128;

    [NativeTypeName("#define KRB_NT_MS_PRINCIPAL_AND_ID -129")]
    public const int KRB_NT_MS_PRINCIPAL_AND_ID = -129;

    [NativeTypeName("#define KRB_NT_MS_BRANCH_ID -133")]
    public const int KRB_NT_MS_BRANCH_ID = -133;

    [NativeTypeName("#define KRB_NT_X500_PRINCIPAL 6")]
    public const int KRB_NT_X500_PRINCIPAL = 6;

    [NativeTypeName("#define KRB_WELLKNOWN_STRING L\"WELLKNOWN\"")]
    public const string KRB_WELLKNOWN_STRING = "WELLKNOWN";

    [NativeTypeName("#define KRB_ANONYMOUS_STRING L\"ANONYMOUS\"")]
    public const string KRB_ANONYMOUS_STRING = "ANONYMOUS";
}
