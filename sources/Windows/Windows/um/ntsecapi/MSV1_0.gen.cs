// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

public static partial class MSV1_0
{
    [NativeTypeName("#define MSV1_0_PACKAGE_NAME \"MICROSOFT_AUTHENTICATION_PACKAGE_V1_0\"")]
    public static ReadOnlySpan<byte> MSV1_0_PACKAGE_NAME => "MICROSOFT_AUTHENTICATION_PACKAGE_V1_0"u8;

    [NativeTypeName("#define MSV1_0_PACKAGE_NAMEW L\"MICROSOFT_AUTHENTICATION_PACKAGE_V1_0\"")]
    public const string MSV1_0_PACKAGE_NAMEW = "MICROSOFT_AUTHENTICATION_PACKAGE_V1_0";

    [NativeTypeName("#define MSV1_0_PACKAGE_NAMEW_LENGTH sizeof(MSV1_0_PACKAGE_NAMEW) - sizeof(WCHAR)")]
    public const ulong MSV1_0_PACKAGE_NAMEW_LENGTH = 76 - 2;

    [NativeTypeName("#define MSV1_0_SUBAUTHENTICATION_KEY \"SYSTEM\\\\CurrentControlSet\\\\Control\\\\Lsa\\\\MSV1_0\"")]
    public static ReadOnlySpan<byte> MSV1_0_SUBAUTHENTICATION_KEY => "SYSTEM\\CurrentControlSet\\Control\\Lsa\\MSV1_0"u8;

    [NativeTypeName("#define MSV1_0_SUBAUTHENTICATION_VALUE \"Auth\"")]
    public static ReadOnlySpan<byte> MSV1_0_SUBAUTHENTICATION_VALUE => "Auth"u8;

    [NativeTypeName("#define MSV1_0_CHALLENGE_LENGTH 8")]
    public const int MSV1_0_CHALLENGE_LENGTH = 8;

    [NativeTypeName("#define MSV1_0_USER_SESSION_KEY_LENGTH 16")]
    public const int MSV1_0_USER_SESSION_KEY_LENGTH = 16;

    [NativeTypeName("#define MSV1_0_LANMAN_SESSION_KEY_LENGTH 8")]
    public const int MSV1_0_LANMAN_SESSION_KEY_LENGTH = 8;

    [NativeTypeName("#define MSV1_0_CLEARTEXT_PASSWORD_ALLOWED 0x02")]
    public const int MSV1_0_CLEARTEXT_PASSWORD_ALLOWED = 0x02;

    [NativeTypeName("#define MSV1_0_UPDATE_LOGON_STATISTICS 0x04")]
    public const int MSV1_0_UPDATE_LOGON_STATISTICS = 0x04;

    [NativeTypeName("#define MSV1_0_RETURN_USER_PARAMETERS 0x08")]
    public const int MSV1_0_RETURN_USER_PARAMETERS = 0x08;

    [NativeTypeName("#define MSV1_0_DONT_TRY_GUEST_ACCOUNT 0x10")]
    public const int MSV1_0_DONT_TRY_GUEST_ACCOUNT = 0x10;

    [NativeTypeName("#define MSV1_0_ALLOW_SERVER_TRUST_ACCOUNT 0x20")]
    public const int MSV1_0_ALLOW_SERVER_TRUST_ACCOUNT = 0x20;

    [NativeTypeName("#define MSV1_0_RETURN_PASSWORD_EXPIRY 0x40")]
    public const int MSV1_0_RETURN_PASSWORD_EXPIRY = 0x40;

    [NativeTypeName("#define MSV1_0_USE_CLIENT_CHALLENGE 0x80")]
    public const int MSV1_0_USE_CLIENT_CHALLENGE = 0x80;

    [NativeTypeName("#define MSV1_0_TRY_GUEST_ACCOUNT_ONLY 0x100")]
    public const int MSV1_0_TRY_GUEST_ACCOUNT_ONLY = 0x100;

    [NativeTypeName("#define MSV1_0_RETURN_PROFILE_PATH 0x200")]
    public const int MSV1_0_RETURN_PROFILE_PATH = 0x200;

