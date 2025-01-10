// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class URL
{
    [NativeTypeName("#define URL_OID_GET_OBJECT_URL_FUNC \"UrlDllGetObjectUrl\"")]
    public static ReadOnlySpan<byte> URL_OID_GET_OBJECT_URL_FUNC => "UrlDllGetObjectUrl"u8;

    [NativeTypeName("#define URL_OID_CERTIFICATE_ISSUER ((LPCSTR)1)")]
    public static sbyte* URL_OID_CERTIFICATE_ISSUER => ((sbyte*)(1));

    [NativeTypeName("#define URL_OID_CERTIFICATE_CRL_DIST_POINT ((LPCSTR)2)")]
    public static sbyte* URL_OID_CERTIFICATE_CRL_DIST_POINT => ((sbyte*)(2));

    [NativeTypeName("#define URL_OID_CTL_ISSUER ((LPCSTR)3)")]
    public static sbyte* URL_OID_CTL_ISSUER => ((sbyte*)(3));

    [NativeTypeName("#define URL_OID_CTL_NEXT_UPDATE ((LPCSTR)4)")]
    public static sbyte* URL_OID_CTL_NEXT_UPDATE => ((sbyte*)(4));

    [NativeTypeName("#define URL_OID_CRL_ISSUER ((LPCSTR)5)")]
    public static sbyte* URL_OID_CRL_ISSUER => ((sbyte*)(5));

    [NativeTypeName("#define URL_OID_CERTIFICATE_FRESHEST_CRL ((LPCSTR)6)")]
    public static sbyte* URL_OID_CERTIFICATE_FRESHEST_CRL => ((sbyte*)(6));

    [NativeTypeName("#define URL_OID_CRL_FRESHEST_CRL ((LPCSTR)7)")]
    public static sbyte* URL_OID_CRL_FRESHEST_CRL => ((sbyte*)(7));

    [NativeTypeName("#define URL_OID_CROSS_CERT_DIST_POINT ((LPCSTR)8)")]
    public static sbyte* URL_OID_CROSS_CERT_DIST_POINT => ((sbyte*)(8));

    [NativeTypeName("#define URL_OID_CERTIFICATE_OCSP ((LPCSTR)9)")]
    public static sbyte* URL_OID_CERTIFICATE_OCSP => ((sbyte*)(9));

    [NativeTypeName("#define URL_OID_CERTIFICATE_OCSP_AND_CRL_DIST_POINT ((LPCSTR)10)")]
    public static sbyte* URL_OID_CERTIFICATE_OCSP_AND_CRL_DIST_POINT => ((sbyte*)(10));

    [NativeTypeName("#define URL_OID_CERTIFICATE_CRL_DIST_POINT_AND_OCSP ((LPCSTR)11)")]
    public static sbyte* URL_OID_CERTIFICATE_CRL_DIST_POINT_AND_OCSP => ((sbyte*)(11));

    [NativeTypeName("#define URL_OID_CROSS_CERT_SUBJECT_INFO_ACCESS ((LPCSTR)12)")]
    public static sbyte* URL_OID_CROSS_CERT_SUBJECT_INFO_ACCESS => ((sbyte*)(12));

    [NativeTypeName("#define URL_OID_CERTIFICATE_ONLY_OCSP ((LPCSTR)13)")]
    public static sbyte* URL_OID_CERTIFICATE_ONLY_OCSP => ((sbyte*)(13));
}
