// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class X509
{
    [NativeTypeName("#define X509_ASN_ENCODING 0x00000001")]
    public const int X509_ASN_ENCODING = 0x00000001;

    [NativeTypeName("#define X509_NDR_ENCODING 0x00000002")]
    public const int X509_NDR_ENCODING = 0x00000002;

    [NativeTypeName("#define X509_CERT ((LPCSTR) 1)")]
    public static sbyte* X509_CERT => ((sbyte*)(1));

    [NativeTypeName("#define X509_CERT_TO_BE_SIGNED ((LPCSTR) 2)")]
    public static sbyte* X509_CERT_TO_BE_SIGNED => ((sbyte*)(2));

    [NativeTypeName("#define X509_CERT_CRL_TO_BE_SIGNED ((LPCSTR) 3)")]
    public static sbyte* X509_CERT_CRL_TO_BE_SIGNED => ((sbyte*)(3));

    [NativeTypeName("#define X509_CERT_REQUEST_TO_BE_SIGNED ((LPCSTR) 4)")]
    public static sbyte* X509_CERT_REQUEST_TO_BE_SIGNED => ((sbyte*)(4));

    [NativeTypeName("#define X509_NAME_VALUE ((LPCSTR) 6)")]
    public static sbyte* X509_NAME_VALUE => ((sbyte*)(6));

    [NativeTypeName("#define X509_PUBLIC_KEY_INFO ((LPCSTR) 8)")]
    public static sbyte* X509_PUBLIC_KEY_INFO => ((sbyte*)(8));

    [NativeTypeName("#define X509_EXTENSIONS ((LPCSTR) 5)")]
    public static sbyte* X509_EXTENSIONS => ((sbyte*)(5));

    [NativeTypeName("#define X509_NAME ((LPCSTR) 7)")]
    public static sbyte* X509_NAME => ((sbyte*)(7));

    [NativeTypeName("#define X509_AUTHORITY_KEY_ID ((LPCSTR) 9)")]
    public static sbyte* X509_AUTHORITY_KEY_ID => ((sbyte*)(9));

    [NativeTypeName("#define X509_KEY_ATTRIBUTES ((LPCSTR) 10)")]
    public static sbyte* X509_KEY_ATTRIBUTES => ((sbyte*)(10));

    [NativeTypeName("#define X509_KEY_USAGE_RESTRICTION ((LPCSTR) 11)")]
    public static sbyte* X509_KEY_USAGE_RESTRICTION => ((sbyte*)(11));

    [NativeTypeName("#define X509_ALTERNATE_NAME ((LPCSTR) 12)")]
    public static sbyte* X509_ALTERNATE_NAME => ((sbyte*)(12));

    [NativeTypeName("#define X509_BASIC_CONSTRAINTS ((LPCSTR) 13)")]
    public static sbyte* X509_BASIC_CONSTRAINTS => ((sbyte*)(13));

    [NativeTypeName("#define X509_KEY_USAGE ((LPCSTR) 14)")]
    public static sbyte* X509_KEY_USAGE => ((sbyte*)(14));

    [NativeTypeName("#define X509_BASIC_CONSTRAINTS2 ((LPCSTR) 15)")]
    public static sbyte* X509_BASIC_CONSTRAINTS2 => ((sbyte*)(15));

    [NativeTypeName("#define X509_CERT_POLICIES ((LPCSTR) 16)")]
    public static sbyte* X509_CERT_POLICIES => ((sbyte*)(16));

    [NativeTypeName("#define X509_UNICODE_NAME ((LPCSTR) 20)")]
    public static sbyte* X509_UNICODE_NAME => ((sbyte*)(20));

    [NativeTypeName("#define X509_KEYGEN_REQUEST_TO_BE_SIGNED ((LPCSTR) 21)")]
    public static sbyte* X509_KEYGEN_REQUEST_TO_BE_SIGNED => ((sbyte*)(21));

    [NativeTypeName("#define X509_UNICODE_NAME_VALUE ((LPCSTR) 24)")]
    public static sbyte* X509_UNICODE_NAME_VALUE => ((sbyte*)(24));

    [NativeTypeName("#define X509_ANY_STRING X509_NAME_VALUE")]
    public static sbyte* X509_ANY_STRING => ((sbyte*)(6));

    [NativeTypeName("#define X509_UNICODE_ANY_STRING X509_UNICODE_NAME_VALUE")]
    public static sbyte* X509_UNICODE_ANY_STRING => ((sbyte*)(24));

    [NativeTypeName("#define X509_OCTET_STRING ((LPCSTR) 25)")]
    public static sbyte* X509_OCTET_STRING => ((sbyte*)(25));

    [NativeTypeName("#define X509_BITS ((LPCSTR) 26)")]
    public static sbyte* X509_BITS => ((sbyte*)(26));

    [NativeTypeName("#define X509_INTEGER ((LPCSTR) 27)")]
    public static sbyte* X509_INTEGER => ((sbyte*)(27));

    [NativeTypeName("#define X509_MULTI_BYTE_INTEGER ((LPCSTR) 28)")]
    public static sbyte* X509_MULTI_BYTE_INTEGER => ((sbyte*)(28));

    [NativeTypeName("#define X509_ENUMERATED ((LPCSTR) 29)")]
    public static sbyte* X509_ENUMERATED => ((sbyte*)(29));

    [NativeTypeName("#define X509_CHOICE_OF_TIME ((LPCSTR) 30)")]
    public static sbyte* X509_CHOICE_OF_TIME => ((sbyte*)(30));

    [NativeTypeName("#define X509_AUTHORITY_KEY_ID2 ((LPCSTR) 31)")]
    public static sbyte* X509_AUTHORITY_KEY_ID2 => ((sbyte*)(31));

    [NativeTypeName("#define X509_AUTHORITY_INFO_ACCESS ((LPCSTR) 32)")]
    public static sbyte* X509_AUTHORITY_INFO_ACCESS => ((sbyte*)(32));

    [NativeTypeName("#define X509_SUBJECT_INFO_ACCESS X509_AUTHORITY_INFO_ACCESS")]
    public static sbyte* X509_SUBJECT_INFO_ACCESS => ((sbyte*)(32));

    [NativeTypeName("#define X509_CRL_REASON_CODE X509_ENUMERATED")]
    public static sbyte* X509_CRL_REASON_CODE => ((sbyte*)(29));

    [NativeTypeName("#define X509_SEQUENCE_OF_ANY ((LPCSTR) 34)")]
    public static sbyte* X509_SEQUENCE_OF_ANY => ((sbyte*)(34));

    [NativeTypeName("#define X509_CRL_DIST_POINTS ((LPCSTR) 35)")]
    public static sbyte* X509_CRL_DIST_POINTS => ((sbyte*)(35));

    [NativeTypeName("#define X509_ENHANCED_KEY_USAGE ((LPCSTR) 36)")]
    public static sbyte* X509_ENHANCED_KEY_USAGE => ((sbyte*)(36));

    [NativeTypeName("#define X509_MULTI_BYTE_UINT ((LPCSTR) 38)")]
    public static sbyte* X509_MULTI_BYTE_UINT => ((sbyte*)(38));

    [NativeTypeName("#define X509_DSS_PUBLICKEY X509_MULTI_BYTE_UINT")]
    public static sbyte* X509_DSS_PUBLICKEY => ((sbyte*)(38));

    [NativeTypeName("#define X509_DSS_PARAMETERS ((LPCSTR) 39)")]
    public static sbyte* X509_DSS_PARAMETERS => ((sbyte*)(39));

    [NativeTypeName("#define X509_DSS_SIGNATURE ((LPCSTR) 40)")]
    public static sbyte* X509_DSS_SIGNATURE => ((sbyte*)(40));

    [NativeTypeName("#define X509_QC_STATEMENTS_EXT ((LPCSTR) 42)")]
    public static sbyte* X509_QC_STATEMENTS_EXT => ((sbyte*)(42));

    [NativeTypeName("#define X509_PKIX_POLICY_QUALIFIER_USERNOTICE ((LPCSTR) 46)")]
    public static sbyte* X509_PKIX_POLICY_QUALIFIER_USERNOTICE => ((sbyte*)(46));

    [NativeTypeName("#define X509_DH_PUBLICKEY X509_MULTI_BYTE_UINT")]
    public static sbyte* X509_DH_PUBLICKEY => ((sbyte*)(38));

    [NativeTypeName("#define X509_DH_PARAMETERS ((LPCSTR) 47)")]
    public static sbyte* X509_DH_PARAMETERS => ((sbyte*)(47));

    [NativeTypeName("#define X509_ECC_SIGNATURE ((LPCSTR) 47)")]
    public static sbyte* X509_ECC_SIGNATURE => ((sbyte*)(47));

    [NativeTypeName("#define X509_BITS_WITHOUT_TRAILING_ZEROES ((LPCSTR) 51)")]
    public static sbyte* X509_BITS_WITHOUT_TRAILING_ZEROES => ((sbyte*)(51));

    [NativeTypeName("#define X509_CERT_PAIR ((LPCSTR) 53)")]
    public static sbyte* X509_CERT_PAIR => ((sbyte*)(53));

    [NativeTypeName("#define X509_ISSUING_DIST_POINT ((LPCSTR) 54)")]
    public static sbyte* X509_ISSUING_DIST_POINT => ((sbyte*)(54));

    [NativeTypeName("#define X509_NAME_CONSTRAINTS ((LPCSTR) 55)")]
    public static sbyte* X509_NAME_CONSTRAINTS => ((sbyte*)(55));

    [NativeTypeName("#define X509_POLICY_MAPPINGS ((LPCSTR) 56)")]
    public static sbyte* X509_POLICY_MAPPINGS => ((sbyte*)(56));

    [NativeTypeName("#define X509_POLICY_CONSTRAINTS ((LPCSTR) 57)")]
    public static sbyte* X509_POLICY_CONSTRAINTS => ((sbyte*)(57));

    [NativeTypeName("#define X509_CROSS_CERT_DIST_POINTS ((LPCSTR) 58)")]
    public static sbyte* X509_CROSS_CERT_DIST_POINTS => ((sbyte*)(58));

    [NativeTypeName("#define X509_CERTIFICATE_TEMPLATE ((LPCSTR) 64)")]
    public static sbyte* X509_CERTIFICATE_TEMPLATE => ((sbyte*)(64));

    [NativeTypeName("#define X509_LOGOTYPE_EXT ((LPCSTR) 70)")]
    public static sbyte* X509_LOGOTYPE_EXT => ((sbyte*)(70));

    [NativeTypeName("#define X509_BIOMETRIC_EXT ((LPCSTR) 71)")]
    public static sbyte* X509_BIOMETRIC_EXT => ((sbyte*)(71));

    [NativeTypeName("#define X509_OBJECT_IDENTIFIER ((LPCSTR) 73)")]
    public static sbyte* X509_OBJECT_IDENTIFIER => ((sbyte*)(73));

    [NativeTypeName("#define X509_ALGORITHM_IDENTIFIER ((LPCSTR) 74)")]
    public static sbyte* X509_ALGORITHM_IDENTIFIER => ((sbyte*)(74));

    [NativeTypeName("#define X509_CERT_BUNDLE ((LPCSTR) 81)")]
    public static sbyte* X509_CERT_BUNDLE => ((sbyte*)(81));

    [NativeTypeName("#define X509_ECC_PRIVATE_KEY ((LPCSTR) 82)")]
    public static sbyte* X509_ECC_PRIVATE_KEY => ((sbyte*)(82));

    [NativeTypeName("#define X509_SUBJECT_DIR_ATTRS ((LPCSTR) 84)")]
    public static sbyte* X509_SUBJECT_DIR_ATTRS => ((sbyte*)(84));

    [NativeTypeName("#define X509_ECC_PARAMETERS ((LPCSTR) 85)")]
    public static sbyte* X509_ECC_PARAMETERS => ((sbyte*)(85));
}