    [NativeTypeName("#define MSV1_0_TRY_SPECIFIED_DOMAIN_ONLY 0x400")]
    public const int MSV1_0_TRY_SPECIFIED_DOMAIN_ONLY = 0x400;

    [NativeTypeName("#define MSV1_0_ALLOW_WORKSTATION_TRUST_ACCOUNT 0x800")]
    public const int MSV1_0_ALLOW_WORKSTATION_TRUST_ACCOUNT = 0x800;

    [NativeTypeName("#define MSV1_0_DISABLE_PERSONAL_FALLBACK 0x00001000")]
    public const int MSV1_0_DISABLE_PERSONAL_FALLBACK = 0x00001000;

    [NativeTypeName("#define MSV1_0_ALLOW_FORCE_GUEST 0x00002000")]
    public const int MSV1_0_ALLOW_FORCE_GUEST = 0x00002000;

    [NativeTypeName("#define MSV1_0_CLEARTEXT_PASSWORD_SUPPLIED 0x00004000")]
    public const int MSV1_0_CLEARTEXT_PASSWORD_SUPPLIED = 0x00004000;

    [NativeTypeName("#define MSV1_0_USE_DOMAIN_FOR_ROUTING_ONLY 0x00008000")]
    public const int MSV1_0_USE_DOMAIN_FOR_ROUTING_ONLY = 0x00008000;

    [NativeTypeName("#define MSV1_0_SUBAUTHENTICATION_DLL_EX 0x00100000")]
    public const int MSV1_0_SUBAUTHENTICATION_DLL_EX = 0x00100000;

    [NativeTypeName("#define MSV1_0_ALLOW_MSVCHAPV2 0x00010000")]
    public const int MSV1_0_ALLOW_MSVCHAPV2 = 0x00010000;

    [NativeTypeName("#define MSV1_0_S4U2SELF 0x00020000")]
    public const int MSV1_0_S4U2SELF = 0x00020000;

    [NativeTypeName("#define MSV1_0_CHECK_LOGONHOURS_FOR_S4U 0x00040000")]
    public const int MSV1_0_CHECK_LOGONHOURS_FOR_S4U = 0x00040000;

    [NativeTypeName("#define MSV1_0_INTERNET_DOMAIN 0x00080000")]
    public const int MSV1_0_INTERNET_DOMAIN = 0x00080000;

    [NativeTypeName("#define MSV1_0_SUBAUTHENTICATION_DLL 0xFF000000")]
    public const uint MSV1_0_SUBAUTHENTICATION_DLL = 0xFF000000;

    [NativeTypeName("#define MSV1_0_SUBAUTHENTICATION_DLL_SHIFT 24")]
    public const int MSV1_0_SUBAUTHENTICATION_DLL_SHIFT = 24;

    [NativeTypeName("#define MSV1_0_MNS_LOGON 0x01000000")]
    public const int MSV1_0_MNS_LOGON = 0x01000000;

    [NativeTypeName("#define MSV1_0_SUBAUTHENTICATION_DLL_RAS 2")]
    public const int MSV1_0_SUBAUTHENTICATION_DLL_RAS = 2;

    [NativeTypeName("#define MSV1_0_SUBAUTHENTICATION_DLL_IIS 132")]
    public const int MSV1_0_SUBAUTHENTICATION_DLL_IIS = 132;

    [NativeTypeName("#define MSV1_0_S4U_LOGON_FLAG_CHECK_LOGONHOURS 0x2")]
    public const int MSV1_0_S4U_LOGON_FLAG_CHECK_LOGONHOURS = 0x2;

    [NativeTypeName("#define MSV1_0_SUBAUTHENTICATION_FLAGS 0xFF000000")]
    public const uint MSV1_0_SUBAUTHENTICATION_FLAGS = 0xFF000000;

    [NativeTypeName("#define MSV1_0_OWF_PASSWORD_LENGTH 16")]
    public const int MSV1_0_OWF_PASSWORD_LENGTH = 16;

    [NativeTypeName("#define MSV1_0_SHA_PASSWORD_LENGTH 20")]
    public const int MSV1_0_SHA_PASSWORD_LENGTH = 20;

