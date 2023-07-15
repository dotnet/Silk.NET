// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static unsafe partial class OCSP
{
    [NativeTypeName("#define OCSP_SIGNED_REQUEST ((LPCSTR) 65)")]
    public static sbyte* OCSP_SIGNED_REQUEST => ((sbyte*)(65));

    [NativeTypeName("#define OCSP_REQUEST ((LPCSTR) 66)")]
    public static sbyte* OCSP_REQUEST => ((sbyte*)(66));

    [NativeTypeName("#define OCSP_RESPONSE ((LPCSTR) 67)")]
    public static sbyte* OCSP_RESPONSE => ((sbyte*)(67));

    [NativeTypeName("#define OCSP_BASIC_SIGNED_RESPONSE ((LPCSTR) 68)")]
    public static sbyte* OCSP_BASIC_SIGNED_RESPONSE => ((sbyte*)(68));

    [NativeTypeName("#define OCSP_BASIC_RESPONSE ((LPCSTR) 69)")]
    public static sbyte* OCSP_BASIC_RESPONSE => ((sbyte*)(69));

    [NativeTypeName("#define OCSP_REQUEST_V1 0")]
    public const int OCSP_REQUEST_V1 = 0;
    [NativeTypeName("#define OCSP_SUCCESSFUL_RESPONSE 0")]
    public const int OCSP_SUCCESSFUL_RESPONSE = 0;
    [NativeTypeName("#define OCSP_MALFORMED_REQUEST_RESPONSE 1")]
    public const int OCSP_MALFORMED_REQUEST_RESPONSE = 1;
    [NativeTypeName("#define OCSP_INTERNAL_ERROR_RESPONSE 2")]
    public const int OCSP_INTERNAL_ERROR_RESPONSE = 2;
    [NativeTypeName("#define OCSP_TRY_LATER_RESPONSE 3")]
    public const int OCSP_TRY_LATER_RESPONSE = 3;
    [NativeTypeName("#define OCSP_SIG_REQUIRED_RESPONSE 5")]
    public const int OCSP_SIG_REQUIRED_RESPONSE = 5;
    [NativeTypeName("#define OCSP_UNAUTHORIZED_RESPONSE 6")]
    public const int OCSP_UNAUTHORIZED_RESPONSE = 6;
    [NativeTypeName("#define OCSP_BASIC_GOOD_CERT_STATUS 0")]
    public const int OCSP_BASIC_GOOD_CERT_STATUS = 0;
    [NativeTypeName("#define OCSP_BASIC_REVOKED_CERT_STATUS 1")]
    public const int OCSP_BASIC_REVOKED_CERT_STATUS = 1;
    [NativeTypeName("#define OCSP_BASIC_UNKNOWN_CERT_STATUS 2")]
    public const int OCSP_BASIC_UNKNOWN_CERT_STATUS = 2;
    [NativeTypeName("#define OCSP_BASIC_RESPONSE_V1 0")]
    public const int OCSP_BASIC_RESPONSE_V1 = 0;
    [NativeTypeName("#define OCSP_BASIC_BY_NAME_RESPONDER_ID 1")]
    public const int OCSP_BASIC_BY_NAME_RESPONDER_ID = 1;
    [NativeTypeName("#define OCSP_BASIC_BY_KEY_RESPONDER_ID 2")]
    public const int OCSP_BASIC_BY_KEY_RESPONDER_ID = 2;
}