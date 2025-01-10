// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SCH
{
    [NativeTypeName("#define SCH_CRED_V1 0x00000001")]
    public const int SCH_CRED_V1 = 0x00000001;

    [NativeTypeName("#define SCH_CRED_V2 0x00000002")]
    public const int SCH_CRED_V2 = 0x00000002;

    [NativeTypeName("#define SCH_CRED_VERSION 0x00000002")]
    public const int SCH_CRED_VERSION = 0x00000002;

    [NativeTypeName("#define SCH_CRED_V3 0x00000003")]
    public const int SCH_CRED_V3 = 0x00000003;

    [NativeTypeName("#define SCH_CREDENTIALS_VERSION 0x00000005")]
    public const int SCH_CREDENTIALS_VERSION = 0x00000005;

    [NativeTypeName("#define SCH_MAX_EXT_SUBSCRIPTIONS 2")]
    public const int SCH_MAX_EXT_SUBSCRIPTIONS = 2;

    [NativeTypeName("#define SCH_CRED_FORMAT_CERT_CONTEXT 0x00000000")]
    public const int SCH_CRED_FORMAT_CERT_CONTEXT = 0x00000000;

    [NativeTypeName("#define SCH_CRED_FORMAT_CERT_HASH 0x00000001")]
    public const int SCH_CRED_FORMAT_CERT_HASH = 0x00000001;

    [NativeTypeName("#define SCH_CRED_FORMAT_CERT_HASH_STORE 0x00000002")]
    public const int SCH_CRED_FORMAT_CERT_HASH_STORE = 0x00000002;

    [NativeTypeName("#define SCH_CRED_MAX_STORE_NAME_SIZE 128")]
    public const int SCH_CRED_MAX_STORE_NAME_SIZE = 128;

    [NativeTypeName("#define SCH_CRED_MAX_SUPPORTED_ALGS 256")]
    public const int SCH_CRED_MAX_SUPPORTED_ALGS = 256;

    [NativeTypeName("#define SCH_CRED_MAX_SUPPORTED_CERTS 100")]
    public const int SCH_CRED_MAX_SUPPORTED_CERTS = 100;

    [NativeTypeName("#define SCH_MACHINE_CERT_HASH 0x00000001")]
    public const int SCH_MACHINE_CERT_HASH = 0x00000001;

    [NativeTypeName("#define SCH_CRED_NO_SYSTEM_MAPPER 0x00000002")]
    public const int SCH_CRED_NO_SYSTEM_MAPPER = 0x00000002;

    [NativeTypeName("#define SCH_CRED_NO_SERVERNAME_CHECK 0x00000004")]
    public const int SCH_CRED_NO_SERVERNAME_CHECK = 0x00000004;

    [NativeTypeName("#define SCH_CRED_MANUAL_CRED_VALIDATION 0x00000008")]
    public const int SCH_CRED_MANUAL_CRED_VALIDATION = 0x00000008;

    [NativeTypeName("#define SCH_CRED_NO_DEFAULT_CREDS 0x00000010")]
    public const int SCH_CRED_NO_DEFAULT_CREDS = 0x00000010;

    [NativeTypeName("#define SCH_CRED_AUTO_CRED_VALIDATION 0x00000020")]
    public const int SCH_CRED_AUTO_CRED_VALIDATION = 0x00000020;

    [NativeTypeName("#define SCH_CRED_USE_DEFAULT_CREDS 0x00000040")]
    public const int SCH_CRED_USE_DEFAULT_CREDS = 0x00000040;

    [NativeTypeName("#define SCH_CRED_DISABLE_RECONNECTS 0x00000080")]
    public const int SCH_CRED_DISABLE_RECONNECTS = 0x00000080;

    [NativeTypeName("#define SCH_CRED_REVOCATION_CHECK_END_CERT 0x00000100")]
    public const int SCH_CRED_REVOCATION_CHECK_END_CERT = 0x00000100;

    [NativeTypeName("#define SCH_CRED_REVOCATION_CHECK_CHAIN 0x00000200")]
    public const int SCH_CRED_REVOCATION_CHECK_CHAIN = 0x00000200;

    [NativeTypeName("#define SCH_CRED_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT 0x00000400")]
    public const int SCH_CRED_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 0x00000400;

    [NativeTypeName("#define SCH_CRED_IGNORE_NO_REVOCATION_CHECK 0x00000800")]
    public const int SCH_CRED_IGNORE_NO_REVOCATION_CHECK = 0x00000800;

    [NativeTypeName("#define SCH_CRED_IGNORE_REVOCATION_OFFLINE 0x00001000")]
    public const int SCH_CRED_IGNORE_REVOCATION_OFFLINE = 0x00001000;

    [NativeTypeName("#define SCH_CRED_RESTRICTED_ROOTS 0x00002000")]
    public const int SCH_CRED_RESTRICTED_ROOTS = 0x00002000;

    [NativeTypeName("#define SCH_CRED_REVOCATION_CHECK_CACHE_ONLY 0x00004000")]
    public const int SCH_CRED_REVOCATION_CHECK_CACHE_ONLY = 0x00004000;

    [NativeTypeName("#define SCH_CRED_CACHE_ONLY_URL_RETRIEVAL 0x00008000")]
    public const int SCH_CRED_CACHE_ONLY_URL_RETRIEVAL = 0x00008000;

    [NativeTypeName("#define SCH_CRED_MEMORY_STORE_CERT 0x00010000")]
    public const int SCH_CRED_MEMORY_STORE_CERT = 0x00010000;

    [NativeTypeName("#define SCH_CRED_CACHE_ONLY_URL_RETRIEVAL_ON_CREATE 0x00020000")]
    public const int SCH_CRED_CACHE_ONLY_URL_RETRIEVAL_ON_CREATE = 0x00020000;

    [NativeTypeName("#define SCH_SEND_ROOT_CERT 0x00040000")]
    public const int SCH_SEND_ROOT_CERT = 0x00040000;

    [NativeTypeName("#define SCH_CRED_SNI_CREDENTIAL 0x00080000")]
    public const int SCH_CRED_SNI_CREDENTIAL = 0x00080000;

    [NativeTypeName("#define SCH_CRED_SNI_ENABLE_OCSP 0x00100000")]
    public const int SCH_CRED_SNI_ENABLE_OCSP = 0x00100000;

    [NativeTypeName("#define SCH_SEND_AUX_RECORD 0x00200000")]
    public const int SCH_SEND_AUX_RECORD = 0x00200000;

    [NativeTypeName("#define SCH_USE_STRONG_CRYPTO 0x00400000")]
    public const int SCH_USE_STRONG_CRYPTO = 0x00400000;

    [NativeTypeName("#define SCH_USE_PRESHAREDKEY_ONLY 0x00800000")]
    public const int SCH_USE_PRESHAREDKEY_ONLY = 0x00800000;

    [NativeTypeName("#define SCH_USE_DTLS_ONLY 0x01000000")]
    public const int SCH_USE_DTLS_ONLY = 0x01000000;

    [NativeTypeName("#define SCH_ALLOW_NULL_ENCRYPTION 0x02000000")]
    public const int SCH_ALLOW_NULL_ENCRYPTION = 0x02000000;

    [NativeTypeName("#define SCH_CRED_DEFERRED_CRED_VALIDATION 0x04000000")]
    public const int SCH_CRED_DEFERRED_CRED_VALIDATION = 0x04000000;

    [NativeTypeName("#define SCH_CRED_X509_CERTCHAIN 0x00000001")]
    public const int SCH_CRED_X509_CERTCHAIN = 0x00000001;

    [NativeTypeName("#define SCH_CRED_X509_CAPI 0x00000002")]
    public const int SCH_CRED_X509_CAPI = 0x00000002;

    [NativeTypeName("#define SCH_CRED_CERT_CONTEXT 0x00000003")]
    public const int SCH_CRED_CERT_CONTEXT = 0x00000003;
}
