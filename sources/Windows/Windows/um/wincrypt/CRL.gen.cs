// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class CRL
{
    [NativeTypeName("#define CRL_V1 0")]
    public const int CRL_V1 = 0;
    [NativeTypeName("#define CRL_V2 1")]
    public const int CRL_V2 = 1;
    [NativeTypeName("#define CRL_REASON_UNSPECIFIED 0")]
    public const int CRL_REASON_UNSPECIFIED = 0;
    [NativeTypeName("#define CRL_REASON_KEY_COMPROMISE 1")]
    public const int CRL_REASON_KEY_COMPROMISE = 1;
    [NativeTypeName("#define CRL_REASON_CA_COMPROMISE 2")]
    public const int CRL_REASON_CA_COMPROMISE = 2;
    [NativeTypeName("#define CRL_REASON_AFFILIATION_CHANGED 3")]
    public const int CRL_REASON_AFFILIATION_CHANGED = 3;
    [NativeTypeName("#define CRL_REASON_SUPERSEDED 4")]
    public const int CRL_REASON_SUPERSEDED = 4;
    [NativeTypeName("#define CRL_REASON_CESSATION_OF_OPERATION 5")]
    public const int CRL_REASON_CESSATION_OF_OPERATION = 5;
    [NativeTypeName("#define CRL_REASON_CERTIFICATE_HOLD 6")]
    public const int CRL_REASON_CERTIFICATE_HOLD = 6;
    [NativeTypeName("#define CRL_REASON_REMOVE_FROM_CRL 8")]
    public const int CRL_REASON_REMOVE_FROM_CRL = 8;
    [NativeTypeName("#define CRL_REASON_PRIVILEGE_WITHDRAWN 9")]
    public const int CRL_REASON_PRIVILEGE_WITHDRAWN = 9;
    [NativeTypeName("#define CRL_REASON_AA_COMPROMISE 10")]
    public const int CRL_REASON_AA_COMPROMISE = 10;
    [NativeTypeName("#define CRL_DIST_POINT_NO_NAME 0")]
    public const int CRL_DIST_POINT_NO_NAME = 0;
    [NativeTypeName("#define CRL_DIST_POINT_FULL_NAME 1")]
    public const int CRL_DIST_POINT_FULL_NAME = 1;
    [NativeTypeName("#define CRL_DIST_POINT_ISSUER_RDN_NAME 2")]
    public const int CRL_DIST_POINT_ISSUER_RDN_NAME = 2;
    [NativeTypeName("#define CRL_REASON_UNUSED_FLAG 0x80")]
    public const int CRL_REASON_UNUSED_FLAG = 0x80;
    [NativeTypeName("#define CRL_REASON_KEY_COMPROMISE_FLAG 0x40")]
    public const int CRL_REASON_KEY_COMPROMISE_FLAG = 0x40;
    [NativeTypeName("#define CRL_REASON_CA_COMPROMISE_FLAG 0x20")]
    public const int CRL_REASON_CA_COMPROMISE_FLAG = 0x20;
    [NativeTypeName("#define CRL_REASON_AFFILIATION_CHANGED_FLAG 0x10")]
    public const int CRL_REASON_AFFILIATION_CHANGED_FLAG = 0x10;
    [NativeTypeName("#define CRL_REASON_SUPERSEDED_FLAG 0x08")]
    public const int CRL_REASON_SUPERSEDED_FLAG = 0x08;
    [NativeTypeName("#define CRL_REASON_CESSATION_OF_OPERATION_FLAG 0x04")]
    public const int CRL_REASON_CESSATION_OF_OPERATION_FLAG = 0x04;
    [NativeTypeName("#define CRL_REASON_CERTIFICATE_HOLD_FLAG 0x02")]
    public const int CRL_REASON_CERTIFICATE_HOLD_FLAG = 0x02;
    [NativeTypeName("#define CRL_REASON_PRIVILEGE_WITHDRAWN_FLAG 0x01")]
    public const int CRL_REASON_PRIVILEGE_WITHDRAWN_FLAG = 0x01;
    [NativeTypeName("#define CRL_REASON_AA_COMPROMISE_FLAG 0x80")]
    public const int CRL_REASON_AA_COMPROMISE_FLAG = 0x80;
    [NativeTypeName("#define CRL_DIST_POINT_ERR_INDEX_MASK 0x7F")]
    public const int CRL_DIST_POINT_ERR_INDEX_MASK = 0x7F;
    [NativeTypeName("#define CRL_DIST_POINT_ERR_INDEX_SHIFT 24")]
    public const int CRL_DIST_POINT_ERR_INDEX_SHIFT = 24;
    [NativeTypeName("#define CRL_DIST_POINT_ERR_CRL_ISSUER_BIT 0x80000000L")]
    public const uint CRL_DIST_POINT_ERR_CRL_ISSUER_BIT = 0x80000000;
    [NativeTypeName("#define CRL_FIND_ANY 0")]
    public const int CRL_FIND_ANY = 0;
    [NativeTypeName("#define CRL_FIND_ISSUED_BY 1")]
    public const int CRL_FIND_ISSUED_BY = 1;
    [NativeTypeName("#define CRL_FIND_EXISTING 2")]
    public const int CRL_FIND_EXISTING = 2;
    [NativeTypeName("#define CRL_FIND_ISSUED_FOR 3")]
    public const int CRL_FIND_ISSUED_FOR = 3;
    [NativeTypeName("#define CRL_FIND_ISSUED_BY_AKI_FLAG 0x1")]
    public const int CRL_FIND_ISSUED_BY_AKI_FLAG = 0x1;
    [NativeTypeName("#define CRL_FIND_ISSUED_BY_SIGNATURE_FLAG 0x2")]
    public const int CRL_FIND_ISSUED_BY_SIGNATURE_FLAG = 0x2;
    [NativeTypeName("#define CRL_FIND_ISSUED_BY_DELTA_FLAG 0x4")]
    public const int CRL_FIND_ISSUED_BY_DELTA_FLAG = 0x4;
    [NativeTypeName("#define CRL_FIND_ISSUED_BY_BASE_FLAG 0x8")]
    public const int CRL_FIND_ISSUED_BY_BASE_FLAG = 0x8;
    [NativeTypeName("#define CRL_FIND_ISSUED_FOR_SET_STRONG_PROPERTIES_FLAG 0x10")]
    public const int CRL_FIND_ISSUED_FOR_SET_STRONG_PROPERTIES_FLAG = 0x10;
}