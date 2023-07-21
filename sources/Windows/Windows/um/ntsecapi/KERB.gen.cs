// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class KERB
{
    [NativeTypeName("#define KERB_ETYPE_NULL 0")]
    public const int KERB_ETYPE_NULL = 0;

    [NativeTypeName("#define KERB_ETYPE_DES_CBC_CRC 1")]
    public const int KERB_ETYPE_DES_CBC_CRC = 1;

    [NativeTypeName("#define KERB_ETYPE_DES_CBC_MD4 2")]
    public const int KERB_ETYPE_DES_CBC_MD4 = 2;

    [NativeTypeName("#define KERB_ETYPE_DES_CBC_MD5 3")]
    public const int KERB_ETYPE_DES_CBC_MD5 = 3;

    [NativeTypeName("#define KERB_ETYPE_AES128_CTS_HMAC_SHA1_96 17")]
    public const int KERB_ETYPE_AES128_CTS_HMAC_SHA1_96 = 17;

    [NativeTypeName("#define KERB_ETYPE_AES256_CTS_HMAC_SHA1_96 18")]
    public const int KERB_ETYPE_AES256_CTS_HMAC_SHA1_96 = 18;

    [NativeTypeName("#define KERB_ETYPE_RC4_MD4 -128")]
    public const int KERB_ETYPE_RC4_MD4 = -128;

    [NativeTypeName("#define KERB_ETYPE_RC4_PLAIN2 -129")]
    public const int KERB_ETYPE_RC4_PLAIN2 = -129;

    [NativeTypeName("#define KERB_ETYPE_RC4_LM -130")]
    public const int KERB_ETYPE_RC4_LM = -130;

    [NativeTypeName("#define KERB_ETYPE_RC4_SHA -131")]
    public const int KERB_ETYPE_RC4_SHA = -131;

    [NativeTypeName("#define KERB_ETYPE_DES_PLAIN -132")]
    public const int KERB_ETYPE_DES_PLAIN = -132;

    [NativeTypeName("#define KERB_ETYPE_RC4_HMAC_OLD -133")]
    public const int KERB_ETYPE_RC4_HMAC_OLD = -133;

    [NativeTypeName("#define KERB_ETYPE_RC4_PLAIN_OLD -134")]
    public const int KERB_ETYPE_RC4_PLAIN_OLD = -134;

    [NativeTypeName("#define KERB_ETYPE_RC4_HMAC_OLD_EXP -135")]
    public const int KERB_ETYPE_RC4_HMAC_OLD_EXP = -135;

    [NativeTypeName("#define KERB_ETYPE_RC4_PLAIN_OLD_EXP -136")]
    public const int KERB_ETYPE_RC4_PLAIN_OLD_EXP = -136;

    [NativeTypeName("#define KERB_ETYPE_RC4_PLAIN -140")]
    public const int KERB_ETYPE_RC4_PLAIN = -140;

    [NativeTypeName("#define KERB_ETYPE_RC4_PLAIN_EXP -141")]
    public const int KERB_ETYPE_RC4_PLAIN_EXP = -141;

    [NativeTypeName("#define KERB_ETYPE_AES128_CTS_HMAC_SHA1_96_PLAIN -148")]
    public const int KERB_ETYPE_AES128_CTS_HMAC_SHA1_96_PLAIN = -148;

    [NativeTypeName("#define KERB_ETYPE_AES256_CTS_HMAC_SHA1_96_PLAIN -149")]
    public const int KERB_ETYPE_AES256_CTS_HMAC_SHA1_96_PLAIN = -149;

    [NativeTypeName("#define KERB_ETYPE_DSA_SHA1_CMS 9")]
    public const int KERB_ETYPE_DSA_SHA1_CMS = 9;

    [NativeTypeName("#define KERB_ETYPE_RSA_MD5_CMS 10")]
    public const int KERB_ETYPE_RSA_MD5_CMS = 10;

    [NativeTypeName("#define KERB_ETYPE_RSA_SHA1_CMS 11")]
    public const int KERB_ETYPE_RSA_SHA1_CMS = 11;

    [NativeTypeName("#define KERB_ETYPE_RC2_CBC_ENV 12")]
    public const int KERB_ETYPE_RC2_CBC_ENV = 12;

    [NativeTypeName("#define KERB_ETYPE_RSA_ENV 13")]
    public const int KERB_ETYPE_RSA_ENV = 13;

    [NativeTypeName("#define KERB_ETYPE_RSA_ES_OEAP_ENV 14")]
    public const int KERB_ETYPE_RSA_ES_OEAP_ENV = 14;

    [NativeTypeName("#define KERB_ETYPE_DES_EDE3_CBC_ENV 15")]
    public const int KERB_ETYPE_DES_EDE3_CBC_ENV = 15;

    [NativeTypeName("#define KERB_ETYPE_DSA_SIGN 8")]
    public const int KERB_ETYPE_DSA_SIGN = 8;

    [NativeTypeName("#define KERB_ETYPE_RSA_PRIV 9")]
    public const int KERB_ETYPE_RSA_PRIV = 9;

    [NativeTypeName("#define KERB_ETYPE_RSA_PUB 10")]
    public const int KERB_ETYPE_RSA_PUB = 10;

    [NativeTypeName("#define KERB_ETYPE_RSA_PUB_MD5 11")]
    public const int KERB_ETYPE_RSA_PUB_MD5 = 11;

    [NativeTypeName("#define KERB_ETYPE_RSA_PUB_SHA1 12")]
    public const int KERB_ETYPE_RSA_PUB_SHA1 = 12;

    [NativeTypeName("#define KERB_ETYPE_PKCS7_PUB 13")]
    public const int KERB_ETYPE_PKCS7_PUB = 13;

    [NativeTypeName("#define KERB_ETYPE_DES3_CBC_MD5 5")]
    public const int KERB_ETYPE_DES3_CBC_MD5 = 5;

    [NativeTypeName("#define KERB_ETYPE_DES3_CBC_SHA1 7")]
    public const int KERB_ETYPE_DES3_CBC_SHA1 = 7;

    [NativeTypeName("#define KERB_ETYPE_DES3_CBC_SHA1_KD 16")]
    public const int KERB_ETYPE_DES3_CBC_SHA1_KD = 16;

    [NativeTypeName("#define KERB_ETYPE_DES_CBC_MD5_NT 20")]
    public const int KERB_ETYPE_DES_CBC_MD5_NT = 20;

    [NativeTypeName("#define KERB_ETYPE_RC4_HMAC_NT 23")]
    public const int KERB_ETYPE_RC4_HMAC_NT = 23;

    [NativeTypeName("#define KERB_ETYPE_RC4_HMAC_NT_EXP 24")]
    public const int KERB_ETYPE_RC4_HMAC_NT_EXP = 24;

    [NativeTypeName("#define KERB_CHECKSUM_NONE 0")]
    public const int KERB_CHECKSUM_NONE = 0;

    [NativeTypeName("#define KERB_CHECKSUM_CRC32 1")]
    public const int KERB_CHECKSUM_CRC32 = 1;

    [NativeTypeName("#define KERB_CHECKSUM_MD4 2")]
    public const int KERB_CHECKSUM_MD4 = 2;

    [NativeTypeName("#define KERB_CHECKSUM_KRB_DES_MAC 4")]
    public const int KERB_CHECKSUM_KRB_DES_MAC = 4;

    [NativeTypeName("#define KERB_CHECKSUM_KRB_DES_MAC_K 5")]
    public const int KERB_CHECKSUM_KRB_DES_MAC_K = 5;

    [NativeTypeName("#define KERB_CHECKSUM_MD5 7")]
    public const int KERB_CHECKSUM_MD5 = 7;

    [NativeTypeName("#define KERB_CHECKSUM_MD5_DES 8")]
    public const int KERB_CHECKSUM_MD5_DES = 8;

    [NativeTypeName("#define KERB_CHECKSUM_SHA1_NEW 14")]
    public const int KERB_CHECKSUM_SHA1_NEW = 14;

    [NativeTypeName("#define KERB_CHECKSUM_HMAC_SHA1_96_AES128 15")]
    public const int KERB_CHECKSUM_HMAC_SHA1_96_AES128 = 15;

    [NativeTypeName("#define KERB_CHECKSUM_HMAC_SHA1_96_AES256 16")]
    public const int KERB_CHECKSUM_HMAC_SHA1_96_AES256 = 16;

    [NativeTypeName("#define KERB_CHECKSUM_LM -130")]
    public const int KERB_CHECKSUM_LM = -130;

    [NativeTypeName("#define KERB_CHECKSUM_SHA1 -131")]
    public const int KERB_CHECKSUM_SHA1 = -131;

    [NativeTypeName("#define KERB_CHECKSUM_REAL_CRC32 -132")]
    public const int KERB_CHECKSUM_REAL_CRC32 = -132;

    [NativeTypeName("#define KERB_CHECKSUM_DES_MAC -133")]
    public const int KERB_CHECKSUM_DES_MAC = -133;

    [NativeTypeName("#define KERB_CHECKSUM_DES_MAC_MD5 -134")]
    public const int KERB_CHECKSUM_DES_MAC_MD5 = -134;

    [NativeTypeName("#define KERB_CHECKSUM_MD25 -135")]
    public const int KERB_CHECKSUM_MD25 = -135;

    [NativeTypeName("#define KERB_CHECKSUM_RC4_MD5 -136")]
    public const int KERB_CHECKSUM_RC4_MD5 = -136;

    [NativeTypeName("#define KERB_CHECKSUM_MD5_HMAC -137")]
    public const int KERB_CHECKSUM_MD5_HMAC = -137;

    [NativeTypeName("#define KERB_CHECKSUM_HMAC_MD5 -138")]
    public const int KERB_CHECKSUM_HMAC_MD5 = -138;

    [NativeTypeName("#define KERB_CHECKSUM_SHA256 -139")]
    public const int KERB_CHECKSUM_SHA256 = -139;

    [NativeTypeName("#define KERB_CHECKSUM_SHA384 -140")]
    public const int KERB_CHECKSUM_SHA384 = -140;

    [NativeTypeName("#define KERB_CHECKSUM_SHA512 -141")]
    public const int KERB_CHECKSUM_SHA512 = -141;

    [NativeTypeName("#define KERB_CHECKSUM_HMAC_SHA1_96_AES128_Ki -150")]
    public const int KERB_CHECKSUM_HMAC_SHA1_96_AES128_Ki = -150;

    [NativeTypeName("#define KERB_CHECKSUM_HMAC_SHA1_96_AES256_Ki -151")]
    public const int KERB_CHECKSUM_HMAC_SHA1_96_AES256_Ki = -151;

    [NativeTypeName("#define KERB_TICKET_FLAGS_reserved 0x80000000")]
    public const uint KERB_TICKET_FLAGS_reserved = 0x80000000;

    [NativeTypeName("#define KERB_TICKET_FLAGS_forwardable 0x40000000")]
    public const int KERB_TICKET_FLAGS_forwardable = 0x40000000;

    [NativeTypeName("#define KERB_TICKET_FLAGS_forwarded 0x20000000")]
    public const int KERB_TICKET_FLAGS_forwarded = 0x20000000;

    [NativeTypeName("#define KERB_TICKET_FLAGS_proxiable 0x10000000")]
    public const int KERB_TICKET_FLAGS_proxiable = 0x10000000;

    [NativeTypeName("#define KERB_TICKET_FLAGS_proxy 0x08000000")]
    public const int KERB_TICKET_FLAGS_proxy = 0x08000000;

    [NativeTypeName("#define KERB_TICKET_FLAGS_may_postdate 0x04000000")]
    public const int KERB_TICKET_FLAGS_may_postdate = 0x04000000;

    [NativeTypeName("#define KERB_TICKET_FLAGS_postdated 0x02000000")]
    public const int KERB_TICKET_FLAGS_postdated = 0x02000000;

    [NativeTypeName("#define KERB_TICKET_FLAGS_invalid 0x01000000")]
    public const int KERB_TICKET_FLAGS_invalid = 0x01000000;

    [NativeTypeName("#define KERB_TICKET_FLAGS_renewable 0x00800000")]
    public const int KERB_TICKET_FLAGS_renewable = 0x00800000;

    [NativeTypeName("#define KERB_TICKET_FLAGS_initial 0x00400000")]
    public const int KERB_TICKET_FLAGS_initial = 0x00400000;

    [NativeTypeName("#define KERB_TICKET_FLAGS_pre_authent 0x00200000")]
    public const int KERB_TICKET_FLAGS_pre_authent = 0x00200000;

    [NativeTypeName("#define KERB_TICKET_FLAGS_hw_authent 0x00100000")]
    public const int KERB_TICKET_FLAGS_hw_authent = 0x00100000;

    [NativeTypeName("#define KERB_TICKET_FLAGS_ok_as_delegate 0x00040000")]
    public const int KERB_TICKET_FLAGS_ok_as_delegate = 0x00040000;

    [NativeTypeName("#define KERB_TICKET_FLAGS_name_canonicalize 0x00010000")]
    public const int KERB_TICKET_FLAGS_name_canonicalize = 0x00010000;

    [NativeTypeName("#define KERB_TICKET_FLAGS_enc_pa_rep 0x00010000")]
    public const int KERB_TICKET_FLAGS_enc_pa_rep = 0x00010000;

    [NativeTypeName("#define KERB_TICKET_FLAGS_reserved1 0x00000001")]
    public const int KERB_TICKET_FLAGS_reserved1 = 0x00000001;

    [NativeTypeName("#define KERB_WRAP_NO_ENCRYPT 0x80000001")]
    public const uint KERB_WRAP_NO_ENCRYPT = 0x80000001;

    [NativeTypeName("#define KERB_CERTIFICATE_LOGON_FLAG_CHECK_DUPLICATES 0x1")]
    public const int KERB_CERTIFICATE_LOGON_FLAG_CHECK_DUPLICATES = 0x1;

    [NativeTypeName("#define KERB_CERTIFICATE_LOGON_FLAG_USE_CERTIFICATE_INFO 0x2")]
    public const int KERB_CERTIFICATE_LOGON_FLAG_USE_CERTIFICATE_INFO = 0x2;

    [NativeTypeName("#define KERB_CERTIFICATE_S4U_LOGON_FLAG_CHECK_DUPLICATES 0x1")]
    public const int KERB_CERTIFICATE_S4U_LOGON_FLAG_CHECK_DUPLICATES = 0x1;

    [NativeTypeName("#define KERB_CERTIFICATE_S4U_LOGON_FLAG_CHECK_LOGONHOURS 0x2")]
    public const int KERB_CERTIFICATE_S4U_LOGON_FLAG_CHECK_LOGONHOURS = 0x2;

    [NativeTypeName("#define KERB_CERTIFICATE_S4U_LOGON_FLAG_FAIL_IF_NT_AUTH_POLICY_REQUIRED 0x4")]
    public const int KERB_CERTIFICATE_S4U_LOGON_FLAG_FAIL_IF_NT_AUTH_POLICY_REQUIRED = 0x4;

    [NativeTypeName("#define KERB_CERTIFICATE_S4U_LOGON_FLAG_IDENTIFY 0x8")]
    public const int KERB_CERTIFICATE_S4U_LOGON_FLAG_IDENTIFY = 0x8;

    [NativeTypeName("#define KERB_LOGON_FLAG_ALLOW_EXPIRED_TICKET 0x1")]
    public const int KERB_LOGON_FLAG_ALLOW_EXPIRED_TICKET = 0x1;

    [NativeTypeName("#define KERB_LOGON_FLAG_REDIRECTED 0x2")]
    public const int KERB_LOGON_FLAG_REDIRECTED = 0x2;

    [NativeTypeName("#define KERB_S4U_LOGON_FLAG_CHECK_LOGONHOURS 0x2")]
    public const int KERB_S4U_LOGON_FLAG_CHECK_LOGONHOURS = 0x2;

    [NativeTypeName("#define KERB_S4U_LOGON_FLAG_IDENTIFY 0x8")]
    public const int KERB_S4U_LOGON_FLAG_IDENTIFY = 0x8;

    [NativeTypeName("#define KERB_USE_DEFAULT_TICKET_FLAGS 0x0")]
    public const int KERB_USE_DEFAULT_TICKET_FLAGS = 0x0;

    [NativeTypeName("#define KERB_RETRIEVE_TICKET_DEFAULT 0x0")]
    public const int KERB_RETRIEVE_TICKET_DEFAULT = 0x0;

    [NativeTypeName("#define KERB_RETRIEVE_TICKET_DONT_USE_CACHE 0x1")]
    public const int KERB_RETRIEVE_TICKET_DONT_USE_CACHE = 0x1;

    [NativeTypeName("#define KERB_RETRIEVE_TICKET_USE_CACHE_ONLY 0x2")]
    public const int KERB_RETRIEVE_TICKET_USE_CACHE_ONLY = 0x2;

    [NativeTypeName("#define KERB_RETRIEVE_TICKET_USE_CREDHANDLE 0x4")]
    public const int KERB_RETRIEVE_TICKET_USE_CREDHANDLE = 0x4;

    [NativeTypeName("#define KERB_RETRIEVE_TICKET_AS_KERB_CRED 0x8")]
    public const int KERB_RETRIEVE_TICKET_AS_KERB_CRED = 0x8;

    [NativeTypeName("#define KERB_RETRIEVE_TICKET_WITH_SEC_CRED 0x10")]
    public const int KERB_RETRIEVE_TICKET_WITH_SEC_CRED = 0x10;

    [NativeTypeName("#define KERB_RETRIEVE_TICKET_CACHE_TICKET 0x20")]
    public const int KERB_RETRIEVE_TICKET_CACHE_TICKET = 0x20;

    [NativeTypeName("#define KERB_RETRIEVE_TICKET_MAX_LIFETIME 0x40")]
    public const int KERB_RETRIEVE_TICKET_MAX_LIFETIME = 0x40;

    [NativeTypeName("#define KERB_ETYPE_DEFAULT 0x0")]
    public const int KERB_ETYPE_DEFAULT = 0x0;

    [NativeTypeName("#define KERB_PURGE_ALL_TICKETS 1")]
    public const int KERB_PURGE_ALL_TICKETS = 1;

    [NativeTypeName("#define KERB_S4U2PROXY_CACHE_ENTRY_INFO_FLAG_NEGATIVE 0x1")]
    public const int KERB_S4U2PROXY_CACHE_ENTRY_INFO_FLAG_NEGATIVE = 0x1;

    [NativeTypeName("#define KERB_S4U2PROXY_CRED_FLAG_NEGATIVE 0x1")]
    public const int KERB_S4U2PROXY_CRED_FLAG_NEGATIVE = 0x1;

    [NativeTypeName("#define KERB_REFRESH_POLICY_KERBEROS 0x1")]
    public const int KERB_REFRESH_POLICY_KERBEROS = 0x1;

    [NativeTypeName("#define KERB_REFRESH_POLICY_KDC 0x2")]
    public const int KERB_REFRESH_POLICY_KDC = 0x2;

    [NativeTypeName("#define KERB_CLOUD_KERBEROS_DEBUG_DATA_VERSION 1")]
    public const int KERB_CLOUD_KERBEROS_DEBUG_DATA_VERSION = 1;

    [NativeTypeName("#define KERB_SETPASS_USE_LOGONID 1")]
    public const int KERB_SETPASS_USE_LOGONID = 1;

    [NativeTypeName("#define KERB_SETPASS_USE_CREDHANDLE 2")]
    public const int KERB_SETPASS_USE_CREDHANDLE = 2;

    [NativeTypeName("#define KERB_DECRYPT_FLAG_DEFAULT_KEY 0x00000001")]
    public const int KERB_DECRYPT_FLAG_DEFAULT_KEY = 0x00000001;

    [NativeTypeName("#define KERB_REFRESH_SCCRED_RELEASE 0x0")]
    public const int KERB_REFRESH_SCCRED_RELEASE = 0x0;

    [NativeTypeName("#define KERB_REFRESH_SCCRED_GETTGT 0x1")]
    public const int KERB_REFRESH_SCCRED_GETTGT = 0x1;

    [NativeTypeName("#define KERB_REQUEST_ADD_CREDENTIAL 1")]
    public const int KERB_REQUEST_ADD_CREDENTIAL = 1;

    [NativeTypeName("#define KERB_REQUEST_REPLACE_CREDENTIAL 2")]
    public const int KERB_REQUEST_REPLACE_CREDENTIAL = 2;

    [NativeTypeName("#define KERB_REQUEST_REMOVE_CREDENTIAL 4")]
    public const int KERB_REQUEST_REMOVE_CREDENTIAL = 4;

    [NativeTypeName("#define KERB_TRANSFER_CRED_WITH_TICKETS 0x1")]
    public const int KERB_TRANSFER_CRED_WITH_TICKETS = 0x1;

    [NativeTypeName("#define KERB_TRANSFER_CRED_CLEANUP_CREDENTIALS 0x2")]
    public const int KERB_TRANSFER_CRED_CLEANUP_CREDENTIALS = 0x2;

    [NativeTypeName("#define KERB_QUERY_DOMAIN_EXTENDED_POLICIES_RESPONSE_FLAG_DAC_DISABLED 0x1")]
    public const int KERB_QUERY_DOMAIN_EXTENDED_POLICIES_RESPONSE_FLAG_DAC_DISABLED = 0x1;
}
