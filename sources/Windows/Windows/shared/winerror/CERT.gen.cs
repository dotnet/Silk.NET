// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class CERT
{
    [NativeTypeName("#define CERT_E_EXPIRED _HRESULT_TYPEDEF_(0x800B0101L)")]
    public const int CERT_E_EXPIRED = unchecked((int)(0x800B0101));
    [NativeTypeName("#define CERT_E_VALIDITYPERIODNESTING _HRESULT_TYPEDEF_(0x800B0102L)")]
    public const int CERT_E_VALIDITYPERIODNESTING = unchecked((int)(0x800B0102));
    [NativeTypeName("#define CERT_E_ROLE _HRESULT_TYPEDEF_(0x800B0103L)")]
    public const int CERT_E_ROLE = unchecked((int)(0x800B0103));
    [NativeTypeName("#define CERT_E_PATHLENCONST _HRESULT_TYPEDEF_(0x800B0104L)")]
    public const int CERT_E_PATHLENCONST = unchecked((int)(0x800B0104));
    [NativeTypeName("#define CERT_E_CRITICAL _HRESULT_TYPEDEF_(0x800B0105L)")]
    public const int CERT_E_CRITICAL = unchecked((int)(0x800B0105));
    [NativeTypeName("#define CERT_E_PURPOSE _HRESULT_TYPEDEF_(0x800B0106L)")]
    public const int CERT_E_PURPOSE = unchecked((int)(0x800B0106));
    [NativeTypeName("#define CERT_E_ISSUERCHAINING _HRESULT_TYPEDEF_(0x800B0107L)")]
    public const int CERT_E_ISSUERCHAINING = unchecked((int)(0x800B0107));
    [NativeTypeName("#define CERT_E_MALFORMED _HRESULT_TYPEDEF_(0x800B0108L)")]
    public const int CERT_E_MALFORMED = unchecked((int)(0x800B0108));
    [NativeTypeName("#define CERT_E_UNTRUSTEDROOT _HRESULT_TYPEDEF_(0x800B0109L)")]
    public const int CERT_E_UNTRUSTEDROOT = unchecked((int)(0x800B0109));
    [NativeTypeName("#define CERT_E_CHAINING _HRESULT_TYPEDEF_(0x800B010AL)")]
    public const int CERT_E_CHAINING = unchecked((int)(0x800B010A));
    [NativeTypeName("#define CERT_E_REVOKED _HRESULT_TYPEDEF_(0x800B010CL)")]
    public const int CERT_E_REVOKED = unchecked((int)(0x800B010C));
    [NativeTypeName("#define CERT_E_UNTRUSTEDTESTROOT _HRESULT_TYPEDEF_(0x800B010DL)")]
    public const int CERT_E_UNTRUSTEDTESTROOT = unchecked((int)(0x800B010D));
    [NativeTypeName("#define CERT_E_REVOCATION_FAILURE _HRESULT_TYPEDEF_(0x800B010EL)")]
    public const int CERT_E_REVOCATION_FAILURE = unchecked((int)(0x800B010E));
    [NativeTypeName("#define CERT_E_CN_NO_MATCH _HRESULT_TYPEDEF_(0x800B010FL)")]
    public const int CERT_E_CN_NO_MATCH = unchecked((int)(0x800B010F));
    [NativeTypeName("#define CERT_E_WRONG_USAGE _HRESULT_TYPEDEF_(0x800B0110L)")]
    public const int CERT_E_WRONG_USAGE = unchecked((int)(0x800B0110));
    [NativeTypeName("#define CERT_E_UNTRUSTEDCA _HRESULT_TYPEDEF_(0x800B0112L)")]
    public const int CERT_E_UNTRUSTEDCA = unchecked((int)(0x800B0112));
    [NativeTypeName("#define CERT_E_INVALID_POLICY _HRESULT_TYPEDEF_(0x800B0113L)")]
    public const int CERT_E_INVALID_POLICY = unchecked((int)(0x800B0113));
    [NativeTypeName("#define CERT_E_INVALID_NAME _HRESULT_TYPEDEF_(0x800B0114L)")]
    public const int CERT_E_INVALID_NAME = unchecked((int)(0x800B0114));
}