    [NativeTypeName("#define MSV1_0_CREDENTIAL_KEY_LENGTH 20")]
    public const int MSV1_0_CREDENTIAL_KEY_LENGTH = 20;

    [NativeTypeName("#define MSV1_0_CRED_LM_PRESENT 0x0001")]
    public const int MSV1_0_CRED_LM_PRESENT = 0x0001;

    [NativeTypeName("#define MSV1_0_CRED_NT_PRESENT 0x0002")]
    public const int MSV1_0_CRED_NT_PRESENT = 0x0002;

    [NativeTypeName("#define MSV1_0_CRED_REMOVED 0x0004")]
    public const int MSV1_0_CRED_REMOVED = 0x0004;

    [NativeTypeName("#define MSV1_0_CRED_CREDKEY_PRESENT 0x0008")]
    public const int MSV1_0_CRED_CREDKEY_PRESENT = 0x0008;

    [NativeTypeName("#define MSV1_0_CRED_SHA_PRESENT 0x0010")]
    public const int MSV1_0_CRED_SHA_PRESENT = 0x0010;

    [NativeTypeName("#define MSV1_0_CRED_VERSION 0")]
    public const int MSV1_0_CRED_VERSION = 0;

    [NativeTypeName("#define MSV1_0_CRED_VERSION_V2 2")]
    public const int MSV1_0_CRED_VERSION_V2 = 2;

    [NativeTypeName("#define MSV1_0_CRED_VERSION_V3 4")]
    public const int MSV1_0_CRED_VERSION_V3 = 4;

    [NativeTypeName("#define MSV1_0_CRED_VERSION_IUM 0xffff0001")]
    public const uint MSV1_0_CRED_VERSION_IUM = 0xffff0001;

    [NativeTypeName("#define MSV1_0_CRED_VERSION_REMOTE 0xffff0002")]
    public const uint MSV1_0_CRED_VERSION_REMOTE = 0xffff0002;

    [NativeTypeName("#define MSV1_0_CRED_VERSION_ARSO 0xffff0003")]
    public const uint MSV1_0_CRED_VERSION_ARSO = 0xffff0003;

    [NativeTypeName("#define MSV1_0_CRED_VERSION_RESERVED_1 0xfffffffe")]
    public const uint MSV1_0_CRED_VERSION_RESERVED_1 = 0xfffffffe;

    [NativeTypeName("#define MSV1_0_CRED_VERSION_INVALID 0xffffffff")]
    public const uint MSV1_0_CRED_VERSION_INVALID = 0xffffffff;

    [NativeTypeName("#define MSV1_0_NTLM3_RESPONSE_LENGTH 16")]
    public const int MSV1_0_NTLM3_RESPONSE_LENGTH = 16;

    [NativeTypeName("#define MSV1_0_NTLM3_OWF_LENGTH 16")]
    public const int MSV1_0_NTLM3_OWF_LENGTH = 16;

    [NativeTypeName("#define MSV1_0_MAX_NTLM3_LIFE 129600")]
    public const int MSV1_0_MAX_NTLM3_LIFE = 129600;

    [NativeTypeName("#define MSV1_0_MAX_AVL_SIZE 64000")]
    public const int MSV1_0_MAX_AVL_SIZE = 64000;

    [NativeTypeName("#define MSV1_0_AV_FLAG_FORCE_GUEST 0x00000001")]
    public const int MSV1_0_AV_FLAG_FORCE_GUEST = 0x00000001;

    [NativeTypeName("#define MSV1_0_AV_FLAG_MIC_HANDSHAKE_MESSAGES 0x00000002")]
    public const int MSV1_0_AV_FLAG_MIC_HANDSHAKE_MESSAGES = 0x00000002;

    [NativeTypeName("#define MSV1_0_AV_FLAG_UNVERIFIED_TARGET 0x00000004")]
    public const int MSV1_0_AV_FLAG_UNVERIFIED_TARGET = 0x00000004;

    [NativeTypeName("#define MSV1_0_NTLM3_INPUT_LENGTH (sizeof(MSV1_0_NTLM3_RESPONSE) - MSV1_0_NTLM3_RESPONSE_LENGTH)")]
    public const ulong MSV1_0_NTLM3_INPUT_LENGTH = (48 - 16);
}
