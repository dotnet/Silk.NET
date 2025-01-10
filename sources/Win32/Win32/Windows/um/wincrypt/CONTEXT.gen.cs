// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class CONTEXT
{
    [NativeTypeName(
        "#define CONTEXT_OID_CREATE_OBJECT_CONTEXT_FUNC \"ContextDllCreateObjectContext\""
    )]
    public static ReadOnlySpan<byte> CONTEXT_OID_CREATE_OBJECT_CONTEXT_FUNC =>
        "ContextDllCreateObjectContext"u8;

    [NativeTypeName("#define CONTEXT_OID_CERTIFICATE ((LPCSTR)1)")]
    public static sbyte* CONTEXT_OID_CERTIFICATE => ((sbyte*)(1));

    [NativeTypeName("#define CONTEXT_OID_CRL ((LPCSTR)2)")]
    public static sbyte* CONTEXT_OID_CRL => ((sbyte*)(2));

    [NativeTypeName("#define CONTEXT_OID_CTL ((LPCSTR)3)")]
    public static sbyte* CONTEXT_OID_CTL => ((sbyte*)(3));

    [NativeTypeName("#define CONTEXT_OID_PKCS7 ((LPCSTR)4)")]
    public static sbyte* CONTEXT_OID_PKCS7 => ((sbyte*)(4));

    [NativeTypeName("#define CONTEXT_OID_CAPI2_ANY ((LPCSTR)5)")]
    public static sbyte* CONTEXT_OID_CAPI2_ANY => ((sbyte*)(5));

    [NativeTypeName("#define CONTEXT_OID_OCSP_RESP ((LPCSTR)6)")]
    public static sbyte* CONTEXT_OID_OCSP_RESP => ((sbyte*)(6));
}
