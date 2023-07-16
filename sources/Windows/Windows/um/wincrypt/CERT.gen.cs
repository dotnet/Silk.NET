// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
public static unsafe partial class CERT
{
    [NativeTypeName("#define CERT_RDN_ANY_TYPE 0")]
    public const int CERT_RDN_ANY_TYPE = 0;
    [NativeTypeName("#define CERT_RDN_ENCODED_BLOB 1")]
    public const int CERT_RDN_ENCODED_BLOB = 1;
    [NativeTypeName("#define CERT_RDN_OCTET_STRING 2")]
    public const int CERT_RDN_OCTET_STRING = 2;
    [NativeTypeName("#define CERT_RDN_NUMERIC_STRING 3")]
    public const int CERT_RDN_NUMERIC_STRING = 3;
    [NativeTypeName("#define CERT_RDN_PRINTABLE_STRING 4")]
    public const int CERT_RDN_PRINTABLE_STRING = 4;
    [NativeTypeName("#define CERT_RDN_TELETEX_STRING 5")]
    public const int CERT_RDN_TELETEX_STRING = 5;
    [NativeTypeName("#define CERT_RDN_T61_STRING 5")]
    public const int CERT_RDN_T61_STRING = 5;
    [NativeTypeName("#define CERT_RDN_VIDEOTEX_STRING 6")]
    public const int CERT_RDN_VIDEOTEX_STRING = 6;
    [NativeTypeName("#define CERT_RDN_IA5_STRING 7")]
    public const int CERT_RDN_IA5_STRING = 7;
    [NativeTypeName("#define CERT_RDN_GRAPHIC_STRING 8")]
    public const int CERT_RDN_GRAPHIC_STRING = 8;
    [NativeTypeName("#define CERT_RDN_VISIBLE_STRING 9")]
    public const int CERT_RDN_VISIBLE_STRING = 9;
    [NativeTypeName("#define CERT_RDN_ISO646_STRING 9")]
    public const int CERT_RDN_ISO646_STRING = 9;
    [NativeTypeName("#define CERT_RDN_GENERAL_STRING 10")]
    public const int CERT_RDN_GENERAL_STRING = 10;
    [NativeTypeName("#define CERT_RDN_UNIVERSAL_STRING 11")]
    public const int CERT_RDN_UNIVERSAL_STRING = 11;
    [NativeTypeName("#define CERT_RDN_INT4_STRING 11")]
    public const int CERT_RDN_INT4_STRING = 11;
    [NativeTypeName("#define CERT_RDN_BMP_STRING 12")]
    public const int CERT_RDN_BMP_STRING = 12;
    [NativeTypeName("#define CERT_RDN_UNICODE_STRING 12")]
    public const int CERT_RDN_UNICODE_STRING = 12;
    [NativeTypeName("#define CERT_RDN_UTF8_STRING 13")]
    public const int CERT_RDN_UTF8_STRING = 13;
    [NativeTypeName("#define CERT_RDN_TYPE_MASK 0x000000FF")]
    public const int CERT_RDN_TYPE_MASK = 0x000000FF;
    [NativeTypeName("#define CERT_RDN_FLAGS_MASK 0xFF000000")]
    public const uint CERT_RDN_FLAGS_MASK = 0xFF000000;
    [NativeTypeName("#define CERT_RDN_ENABLE_T61_UNICODE_FLAG 0x80000000")]
    public const uint CERT_RDN_ENABLE_T61_UNICODE_FLAG = 0x80000000;
    [NativeTypeName("#define CERT_RDN_ENABLE_UTF8_UNICODE_FLAG 0x20000000")]
    public const int CERT_RDN_ENABLE_UTF8_UNICODE_FLAG = 0x20000000;
    [NativeTypeName("#define CERT_RDN_FORCE_UTF8_UNICODE_FLAG 0x10000000")]
    public const int CERT_RDN_FORCE_UTF8_UNICODE_FLAG = 0x10000000;
    [NativeTypeName("#define CERT_RDN_DISABLE_CHECK_TYPE_FLAG 0x40000000")]
    public const int CERT_RDN_DISABLE_CHECK_TYPE_FLAG = 0x40000000;
    [NativeTypeName("#define CERT_RDN_DISABLE_IE4_UTF8_FLAG 0x01000000")]
    public const int CERT_RDN_DISABLE_IE4_UTF8_FLAG = 0x01000000;
    [NativeTypeName("#define CERT_RDN_ENABLE_PUNYCODE_FLAG 0x02000000")]
    public const int CERT_RDN_ENABLE_PUNYCODE_FLAG = 0x02000000;
    [NativeTypeName("#define CERT_RSA_PUBLIC_KEY_OBJID szOID_RSA_RSA")]
    public static ReadOnlySpan<byte> CERT_RSA_PUBLIC_KEY_OBJID => "1.2.840.113549.1.1.1"u8;

    [NativeTypeName("#define CERT_DEFAULT_OID_PUBLIC_KEY_SIGN szOID_RSA_RSA")]
    public static ReadOnlySpan<byte> CERT_DEFAULT_OID_PUBLIC_KEY_SIGN => "1.2.840.113549.1.1.1"u8;

    [NativeTypeName("#define CERT_DEFAULT_OID_PUBLIC_KEY_XCHG szOID_RSA_RSA")]
    public static ReadOnlySpan<byte> CERT_DEFAULT_OID_PUBLIC_KEY_XCHG => "1.2.840.113549.1.1.1"u8;

    [NativeTypeName("#define CERT_V1 0")]
    public const int CERT_V1 = 0;
    [NativeTypeName("#define CERT_V2 1")]
    public const int CERT_V2 = 1;
    [NativeTypeName("#define CERT_V3 2")]
    public const int CERT_V3 = 2;
    [NativeTypeName("#define CERT_INFO_VERSION_FLAG 1")]
    public const int CERT_INFO_VERSION_FLAG = 1;
    [NativeTypeName("#define CERT_INFO_SERIAL_NUMBER_FLAG 2")]
    public const int CERT_INFO_SERIAL_NUMBER_FLAG = 2;
    [NativeTypeName("#define CERT_INFO_SIGNATURE_ALGORITHM_FLAG 3")]
    public const int CERT_INFO_SIGNATURE_ALGORITHM_FLAG = 3;
    [NativeTypeName("#define CERT_INFO_ISSUER_FLAG 4")]
    public const int CERT_INFO_ISSUER_FLAG = 4;
    [NativeTypeName("#define CERT_INFO_NOT_BEFORE_FLAG 5")]
    public const int CERT_INFO_NOT_BEFORE_FLAG = 5;
    [NativeTypeName("#define CERT_INFO_NOT_AFTER_FLAG 6")]
    public const int CERT_INFO_NOT_AFTER_FLAG = 6;
    [NativeTypeName("#define CERT_INFO_SUBJECT_FLAG 7")]
    public const int CERT_INFO_SUBJECT_FLAG = 7;
    [NativeTypeName("#define CERT_INFO_SUBJECT_PUBLIC_KEY_INFO_FLAG 8")]
    public const int CERT_INFO_SUBJECT_PUBLIC_KEY_INFO_FLAG = 8;
    [NativeTypeName("#define CERT_INFO_ISSUER_UNIQUE_ID_FLAG 9")]
    public const int CERT_INFO_ISSUER_UNIQUE_ID_FLAG = 9;
    [NativeTypeName("#define CERT_INFO_SUBJECT_UNIQUE_ID_FLAG 10")]
    public const int CERT_INFO_SUBJECT_UNIQUE_ID_FLAG = 10;
    [NativeTypeName("#define CERT_INFO_EXTENSION_FLAG 11")]
    public const int CERT_INFO_EXTENSION_FLAG = 11;
    [NativeTypeName("#define CERT_BUNDLE_CERTIFICATE 0")]
    public const int CERT_BUNDLE_CERTIFICATE = 0;
    [NativeTypeName("#define CERT_BUNDLE_CRL 1")]
    public const int CERT_BUNDLE_CRL = 1;
    [NativeTypeName("#define CERT_REQUEST_V1 0")]
    public const int CERT_REQUEST_V1 = 0;
    [NativeTypeName("#define CERT_KEYGEN_REQUEST_V1 0")]
    public const int CERT_KEYGEN_REQUEST_V1 = 0;
    [NativeTypeName("#define CERT_ENCODING_TYPE_MASK 0x0000FFFF")]
    public const int CERT_ENCODING_TYPE_MASK = 0x0000FFFF;
    [NativeTypeName("#define CERT_ROOT_PROGRAM_FLAG_ORG 0x80")]
    public const int CERT_ROOT_PROGRAM_FLAG_ORG = 0x80;
    [NativeTypeName("#define CERT_ROOT_PROGRAM_FLAG_LSC 0x40")]
    public const int CERT_ROOT_PROGRAM_FLAG_LSC = 0x40;
    [NativeTypeName("#define CERT_ROOT_PROGRAM_FLAG_SUBJECT_LOGO 0x20")]
    public const int CERT_ROOT_PROGRAM_FLAG_SUBJECT_LOGO = 0x20;
    [NativeTypeName("#define CERT_ROOT_PROGRAM_FLAG_OU 0x10")]
    public const int CERT_ROOT_PROGRAM_FLAG_OU = 0x10;
    [NativeTypeName("#define CERT_ROOT_PROGRAM_FLAG_ADDRESS 0x08")]
    public const int CERT_ROOT_PROGRAM_FLAG_ADDRESS = 0x08;
    [NativeTypeName("#define CERT_UNICODE_RDN_ERR_INDEX_MASK 0x3FF")]
    public const int CERT_UNICODE_RDN_ERR_INDEX_MASK = 0x3FF;
    [NativeTypeName("#define CERT_UNICODE_RDN_ERR_INDEX_SHIFT 22")]
    public const int CERT_UNICODE_RDN_ERR_INDEX_SHIFT = 22;
    [NativeTypeName("#define CERT_UNICODE_ATTR_ERR_INDEX_MASK 0x003F")]
    public const int CERT_UNICODE_ATTR_ERR_INDEX_MASK = 0x003F;
    [NativeTypeName("#define CERT_UNICODE_ATTR_ERR_INDEX_SHIFT 16")]
    public const int CERT_UNICODE_ATTR_ERR_INDEX_SHIFT = 16;
    [NativeTypeName("#define CERT_UNICODE_VALUE_ERR_INDEX_MASK 0x0000FFFF")]
    public const int CERT_UNICODE_VALUE_ERR_INDEX_MASK = 0x0000FFFF;
    [NativeTypeName("#define CERT_UNICODE_VALUE_ERR_INDEX_SHIFT 0")]
    public const int CERT_UNICODE_VALUE_ERR_INDEX_SHIFT = 0;
    [NativeTypeName("#define CERT_DIGITAL_SIGNATURE_KEY_USAGE 0x80")]
    public const int CERT_DIGITAL_SIGNATURE_KEY_USAGE = 0x80;
    [NativeTypeName("#define CERT_NON_REPUDIATION_KEY_USAGE 0x40")]
    public const int CERT_NON_REPUDIATION_KEY_USAGE = 0x40;
    [NativeTypeName("#define CERT_KEY_ENCIPHERMENT_KEY_USAGE 0x20")]
    public const int CERT_KEY_ENCIPHERMENT_KEY_USAGE = 0x20;
    [NativeTypeName("#define CERT_DATA_ENCIPHERMENT_KEY_USAGE 0x10")]
    public const int CERT_DATA_ENCIPHERMENT_KEY_USAGE = 0x10;
    [NativeTypeName("#define CERT_KEY_AGREEMENT_KEY_USAGE 0x08")]
    public const int CERT_KEY_AGREEMENT_KEY_USAGE = 0x08;
    [NativeTypeName("#define CERT_KEY_CERT_SIGN_KEY_USAGE 0x04")]
    public const int CERT_KEY_CERT_SIGN_KEY_USAGE = 0x04;
    [NativeTypeName("#define CERT_OFFLINE_CRL_SIGN_KEY_USAGE 0x02")]
    public const int CERT_OFFLINE_CRL_SIGN_KEY_USAGE = 0x02;
    [NativeTypeName("#define CERT_CRL_SIGN_KEY_USAGE 0x02")]
    public const int CERT_CRL_SIGN_KEY_USAGE = 0x02;
    [NativeTypeName("#define CERT_ENCIPHER_ONLY_KEY_USAGE 0x01")]
    public const int CERT_ENCIPHER_ONLY_KEY_USAGE = 0x01;
    [NativeTypeName("#define CERT_DECIPHER_ONLY_KEY_USAGE 0x80")]
    public const int CERT_DECIPHER_ONLY_KEY_USAGE = 0x80;
    [NativeTypeName("#define CERT_ALT_NAME_OTHER_NAME 1")]
    public const int CERT_ALT_NAME_OTHER_NAME = 1;
    [NativeTypeName("#define CERT_ALT_NAME_RFC822_NAME 2")]
    public const int CERT_ALT_NAME_RFC822_NAME = 2;
    [NativeTypeName("#define CERT_ALT_NAME_DNS_NAME 3")]
    public const int CERT_ALT_NAME_DNS_NAME = 3;
    [NativeTypeName("#define CERT_ALT_NAME_X400_ADDRESS 4")]
    public const int CERT_ALT_NAME_X400_ADDRESS = 4;
    [NativeTypeName("#define CERT_ALT_NAME_DIRECTORY_NAME 5")]
    public const int CERT_ALT_NAME_DIRECTORY_NAME = 5;
    [NativeTypeName("#define CERT_ALT_NAME_EDI_PARTY_NAME 6")]
    public const int CERT_ALT_NAME_EDI_PARTY_NAME = 6;
    [NativeTypeName("#define CERT_ALT_NAME_URL 7")]
    public const int CERT_ALT_NAME_URL = 7;
    [NativeTypeName("#define CERT_ALT_NAME_IP_ADDRESS 8")]
    public const int CERT_ALT_NAME_IP_ADDRESS = 8;
    [NativeTypeName("#define CERT_ALT_NAME_REGISTERED_ID 9")]
    public const int CERT_ALT_NAME_REGISTERED_ID = 9;
    [NativeTypeName("#define CERT_ALT_NAME_ENTRY_ERR_INDEX_MASK 0xFF")]
    public const int CERT_ALT_NAME_ENTRY_ERR_INDEX_MASK = 0xFF;
    [NativeTypeName("#define CERT_ALT_NAME_ENTRY_ERR_INDEX_SHIFT 16")]
    public const int CERT_ALT_NAME_ENTRY_ERR_INDEX_SHIFT = 16;
    [NativeTypeName("#define CERT_ALT_NAME_VALUE_ERR_INDEX_MASK 0x0000FFFF")]
    public const int CERT_ALT_NAME_VALUE_ERR_INDEX_MASK = 0x0000FFFF;
    [NativeTypeName("#define CERT_ALT_NAME_VALUE_ERR_INDEX_SHIFT 0")]
    public const int CERT_ALT_NAME_VALUE_ERR_INDEX_SHIFT = 0;
    [NativeTypeName("#define CERT_CA_SUBJECT_FLAG 0x80")]
    public const int CERT_CA_SUBJECT_FLAG = 0x80;
    [NativeTypeName("#define CERT_END_ENTITY_SUBJECT_FLAG 0x40")]
    public const int CERT_END_ENTITY_SUBJECT_FLAG = 0x40;
    [NativeTypeName("#define CERT_EXCLUDED_SUBTREE_BIT 0x80000000L")]
    public const uint CERT_EXCLUDED_SUBTREE_BIT = 0x80000000;
    [NativeTypeName("#define CERT_DSS_R_LEN 20")]
    public const int CERT_DSS_R_LEN = 20;
    [NativeTypeName("#define CERT_DSS_S_LEN 20")]
    public const int CERT_DSS_S_LEN = 20;
    [NativeTypeName("#define CERT_DSS_SIGNATURE_LEN (CERT_DSS_R_LEN + CERT_DSS_S_LEN)")]
    public const int CERT_DSS_SIGNATURE_LEN = (20 + 20);
    [NativeTypeName("#define CERT_MAX_ASN_ENCODED_DSS_SIGNATURE_LEN (2 + 2*(2 + 20 +1))")]
    public const int CERT_MAX_ASN_ENCODED_DSS_SIGNATURE_LEN = (2 + 2 * (2 + 20 + 1));
    [NativeTypeName("#define CERT_LOGOTYPE_GRAY_SCALE_IMAGE_INFO_CHOICE 1")]
    public const int CERT_LOGOTYPE_GRAY_SCALE_IMAGE_INFO_CHOICE = 1;
    [NativeTypeName("#define CERT_LOGOTYPE_COLOR_IMAGE_INFO_CHOICE 2")]
    public const int CERT_LOGOTYPE_COLOR_IMAGE_INFO_CHOICE = 2;
    [NativeTypeName("#define CERT_LOGOTYPE_NO_IMAGE_RESOLUTION_CHOICE 0")]
    public const int CERT_LOGOTYPE_NO_IMAGE_RESOLUTION_CHOICE = 0;
    [NativeTypeName("#define CERT_LOGOTYPE_BITS_IMAGE_RESOLUTION_CHOICE 1")]
    public const int CERT_LOGOTYPE_BITS_IMAGE_RESOLUTION_CHOICE = 1;
    [NativeTypeName("#define CERT_LOGOTYPE_TABLE_SIZE_IMAGE_RESOLUTION_CHOICE 2")]
    public const int CERT_LOGOTYPE_TABLE_SIZE_IMAGE_RESOLUTION_CHOICE = 2;
    [NativeTypeName("#define CERT_LOGOTYPE_DIRECT_INFO_CHOICE 1")]
    public const int CERT_LOGOTYPE_DIRECT_INFO_CHOICE = 1;
    [NativeTypeName("#define CERT_LOGOTYPE_INDIRECT_INFO_CHOICE 2")]
    public const int CERT_LOGOTYPE_INDIRECT_INFO_CHOICE = 2;
    [NativeTypeName("#define CERT_BIOMETRIC_PREDEFINED_DATA_CHOICE 1")]
    public const int CERT_BIOMETRIC_PREDEFINED_DATA_CHOICE = 1;
    [NativeTypeName("#define CERT_BIOMETRIC_OID_DATA_CHOICE 2")]
    public const int CERT_BIOMETRIC_OID_DATA_CHOICE = 2;
    [NativeTypeName("#define CERT_BIOMETRIC_PICTURE_TYPE 0")]
    public const int CERT_BIOMETRIC_PICTURE_TYPE = 0;
    [NativeTypeName("#define CERT_BIOMETRIC_SIGNATURE_TYPE 1")]
    public const int CERT_BIOMETRIC_SIGNATURE_TYPE = 1;
    [NativeTypeName("#define CERT_STRONG_SIGN_ECDSA_ALGORITHM L\"ECDSA\"")]
    public const string CERT_STRONG_SIGN_ECDSA_ALGORITHM = "ECDSA";
    [NativeTypeName("#define CERT_STRONG_SIGN_SERIALIZED_INFO_CHOICE 1")]
    public const int CERT_STRONG_SIGN_SERIALIZED_INFO_CHOICE = 1;
    [NativeTypeName("#define CERT_STRONG_SIGN_OID_INFO_CHOICE 2")]
    public const int CERT_STRONG_SIGN_OID_INFO_CHOICE = 2;
    [NativeTypeName("#define CERT_STRONG_SIGN_ENABLE_CRL_CHECK 0x1")]
    public const int CERT_STRONG_SIGN_ENABLE_CRL_CHECK = 0x1;
    [NativeTypeName("#define CERT_STRONG_SIGN_ENABLE_OCSP_CHECK 0x2")]
    public const int CERT_STRONG_SIGN_ENABLE_OCSP_CHECK = 0x2;
    [NativeTypeName("#define CERT_ID_ISSUER_SERIAL_NUMBER 1")]
    public const int CERT_ID_ISSUER_SERIAL_NUMBER = 1;
    [NativeTypeName("#define CERT_ID_KEY_IDENTIFIER 2")]
    public const int CERT_ID_KEY_IDENTIFIER = 2;
    [NativeTypeName("#define CERT_ID_SHA1_HASH 3")]
    public const int CERT_ID_SHA1_HASH = 3;
    [NativeTypeName("#define CERT_KEY_PROV_HANDLE_PROP_ID 1")]
    public const int CERT_KEY_PROV_HANDLE_PROP_ID = 1;
    [NativeTypeName("#define CERT_KEY_PROV_INFO_PROP_ID 2")]
    public const int CERT_KEY_PROV_INFO_PROP_ID = 2;
    [NativeTypeName("#define CERT_SHA1_HASH_PROP_ID 3")]
    public const int CERT_SHA1_HASH_PROP_ID = 3;
    [NativeTypeName("#define CERT_MD5_HASH_PROP_ID 4")]
    public const int CERT_MD5_HASH_PROP_ID = 4;
    [NativeTypeName("#define CERT_HASH_PROP_ID CERT_SHA1_HASH_PROP_ID")]
    public const int CERT_HASH_PROP_ID = 3;
    [NativeTypeName("#define CERT_KEY_CONTEXT_PROP_ID 5")]
    public const int CERT_KEY_CONTEXT_PROP_ID = 5;
    [NativeTypeName("#define CERT_KEY_SPEC_PROP_ID 6")]
    public const int CERT_KEY_SPEC_PROP_ID = 6;
    [NativeTypeName("#define CERT_IE30_RESERVED_PROP_ID 7")]
    public const int CERT_IE30_RESERVED_PROP_ID = 7;
    [NativeTypeName("#define CERT_PUBKEY_HASH_RESERVED_PROP_ID 8")]
    public const int CERT_PUBKEY_HASH_RESERVED_PROP_ID = 8;
    [NativeTypeName("#define CERT_ENHKEY_USAGE_PROP_ID 9")]
    public const int CERT_ENHKEY_USAGE_PROP_ID = 9;
    [NativeTypeName("#define CERT_CTL_USAGE_PROP_ID CERT_ENHKEY_USAGE_PROP_ID")]
    public const int CERT_CTL_USAGE_PROP_ID = 9;
    [NativeTypeName("#define CERT_NEXT_UPDATE_LOCATION_PROP_ID 10")]
    public const int CERT_NEXT_UPDATE_LOCATION_PROP_ID = 10;
    [NativeTypeName("#define CERT_FRIENDLY_NAME_PROP_ID 11")]
    public const int CERT_FRIENDLY_NAME_PROP_ID = 11;
    [NativeTypeName("#define CERT_PVK_FILE_PROP_ID 12")]
    public const int CERT_PVK_FILE_PROP_ID = 12;
    [NativeTypeName("#define CERT_DESCRIPTION_PROP_ID 13")]
    public const int CERT_DESCRIPTION_PROP_ID = 13;
    [NativeTypeName("#define CERT_ACCESS_STATE_PROP_ID 14")]
    public const int CERT_ACCESS_STATE_PROP_ID = 14;
    [NativeTypeName("#define CERT_SIGNATURE_HASH_PROP_ID 15")]
    public const int CERT_SIGNATURE_HASH_PROP_ID = 15;
    [NativeTypeName("#define CERT_SMART_CARD_DATA_PROP_ID 16")]
    public const int CERT_SMART_CARD_DATA_PROP_ID = 16;
    [NativeTypeName("#define CERT_EFS_PROP_ID 17")]
    public const int CERT_EFS_PROP_ID = 17;
    [NativeTypeName("#define CERT_FORTEZZA_DATA_PROP_ID 18")]
    public const int CERT_FORTEZZA_DATA_PROP_ID = 18;
    [NativeTypeName("#define CERT_ARCHIVED_PROP_ID 19")]
    public const int CERT_ARCHIVED_PROP_ID = 19;
    [NativeTypeName("#define CERT_KEY_IDENTIFIER_PROP_ID 20")]
    public const int CERT_KEY_IDENTIFIER_PROP_ID = 20;
    [NativeTypeName("#define CERT_AUTO_ENROLL_PROP_ID 21")]
    public const int CERT_AUTO_ENROLL_PROP_ID = 21;
    [NativeTypeName("#define CERT_PUBKEY_ALG_PARA_PROP_ID 22")]
    public const int CERT_PUBKEY_ALG_PARA_PROP_ID = 22;
    [NativeTypeName("#define CERT_CROSS_CERT_DIST_POINTS_PROP_ID 23")]
    public const int CERT_CROSS_CERT_DIST_POINTS_PROP_ID = 23;
    [NativeTypeName("#define CERT_ISSUER_PUBLIC_KEY_MD5_HASH_PROP_ID 24")]
    public const int CERT_ISSUER_PUBLIC_KEY_MD5_HASH_PROP_ID = 24;
    [NativeTypeName("#define CERT_SUBJECT_PUBLIC_KEY_MD5_HASH_PROP_ID 25")]
    public const int CERT_SUBJECT_PUBLIC_KEY_MD5_HASH_PROP_ID = 25;
    [NativeTypeName("#define CERT_ENROLLMENT_PROP_ID 26")]
    public const int CERT_ENROLLMENT_PROP_ID = 26;
    [NativeTypeName("#define CERT_DATE_STAMP_PROP_ID 27")]
    public const int CERT_DATE_STAMP_PROP_ID = 27;
    [NativeTypeName("#define CERT_ISSUER_SERIAL_NUMBER_MD5_HASH_PROP_ID 28")]
    public const int CERT_ISSUER_SERIAL_NUMBER_MD5_HASH_PROP_ID = 28;
    [NativeTypeName("#define CERT_SUBJECT_NAME_MD5_HASH_PROP_ID 29")]
    public const int CERT_SUBJECT_NAME_MD5_HASH_PROP_ID = 29;
    [NativeTypeName("#define CERT_EXTENDED_ERROR_INFO_PROP_ID 30")]
    public const int CERT_EXTENDED_ERROR_INFO_PROP_ID = 30;
    [NativeTypeName("#define CERT_RENEWAL_PROP_ID 64")]
    public const int CERT_RENEWAL_PROP_ID = 64;
    [NativeTypeName("#define CERT_ARCHIVED_KEY_HASH_PROP_ID 65")]
    public const int CERT_ARCHIVED_KEY_HASH_PROP_ID = 65;
    [NativeTypeName("#define CERT_AUTO_ENROLL_RETRY_PROP_ID 66")]
    public const int CERT_AUTO_ENROLL_RETRY_PROP_ID = 66;
    [NativeTypeName("#define CERT_AIA_URL_RETRIEVED_PROP_ID 67")]
    public const int CERT_AIA_URL_RETRIEVED_PROP_ID = 67;
    [NativeTypeName("#define CERT_AUTHORITY_INFO_ACCESS_PROP_ID 68")]
    public const int CERT_AUTHORITY_INFO_ACCESS_PROP_ID = 68;
    [NativeTypeName("#define CERT_BACKED_UP_PROP_ID 69")]
    public const int CERT_BACKED_UP_PROP_ID = 69;
    [NativeTypeName("#define CERT_OCSP_RESPONSE_PROP_ID 70")]
    public const int CERT_OCSP_RESPONSE_PROP_ID = 70;
    [NativeTypeName("#define CERT_REQUEST_ORIGINATOR_PROP_ID 71")]
    public const int CERT_REQUEST_ORIGINATOR_PROP_ID = 71;
    [NativeTypeName("#define CERT_SOURCE_LOCATION_PROP_ID 72")]
    public const int CERT_SOURCE_LOCATION_PROP_ID = 72;
    [NativeTypeName("#define CERT_SOURCE_URL_PROP_ID 73")]
    public const int CERT_SOURCE_URL_PROP_ID = 73;
    [NativeTypeName("#define CERT_NEW_KEY_PROP_ID 74")]
    public const int CERT_NEW_KEY_PROP_ID = 74;
    [NativeTypeName("#define CERT_OCSP_CACHE_PREFIX_PROP_ID 75")]
    public const int CERT_OCSP_CACHE_PREFIX_PROP_ID = 75;
    [NativeTypeName("#define CERT_SMART_CARD_ROOT_INFO_PROP_ID 76")]
    public const int CERT_SMART_CARD_ROOT_INFO_PROP_ID = 76;
    [NativeTypeName("#define CERT_NO_AUTO_EXPIRE_CHECK_PROP_ID 77")]
    public const int CERT_NO_AUTO_EXPIRE_CHECK_PROP_ID = 77;
    [NativeTypeName("#define CERT_NCRYPT_KEY_HANDLE_PROP_ID 78")]
    public const int CERT_NCRYPT_KEY_HANDLE_PROP_ID = 78;
    [NativeTypeName("#define CERT_HCRYPTPROV_OR_NCRYPT_KEY_HANDLE_PROP_ID 79")]
    public const int CERT_HCRYPTPROV_OR_NCRYPT_KEY_HANDLE_PROP_ID = 79;
    [NativeTypeName("#define CERT_SUBJECT_INFO_ACCESS_PROP_ID 80")]
    public const int CERT_SUBJECT_INFO_ACCESS_PROP_ID = 80;
    [NativeTypeName("#define CERT_CA_OCSP_AUTHORITY_INFO_ACCESS_PROP_ID 81")]
    public const int CERT_CA_OCSP_AUTHORITY_INFO_ACCESS_PROP_ID = 81;
    [NativeTypeName("#define CERT_CA_DISABLE_CRL_PROP_ID 82")]
    public const int CERT_CA_DISABLE_CRL_PROP_ID = 82;
    [NativeTypeName("#define CERT_ROOT_PROGRAM_CERT_POLICIES_PROP_ID 83")]
    public const int CERT_ROOT_PROGRAM_CERT_POLICIES_PROP_ID = 83;
    [NativeTypeName("#define CERT_ROOT_PROGRAM_NAME_CONSTRAINTS_PROP_ID 84")]
    public const int CERT_ROOT_PROGRAM_NAME_CONSTRAINTS_PROP_ID = 84;
    [NativeTypeName("#define CERT_SUBJECT_OCSP_AUTHORITY_INFO_ACCESS_PROP_ID 85")]
    public const int CERT_SUBJECT_OCSP_AUTHORITY_INFO_ACCESS_PROP_ID = 85;
    [NativeTypeName("#define CERT_SUBJECT_DISABLE_CRL_PROP_ID 86")]
    public const int CERT_SUBJECT_DISABLE_CRL_PROP_ID = 86;
    [NativeTypeName("#define CERT_CEP_PROP_ID 87")]
    public const int CERT_CEP_PROP_ID = 87;
    [NativeTypeName("#define CERT_SIGN_HASH_CNG_ALG_PROP_ID 89")]
    public const int CERT_SIGN_HASH_CNG_ALG_PROP_ID = 89;
    [NativeTypeName("#define CERT_SCARD_PIN_ID_PROP_ID 90")]
    public const int CERT_SCARD_PIN_ID_PROP_ID = 90;
    [NativeTypeName("#define CERT_SCARD_PIN_INFO_PROP_ID 91")]
    public const int CERT_SCARD_PIN_INFO_PROP_ID = 91;
    [NativeTypeName("#define CERT_SUBJECT_PUB_KEY_BIT_LENGTH_PROP_ID 92")]
    public const int CERT_SUBJECT_PUB_KEY_BIT_LENGTH_PROP_ID = 92;
    [NativeTypeName("#define CERT_PUB_KEY_CNG_ALG_BIT_LENGTH_PROP_ID 93")]
    public const int CERT_PUB_KEY_CNG_ALG_BIT_LENGTH_PROP_ID = 93;
    [NativeTypeName("#define CERT_ISSUER_PUB_KEY_BIT_LENGTH_PROP_ID 94")]
    public const int CERT_ISSUER_PUB_KEY_BIT_LENGTH_PROP_ID = 94;
    [NativeTypeName("#define CERT_ISSUER_CHAIN_SIGN_HASH_CNG_ALG_PROP_ID 95")]
    public const int CERT_ISSUER_CHAIN_SIGN_HASH_CNG_ALG_PROP_ID = 95;
    [NativeTypeName("#define CERT_ISSUER_CHAIN_PUB_KEY_CNG_ALG_BIT_LENGTH_PROP_ID 96")]
    public const int CERT_ISSUER_CHAIN_PUB_KEY_CNG_ALG_BIT_LENGTH_PROP_ID = 96;
    [NativeTypeName("#define CERT_NO_EXPIRE_NOTIFICATION_PROP_ID 97")]
    public const int CERT_NO_EXPIRE_NOTIFICATION_PROP_ID = 97;
    [NativeTypeName("#define CERT_AUTH_ROOT_SHA256_HASH_PROP_ID 98")]
    public const int CERT_AUTH_ROOT_SHA256_HASH_PROP_ID = 98;
    [NativeTypeName("#define CERT_NCRYPT_KEY_HANDLE_TRANSFER_PROP_ID 99")]
    public const int CERT_NCRYPT_KEY_HANDLE_TRANSFER_PROP_ID = 99;
    [NativeTypeName("#define CERT_HCRYPTPROV_TRANSFER_PROP_ID 100")]
    public const int CERT_HCRYPTPROV_TRANSFER_PROP_ID = 100;
    [NativeTypeName("#define CERT_SMART_CARD_READER_PROP_ID 101")]
    public const int CERT_SMART_CARD_READER_PROP_ID = 101;
    [NativeTypeName("#define CERT_SEND_AS_TRUSTED_ISSUER_PROP_ID 102")]
    public const int CERT_SEND_AS_TRUSTED_ISSUER_PROP_ID = 102;
    [NativeTypeName("#define CERT_KEY_REPAIR_ATTEMPTED_PROP_ID 103")]
    public const int CERT_KEY_REPAIR_ATTEMPTED_PROP_ID = 103;
    [NativeTypeName("#define CERT_DISALLOWED_FILETIME_PROP_ID 104")]
    public const int CERT_DISALLOWED_FILETIME_PROP_ID = 104;
    [NativeTypeName("#define CERT_ROOT_PROGRAM_CHAIN_POLICIES_PROP_ID 105")]
    public const int CERT_ROOT_PROGRAM_CHAIN_POLICIES_PROP_ID = 105;
    [NativeTypeName("#define CERT_SMART_CARD_READER_NON_REMOVABLE_PROP_ID 106")]
    public const int CERT_SMART_CARD_READER_NON_REMOVABLE_PROP_ID = 106;
    [NativeTypeName("#define CERT_SHA256_HASH_PROP_ID 107")]
    public const int CERT_SHA256_HASH_PROP_ID = 107;
    [NativeTypeName("#define CERT_SCEP_SERVER_CERTS_PROP_ID 108")]
    public const int CERT_SCEP_SERVER_CERTS_PROP_ID = 108;
    [NativeTypeName("#define CERT_SCEP_RA_SIGNATURE_CERT_PROP_ID 109")]
    public const int CERT_SCEP_RA_SIGNATURE_CERT_PROP_ID = 109;
    [NativeTypeName("#define CERT_SCEP_RA_ENCRYPTION_CERT_PROP_ID 110")]
    public const int CERT_SCEP_RA_ENCRYPTION_CERT_PROP_ID = 110;
    [NativeTypeName("#define CERT_SCEP_CA_CERT_PROP_ID 111")]
    public const int CERT_SCEP_CA_CERT_PROP_ID = 111;
    [NativeTypeName("#define CERT_SCEP_SIGNER_CERT_PROP_ID 112")]
    public const int CERT_SCEP_SIGNER_CERT_PROP_ID = 112;
    [NativeTypeName("#define CERT_SCEP_NONCE_PROP_ID 113")]
    public const int CERT_SCEP_NONCE_PROP_ID = 113;
    [NativeTypeName("#define CERT_SCEP_ENCRYPT_HASH_CNG_ALG_PROP_ID 114")]
    public const int CERT_SCEP_ENCRYPT_HASH_CNG_ALG_PROP_ID = 114;
    [NativeTypeName("#define CERT_SCEP_FLAGS_PROP_ID 115")]
    public const int CERT_SCEP_FLAGS_PROP_ID = 115;
    [NativeTypeName("#define CERT_SCEP_GUID_PROP_ID 116")]
    public const int CERT_SCEP_GUID_PROP_ID = 116;
    [NativeTypeName("#define CERT_SERIALIZABLE_KEY_CONTEXT_PROP_ID 117")]
    public const int CERT_SERIALIZABLE_KEY_CONTEXT_PROP_ID = 117;
    [NativeTypeName("#define CERT_ISOLATED_KEY_PROP_ID 118")]
    public const int CERT_ISOLATED_KEY_PROP_ID = 118;
    [NativeTypeName("#define CERT_SERIAL_CHAIN_PROP_ID 119")]
    public const int CERT_SERIAL_CHAIN_PROP_ID = 119;
    [NativeTypeName("#define CERT_KEY_CLASSIFICATION_PROP_ID 120")]
    public const int CERT_KEY_CLASSIFICATION_PROP_ID = 120;
    [NativeTypeName("#define CERT_OCSP_MUST_STAPLE_PROP_ID 121")]
    public const int CERT_OCSP_MUST_STAPLE_PROP_ID = 121;
    [NativeTypeName("#define CERT_DISALLOWED_ENHKEY_USAGE_PROP_ID 122")]
    public const int CERT_DISALLOWED_ENHKEY_USAGE_PROP_ID = 122;
    [NativeTypeName("#define CERT_NONCOMPLIANT_ROOT_URL_PROP_ID 123")]
    public const int CERT_NONCOMPLIANT_ROOT_URL_PROP_ID = 123;
    [NativeTypeName("#define CERT_PIN_SHA256_HASH_PROP_ID 124")]
    public const int CERT_PIN_SHA256_HASH_PROP_ID = 124;
    [NativeTypeName("#define CERT_CLR_DELETE_KEY_PROP_ID 125")]
    public const int CERT_CLR_DELETE_KEY_PROP_ID = 125;
    [NativeTypeName("#define CERT_NOT_BEFORE_FILETIME_PROP_ID 126")]
    public const int CERT_NOT_BEFORE_FILETIME_PROP_ID = 126;
    [NativeTypeName("#define CERT_NOT_BEFORE_ENHKEY_USAGE_PROP_ID 127")]
    public const int CERT_NOT_BEFORE_ENHKEY_USAGE_PROP_ID = 127;
    [NativeTypeName("#define CERT_DISALLOWED_CA_FILETIME_PROP_ID 128")]
    public const int CERT_DISALLOWED_CA_FILETIME_PROP_ID = 128;
    [NativeTypeName("#define CERT_FIRST_RESERVED_PROP_ID 129")]
    public const int CERT_FIRST_RESERVED_PROP_ID = 129;
    [NativeTypeName("#define CERT_LAST_RESERVED_PROP_ID 0x00007FFF")]
    public const int CERT_LAST_RESERVED_PROP_ID = 0x00007FFF;
    [NativeTypeName("#define CERT_FIRST_USER_PROP_ID 0x00008000")]
    public const int CERT_FIRST_USER_PROP_ID = 0x00008000;
    [NativeTypeName("#define CERT_LAST_USER_PROP_ID 0x0000FFFF")]
    public const int CERT_LAST_USER_PROP_ID = 0x0000FFFF;
    [NativeTypeName("#define CERT_ACCESS_STATE_WRITE_PERSIST_FLAG 0x1")]
    public const int CERT_ACCESS_STATE_WRITE_PERSIST_FLAG = 0x1;
    [NativeTypeName("#define CERT_ACCESS_STATE_SYSTEM_STORE_FLAG 0x2")]
    public const int CERT_ACCESS_STATE_SYSTEM_STORE_FLAG = 0x2;
    [NativeTypeName("#define CERT_ACCESS_STATE_LM_SYSTEM_STORE_FLAG 0x4")]
    public const int CERT_ACCESS_STATE_LM_SYSTEM_STORE_FLAG = 0x4;
    [NativeTypeName("#define CERT_ACCESS_STATE_GP_SYSTEM_STORE_FLAG 0x8")]
    public const int CERT_ACCESS_STATE_GP_SYSTEM_STORE_FLAG = 0x8;
    [NativeTypeName("#define CERT_ACCESS_STATE_SHARED_USER_FLAG 0x10")]
    public const int CERT_ACCESS_STATE_SHARED_USER_FLAG = 0x10;
    [NativeTypeName("#define CERT_SET_KEY_PROV_HANDLE_PROP_ID 0x00000001")]
    public const int CERT_SET_KEY_PROV_HANDLE_PROP_ID = 0x00000001;
    [NativeTypeName("#define CERT_SET_KEY_CONTEXT_PROP_ID 0x00000001")]
    public const int CERT_SET_KEY_CONTEXT_PROP_ID = 0x00000001;
    [NativeTypeName("#define CERT_NCRYPT_KEY_SPEC 0xFFFFFFFF")]
    public const uint CERT_NCRYPT_KEY_SPEC = 0xFFFFFFFF;
    [NativeTypeName("#define CERT_STORE_PROV_MSG ((LPCSTR) 1)")]
    public static sbyte* CERT_STORE_PROV_MSG => ((sbyte*)(1));

    [NativeTypeName("#define CERT_STORE_PROV_MEMORY ((LPCSTR) 2)")]
    public static sbyte* CERT_STORE_PROV_MEMORY => ((sbyte*)(2));

    [NativeTypeName("#define CERT_STORE_PROV_FILE ((LPCSTR) 3)")]
    public static sbyte* CERT_STORE_PROV_FILE => ((sbyte*)(3));

    [NativeTypeName("#define CERT_STORE_PROV_REG ((LPCSTR) 4)")]
    public static sbyte* CERT_STORE_PROV_REG => ((sbyte*)(4));

    [NativeTypeName("#define CERT_STORE_PROV_PKCS7 ((LPCSTR) 5)")]
    public static sbyte* CERT_STORE_PROV_PKCS7 => ((sbyte*)(5));

    [NativeTypeName("#define CERT_STORE_PROV_SERIALIZED ((LPCSTR) 6)")]
    public static sbyte* CERT_STORE_PROV_SERIALIZED => ((sbyte*)(6));

    [NativeTypeName("#define CERT_STORE_PROV_FILENAME_A ((LPCSTR) 7)")]
    public static sbyte* CERT_STORE_PROV_FILENAME_A => ((sbyte*)(7));

    [NativeTypeName("#define CERT_STORE_PROV_FILENAME_W ((LPCSTR) 8)")]
    public static sbyte* CERT_STORE_PROV_FILENAME_W => ((sbyte*)(8));

    [NativeTypeName("#define CERT_STORE_PROV_FILENAME CERT_STORE_PROV_FILENAME_W")]
    public static sbyte* CERT_STORE_PROV_FILENAME => ((sbyte*)(8));

    [NativeTypeName("#define CERT_STORE_PROV_SYSTEM_A ((LPCSTR) 9)")]
    public static sbyte* CERT_STORE_PROV_SYSTEM_A => ((sbyte*)(9));

    [NativeTypeName("#define CERT_STORE_PROV_SYSTEM_W ((LPCSTR) 10)")]
    public static sbyte* CERT_STORE_PROV_SYSTEM_W => ((sbyte*)(10));

    [NativeTypeName("#define CERT_STORE_PROV_SYSTEM CERT_STORE_PROV_SYSTEM_W")]
    public static sbyte* CERT_STORE_PROV_SYSTEM => ((sbyte*)(10));

    [NativeTypeName("#define CERT_STORE_PROV_COLLECTION ((LPCSTR) 11)")]
    public static sbyte* CERT_STORE_PROV_COLLECTION => ((sbyte*)(11));

    [NativeTypeName("#define CERT_STORE_PROV_SYSTEM_REGISTRY_A ((LPCSTR) 12)")]
    public static sbyte* CERT_STORE_PROV_SYSTEM_REGISTRY_A => ((sbyte*)(12));

    [NativeTypeName("#define CERT_STORE_PROV_SYSTEM_REGISTRY_W ((LPCSTR) 13)")]
    public static sbyte* CERT_STORE_PROV_SYSTEM_REGISTRY_W => ((sbyte*)(13));

    [NativeTypeName("#define CERT_STORE_PROV_SYSTEM_REGISTRY CERT_STORE_PROV_SYSTEM_REGISTRY_W")]
    public static sbyte* CERT_STORE_PROV_SYSTEM_REGISTRY => ((sbyte*)(13));

    [NativeTypeName("#define CERT_STORE_PROV_PHYSICAL_W ((LPCSTR) 14)")]
    public static sbyte* CERT_STORE_PROV_PHYSICAL_W => ((sbyte*)(14));

    [NativeTypeName("#define CERT_STORE_PROV_PHYSICAL CERT_STORE_PROV_PHYSICAL_W")]
    public static sbyte* CERT_STORE_PROV_PHYSICAL => ((sbyte*)(14));

    [NativeTypeName("#define CERT_STORE_PROV_SMART_CARD_W ((LPCSTR) 15)")]
    public static sbyte* CERT_STORE_PROV_SMART_CARD_W => ((sbyte*)(15));

    [NativeTypeName("#define CERT_STORE_PROV_SMART_CARD CERT_STORE_PROV_SMART_CARD_W")]
    public static sbyte* CERT_STORE_PROV_SMART_CARD => ((sbyte*)(15));

    [NativeTypeName("#define CERT_STORE_PROV_LDAP_W ((LPCSTR) 16)")]
    public static sbyte* CERT_STORE_PROV_LDAP_W => ((sbyte*)(16));

    [NativeTypeName("#define CERT_STORE_PROV_LDAP CERT_STORE_PROV_LDAP_W")]
    public static sbyte* CERT_STORE_PROV_LDAP => ((sbyte*)(16));

    [NativeTypeName("#define CERT_STORE_PROV_PKCS12 ((LPCSTR) 17)")]
    public static sbyte* CERT_STORE_PROV_PKCS12 => ((sbyte*)(17));

    [NativeTypeName("#define CERT_STORE_SIGNATURE_FLAG 0x00000001")]
    public const int CERT_STORE_SIGNATURE_FLAG = 0x00000001;
    [NativeTypeName("#define CERT_STORE_TIME_VALIDITY_FLAG 0x00000002")]
    public const int CERT_STORE_TIME_VALIDITY_FLAG = 0x00000002;
    [NativeTypeName("#define CERT_STORE_REVOCATION_FLAG 0x00000004")]
    public const int CERT_STORE_REVOCATION_FLAG = 0x00000004;
    [NativeTypeName("#define CERT_STORE_NO_CRL_FLAG 0x00010000")]
    public const int CERT_STORE_NO_CRL_FLAG = 0x00010000;
    [NativeTypeName("#define CERT_STORE_NO_ISSUER_FLAG 0x00020000")]
    public const int CERT_STORE_NO_ISSUER_FLAG = 0x00020000;
    [NativeTypeName("#define CERT_STORE_BASE_CRL_FLAG 0x00000100")]
    public const int CERT_STORE_BASE_CRL_FLAG = 0x00000100;
    [NativeTypeName("#define CERT_STORE_DELTA_CRL_FLAG 0x00000200")]
    public const int CERT_STORE_DELTA_CRL_FLAG = 0x00000200;
    [NativeTypeName("#define CERT_STORE_NO_CRYPT_RELEASE_FLAG 0x00000001")]
    public const int CERT_STORE_NO_CRYPT_RELEASE_FLAG = 0x00000001;
    [NativeTypeName("#define CERT_STORE_SET_LOCALIZED_NAME_FLAG 0x00000002")]
    public const int CERT_STORE_SET_LOCALIZED_NAME_FLAG = 0x00000002;
    [NativeTypeName("#define CERT_STORE_DEFER_CLOSE_UNTIL_LAST_FREE_FLAG 0x00000004")]
    public const int CERT_STORE_DEFER_CLOSE_UNTIL_LAST_FREE_FLAG = 0x00000004;
    [NativeTypeName("#define CERT_STORE_DELETE_FLAG 0x00000010")]
    public const int CERT_STORE_DELETE_FLAG = 0x00000010;
    [NativeTypeName("#define CERT_STORE_UNSAFE_PHYSICAL_FLAG 0x00000020")]
    public const int CERT_STORE_UNSAFE_PHYSICAL_FLAG = 0x00000020;
    [NativeTypeName("#define CERT_STORE_SHARE_STORE_FLAG 0x00000040")]
    public const int CERT_STORE_SHARE_STORE_FLAG = 0x00000040;
    [NativeTypeName("#define CERT_STORE_SHARE_CONTEXT_FLAG 0x00000080")]
    public const int CERT_STORE_SHARE_CONTEXT_FLAG = 0x00000080;
    [NativeTypeName("#define CERT_STORE_MANIFOLD_FLAG 0x00000100")]
    public const int CERT_STORE_MANIFOLD_FLAG = 0x00000100;
    [NativeTypeName("#define CERT_STORE_ENUM_ARCHIVED_FLAG 0x00000200")]
    public const int CERT_STORE_ENUM_ARCHIVED_FLAG = 0x00000200;
    [NativeTypeName("#define CERT_STORE_UPDATE_KEYID_FLAG 0x00000400")]
    public const int CERT_STORE_UPDATE_KEYID_FLAG = 0x00000400;
    [NativeTypeName("#define CERT_STORE_BACKUP_RESTORE_FLAG 0x00000800")]
    public const int CERT_STORE_BACKUP_RESTORE_FLAG = 0x00000800;
    [NativeTypeName("#define CERT_STORE_READONLY_FLAG 0x00008000")]
    public const int CERT_STORE_READONLY_FLAG = 0x00008000;
    [NativeTypeName("#define CERT_STORE_OPEN_EXISTING_FLAG 0x00004000")]
    public const int CERT_STORE_OPEN_EXISTING_FLAG = 0x00004000;
    [NativeTypeName("#define CERT_STORE_CREATE_NEW_FLAG 0x00002000")]
    public const int CERT_STORE_CREATE_NEW_FLAG = 0x00002000;
    [NativeTypeName("#define CERT_STORE_MAXIMUM_ALLOWED_FLAG 0x00001000")]
    public const int CERT_STORE_MAXIMUM_ALLOWED_FLAG = 0x00001000;
    [NativeTypeName("#define CERT_SYSTEM_STORE_MASK 0xFFFF0000")]
    public const uint CERT_SYSTEM_STORE_MASK = 0xFFFF0000;
    [NativeTypeName("#define CERT_SYSTEM_STORE_RELOCATE_FLAG 0x80000000")]
    public const uint CERT_SYSTEM_STORE_RELOCATE_FLAG = 0x80000000;
    [NativeTypeName("#define CERT_SYSTEM_STORE_UNPROTECTED_FLAG 0x40000000")]
    public const int CERT_SYSTEM_STORE_UNPROTECTED_FLAG = 0x40000000;
    [NativeTypeName("#define CERT_SYSTEM_STORE_DEFER_READ_FLAG 0x20000000")]
    public const int CERT_SYSTEM_STORE_DEFER_READ_FLAG = 0x20000000;
    [NativeTypeName("#define CERT_SYSTEM_STORE_LOCATION_MASK 0x00FF0000")]
    public const int CERT_SYSTEM_STORE_LOCATION_MASK = 0x00FF0000;
    [NativeTypeName("#define CERT_SYSTEM_STORE_LOCATION_SHIFT 16")]
    public const int CERT_SYSTEM_STORE_LOCATION_SHIFT = 16;
    [NativeTypeName("#define CERT_SYSTEM_STORE_CURRENT_USER_ID 1")]
    public const int CERT_SYSTEM_STORE_CURRENT_USER_ID = 1;
    [NativeTypeName("#define CERT_SYSTEM_STORE_LOCAL_MACHINE_ID 2")]
    public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_ID = 2;
    [NativeTypeName("#define CERT_SYSTEM_STORE_CURRENT_SERVICE_ID 4")]
    public const int CERT_SYSTEM_STORE_CURRENT_SERVICE_ID = 4;
    [NativeTypeName("#define CERT_SYSTEM_STORE_SERVICES_ID 5")]
    public const int CERT_SYSTEM_STORE_SERVICES_ID = 5;
    [NativeTypeName("#define CERT_SYSTEM_STORE_USERS_ID 6")]
    public const int CERT_SYSTEM_STORE_USERS_ID = 6;
    [NativeTypeName("#define CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY_ID 7")]
    public const int CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY_ID = 7;
    [NativeTypeName("#define CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY_ID 8")]
    public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY_ID = 8;
    [NativeTypeName("#define CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE_ID 9")]
    public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE_ID = 9;
    [NativeTypeName("#define CERT_SYSTEM_STORE_LOCAL_MACHINE_WCOS_ID 10")]
    public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_WCOS_ID = 10;
    [NativeTypeName("#define CERT_SYSTEM_STORE_CURRENT_USER (CERT_SYSTEM_STORE_CURRENT_USER_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
    public const int CERT_SYSTEM_STORE_CURRENT_USER = (1 << 16);
    [NativeTypeName("#define CERT_SYSTEM_STORE_LOCAL_MACHINE (CERT_SYSTEM_STORE_LOCAL_MACHINE_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
    public const int CERT_SYSTEM_STORE_LOCAL_MACHINE = (2 << 16);
    [NativeTypeName("#define CERT_SYSTEM_STORE_CURRENT_SERVICE (CERT_SYSTEM_STORE_CURRENT_SERVICE_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
    public const int CERT_SYSTEM_STORE_CURRENT_SERVICE = (4 << 16);
    [NativeTypeName("#define CERT_SYSTEM_STORE_SERVICES (CERT_SYSTEM_STORE_SERVICES_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
    public const int CERT_SYSTEM_STORE_SERVICES = (5 << 16);
    [NativeTypeName("#define CERT_SYSTEM_STORE_USERS (CERT_SYSTEM_STORE_USERS_ID << CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
    public const int CERT_SYSTEM_STORE_USERS = (6 << 16);
    [NativeTypeName("#define CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY (CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY_ID << \\\r\n        CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
    public const int CERT_SYSTEM_STORE_CURRENT_USER_GROUP_POLICY = (7 << 16);
    [NativeTypeName("#define CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY (CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY_ID << \\\r\n        CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
    public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_GROUP_POLICY = (8 << 16);
    [NativeTypeName("#define CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE (CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE_ID << \\\r\n        CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
    public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_ENTERPRISE = (9 << 16);
    [NativeTypeName("#define CERT_SYSTEM_STORE_LOCAL_MACHINE_WCOS (CERT_SYSTEM_STORE_LOCAL_MACHINE_WCOS_ID << \\\r\n        CERT_SYSTEM_STORE_LOCATION_SHIFT)")]
    public const int CERT_SYSTEM_STORE_LOCAL_MACHINE_WCOS = (10 << 16);
    [NativeTypeName("#define CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH L\"Software\\\\Policies\\\\Microsoft\\\\SystemCertificates\"")]
    public const string CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH = "Software\\Policies\\Microsoft\\SystemCertificates";
    [NativeTypeName("#define CERT_EFSBLOB_REGPATH CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH L\"\\\\EFS\"")]
    public const string CERT_EFSBLOB_REGPATH = "Software\\Policies\\Microsoft\\SystemCertificates\\EFS";
    [NativeTypeName("#define CERT_EFSBLOB_VALUE_NAME L\"EFSBlob\"")]
    public const string CERT_EFSBLOB_VALUE_NAME = "EFSBlob";
    [NativeTypeName("#define CERT_PROT_ROOT_FLAGS_REGPATH CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH L\"\\\\Root\\\\ProtectedRoots\"")]
    public const string CERT_PROT_ROOT_FLAGS_REGPATH = "Software\\Policies\\Microsoft\\SystemCertificates\\Root\\ProtectedRoots";
    [NativeTypeName("#define CERT_PROT_ROOT_FLAGS_VALUE_NAME L\"Flags\"")]
    public const string CERT_PROT_ROOT_FLAGS_VALUE_NAME = "Flags";
    [NativeTypeName("#define CERT_PROT_ROOT_DISABLE_CURRENT_USER_FLAG 0x1")]
    public const int CERT_PROT_ROOT_DISABLE_CURRENT_USER_FLAG = 0x1;
    [NativeTypeName("#define CERT_PROT_ROOT_INHIBIT_ADD_AT_INIT_FLAG 0x2")]
    public const int CERT_PROT_ROOT_INHIBIT_ADD_AT_INIT_FLAG = 0x2;
    [NativeTypeName("#define CERT_PROT_ROOT_INHIBIT_PURGE_LM_FLAG 0x4")]
    public const int CERT_PROT_ROOT_INHIBIT_PURGE_LM_FLAG = 0x4;
    [NativeTypeName("#define CERT_PROT_ROOT_DISABLE_LM_AUTH_FLAG 0x8")]
    public const int CERT_PROT_ROOT_DISABLE_LM_AUTH_FLAG = 0x8;
    [NativeTypeName("#define CERT_PROT_ROOT_ONLY_LM_GPT_FLAG 0x8")]
    public const int CERT_PROT_ROOT_ONLY_LM_GPT_FLAG = 0x8;
    [NativeTypeName("#define CERT_PROT_ROOT_DISABLE_NT_AUTH_REQUIRED_FLAG 0x10")]
    public const int CERT_PROT_ROOT_DISABLE_NT_AUTH_REQUIRED_FLAG = 0x10;
    [NativeTypeName("#define CERT_PROT_ROOT_DISABLE_NOT_DEFINED_NAME_CONSTRAINT_FLAG 0x20")]
    public const int CERT_PROT_ROOT_DISABLE_NOT_DEFINED_NAME_CONSTRAINT_FLAG = 0x20;
    [NativeTypeName("#define CERT_PROT_ROOT_DISABLE_PEER_TRUST 0x10000")]
    public const int CERT_PROT_ROOT_DISABLE_PEER_TRUST = 0x10000;
    [NativeTypeName("#define CERT_PROT_ROOT_PEER_USAGES_VALUE_NAME L\"PeerUsages\"")]
    public const string CERT_PROT_ROOT_PEER_USAGES_VALUE_NAME = "PeerUsages";
    [NativeTypeName("#define CERT_PROT_ROOT_PEER_USAGES_VALUE_NAME_A \"PeerUsages\"")]
    public static ReadOnlySpan<byte> CERT_PROT_ROOT_PEER_USAGES_VALUE_NAME_A => "PeerUsages"u8;

    [NativeTypeName("#define CERT_PROT_ROOT_PEER_USAGES_DEFAULT_A szOID_PKIX_KP_CLIENT_AUTH \"\\0\"                  \\\r\n    szOID_PKIX_KP_EMAIL_PROTECTION \"\\0\"             \\\r\n    szOID_KP_EFS \"\\0\"")]
    public static ReadOnlySpan<byte> CERT_PROT_ROOT_PEER_USAGES_DEFAULT_A => "1.3.6.1.5.5.7.3.2\\01.3.6.1.5.5.7.3.4\\01.3.6.1.4.1.311.10.3.4\\0"u8;

    [NativeTypeName("#define CERT_TRUST_PUB_SAFER_GROUP_POLICY_REGPATH CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH L\"\\\\TrustedPublisher\\\\Safer\"")]
    public const string CERT_TRUST_PUB_SAFER_GROUP_POLICY_REGPATH = "Software\\Policies\\Microsoft\\SystemCertificates\\TrustedPublisher\\Safer";
    [NativeTypeName("#define CERT_LOCAL_MACHINE_SYSTEM_STORE_REGPATH L\"Software\\\\Microsoft\\\\SystemCertificates\"")]
    public const string CERT_LOCAL_MACHINE_SYSTEM_STORE_REGPATH = "Software\\Microsoft\\SystemCertificates";
    [NativeTypeName("#define CERT_TRUST_PUB_SAFER_LOCAL_MACHINE_REGPATH CERT_LOCAL_MACHINE_SYSTEM_STORE_REGPATH L\"\\\\TrustedPublisher\\\\Safer\"")]
    public const string CERT_TRUST_PUB_SAFER_LOCAL_MACHINE_REGPATH = "Software\\Microsoft\\SystemCertificates\\TrustedPublisher\\Safer";
    [NativeTypeName("#define CERT_TRUST_PUB_AUTHENTICODE_FLAGS_VALUE_NAME L\"AuthenticodeFlags\"")]
    public const string CERT_TRUST_PUB_AUTHENTICODE_FLAGS_VALUE_NAME = "AuthenticodeFlags";
    [NativeTypeName("#define CERT_TRUST_PUB_ALLOW_TRUST_MASK 0x00000003")]
    public const int CERT_TRUST_PUB_ALLOW_TRUST_MASK = 0x00000003;
    [NativeTypeName("#define CERT_TRUST_PUB_ALLOW_END_USER_TRUST 0x00000000")]
    public const int CERT_TRUST_PUB_ALLOW_END_USER_TRUST = 0x00000000;
    [NativeTypeName("#define CERT_TRUST_PUB_ALLOW_MACHINE_ADMIN_TRUST 0x00000001")]
    public const int CERT_TRUST_PUB_ALLOW_MACHINE_ADMIN_TRUST = 0x00000001;
    [NativeTypeName("#define CERT_TRUST_PUB_ALLOW_ENTERPRISE_ADMIN_TRUST 0x00000002")]
    public const int CERT_TRUST_PUB_ALLOW_ENTERPRISE_ADMIN_TRUST = 0x00000002;
    [NativeTypeName("#define CERT_TRUST_PUB_CHECK_PUBLISHER_REV_FLAG 0x00000100")]
    public const int CERT_TRUST_PUB_CHECK_PUBLISHER_REV_FLAG = 0x00000100;
    [NativeTypeName("#define CERT_TRUST_PUB_CHECK_TIMESTAMP_REV_FLAG 0x00000200")]
    public const int CERT_TRUST_PUB_CHECK_TIMESTAMP_REV_FLAG = 0x00000200;
    [NativeTypeName("#define CERT_OCM_SUBCOMPONENTS_LOCAL_MACHINE_REGPATH L\"SOFTWARE\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Setup\\\\OC Manager\\\\Subcomponents\"")]
    public const string CERT_OCM_SUBCOMPONENTS_LOCAL_MACHINE_REGPATH = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Setup\\OC Manager\\Subcomponents";
    [NativeTypeName("#define CERT_OCM_SUBCOMPONENTS_ROOT_AUTO_UPDATE_VALUE_NAME L\"RootAutoUpdate\"")]
    public const string CERT_OCM_SUBCOMPONENTS_ROOT_AUTO_UPDATE_VALUE_NAME = "RootAutoUpdate";
    [NativeTypeName("#define CERT_DISABLE_ROOT_AUTO_UPDATE_REGPATH CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH L\"\\\\AuthRoot\"")]
    public const string CERT_DISABLE_ROOT_AUTO_UPDATE_REGPATH = "Software\\Policies\\Microsoft\\SystemCertificates\\AuthRoot";
    [NativeTypeName("#define CERT_DISABLE_ROOT_AUTO_UPDATE_VALUE_NAME L\"DisableRootAutoUpdate\"")]
    public const string CERT_DISABLE_ROOT_AUTO_UPDATE_VALUE_NAME = "DisableRootAutoUpdate";
    [NativeTypeName("#define CERT_ENABLE_DISALLOWED_CERT_AUTO_UPDATE_VALUE_NAME L\"EnableDisallowedCertAutoUpdate\"")]
    public const string CERT_ENABLE_DISALLOWED_CERT_AUTO_UPDATE_VALUE_NAME = "EnableDisallowedCertAutoUpdate";
    [NativeTypeName("#define CERT_DISABLE_PIN_RULES_AUTO_UPDATE_VALUE_NAME L\"DisablePinRulesAutoUpdate\"")]
    public const string CERT_DISABLE_PIN_RULES_AUTO_UPDATE_VALUE_NAME = "DisablePinRulesAutoUpdate";
    [NativeTypeName("#define CERT_AUTO_UPDATE_LOCAL_MACHINE_REGPATH CERT_LOCAL_MACHINE_SYSTEM_STORE_REGPATH L\"\\\\AuthRoot\\\\AutoUpdate\"")]
    public const string CERT_AUTO_UPDATE_LOCAL_MACHINE_REGPATH = "Software\\Microsoft\\SystemCertificates\\AuthRoot\\AutoUpdate";
    [NativeTypeName("#define CERT_AUTO_UPDATE_ROOT_DIR_URL_VALUE_NAME L\"RootDirUrl\"")]
    public const string CERT_AUTO_UPDATE_ROOT_DIR_URL_VALUE_NAME = "RootDirUrl";
    [NativeTypeName("#define CERT_AUTO_UPDATE_SYNC_FROM_DIR_URL_VALUE_NAME L\"SyncFromDirUrl\"")]
    public const string CERT_AUTO_UPDATE_SYNC_FROM_DIR_URL_VALUE_NAME = "SyncFromDirUrl";
    [NativeTypeName("#define CERT_AUTH_ROOT_AUTO_UPDATE_LOCAL_MACHINE_REGPATH CERT_AUTO_UPDATE_LOCAL_MACHINE_REGPATH")]
    public const string CERT_AUTH_ROOT_AUTO_UPDATE_LOCAL_MACHINE_REGPATH = "Software\\Microsoft\\SystemCertificates\\AuthRoot\\AutoUpdate";
    [NativeTypeName("#define CERT_AUTH_ROOT_AUTO_UPDATE_ROOT_DIR_URL_VALUE_NAME CERT_AUTO_UPDATE_ROOT_DIR_URL_VALUE_NAME")]
    public const string CERT_AUTH_ROOT_AUTO_UPDATE_ROOT_DIR_URL_VALUE_NAME = "RootDirUrl";
    [NativeTypeName("#define CERT_AUTH_ROOT_AUTO_UPDATE_SYNC_DELTA_TIME_VALUE_NAME L\"SyncDeltaTime\"")]
    public const string CERT_AUTH_ROOT_AUTO_UPDATE_SYNC_DELTA_TIME_VALUE_NAME = "SyncDeltaTime";
    [NativeTypeName("#define CERT_AUTH_ROOT_AUTO_UPDATE_FLAGS_VALUE_NAME L\"Flags\"")]
    public const string CERT_AUTH_ROOT_AUTO_UPDATE_FLAGS_VALUE_NAME = "Flags";
    [NativeTypeName("#define CERT_AUTH_ROOT_AUTO_UPDATE_DISABLE_UNTRUSTED_ROOT_LOGGING_FLAG 0x1")]
    public const int CERT_AUTH_ROOT_AUTO_UPDATE_DISABLE_UNTRUSTED_ROOT_LOGGING_FLAG = 0x1;
    [NativeTypeName("#define CERT_AUTH_ROOT_AUTO_UPDATE_DISABLE_PARTIAL_CHAIN_LOGGING_FLAG 0x2")]
    public const int CERT_AUTH_ROOT_AUTO_UPDATE_DISABLE_PARTIAL_CHAIN_LOGGING_FLAG = 0x2;
    [NativeTypeName("#define CERT_AUTO_UPDATE_DISABLE_RANDOM_QUERY_STRING_FLAG 0x4")]
    public const int CERT_AUTO_UPDATE_DISABLE_RANDOM_QUERY_STRING_FLAG = 0x4;
    [NativeTypeName("#define CERT_AUTH_ROOT_AUTO_UPDATE_LAST_SYNC_TIME_VALUE_NAME L\"LastSyncTime\"")]
    public const string CERT_AUTH_ROOT_AUTO_UPDATE_LAST_SYNC_TIME_VALUE_NAME = "LastSyncTime";
    [NativeTypeName("#define CERT_AUTH_ROOT_AUTO_UPDATE_ENCODED_CTL_VALUE_NAME L\"EncodedCtl\"")]
    public const string CERT_AUTH_ROOT_AUTO_UPDATE_ENCODED_CTL_VALUE_NAME = "EncodedCtl";
    [NativeTypeName("#define CERT_AUTH_ROOT_CTL_FILENAME L\"authroot.stl\"")]
    public const string CERT_AUTH_ROOT_CTL_FILENAME = "authroot.stl";
    [NativeTypeName("#define CERT_AUTH_ROOT_CTL_FILENAME_A \"authroot.stl\"")]
    public static ReadOnlySpan<byte> CERT_AUTH_ROOT_CTL_FILENAME_A => "authroot.stl"u8;

    [NativeTypeName("#define CERT_AUTH_ROOT_CAB_FILENAME L\"authrootstl.cab\"")]
    public const string CERT_AUTH_ROOT_CAB_FILENAME = "authrootstl.cab";
    [NativeTypeName("#define CERT_AUTH_ROOT_SEQ_FILENAME L\"authrootseq.txt\"")]
    public const string CERT_AUTH_ROOT_SEQ_FILENAME = "authrootseq.txt";
    [NativeTypeName("#define CERT_AUTH_ROOT_CERT_EXT L\".crt\"")]
    public const string CERT_AUTH_ROOT_CERT_EXT = ".crt";
    [NativeTypeName("#define CERT_DISALLOWED_CERT_AUTO_UPDATE_SYNC_DELTA_TIME_VALUE_NAME L\"DisallowedCertSyncDeltaTime\"")]
    public const string CERT_DISALLOWED_CERT_AUTO_UPDATE_SYNC_DELTA_TIME_VALUE_NAME = "DisallowedCertSyncDeltaTime";
    [NativeTypeName("#define CERT_DISALLOWED_CERT_AUTO_UPDATE_LAST_SYNC_TIME_VALUE_NAME L\"DisallowedCertLastSyncTime\"")]
    public const string CERT_DISALLOWED_CERT_AUTO_UPDATE_LAST_SYNC_TIME_VALUE_NAME = "DisallowedCertLastSyncTime";
    [NativeTypeName("#define CERT_DISALLOWED_CERT_AUTO_UPDATE_ENCODED_CTL_VALUE_NAME L\"DisallowedCertEncodedCtl\"")]
    public const string CERT_DISALLOWED_CERT_AUTO_UPDATE_ENCODED_CTL_VALUE_NAME = "DisallowedCertEncodedCtl";
    [NativeTypeName("#define CERT_DISALLOWED_CERT_CTL_FILENAME L\"disallowedcert.stl\"")]
    public const string CERT_DISALLOWED_CERT_CTL_FILENAME = "disallowedcert.stl";
    [NativeTypeName("#define CERT_DISALLOWED_CERT_CTL_FILENAME_A \"disallowedcert.stl\"")]
    public static ReadOnlySpan<byte> CERT_DISALLOWED_CERT_CTL_FILENAME_A => "disallowedcert.stl"u8;

    [NativeTypeName("#define CERT_DISALLOWED_CERT_CAB_FILENAME L\"disallowedcertstl.cab\"")]
    public const string CERT_DISALLOWED_CERT_CAB_FILENAME = "disallowedcertstl.cab";
    [NativeTypeName("#define CERT_DISALLOWED_CERT_AUTO_UPDATE_LIST_IDENTIFIER L\"DisallowedCert_AutoUpdate_1\"")]
    public const string CERT_DISALLOWED_CERT_AUTO_UPDATE_LIST_IDENTIFIER = "DisallowedCert_AutoUpdate_1";
    [NativeTypeName("#define CERT_PIN_RULES_AUTO_UPDATE_SYNC_DELTA_TIME_VALUE_NAME L\"PinRulesSyncDeltaTime\"")]
    public const string CERT_PIN_RULES_AUTO_UPDATE_SYNC_DELTA_TIME_VALUE_NAME = "PinRulesSyncDeltaTime";
    [NativeTypeName("#define CERT_PIN_RULES_AUTO_UPDATE_LAST_SYNC_TIME_VALUE_NAME L\"PinRulesLastSyncTime\"")]
    public const string CERT_PIN_RULES_AUTO_UPDATE_LAST_SYNC_TIME_VALUE_NAME = "PinRulesLastSyncTime";
    [NativeTypeName("#define CERT_PIN_RULES_AUTO_UPDATE_ENCODED_CTL_VALUE_NAME L\"PinRulesEncodedCtl\"")]
    public const string CERT_PIN_RULES_AUTO_UPDATE_ENCODED_CTL_VALUE_NAME = "PinRulesEncodedCtl";
    [NativeTypeName("#define CERT_PIN_RULES_CTL_FILENAME L\"pinrules.stl\"")]
    public const string CERT_PIN_RULES_CTL_FILENAME = "pinrules.stl";
    [NativeTypeName("#define CERT_PIN_RULES_CTL_FILENAME_A \"pinrules.stl\"")]
    public static ReadOnlySpan<byte> CERT_PIN_RULES_CTL_FILENAME_A => "pinrules.stl"u8;

    [NativeTypeName("#define CERT_PIN_RULES_CAB_FILENAME L\"pinrulesstl.cab\"")]
    public const string CERT_PIN_RULES_CAB_FILENAME = "pinrulesstl.cab";
    [NativeTypeName("#define CERT_PIN_RULES_AUTO_UPDATE_LIST_IDENTIFIER L\"PinRules_AutoUpdate_1\"")]
    public const string CERT_PIN_RULES_AUTO_UPDATE_LIST_IDENTIFIER = "PinRules_AutoUpdate_1";
    [NativeTypeName("#define CERT_REGISTRY_STORE_REMOTE_FLAG 0x10000")]
    public const int CERT_REGISTRY_STORE_REMOTE_FLAG = 0x10000;
    [NativeTypeName("#define CERT_REGISTRY_STORE_SERIALIZED_FLAG 0x20000")]
    public const int CERT_REGISTRY_STORE_SERIALIZED_FLAG = 0x20000;
    [NativeTypeName("#define CERT_REGISTRY_STORE_CLIENT_GPT_FLAG 0x80000000")]
    public const uint CERT_REGISTRY_STORE_CLIENT_GPT_FLAG = 0x80000000;
    [NativeTypeName("#define CERT_REGISTRY_STORE_LM_GPT_FLAG 0x01000000")]
    public const int CERT_REGISTRY_STORE_LM_GPT_FLAG = 0x01000000;
    [NativeTypeName("#define CERT_REGISTRY_STORE_ROAMING_FLAG 0x40000")]
    public const int CERT_REGISTRY_STORE_ROAMING_FLAG = 0x40000;
    [NativeTypeName("#define CERT_REGISTRY_STORE_MY_IE_DIRTY_FLAG 0x80000")]
    public const int CERT_REGISTRY_STORE_MY_IE_DIRTY_FLAG = 0x80000;
    [NativeTypeName("#define CERT_REGISTRY_STORE_EXTERNAL_FLAG 0x100000")]
    public const int CERT_REGISTRY_STORE_EXTERNAL_FLAG = 0x100000;
    [NativeTypeName("#define CERT_IE_DIRTY_FLAGS_REGPATH L\"Software\\\\Microsoft\\\\Cryptography\\\\IEDirtyFlags\"")]
    public const string CERT_IE_DIRTY_FLAGS_REGPATH = "Software\\Microsoft\\Cryptography\\IEDirtyFlags";
    [NativeTypeName("#define CERT_FILE_STORE_COMMIT_ENABLE_FLAG 0x10000")]
    public const int CERT_FILE_STORE_COMMIT_ENABLE_FLAG = 0x10000;
    [NativeTypeName("#define CERT_LDAP_STORE_SIGN_FLAG 0x10000")]
    public const int CERT_LDAP_STORE_SIGN_FLAG = 0x10000;
    [NativeTypeName("#define CERT_LDAP_STORE_AREC_EXCLUSIVE_FLAG 0x20000")]
    public const int CERT_LDAP_STORE_AREC_EXCLUSIVE_FLAG = 0x20000;
    [NativeTypeName("#define CERT_LDAP_STORE_OPENED_FLAG 0x40000")]
    public const int CERT_LDAP_STORE_OPENED_FLAG = 0x40000;
    [NativeTypeName("#define CERT_LDAP_STORE_UNBIND_FLAG 0x80000")]
    public const int CERT_LDAP_STORE_UNBIND_FLAG = 0x80000;
    [NativeTypeName("#define CERT_STORE_PROV_EXTERNAL_FLAG 0x1")]
    public const int CERT_STORE_PROV_EXTERNAL_FLAG = 0x1;
    [NativeTypeName("#define CERT_STORE_PROV_DELETED_FLAG 0x2")]
    public const int CERT_STORE_PROV_DELETED_FLAG = 0x2;
    [NativeTypeName("#define CERT_STORE_PROV_NO_PERSIST_FLAG 0x4")]
    public const int CERT_STORE_PROV_NO_PERSIST_FLAG = 0x4;
    [NativeTypeName("#define CERT_STORE_PROV_SYSTEM_STORE_FLAG 0x8")]
    public const int CERT_STORE_PROV_SYSTEM_STORE_FLAG = 0x8;
    [NativeTypeName("#define CERT_STORE_PROV_LM_SYSTEM_STORE_FLAG 0x10")]
    public const int CERT_STORE_PROV_LM_SYSTEM_STORE_FLAG = 0x10;
    [NativeTypeName("#define CERT_STORE_PROV_GP_SYSTEM_STORE_FLAG 0x20")]
    public const int CERT_STORE_PROV_GP_SYSTEM_STORE_FLAG = 0x20;
    [NativeTypeName("#define CERT_STORE_PROV_SHARED_USER_FLAG 0x40")]
    public const int CERT_STORE_PROV_SHARED_USER_FLAG = 0x40;
    [NativeTypeName("#define CERT_STORE_PROV_CLOSE_FUNC 0")]
    public const int CERT_STORE_PROV_CLOSE_FUNC = 0;
    [NativeTypeName("#define CERT_STORE_PROV_READ_CERT_FUNC 1")]
    public const int CERT_STORE_PROV_READ_CERT_FUNC = 1;
    [NativeTypeName("#define CERT_STORE_PROV_WRITE_CERT_FUNC 2")]
    public const int CERT_STORE_PROV_WRITE_CERT_FUNC = 2;
    [NativeTypeName("#define CERT_STORE_PROV_DELETE_CERT_FUNC 3")]
    public const int CERT_STORE_PROV_DELETE_CERT_FUNC = 3;
    [NativeTypeName("#define CERT_STORE_PROV_SET_CERT_PROPERTY_FUNC 4")]
    public const int CERT_STORE_PROV_SET_CERT_PROPERTY_FUNC = 4;
    [NativeTypeName("#define CERT_STORE_PROV_READ_CRL_FUNC 5")]
    public const int CERT_STORE_PROV_READ_CRL_FUNC = 5;
    [NativeTypeName("#define CERT_STORE_PROV_WRITE_CRL_FUNC 6")]
    public const int CERT_STORE_PROV_WRITE_CRL_FUNC = 6;
    [NativeTypeName("#define CERT_STORE_PROV_DELETE_CRL_FUNC 7")]
    public const int CERT_STORE_PROV_DELETE_CRL_FUNC = 7;
    [NativeTypeName("#define CERT_STORE_PROV_SET_CRL_PROPERTY_FUNC 8")]
    public const int CERT_STORE_PROV_SET_CRL_PROPERTY_FUNC = 8;
    [NativeTypeName("#define CERT_STORE_PROV_READ_CTL_FUNC 9")]
    public const int CERT_STORE_PROV_READ_CTL_FUNC = 9;
    [NativeTypeName("#define CERT_STORE_PROV_WRITE_CTL_FUNC 10")]
    public const int CERT_STORE_PROV_WRITE_CTL_FUNC = 10;
    [NativeTypeName("#define CERT_STORE_PROV_DELETE_CTL_FUNC 11")]
    public const int CERT_STORE_PROV_DELETE_CTL_FUNC = 11;
    [NativeTypeName("#define CERT_STORE_PROV_SET_CTL_PROPERTY_FUNC 12")]
    public const int CERT_STORE_PROV_SET_CTL_PROPERTY_FUNC = 12;
    [NativeTypeName("#define CERT_STORE_PROV_CONTROL_FUNC 13")]
    public const int CERT_STORE_PROV_CONTROL_FUNC = 13;
    [NativeTypeName("#define CERT_STORE_PROV_FIND_CERT_FUNC 14")]
    public const int CERT_STORE_PROV_FIND_CERT_FUNC = 14;
    [NativeTypeName("#define CERT_STORE_PROV_FREE_FIND_CERT_FUNC 15")]
    public const int CERT_STORE_PROV_FREE_FIND_CERT_FUNC = 15;
    [NativeTypeName("#define CERT_STORE_PROV_GET_CERT_PROPERTY_FUNC 16")]
    public const int CERT_STORE_PROV_GET_CERT_PROPERTY_FUNC = 16;
    [NativeTypeName("#define CERT_STORE_PROV_FIND_CRL_FUNC 17")]
    public const int CERT_STORE_PROV_FIND_CRL_FUNC = 17;
    [NativeTypeName("#define CERT_STORE_PROV_FREE_FIND_CRL_FUNC 18")]
    public const int CERT_STORE_PROV_FREE_FIND_CRL_FUNC = 18;
    [NativeTypeName("#define CERT_STORE_PROV_GET_CRL_PROPERTY_FUNC 19")]
    public const int CERT_STORE_PROV_GET_CRL_PROPERTY_FUNC = 19;
    [NativeTypeName("#define CERT_STORE_PROV_FIND_CTL_FUNC 20")]
    public const int CERT_STORE_PROV_FIND_CTL_FUNC = 20;
    [NativeTypeName("#define CERT_STORE_PROV_FREE_FIND_CTL_FUNC 21")]
    public const int CERT_STORE_PROV_FREE_FIND_CTL_FUNC = 21;
    [NativeTypeName("#define CERT_STORE_PROV_GET_CTL_PROPERTY_FUNC 22")]
    public const int CERT_STORE_PROV_GET_CTL_PROPERTY_FUNC = 22;
    [NativeTypeName("#define CERT_STORE_PROV_WRITE_ADD_FLAG 0x1")]
    public const int CERT_STORE_PROV_WRITE_ADD_FLAG = 0x1;
    [NativeTypeName("#define CERT_STORE_SAVE_AS_STORE 1")]
    public const int CERT_STORE_SAVE_AS_STORE = 1;
    [NativeTypeName("#define CERT_STORE_SAVE_AS_PKCS7 2")]
    public const int CERT_STORE_SAVE_AS_PKCS7 = 2;
    [NativeTypeName("#define CERT_STORE_SAVE_AS_PKCS12 3")]
    public const int CERT_STORE_SAVE_AS_PKCS12 = 3;
    [NativeTypeName("#define CERT_STORE_SAVE_TO_FILE 1")]
    public const int CERT_STORE_SAVE_TO_FILE = 1;
    [NativeTypeName("#define CERT_STORE_SAVE_TO_MEMORY 2")]
    public const int CERT_STORE_SAVE_TO_MEMORY = 2;
    [NativeTypeName("#define CERT_STORE_SAVE_TO_FILENAME_A 3")]
    public const int CERT_STORE_SAVE_TO_FILENAME_A = 3;
    [NativeTypeName("#define CERT_STORE_SAVE_TO_FILENAME_W 4")]
    public const int CERT_STORE_SAVE_TO_FILENAME_W = 4;
    [NativeTypeName("#define CERT_STORE_SAVE_TO_FILENAME CERT_STORE_SAVE_TO_FILENAME_W")]
    public const int CERT_STORE_SAVE_TO_FILENAME = 4;
    [NativeTypeName("#define CERT_CLOSE_STORE_FORCE_FLAG 0x00000001")]
    public const int CERT_CLOSE_STORE_FORCE_FLAG = 0x00000001;
    [NativeTypeName("#define CERT_CLOSE_STORE_CHECK_FLAG 0x00000002")]
    public const int CERT_CLOSE_STORE_CHECK_FLAG = 0x00000002;
    [NativeTypeName("#define CERT_COMPARE_MASK 0xFFFF")]
    public const int CERT_COMPARE_MASK = 0xFFFF;
    [NativeTypeName("#define CERT_COMPARE_SHIFT 16")]
    public const int CERT_COMPARE_SHIFT = 16;
    [NativeTypeName("#define CERT_COMPARE_ANY 0")]
    public const int CERT_COMPARE_ANY = 0;
    [NativeTypeName("#define CERT_COMPARE_SHA1_HASH 1")]
    public const int CERT_COMPARE_SHA1_HASH = 1;
    [NativeTypeName("#define CERT_COMPARE_NAME 2")]
    public const int CERT_COMPARE_NAME = 2;
    [NativeTypeName("#define CERT_COMPARE_ATTR 3")]
    public const int CERT_COMPARE_ATTR = 3;
    [NativeTypeName("#define CERT_COMPARE_MD5_HASH 4")]
    public const int CERT_COMPARE_MD5_HASH = 4;
    [NativeTypeName("#define CERT_COMPARE_PROPERTY 5")]
    public const int CERT_COMPARE_PROPERTY = 5;
    [NativeTypeName("#define CERT_COMPARE_PUBLIC_KEY 6")]
    public const int CERT_COMPARE_PUBLIC_KEY = 6;
    [NativeTypeName("#define CERT_COMPARE_HASH CERT_COMPARE_SHA1_HASH")]
    public const int CERT_COMPARE_HASH = 1;
    [NativeTypeName("#define CERT_COMPARE_NAME_STR_A 7")]
    public const int CERT_COMPARE_NAME_STR_A = 7;
    [NativeTypeName("#define CERT_COMPARE_NAME_STR_W 8")]
    public const int CERT_COMPARE_NAME_STR_W = 8;
    [NativeTypeName("#define CERT_COMPARE_KEY_SPEC 9")]
    public const int CERT_COMPARE_KEY_SPEC = 9;
    [NativeTypeName("#define CERT_COMPARE_ENHKEY_USAGE 10")]
    public const int CERT_COMPARE_ENHKEY_USAGE = 10;
    [NativeTypeName("#define CERT_COMPARE_CTL_USAGE CERT_COMPARE_ENHKEY_USAGE")]
    public const int CERT_COMPARE_CTL_USAGE = 10;
    [NativeTypeName("#define CERT_COMPARE_SUBJECT_CERT 11")]
    public const int CERT_COMPARE_SUBJECT_CERT = 11;
    [NativeTypeName("#define CERT_COMPARE_ISSUER_OF 12")]
    public const int CERT_COMPARE_ISSUER_OF = 12;
    [NativeTypeName("#define CERT_COMPARE_EXISTING 13")]
    public const int CERT_COMPARE_EXISTING = 13;
    [NativeTypeName("#define CERT_COMPARE_SIGNATURE_HASH 14")]
    public const int CERT_COMPARE_SIGNATURE_HASH = 14;
    [NativeTypeName("#define CERT_COMPARE_KEY_IDENTIFIER 15")]
    public const int CERT_COMPARE_KEY_IDENTIFIER = 15;
    [NativeTypeName("#define CERT_COMPARE_CERT_ID 16")]
    public const int CERT_COMPARE_CERT_ID = 16;
    [NativeTypeName("#define CERT_COMPARE_CROSS_CERT_DIST_POINTS 17")]
    public const int CERT_COMPARE_CROSS_CERT_DIST_POINTS = 17;
    [NativeTypeName("#define CERT_COMPARE_PUBKEY_MD5_HASH 18")]
    public const int CERT_COMPARE_PUBKEY_MD5_HASH = 18;
    [NativeTypeName("#define CERT_COMPARE_SUBJECT_INFO_ACCESS 19")]
    public const int CERT_COMPARE_SUBJECT_INFO_ACCESS = 19;
    [NativeTypeName("#define CERT_COMPARE_HASH_STR 20")]
    public const int CERT_COMPARE_HASH_STR = 20;
    [NativeTypeName("#define CERT_COMPARE_HAS_PRIVATE_KEY 21")]
    public const int CERT_COMPARE_HAS_PRIVATE_KEY = 21;
    [NativeTypeName("#define CERT_FIND_ANY (CERT_COMPARE_ANY << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_ANY = (0 << 16);
    [NativeTypeName("#define CERT_FIND_SHA1_HASH (CERT_COMPARE_SHA1_HASH << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_SHA1_HASH = (1 << 16);
    [NativeTypeName("#define CERT_FIND_MD5_HASH (CERT_COMPARE_MD5_HASH << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_MD5_HASH = (4 << 16);
    [NativeTypeName("#define CERT_FIND_SIGNATURE_HASH (CERT_COMPARE_SIGNATURE_HASH << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_SIGNATURE_HASH = (14 << 16);
    [NativeTypeName("#define CERT_FIND_KEY_IDENTIFIER (CERT_COMPARE_KEY_IDENTIFIER << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_KEY_IDENTIFIER = (15 << 16);
    [NativeTypeName("#define CERT_FIND_HASH CERT_FIND_SHA1_HASH")]
    public const int CERT_FIND_HASH = (1 << 16);
    [NativeTypeName("#define CERT_FIND_PROPERTY (CERT_COMPARE_PROPERTY << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_PROPERTY = (5 << 16);
    [NativeTypeName("#define CERT_FIND_PUBLIC_KEY (CERT_COMPARE_PUBLIC_KEY << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_PUBLIC_KEY = (6 << 16);
    [NativeTypeName("#define CERT_FIND_SUBJECT_NAME (CERT_COMPARE_NAME << CERT_COMPARE_SHIFT | \\\r\n                                 CERT_INFO_SUBJECT_FLAG)")]
    public const int CERT_FIND_SUBJECT_NAME = (2 << 16 | 7);
    [NativeTypeName("#define CERT_FIND_SUBJECT_ATTR (CERT_COMPARE_ATTR << CERT_COMPARE_SHIFT | \\\r\n                                 CERT_INFO_SUBJECT_FLAG)")]
    public const int CERT_FIND_SUBJECT_ATTR = (3 << 16 | 7);
    [NativeTypeName("#define CERT_FIND_ISSUER_NAME (CERT_COMPARE_NAME << CERT_COMPARE_SHIFT | \\\r\n                                 CERT_INFO_ISSUER_FLAG)")]
    public const int CERT_FIND_ISSUER_NAME = (2 << 16 | 4);
    [NativeTypeName("#define CERT_FIND_ISSUER_ATTR (CERT_COMPARE_ATTR << CERT_COMPARE_SHIFT | \\\r\n                                 CERT_INFO_ISSUER_FLAG)")]
    public const int CERT_FIND_ISSUER_ATTR = (3 << 16 | 4);
    [NativeTypeName("#define CERT_FIND_SUBJECT_STR_A (CERT_COMPARE_NAME_STR_A << CERT_COMPARE_SHIFT | \\\r\n                                 CERT_INFO_SUBJECT_FLAG)")]
    public const int CERT_FIND_SUBJECT_STR_A = (7 << 16 | 7);
    [NativeTypeName("#define CERT_FIND_SUBJECT_STR_W (CERT_COMPARE_NAME_STR_W << CERT_COMPARE_SHIFT | \\\r\n                                 CERT_INFO_SUBJECT_FLAG)")]
    public const int CERT_FIND_SUBJECT_STR_W = (8 << 16 | 7);
    [NativeTypeName("#define CERT_FIND_SUBJECT_STR CERT_FIND_SUBJECT_STR_W")]
    public const int CERT_FIND_SUBJECT_STR = (8 << 16 | 7);
    [NativeTypeName("#define CERT_FIND_ISSUER_STR_A (CERT_COMPARE_NAME_STR_A << CERT_COMPARE_SHIFT | \\\r\n                                 CERT_INFO_ISSUER_FLAG)")]
    public const int CERT_FIND_ISSUER_STR_A = (7 << 16 | 4);
    [NativeTypeName("#define CERT_FIND_ISSUER_STR_W (CERT_COMPARE_NAME_STR_W << CERT_COMPARE_SHIFT | \\\r\n                                 CERT_INFO_ISSUER_FLAG)")]
    public const int CERT_FIND_ISSUER_STR_W = (8 << 16 | 4);
    [NativeTypeName("#define CERT_FIND_ISSUER_STR CERT_FIND_ISSUER_STR_W")]
    public const int CERT_FIND_ISSUER_STR = (8 << 16 | 4);
    [NativeTypeName("#define CERT_FIND_KEY_SPEC (CERT_COMPARE_KEY_SPEC << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_KEY_SPEC = (9 << 16);
    [NativeTypeName("#define CERT_FIND_ENHKEY_USAGE (CERT_COMPARE_ENHKEY_USAGE << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_ENHKEY_USAGE = (10 << 16);
    [NativeTypeName("#define CERT_FIND_CTL_USAGE CERT_FIND_ENHKEY_USAGE")]
    public const int CERT_FIND_CTL_USAGE = (10 << 16);
    [NativeTypeName("#define CERT_FIND_SUBJECT_CERT (CERT_COMPARE_SUBJECT_CERT << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_SUBJECT_CERT = (11 << 16);
    [NativeTypeName("#define CERT_FIND_ISSUER_OF (CERT_COMPARE_ISSUER_OF << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_ISSUER_OF = (12 << 16);
    [NativeTypeName("#define CERT_FIND_EXISTING (CERT_COMPARE_EXISTING << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_EXISTING = (13 << 16);
    [NativeTypeName("#define CERT_FIND_CERT_ID (CERT_COMPARE_CERT_ID << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_CERT_ID = (16 << 16);
    [NativeTypeName("#define CERT_FIND_CROSS_CERT_DIST_POINTS (CERT_COMPARE_CROSS_CERT_DIST_POINTS << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_CROSS_CERT_DIST_POINTS = (17 << 16);
    [NativeTypeName("#define CERT_FIND_PUBKEY_MD5_HASH (CERT_COMPARE_PUBKEY_MD5_HASH << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_PUBKEY_MD5_HASH = (18 << 16);
    [NativeTypeName("#define CERT_FIND_SUBJECT_INFO_ACCESS (CERT_COMPARE_SUBJECT_INFO_ACCESS << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_SUBJECT_INFO_ACCESS = (19 << 16);
    [NativeTypeName("#define CERT_FIND_HASH_STR (CERT_COMPARE_HASH_STR << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_HASH_STR = (20 << 16);
    [NativeTypeName("#define CERT_FIND_HAS_PRIVATE_KEY (CERT_COMPARE_HAS_PRIVATE_KEY << CERT_COMPARE_SHIFT)")]
    public const int CERT_FIND_HAS_PRIVATE_KEY = (21 << 16);
    [NativeTypeName("#define CERT_FIND_OPTIONAL_ENHKEY_USAGE_FLAG 0x1")]
    public const int CERT_FIND_OPTIONAL_ENHKEY_USAGE_FLAG = 0x1;
    [NativeTypeName("#define CERT_FIND_EXT_ONLY_ENHKEY_USAGE_FLAG 0x2")]
    public const int CERT_FIND_EXT_ONLY_ENHKEY_USAGE_FLAG = 0x2;
    [NativeTypeName("#define CERT_FIND_PROP_ONLY_ENHKEY_USAGE_FLAG 0x4")]
    public const int CERT_FIND_PROP_ONLY_ENHKEY_USAGE_FLAG = 0x4;
    [NativeTypeName("#define CERT_FIND_NO_ENHKEY_USAGE_FLAG 0x8")]
    public const int CERT_FIND_NO_ENHKEY_USAGE_FLAG = 0x8;
    [NativeTypeName("#define CERT_FIND_OR_ENHKEY_USAGE_FLAG 0x10")]
    public const int CERT_FIND_OR_ENHKEY_USAGE_FLAG = 0x10;
    [NativeTypeName("#define CERT_FIND_VALID_ENHKEY_USAGE_FLAG 0x20")]
    public const int CERT_FIND_VALID_ENHKEY_USAGE_FLAG = 0x20;
    [NativeTypeName("#define CERT_FIND_OPTIONAL_CTL_USAGE_FLAG CERT_FIND_OPTIONAL_ENHKEY_USAGE_FLAG")]
    public const int CERT_FIND_OPTIONAL_CTL_USAGE_FLAG = 0x1;
    [NativeTypeName("#define CERT_FIND_EXT_ONLY_CTL_USAGE_FLAG CERT_FIND_EXT_ONLY_ENHKEY_USAGE_FLAG")]
    public const int CERT_FIND_EXT_ONLY_CTL_USAGE_FLAG = 0x2;
    [NativeTypeName("#define CERT_FIND_PROP_ONLY_CTL_USAGE_FLAG CERT_FIND_PROP_ONLY_ENHKEY_USAGE_FLAG")]
    public const int CERT_FIND_PROP_ONLY_CTL_USAGE_FLAG = 0x4;
    [NativeTypeName("#define CERT_FIND_NO_CTL_USAGE_FLAG CERT_FIND_NO_ENHKEY_USAGE_FLAG")]
    public const int CERT_FIND_NO_CTL_USAGE_FLAG = 0x8;
    [NativeTypeName("#define CERT_FIND_OR_CTL_USAGE_FLAG CERT_FIND_OR_ENHKEY_USAGE_FLAG")]
    public const int CERT_FIND_OR_CTL_USAGE_FLAG = 0x10;
    [NativeTypeName("#define CERT_FIND_VALID_CTL_USAGE_FLAG CERT_FIND_VALID_ENHKEY_USAGE_FLAG")]
    public const int CERT_FIND_VALID_CTL_USAGE_FLAG = 0x20;
    [NativeTypeName("#define CERT_SET_PROPERTY_IGNORE_PERSIST_ERROR_FLAG 0x80000000")]
    public const uint CERT_SET_PROPERTY_IGNORE_PERSIST_ERROR_FLAG = 0x80000000;
    [NativeTypeName("#define CERT_SET_PROPERTY_INHIBIT_PERSIST_FLAG 0x40000000")]
    public const int CERT_SET_PROPERTY_INHIBIT_PERSIST_FLAG = 0x40000000;
    [NativeTypeName("#define CERT_STORE_ADD_NEW 1")]
    public const int CERT_STORE_ADD_NEW = 1;
    [NativeTypeName("#define CERT_STORE_ADD_USE_EXISTING 2")]
    public const int CERT_STORE_ADD_USE_EXISTING = 2;
    [NativeTypeName("#define CERT_STORE_ADD_REPLACE_EXISTING 3")]
    public const int CERT_STORE_ADD_REPLACE_EXISTING = 3;
    [NativeTypeName("#define CERT_STORE_ADD_ALWAYS 4")]
    public const int CERT_STORE_ADD_ALWAYS = 4;
    [NativeTypeName("#define CERT_STORE_ADD_REPLACE_EXISTING_INHERIT_PROPERTIES 5")]
    public const int CERT_STORE_ADD_REPLACE_EXISTING_INHERIT_PROPERTIES = 5;
    [NativeTypeName("#define CERT_STORE_ADD_NEWER 6")]
    public const int CERT_STORE_ADD_NEWER = 6;
    [NativeTypeName("#define CERT_STORE_ADD_NEWER_INHERIT_PROPERTIES 7")]
    public const int CERT_STORE_ADD_NEWER_INHERIT_PROPERTIES = 7;
    [NativeTypeName("#define CERT_STORE_CERTIFICATE_CONTEXT 1")]
    public const int CERT_STORE_CERTIFICATE_CONTEXT = 1;
    [NativeTypeName("#define CERT_STORE_CRL_CONTEXT 2")]
    public const int CERT_STORE_CRL_CONTEXT = 2;
    [NativeTypeName("#define CERT_STORE_CTL_CONTEXT 3")]
    public const int CERT_STORE_CTL_CONTEXT = 3;
    [NativeTypeName("#define CERT_STORE_ALL_CONTEXT_FLAG (~0UL)")]
    public const uint CERT_STORE_ALL_CONTEXT_FLAG = (~0U);
    [NativeTypeName("#define CERT_STORE_CERTIFICATE_CONTEXT_FLAG (1 << CERT_STORE_CERTIFICATE_CONTEXT)")]
    public const int CERT_STORE_CERTIFICATE_CONTEXT_FLAG = (1 << 1);
    [NativeTypeName("#define CERT_STORE_CRL_CONTEXT_FLAG (1 << CERT_STORE_CRL_CONTEXT)")]
    public const int CERT_STORE_CRL_CONTEXT_FLAG = (1 << 2);
    [NativeTypeName("#define CERT_STORE_CTL_CONTEXT_FLAG (1 << CERT_STORE_CTL_CONTEXT)")]
    public const int CERT_STORE_CTL_CONTEXT_FLAG = (1 << 3);
    [NativeTypeName("#define CERT_STORE_CTRL_RESYNC 1")]
    public const int CERT_STORE_CTRL_RESYNC = 1;
    [NativeTypeName("#define CERT_STORE_CTRL_NOTIFY_CHANGE 2")]
    public const int CERT_STORE_CTRL_NOTIFY_CHANGE = 2;
    [NativeTypeName("#define CERT_STORE_CTRL_COMMIT 3")]
    public const int CERT_STORE_CTRL_COMMIT = 3;
    [NativeTypeName("#define CERT_STORE_CTRL_AUTO_RESYNC 4")]
    public const int CERT_STORE_CTRL_AUTO_RESYNC = 4;
    [NativeTypeName("#define CERT_STORE_CTRL_CANCEL_NOTIFY 5")]
    public const int CERT_STORE_CTRL_CANCEL_NOTIFY = 5;
    [NativeTypeName("#define CERT_STORE_CTRL_INHIBIT_DUPLICATE_HANDLE_FLAG 0x1")]
    public const int CERT_STORE_CTRL_INHIBIT_DUPLICATE_HANDLE_FLAG = 0x1;
    [NativeTypeName("#define CERT_STORE_CTRL_COMMIT_FORCE_FLAG 0x1")]
    public const int CERT_STORE_CTRL_COMMIT_FORCE_FLAG = 0x1;
    [NativeTypeName("#define CERT_STORE_CTRL_COMMIT_CLEAR_FLAG 0x2")]
    public const int CERT_STORE_CTRL_COMMIT_CLEAR_FLAG = 0x2;
    [NativeTypeName("#define CERT_STORE_LOCALIZED_NAME_PROP_ID 0x1000")]
    public const int CERT_STORE_LOCALIZED_NAME_PROP_ID = 0x1000;
    [NativeTypeName("#define CERT_CREATE_CONTEXT_NOCOPY_FLAG 0x1")]
    public const int CERT_CREATE_CONTEXT_NOCOPY_FLAG = 0x1;
    [NativeTypeName("#define CERT_CREATE_CONTEXT_SORTED_FLAG 0x2")]
    public const int CERT_CREATE_CONTEXT_SORTED_FLAG = 0x2;
    [NativeTypeName("#define CERT_CREATE_CONTEXT_NO_HCRYPTMSG_FLAG 0x4")]
    public const int CERT_CREATE_CONTEXT_NO_HCRYPTMSG_FLAG = 0x4;
    [NativeTypeName("#define CERT_CREATE_CONTEXT_NO_ENTRY_FLAG 0x8")]
    public const int CERT_CREATE_CONTEXT_NO_ENTRY_FLAG = 0x8;
    [NativeTypeName("#define CERT_PHYSICAL_STORE_ADD_ENABLE_FLAG 0x1")]
    public const int CERT_PHYSICAL_STORE_ADD_ENABLE_FLAG = 0x1;
    [NativeTypeName("#define CERT_PHYSICAL_STORE_OPEN_DISABLE_FLAG 0x2")]
    public const int CERT_PHYSICAL_STORE_OPEN_DISABLE_FLAG = 0x2;
    [NativeTypeName("#define CERT_PHYSICAL_STORE_REMOTE_OPEN_DISABLE_FLAG 0x4")]
    public const int CERT_PHYSICAL_STORE_REMOTE_OPEN_DISABLE_FLAG = 0x4;
    [NativeTypeName("#define CERT_PHYSICAL_STORE_INSERT_COMPUTER_NAME_ENABLE_FLAG 0x8")]
    public const int CERT_PHYSICAL_STORE_INSERT_COMPUTER_NAME_ENABLE_FLAG = 0x8;
    [NativeTypeName("#define CERT_PHYSICAL_STORE_PREDEFINED_ENUM_FLAG 0x1")]
    public const int CERT_PHYSICAL_STORE_PREDEFINED_ENUM_FLAG = 0x1;
    [NativeTypeName("#define CERT_PHYSICAL_STORE_DEFAULT_NAME L\".Default\"")]
    public const string CERT_PHYSICAL_STORE_DEFAULT_NAME = ".Default";
    [NativeTypeName("#define CERT_PHYSICAL_STORE_GROUP_POLICY_NAME L\".GroupPolicy\"")]
    public const string CERT_PHYSICAL_STORE_GROUP_POLICY_NAME = ".GroupPolicy";
    [NativeTypeName("#define CERT_PHYSICAL_STORE_LOCAL_MACHINE_NAME L\".LocalMachine\"")]
    public const string CERT_PHYSICAL_STORE_LOCAL_MACHINE_NAME = ".LocalMachine";
    [NativeTypeName("#define CERT_PHYSICAL_STORE_DS_USER_CERTIFICATE_NAME L\".UserCertificate\"")]
    public const string CERT_PHYSICAL_STORE_DS_USER_CERTIFICATE_NAME = ".UserCertificate";
    [NativeTypeName("#define CERT_PHYSICAL_STORE_LOCAL_MACHINE_GROUP_POLICY_NAME L\".LocalMachineGroupPolicy\"")]
    public const string CERT_PHYSICAL_STORE_LOCAL_MACHINE_GROUP_POLICY_NAME = ".LocalMachineGroupPolicy";
    [NativeTypeName("#define CERT_PHYSICAL_STORE_ENTERPRISE_NAME L\".Enterprise\"")]
    public const string CERT_PHYSICAL_STORE_ENTERPRISE_NAME = ".Enterprise";
    [NativeTypeName("#define CERT_PHYSICAL_STORE_AUTH_ROOT_NAME L\".AuthRoot\"")]
    public const string CERT_PHYSICAL_STORE_AUTH_ROOT_NAME = ".AuthRoot";
    [NativeTypeName("#define CERT_PHYSICAL_STORE_SMART_CARD_NAME L\".SmartCard\"")]
    public const string CERT_PHYSICAL_STORE_SMART_CARD_NAME = ".SmartCard";
    [NativeTypeName("#define CERT_VERIFY_INHIBIT_CTL_UPDATE_FLAG 0x1")]
    public const int CERT_VERIFY_INHIBIT_CTL_UPDATE_FLAG = 0x1;
    [NativeTypeName("#define CERT_VERIFY_TRUSTED_SIGNERS_FLAG 0x2")]
    public const int CERT_VERIFY_TRUSTED_SIGNERS_FLAG = 0x2;
    [NativeTypeName("#define CERT_VERIFY_NO_TIME_CHECK_FLAG 0x4")]
    public const int CERT_VERIFY_NO_TIME_CHECK_FLAG = 0x4;
    [NativeTypeName("#define CERT_VERIFY_ALLOW_MORE_USAGE_FLAG 0x8")]
    public const int CERT_VERIFY_ALLOW_MORE_USAGE_FLAG = 0x8;
    [NativeTypeName("#define CERT_VERIFY_UPDATED_CTL_FLAG 0x1")]
    public const int CERT_VERIFY_UPDATED_CTL_FLAG = 0x1;
    [NativeTypeName("#define CERT_CONTEXT_REVOCATION_TYPE 1")]
    public const int CERT_CONTEXT_REVOCATION_TYPE = 1;
    [NativeTypeName("#define CERT_VERIFY_REV_CHAIN_FLAG 0x00000001")]
    public const int CERT_VERIFY_REV_CHAIN_FLAG = 0x00000001;
    [NativeTypeName("#define CERT_VERIFY_CACHE_ONLY_BASED_REVOCATION 0x00000002")]
    public const int CERT_VERIFY_CACHE_ONLY_BASED_REVOCATION = 0x00000002;
    [NativeTypeName("#define CERT_VERIFY_REV_ACCUMULATIVE_TIMEOUT_FLAG 0x00000004")]
    public const int CERT_VERIFY_REV_ACCUMULATIVE_TIMEOUT_FLAG = 0x00000004;
    [NativeTypeName("#define CERT_VERIFY_REV_SERVER_OCSP_FLAG 0x00000008")]
    public const int CERT_VERIFY_REV_SERVER_OCSP_FLAG = 0x00000008;
    [NativeTypeName("#define CERT_VERIFY_REV_NO_OCSP_FAILOVER_TO_CRL_FLAG 0x00000010")]
    public const int CERT_VERIFY_REV_NO_OCSP_FAILOVER_TO_CRL_FLAG = 0x00000010;
    [NativeTypeName("#define CERT_VERIFY_REV_SERVER_OCSP_WIRE_ONLY_FLAG 0x00000020")]
    public const int CERT_VERIFY_REV_SERVER_OCSP_WIRE_ONLY_FLAG = 0x00000020;
    [NativeTypeName("#define CERT_UNICODE_IS_RDN_ATTRS_FLAG 0x1")]
    public const int CERT_UNICODE_IS_RDN_ATTRS_FLAG = 0x1;
    [NativeTypeName("#define CERT_CASE_INSENSITIVE_IS_RDN_ATTRS_FLAG 0x2")]
    public const int CERT_CASE_INSENSITIVE_IS_RDN_ATTRS_FLAG = 0x2;
    [NativeTypeName("#define CERT_SIMPLE_NAME_STR 1")]
    public const int CERT_SIMPLE_NAME_STR = 1;
    [NativeTypeName("#define CERT_OID_NAME_STR 2")]
    public const int CERT_OID_NAME_STR = 2;
    [NativeTypeName("#define CERT_X500_NAME_STR 3")]
    public const int CERT_X500_NAME_STR = 3;
    [NativeTypeName("#define CERT_XML_NAME_STR 4")]
    public const int CERT_XML_NAME_STR = 4;
    [NativeTypeName("#define CERT_NAME_STR_SEMICOLON_FLAG 0x40000000")]
    public const int CERT_NAME_STR_SEMICOLON_FLAG = 0x40000000;
    [NativeTypeName("#define CERT_NAME_STR_NO_PLUS_FLAG 0x20000000")]
    public const int CERT_NAME_STR_NO_PLUS_FLAG = 0x20000000;
    [NativeTypeName("#define CERT_NAME_STR_NO_QUOTING_FLAG 0x10000000")]
    public const int CERT_NAME_STR_NO_QUOTING_FLAG = 0x10000000;
    [NativeTypeName("#define CERT_NAME_STR_CRLF_FLAG 0x08000000")]
    public const int CERT_NAME_STR_CRLF_FLAG = 0x08000000;
    [NativeTypeName("#define CERT_NAME_STR_COMMA_FLAG 0x04000000")]
    public const int CERT_NAME_STR_COMMA_FLAG = 0x04000000;
    [NativeTypeName("#define CERT_NAME_STR_REVERSE_FLAG 0x02000000")]
    public const int CERT_NAME_STR_REVERSE_FLAG = 0x02000000;
    [NativeTypeName("#define CERT_NAME_STR_FORWARD_FLAG 0x01000000")]
    public const int CERT_NAME_STR_FORWARD_FLAG = 0x01000000;
    [NativeTypeName("#define CERT_NAME_STR_DISABLE_IE4_UTF8_FLAG 0x00010000")]
    public const int CERT_NAME_STR_DISABLE_IE4_UTF8_FLAG = 0x00010000;
    [NativeTypeName("#define CERT_NAME_STR_ENABLE_T61_UNICODE_FLAG 0x00020000")]
    public const int CERT_NAME_STR_ENABLE_T61_UNICODE_FLAG = 0x00020000;
    [NativeTypeName("#define CERT_NAME_STR_ENABLE_UTF8_UNICODE_FLAG 0x00040000")]
    public const int CERT_NAME_STR_ENABLE_UTF8_UNICODE_FLAG = 0x00040000;
    [NativeTypeName("#define CERT_NAME_STR_FORCE_UTF8_DIR_STR_FLAG 0x00080000")]
    public const int CERT_NAME_STR_FORCE_UTF8_DIR_STR_FLAG = 0x00080000;
    [NativeTypeName("#define CERT_NAME_STR_DISABLE_UTF8_DIR_STR_FLAG 0x00100000")]
    public const int CERT_NAME_STR_DISABLE_UTF8_DIR_STR_FLAG = 0x00100000;
    [NativeTypeName("#define CERT_NAME_STR_ENABLE_PUNYCODE_FLAG 0x00200000")]
    public const int CERT_NAME_STR_ENABLE_PUNYCODE_FLAG = 0x00200000;
    [NativeTypeName("#define CERT_NAME_EMAIL_TYPE 1")]
    public const int CERT_NAME_EMAIL_TYPE = 1;
    [NativeTypeName("#define CERT_NAME_RDN_TYPE 2")]
    public const int CERT_NAME_RDN_TYPE = 2;
    [NativeTypeName("#define CERT_NAME_ATTR_TYPE 3")]
    public const int CERT_NAME_ATTR_TYPE = 3;
    [NativeTypeName("#define CERT_NAME_SIMPLE_DISPLAY_TYPE 4")]
    public const int CERT_NAME_SIMPLE_DISPLAY_TYPE = 4;
    [NativeTypeName("#define CERT_NAME_FRIENDLY_DISPLAY_TYPE 5")]
    public const int CERT_NAME_FRIENDLY_DISPLAY_TYPE = 5;
    [NativeTypeName("#define CERT_NAME_DNS_TYPE 6")]
    public const int CERT_NAME_DNS_TYPE = 6;
    [NativeTypeName("#define CERT_NAME_URL_TYPE 7")]
    public const int CERT_NAME_URL_TYPE = 7;
    [NativeTypeName("#define CERT_NAME_UPN_TYPE 8")]
    public const int CERT_NAME_UPN_TYPE = 8;
    [NativeTypeName("#define CERT_NAME_ISSUER_FLAG 0x1")]
    public const int CERT_NAME_ISSUER_FLAG = 0x1;
    [NativeTypeName("#define CERT_NAME_DISABLE_IE4_UTF8_FLAG 0x00010000")]
    public const int CERT_NAME_DISABLE_IE4_UTF8_FLAG = 0x00010000;
    [NativeTypeName("#define CERT_NAME_SEARCH_ALL_NAMES_FLAG 0x2")]
    public const int CERT_NAME_SEARCH_ALL_NAMES_FLAG = 0x2;
    [NativeTypeName("#define CERT_QUERY_OBJECT_FILE 0x00000001")]
    public const int CERT_QUERY_OBJECT_FILE = 0x00000001;
    [NativeTypeName("#define CERT_QUERY_OBJECT_BLOB 0x00000002")]
    public const int CERT_QUERY_OBJECT_BLOB = 0x00000002;
    [NativeTypeName("#define CERT_QUERY_CONTENT_CERT 1")]
    public const int CERT_QUERY_CONTENT_CERT = 1;
    [NativeTypeName("#define CERT_QUERY_CONTENT_CTL 2")]
    public const int CERT_QUERY_CONTENT_CTL = 2;
    [NativeTypeName("#define CERT_QUERY_CONTENT_CRL 3")]
    public const int CERT_QUERY_CONTENT_CRL = 3;
    [NativeTypeName("#define CERT_QUERY_CONTENT_SERIALIZED_STORE 4")]
    public const int CERT_QUERY_CONTENT_SERIALIZED_STORE = 4;
    [NativeTypeName("#define CERT_QUERY_CONTENT_SERIALIZED_CERT 5")]
    public const int CERT_QUERY_CONTENT_SERIALIZED_CERT = 5;
    [NativeTypeName("#define CERT_QUERY_CONTENT_SERIALIZED_CTL 6")]
    public const int CERT_QUERY_CONTENT_SERIALIZED_CTL = 6;
    [NativeTypeName("#define CERT_QUERY_CONTENT_SERIALIZED_CRL 7")]
    public const int CERT_QUERY_CONTENT_SERIALIZED_CRL = 7;
    [NativeTypeName("#define CERT_QUERY_CONTENT_PKCS7_SIGNED 8")]
    public const int CERT_QUERY_CONTENT_PKCS7_SIGNED = 8;
    [NativeTypeName("#define CERT_QUERY_CONTENT_PKCS7_UNSIGNED 9")]
    public const int CERT_QUERY_CONTENT_PKCS7_UNSIGNED = 9;
    [NativeTypeName("#define CERT_QUERY_CONTENT_PKCS7_SIGNED_EMBED 10")]
    public const int CERT_QUERY_CONTENT_PKCS7_SIGNED_EMBED = 10;
    [NativeTypeName("#define CERT_QUERY_CONTENT_PKCS10 11")]
    public const int CERT_QUERY_CONTENT_PKCS10 = 11;
    [NativeTypeName("#define CERT_QUERY_CONTENT_PFX 12")]
    public const int CERT_QUERY_CONTENT_PFX = 12;
    [NativeTypeName("#define CERT_QUERY_CONTENT_CERT_PAIR 13")]
    public const int CERT_QUERY_CONTENT_CERT_PAIR = 13;
    [NativeTypeName("#define CERT_QUERY_CONTENT_PFX_AND_LOAD 14")]
    public const int CERT_QUERY_CONTENT_PFX_AND_LOAD = 14;
    [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_CERT ( 1 << CERT_QUERY_CONTENT_CERT)")]
    public const int CERT_QUERY_CONTENT_FLAG_CERT = (1 << 1);
    [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_CTL ( 1 << CERT_QUERY_CONTENT_CTL)")]
    public const int CERT_QUERY_CONTENT_FLAG_CTL = (1 << 2);
    [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_CRL ( 1 << CERT_QUERY_CONTENT_CRL)")]
    public const int CERT_QUERY_CONTENT_FLAG_CRL = (1 << 3);
    [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE ( 1 << CERT_QUERY_CONTENT_SERIALIZED_STORE)")]
    public const int CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE = (1 << 4);
    [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT ( 1 << CERT_QUERY_CONTENT_SERIALIZED_CERT)")]
    public const int CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT = (1 << 5);
    [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_SERIALIZED_CTL ( 1 << CERT_QUERY_CONTENT_SERIALIZED_CTL)")]
    public const int CERT_QUERY_CONTENT_FLAG_SERIALIZED_CTL = (1 << 6);
    [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_SERIALIZED_CRL ( 1 << CERT_QUERY_CONTENT_SERIALIZED_CRL)")]
    public const int CERT_QUERY_CONTENT_FLAG_SERIALIZED_CRL = (1 << 7);
    [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED ( 1 << CERT_QUERY_CONTENT_PKCS7_SIGNED)")]
    public const int CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED = (1 << 8);
    [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED ( 1 << CERT_QUERY_CONTENT_PKCS7_UNSIGNED)")]
    public const int CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED = (1 << 9);
    [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED_EMBED ( 1 << CERT_QUERY_CONTENT_PKCS7_SIGNED_EMBED)")]
    public const int CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED_EMBED = (1 << 10);
    [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_PKCS10 ( 1 << CERT_QUERY_CONTENT_PKCS10)")]
    public const int CERT_QUERY_CONTENT_FLAG_PKCS10 = (1 << 11);
    [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_PFX ( 1 << CERT_QUERY_CONTENT_PFX)")]
    public const int CERT_QUERY_CONTENT_FLAG_PFX = (1 << 12);
    [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_CERT_PAIR ( 1 << CERT_QUERY_CONTENT_CERT_PAIR)")]
    public const int CERT_QUERY_CONTENT_FLAG_CERT_PAIR = (1 << 13);
    [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_PFX_AND_LOAD ( 1 << CERT_QUERY_CONTENT_PFX_AND_LOAD)")]
    public const int CERT_QUERY_CONTENT_FLAG_PFX_AND_LOAD = (1 << 14);
    [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_ALL ( CERT_QUERY_CONTENT_FLAG_CERT |                  \\\r\n                CERT_QUERY_CONTENT_FLAG_CTL  |                  \\\r\n                CERT_QUERY_CONTENT_FLAG_CRL  |                  \\\r\n                CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE |      \\\r\n                CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT  |      \\\r\n                CERT_QUERY_CONTENT_FLAG_SERIALIZED_CTL   |      \\\r\n                CERT_QUERY_CONTENT_FLAG_SERIALIZED_CRL   |      \\\r\n                CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED     |      \\\r\n                CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED   |      \\\r\n                CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED_EMBED |    \\\r\n                CERT_QUERY_CONTENT_FLAG_PKCS10                     |    \\\r\n                CERT_QUERY_CONTENT_FLAG_PFX                |    \\\r\n                CERT_QUERY_CONTENT_FLAG_CERT_PAIR )")]
    public const int CERT_QUERY_CONTENT_FLAG_ALL = ((1 << 1) | (1 << 2) | (1 << 3) | (1 << 4) | (1 << 5) | (1 << 6) | (1 << 7) | (1 << 8) | (1 << 9) | (1 << 10) | (1 << 11) | (1 << 12) | (1 << 13));
    [NativeTypeName("#define CERT_QUERY_CONTENT_FLAG_ALL_ISSUER_CERT ( CERT_QUERY_CONTENT_FLAG_CERT             |      \\\r\n                CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE |      \\\r\n                CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT  |      \\\r\n                CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED     |      \\\r\n                CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED   )")]
    public const int CERT_QUERY_CONTENT_FLAG_ALL_ISSUER_CERT = ((1 << 1) | (1 << 4) | (1 << 5) | (1 << 8) | (1 << 9));
    [NativeTypeName("#define CERT_QUERY_FORMAT_BINARY 1")]
    public const int CERT_QUERY_FORMAT_BINARY = 1;
    [NativeTypeName("#define CERT_QUERY_FORMAT_BASE64_ENCODED 2")]
    public const int CERT_QUERY_FORMAT_BASE64_ENCODED = 2;
    [NativeTypeName("#define CERT_QUERY_FORMAT_ASN_ASCII_HEX_ENCODED 3")]
    public const int CERT_QUERY_FORMAT_ASN_ASCII_HEX_ENCODED = 3;
    [NativeTypeName("#define CERT_QUERY_FORMAT_FLAG_BINARY ( 1 << CERT_QUERY_FORMAT_BINARY)")]
    public const int CERT_QUERY_FORMAT_FLAG_BINARY = (1 << 1);
    [NativeTypeName("#define CERT_QUERY_FORMAT_FLAG_BASE64_ENCODED ( 1 << CERT_QUERY_FORMAT_BASE64_ENCODED)")]
    public const int CERT_QUERY_FORMAT_FLAG_BASE64_ENCODED = (1 << 2);
    [NativeTypeName("#define CERT_QUERY_FORMAT_FLAG_ASN_ASCII_HEX_ENCODED ( 1 << CERT_QUERY_FORMAT_ASN_ASCII_HEX_ENCODED)")]
    public const int CERT_QUERY_FORMAT_FLAG_ASN_ASCII_HEX_ENCODED = (1 << 3);
    [NativeTypeName("#define CERT_QUERY_FORMAT_FLAG_ALL ( CERT_QUERY_FORMAT_FLAG_BINARY   |       \\\r\n            CERT_QUERY_FORMAT_FLAG_BASE64_ENCODED | \\\r\n            CERT_QUERY_FORMAT_FLAG_ASN_ASCII_HEX_ENCODED )")]
    public const int CERT_QUERY_FORMAT_FLAG_ALL = ((1 << 1) | (1 << 2) | (1 << 3));
    [NativeTypeName("#define CERT_CREATE_SELFSIGN_NO_SIGN 1")]
    public const int CERT_CREATE_SELFSIGN_NO_SIGN = 1;
    [NativeTypeName("#define CERT_CREATE_SELFSIGN_NO_KEY_INFO 2")]
    public const int CERT_CREATE_SELFSIGN_NO_KEY_INFO = 2;
    [NativeTypeName("#define CERT_CHAIN_CONFIG_REGPATH L\"Software\\\\Microsoft\\\\Cryptography\\\\OID\\\\EncodingType 0\\\\CertDllCreateCertificateChainEngine\\\\Config\"")]
    public const string CERT_CHAIN_CONFIG_REGPATH = "Software\\Microsoft\\Cryptography\\OID\\EncodingType 0\\CertDllCreateCertificateChainEngine\\Config";
    [NativeTypeName("#define CERT_CHAIN_MAX_URL_RETRIEVAL_BYTE_COUNT_VALUE_NAME L\"MaxUrlRetrievalByteCount\"")]
    public const string CERT_CHAIN_MAX_URL_RETRIEVAL_BYTE_COUNT_VALUE_NAME = "MaxUrlRetrievalByteCount";
    [NativeTypeName("#define CERT_CHAIN_MAX_URL_RETRIEVAL_BYTE_COUNT_DEFAULT (100*1024*1024)")]
    public const int CERT_CHAIN_MAX_URL_RETRIEVAL_BYTE_COUNT_DEFAULT = (100 * 1024 * 1024);
    [NativeTypeName("#define CERT_CHAIN_CACHE_RESYNC_FILETIME_VALUE_NAME L\"ChainCacheResyncFiletime\"")]
    public const string CERT_CHAIN_CACHE_RESYNC_FILETIME_VALUE_NAME = "ChainCacheResyncFiletime";
    [NativeTypeName("#define CERT_CHAIN_DISABLE_MANDATORY_BASIC_CONSTRAINTS_VALUE_NAME L\"DisableMandatoryBasicConstraints\"")]
    public const string CERT_CHAIN_DISABLE_MANDATORY_BASIC_CONSTRAINTS_VALUE_NAME = "DisableMandatoryBasicConstraints";
    [NativeTypeName("#define CERT_CHAIN_DISABLE_CA_NAME_CONSTRAINTS_VALUE_NAME L\"DisableCANameConstraints\"")]
    public const string CERT_CHAIN_DISABLE_CA_NAME_CONSTRAINTS_VALUE_NAME = "DisableCANameConstraints";
    [NativeTypeName("#define CERT_CHAIN_DISABLE_UNSUPPORTED_CRITICAL_EXTENSIONS_VALUE_NAME L\"DisableUnsupportedCriticalExtensions\"")]
    public const string CERT_CHAIN_DISABLE_UNSUPPORTED_CRITICAL_EXTENSIONS_VALUE_NAME = "DisableUnsupportedCriticalExtensions";
    [NativeTypeName("#define CERT_CHAIN_MAX_AIA_URL_COUNT_IN_CERT_VALUE_NAME L\"MaxAIAUrlCountInCert\"")]
    public const string CERT_CHAIN_MAX_AIA_URL_COUNT_IN_CERT_VALUE_NAME = "MaxAIAUrlCountInCert";
    [NativeTypeName("#define CERT_CHAIN_MAX_AIA_URL_COUNT_IN_CERT_DEFAULT 5")]
    public const int CERT_CHAIN_MAX_AIA_URL_COUNT_IN_CERT_DEFAULT = 5;
    [NativeTypeName("#define CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_COUNT_PER_CHAIN_VALUE_NAME L\"MaxAIAUrlRetrievalCountPerChain\"")]
    public const string CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_COUNT_PER_CHAIN_VALUE_NAME = "MaxAIAUrlRetrievalCountPerChain";
    [NativeTypeName("#define CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_COUNT_PER_CHAIN_DEFAULT 3")]
    public const int CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_COUNT_PER_CHAIN_DEFAULT = 3;
    [NativeTypeName("#define CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_BYTE_COUNT_VALUE_NAME L\"MaxAIAUrlRetrievalByteCount\"")]
    public const string CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_BYTE_COUNT_VALUE_NAME = "MaxAIAUrlRetrievalByteCount";
    [NativeTypeName("#define CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_BYTE_COUNT_DEFAULT 100000")]
    public const int CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_BYTE_COUNT_DEFAULT = 100000;
    [NativeTypeName("#define CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_CERT_COUNT_VALUE_NAME L\"MaxAIAUrlRetrievalCertCount\"")]
    public const string CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_CERT_COUNT_VALUE_NAME = "MaxAIAUrlRetrievalCertCount";
    [NativeTypeName("#define CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_CERT_COUNT_DEFAULT 10")]
    public const int CERT_CHAIN_MAX_AIA_URL_RETRIEVAL_CERT_COUNT_DEFAULT = 10;
    [NativeTypeName("#define CERT_CHAIN_OCSP_VALIDITY_SECONDS_VALUE_NAME L\"OcspValiditySeconds\"")]
    public const string CERT_CHAIN_OCSP_VALIDITY_SECONDS_VALUE_NAME = "OcspValiditySeconds";
    [NativeTypeName("#define CERT_CHAIN_OCSP_VALIDITY_SECONDS_DEFAULT (12 * 60 * 60)")]
    public const int CERT_CHAIN_OCSP_VALIDITY_SECONDS_DEFAULT = (12 * 60 * 60);
    [NativeTypeName("#define CERT_CHAIN_DISABLE_SERIAL_CHAIN_VALUE_NAME L\"DisableSerialChain\"")]
    public const string CERT_CHAIN_DISABLE_SERIAL_CHAIN_VALUE_NAME = "DisableSerialChain";
    [NativeTypeName("#define CERT_CHAIN_SERIAL_CHAIN_LOG_FILE_NAME_VALUE_NAME L\"SerialChainLogFileName\"")]
    public const string CERT_CHAIN_SERIAL_CHAIN_LOG_FILE_NAME_VALUE_NAME = "SerialChainLogFileName";
    [NativeTypeName("#define CERT_CHAIN_DISABLE_SYNC_WITH_SSL_TIME_VALUE_NAME L\"DisableSyncWithSslTime\"")]
    public const string CERT_CHAIN_DISABLE_SYNC_WITH_SSL_TIME_VALUE_NAME = "DisableSyncWithSslTime";
    [NativeTypeName("#define CERT_CHAIN_MAX_SSL_TIME_UPDATED_EVENT_COUNT_VALUE_NAME L\"MaxSslTimeUpdatedEventCount\"")]
    public const string CERT_CHAIN_MAX_SSL_TIME_UPDATED_EVENT_COUNT_VALUE_NAME = "MaxSslTimeUpdatedEventCount";
    [NativeTypeName("#define CERT_CHAIN_MAX_SSL_TIME_UPDATED_EVENT_COUNT_DEFAULT 5")]
    public const int CERT_CHAIN_MAX_SSL_TIME_UPDATED_EVENT_COUNT_DEFAULT = 5;
    [NativeTypeName("#define CERT_CHAIN_MAX_SSL_TIME_UPDATED_EVENT_COUNT_DISABLE 0xFFFFFFFF")]
    public const uint CERT_CHAIN_MAX_SSL_TIME_UPDATED_EVENT_COUNT_DISABLE = 0xFFFFFFFF;
    [NativeTypeName("#define CERT_CHAIN_SSL_HANDSHAKE_LOG_FILE_NAME_VALUE_NAME L\"SslHandshakeLogFileName\"")]
    public const string CERT_CHAIN_SSL_HANDSHAKE_LOG_FILE_NAME_VALUE_NAME = "SslHandshakeLogFileName";
    [NativeTypeName("#define CERT_CHAIN_ENABLE_WEAK_SIGNATURE_FLAGS_VALUE_NAME L\"EnableWeakSignatureFlags\"")]
    public const string CERT_CHAIN_ENABLE_WEAK_SIGNATURE_FLAGS_VALUE_NAME = "EnableWeakSignatureFlags";
    [NativeTypeName("#define CERT_CHAIN_ENABLE_MD2_MD4_FLAG 0x00000001")]
    public const int CERT_CHAIN_ENABLE_MD2_MD4_FLAG = 0x00000001;
    [NativeTypeName("#define CERT_CHAIN_ENABLE_WEAK_RSA_ROOT_FLAG 0x00000002")]
    public const int CERT_CHAIN_ENABLE_WEAK_RSA_ROOT_FLAG = 0x00000002;
    [NativeTypeName("#define CERT_CHAIN_ENABLE_WEAK_LOGGING_FLAG 0x00000004")]
    public const int CERT_CHAIN_ENABLE_WEAK_LOGGING_FLAG = 0x00000004;
    [NativeTypeName("#define CERT_CHAIN_ENABLE_ONLY_WEAK_LOGGING_FLAG 0x00000008")]
    public const int CERT_CHAIN_ENABLE_ONLY_WEAK_LOGGING_FLAG = 0x00000008;
    [NativeTypeName("#define CERT_CHAIN_MIN_RSA_PUB_KEY_BIT_LENGTH_VALUE_NAME L\"MinRsaPubKeyBitLength\"")]
    public const string CERT_CHAIN_MIN_RSA_PUB_KEY_BIT_LENGTH_VALUE_NAME = "MinRsaPubKeyBitLength";
    [NativeTypeName("#define CERT_CHAIN_MIN_RSA_PUB_KEY_BIT_LENGTH_DEFAULT 1023")]
    public const int CERT_CHAIN_MIN_RSA_PUB_KEY_BIT_LENGTH_DEFAULT = 1023;
    [NativeTypeName("#define CERT_CHAIN_MIN_RSA_PUB_KEY_BIT_LENGTH_DISABLE 0xFFFFFFFF")]
    public const uint CERT_CHAIN_MIN_RSA_PUB_KEY_BIT_LENGTH_DISABLE = 0xFFFFFFFF;
    [NativeTypeName("#define CERT_CHAIN_WEAK_RSA_PUB_KEY_TIME_VALUE_NAME L\"WeakRsaPubKeyTime\"")]
    public const string CERT_CHAIN_WEAK_RSA_PUB_KEY_TIME_VALUE_NAME = "WeakRsaPubKeyTime";
    [NativeTypeName("#define CERT_CHAIN_WEAK_RSA_PUB_KEY_TIME_DEFAULT 0x01CA8A755C6E0000ui64")]
    public const ulong CERT_CHAIN_WEAK_RSA_PUB_KEY_TIME_DEFAULT = 0x01CA8A755C6E0000UL;
    [NativeTypeName("#define CERT_CHAIN_WEAK_SIGNATURE_LOG_DIR_VALUE_NAME L\"WeakSignatureLogDir\"")]
    public const string CERT_CHAIN_WEAK_SIGNATURE_LOG_DIR_VALUE_NAME = "WeakSignatureLogDir";
    [NativeTypeName("#define CERT_CHAIN_DEFAULT_CONFIG_SUBDIR L\"Default\"")]
    public const string CERT_CHAIN_DEFAULT_CONFIG_SUBDIR = "Default";
    [NativeTypeName("#define CERT_CHAIN_WEAK_PREFIX_NAME L\"Weak\"")]
    public const string CERT_CHAIN_WEAK_PREFIX_NAME = "Weak";
    [NativeTypeName("#define CERT_CHAIN_WEAK_THIRD_PARTY_CONFIG_NAME L\"ThirdParty\"")]
    public const string CERT_CHAIN_WEAK_THIRD_PARTY_CONFIG_NAME = "ThirdParty";
    [NativeTypeName("#define CERT_CHAIN_WEAK_ALL_CONFIG_NAME L\"All\"")]
    public const string CERT_CHAIN_WEAK_ALL_CONFIG_NAME = "All";
    [NativeTypeName("#define CERT_CHAIN_WEAK_FLAGS_NAME L\"Flags\"")]
    public const string CERT_CHAIN_WEAK_FLAGS_NAME = "Flags";
    [NativeTypeName("#define CERT_CHAIN_WEAK_HYGIENE_NAME L\"Hygiene\"")]
    public const string CERT_CHAIN_WEAK_HYGIENE_NAME = "Hygiene";
    [NativeTypeName("#define CERT_CHAIN_WEAK_AFTER_TIME_NAME L\"AfterTime\"")]
    public const string CERT_CHAIN_WEAK_AFTER_TIME_NAME = "AfterTime";
    [NativeTypeName("#define CERT_CHAIN_WEAK_FILE_HASH_AFTER_TIME_NAME L\"FileHashAfterTime\"")]
    public const string CERT_CHAIN_WEAK_FILE_HASH_AFTER_TIME_NAME = "FileHashAfterTime";
    [NativeTypeName("#define CERT_CHAIN_WEAK_TIMESTAMP_HASH_AFTER_TIME_NAME L\"TimestampHashAfterTime\"")]
    public const string CERT_CHAIN_WEAK_TIMESTAMP_HASH_AFTER_TIME_NAME = "TimestampHashAfterTime";
    [NativeTypeName("#define CERT_CHAIN_WEAK_MIN_BIT_LENGTH_NAME L\"MinBitLength\"")]
    public const string CERT_CHAIN_WEAK_MIN_BIT_LENGTH_NAME = "MinBitLength";
    [NativeTypeName("#define CERT_CHAIN_WEAK_SHA256_ALLOW_NAME L\"Sha256Allow\"")]
    public const string CERT_CHAIN_WEAK_SHA256_ALLOW_NAME = "Sha256Allow";
    [NativeTypeName("#define CERT_CHAIN_MIN_PUB_KEY_BIT_LENGTH_DISABLE 0xFFFFFFFF")]
    public const uint CERT_CHAIN_MIN_PUB_KEY_BIT_LENGTH_DISABLE = 0xFFFFFFFF;
    [NativeTypeName("#define CERT_CHAIN_ENABLE_WEAK_SETTINGS_FLAG 0x80000000")]
    public const uint CERT_CHAIN_ENABLE_WEAK_SETTINGS_FLAG = 0x80000000;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_ECC_PARA_FLAG 0x00000010")]
    public const int CERT_CHAIN_DISABLE_ECC_PARA_FLAG = 0x00000010;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_ALL_EKU_WEAK_FLAG 0x00010000")]
    public const int CERT_CHAIN_DISABLE_ALL_EKU_WEAK_FLAG = 0x00010000;
    [NativeTypeName("#define CERT_CHAIN_ENABLE_ALL_EKU_HYGIENE_FLAG 0x00020000")]
    public const int CERT_CHAIN_ENABLE_ALL_EKU_HYGIENE_FLAG = 0x00020000;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_OPT_IN_SERVER_AUTH_WEAK_FLAG 0x00040000")]
    public const int CERT_CHAIN_DISABLE_OPT_IN_SERVER_AUTH_WEAK_FLAG = 0x00040000;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_SERVER_AUTH_WEAK_FLAG 0x00100000")]
    public const int CERT_CHAIN_DISABLE_SERVER_AUTH_WEAK_FLAG = 0x00100000;
    [NativeTypeName("#define CERT_CHAIN_ENABLE_SERVER_AUTH_HYGIENE_FLAG 0x00200000")]
    public const int CERT_CHAIN_ENABLE_SERVER_AUTH_HYGIENE_FLAG = 0x00200000;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_CODE_SIGNING_WEAK_FLAG 0x00400000")]
    public const int CERT_CHAIN_DISABLE_CODE_SIGNING_WEAK_FLAG = 0x00400000;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_MOTW_CODE_SIGNING_WEAK_FLAG 0x00800000")]
    public const int CERT_CHAIN_DISABLE_MOTW_CODE_SIGNING_WEAK_FLAG = 0x00800000;
    [NativeTypeName("#define CERT_CHAIN_ENABLE_CODE_SIGNING_HYGIENE_FLAG 0x01000000")]
    public const int CERT_CHAIN_ENABLE_CODE_SIGNING_HYGIENE_FLAG = 0x01000000;
    [NativeTypeName("#define CERT_CHAIN_ENABLE_MOTW_CODE_SIGNING_HYGIENE_FLAG 0x02000000")]
    public const int CERT_CHAIN_ENABLE_MOTW_CODE_SIGNING_HYGIENE_FLAG = 0x02000000;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_TIMESTAMP_WEAK_FLAG 0x04000000")]
    public const int CERT_CHAIN_DISABLE_TIMESTAMP_WEAK_FLAG = 0x04000000;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_WEAK_FLAG 0x08000000")]
    public const int CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_WEAK_FLAG = 0x08000000;
    [NativeTypeName("#define CERT_CHAIN_ENABLE_TIMESTAMP_HYGIENE_FLAG 0x10000000")]
    public const int CERT_CHAIN_ENABLE_TIMESTAMP_HYGIENE_FLAG = 0x10000000;
    [NativeTypeName("#define CERT_CHAIN_ENABLE_MOTW_TIMESTAMP_HYGIENE_FLAG 0x20000000")]
    public const int CERT_CHAIN_ENABLE_MOTW_TIMESTAMP_HYGIENE_FLAG = 0x20000000;
    [NativeTypeName("#define CERT_CHAIN_MOTW_IGNORE_AFTER_TIME_WEAK_FLAG 0x40000000")]
    public const int CERT_CHAIN_MOTW_IGNORE_AFTER_TIME_WEAK_FLAG = 0x40000000;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_FILE_HASH_WEAK_FLAG 0x00001000")]
    public const int CERT_CHAIN_DISABLE_FILE_HASH_WEAK_FLAG = 0x00001000;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_MOTW_FILE_HASH_WEAK_FLAG 0x00002000")]
    public const int CERT_CHAIN_DISABLE_MOTW_FILE_HASH_WEAK_FLAG = 0x00002000;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_TIMESTAMP_HASH_WEAK_FLAG 0x00004000")]
    public const int CERT_CHAIN_DISABLE_TIMESTAMP_HASH_WEAK_FLAG = 0x00004000;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_HASH_WEAK_FLAG 0x00008000")]
    public const int CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_HASH_WEAK_FLAG = 0x00008000;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_WEAK_FLAGS (                 \\\r\n    CERT_CHAIN_DISABLE_ECC_PARA_FLAG |                  \\\r\n    CERT_CHAIN_DISABLE_ALL_EKU_WEAK_FLAG |              \\\r\n    CERT_CHAIN_DISABLE_SERVER_AUTH_WEAK_FLAG |          \\\r\n    CERT_CHAIN_DISABLE_OPT_IN_SERVER_AUTH_WEAK_FLAG |   \\\r\n    CERT_CHAIN_DISABLE_CODE_SIGNING_WEAK_FLAG |         \\\r\n    CERT_CHAIN_DISABLE_MOTW_CODE_SIGNING_WEAK_FLAG |    \\\r\n    CERT_CHAIN_DISABLE_TIMESTAMP_WEAK_FLAG |            \\\r\n    CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_WEAK_FLAG )")]
    public const int CERT_CHAIN_DISABLE_WEAK_FLAGS = (0x00000010 | 0x00010000 | 0x00100000 | 0x00040000 | 0x00400000 | 0x00800000 | 0x04000000 | 0x08000000);
    [NativeTypeName("#define CERT_CHAIN_DISABLE_FILE_HASH_WEAK_FLAGS (       \\\r\n    CERT_CHAIN_DISABLE_FILE_HASH_WEAK_FLAG |            \\\r\n    CERT_CHAIN_DISABLE_MOTW_FILE_HASH_WEAK_FLAG )")]
    public const int CERT_CHAIN_DISABLE_FILE_HASH_WEAK_FLAGS = (0x00001000 | 0x00002000);
    [NativeTypeName("#define CERT_CHAIN_DISABLE_TIMESTAMP_HASH_WEAK_FLAGS (  \\\r\n    CERT_CHAIN_DISABLE_TIMESTAMP_HASH_WEAK_FLAG |       \\\r\n    CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_HASH_WEAK_FLAG )")]
    public const int CERT_CHAIN_DISABLE_TIMESTAMP_HASH_WEAK_FLAGS = (0x00004000 | 0x00008000);
    [NativeTypeName("#define CERT_CHAIN_ENABLE_HYGIENE_FLAGS (               \\\r\n    CERT_CHAIN_ENABLE_ALL_EKU_HYGIENE_FLAG |            \\\r\n    CERT_CHAIN_ENABLE_SERVER_AUTH_HYGIENE_FLAG |        \\\r\n    CERT_CHAIN_ENABLE_CODE_SIGNING_HYGIENE_FLAG |       \\\r\n    CERT_CHAIN_ENABLE_MOTW_CODE_SIGNING_HYGIENE_FLAG |  \\\r\n    CERT_CHAIN_ENABLE_TIMESTAMP_HYGIENE_FLAG |          \\\r\n    CERT_CHAIN_ENABLE_MOTW_TIMESTAMP_HYGIENE_FLAG )")]
    public const int CERT_CHAIN_ENABLE_HYGIENE_FLAGS = (0x00020000 | 0x00200000 | 0x01000000 | 0x02000000 | 0x10000000 | 0x20000000);
    [NativeTypeName("#define CERT_CHAIN_MOTW_WEAK_FLAGS (                    \\\r\n    CERT_CHAIN_DISABLE_MOTW_CODE_SIGNING_WEAK_FLAG |    \\\r\n    CERT_CHAIN_DISABLE_MOTW_TIMESTAMP_WEAK_FLAG |       \\\r\n    CERT_CHAIN_ENABLE_MOTW_CODE_SIGNING_HYGIENE_FLAG |  \\\r\n    CERT_CHAIN_ENABLE_MOTW_TIMESTAMP_HYGIENE_FLAG |     \\\r\n    CERT_CHAIN_MOTW_IGNORE_AFTER_TIME_WEAK_FLAG)")]
    public const int CERT_CHAIN_MOTW_WEAK_FLAGS = (0x00800000 | 0x08000000 | 0x02000000 | 0x20000000 | 0x40000000);
    [NativeTypeName("#define CERT_CHAIN_OPT_IN_WEAK_FLAGS (                  \\\r\n    CERT_CHAIN_DISABLE_OPT_IN_SERVER_AUTH_WEAK_FLAG)")]
    public const int CERT_CHAIN_OPT_IN_WEAK_FLAGS = (0x00040000);
    [NativeTypeName("#define CERT_CHAIN_AUTO_CURRENT_USER 1")]
    public const int CERT_CHAIN_AUTO_CURRENT_USER = 1;
    [NativeTypeName("#define CERT_CHAIN_AUTO_LOCAL_MACHINE 2")]
    public const int CERT_CHAIN_AUTO_LOCAL_MACHINE = 2;
    [NativeTypeName("#define CERT_CHAIN_AUTO_IMPERSONATED 3")]
    public const int CERT_CHAIN_AUTO_IMPERSONATED = 3;
    [NativeTypeName("#define CERT_CHAIN_AUTO_PROCESS_INFO 4")]
    public const int CERT_CHAIN_AUTO_PROCESS_INFO = 4;
    [NativeTypeName("#define CERT_CHAIN_AUTO_PINRULE_INFO 5")]
    public const int CERT_CHAIN_AUTO_PINRULE_INFO = 5;
    [NativeTypeName("#define CERT_CHAIN_AUTO_NETWORK_INFO 6")]
    public const int CERT_CHAIN_AUTO_NETWORK_INFO = 6;
    [NativeTypeName("#define CERT_CHAIN_AUTO_SERIAL_LOCAL_MACHINE 7")]
    public const int CERT_CHAIN_AUTO_SERIAL_LOCAL_MACHINE = 7;
    [NativeTypeName("#define CERT_CHAIN_AUTO_HPKP_RULE_INFO 8")]
    public const int CERT_CHAIN_AUTO_HPKP_RULE_INFO = 8;
    [NativeTypeName("#define CERT_CHAIN_AUTO_FLAGS_VALUE_NAME L\"AutoFlags\"")]
    public const string CERT_CHAIN_AUTO_FLAGS_VALUE_NAME = "AutoFlags";
    [NativeTypeName("#define CERT_CHAIN_AUTO_FLUSH_DISABLE_FLAG 0x00000001")]
    public const int CERT_CHAIN_AUTO_FLUSH_DISABLE_FLAG = 0x00000001;
    [NativeTypeName("#define CERT_CHAIN_AUTO_LOG_CREATE_FLAG 0x00000002")]
    public const int CERT_CHAIN_AUTO_LOG_CREATE_FLAG = 0x00000002;
    [NativeTypeName("#define CERT_CHAIN_AUTO_LOG_FREE_FLAG 0x00000004")]
    public const int CERT_CHAIN_AUTO_LOG_FREE_FLAG = 0x00000004;
    [NativeTypeName("#define CERT_CHAIN_AUTO_LOG_FLUSH_FLAG 0x00000008")]
    public const int CERT_CHAIN_AUTO_LOG_FLUSH_FLAG = 0x00000008;
    [NativeTypeName("#define CERT_CHAIN_AUTO_LOG_FLAGS (         \\\r\n    CERT_CHAIN_AUTO_LOG_CREATE_FLAG |       \\\r\n    CERT_CHAIN_AUTO_LOG_FREE_FLAG |         \\\r\n    CERT_CHAIN_AUTO_LOG_FLUSH_FLAG )")]
    public const int CERT_CHAIN_AUTO_LOG_FLAGS = (0x00000002 | 0x00000004 | 0x00000008);
    [NativeTypeName("#define CERT_CHAIN_AUTO_FLUSH_FIRST_DELTA_SECONDS_VALUE_NAME L\"AutoFlushFirstDeltaSeconds\"")]
    public const string CERT_CHAIN_AUTO_FLUSH_FIRST_DELTA_SECONDS_VALUE_NAME = "AutoFlushFirstDeltaSeconds";
    [NativeTypeName("#define CERT_CHAIN_AUTO_FLUSH_FIRST_DELTA_SECONDS_DEFAULT (5 * 60)")]
    public const int CERT_CHAIN_AUTO_FLUSH_FIRST_DELTA_SECONDS_DEFAULT = (5 * 60);
    [NativeTypeName("#define CERT_CHAIN_AUTO_FLUSH_NEXT_DELTA_SECONDS_VALUE_NAME L\"AutoFlushNextDeltaSeconds\"")]
    public const string CERT_CHAIN_AUTO_FLUSH_NEXT_DELTA_SECONDS_VALUE_NAME = "AutoFlushNextDeltaSeconds";
    [NativeTypeName("#define CERT_CHAIN_AUTO_FLUSH_NEXT_DELTA_SECONDS_DEFAULT (30 * 60)")]
    public const int CERT_CHAIN_AUTO_FLUSH_NEXT_DELTA_SECONDS_DEFAULT = (30 * 60);
    [NativeTypeName("#define CERT_CHAIN_AUTO_LOG_FILE_NAME_VALUE_NAME L\"AutoLogFileName\"")]
    public const string CERT_CHAIN_AUTO_LOG_FILE_NAME_VALUE_NAME = "AutoLogFileName";
    [NativeTypeName("#define CERT_CHAIN_DISABLE_AUTO_FLUSH_PROCESS_NAME_LIST_VALUE_NAME L\"DisableAutoFlushProcessNameList\"")]
    public const string CERT_CHAIN_DISABLE_AUTO_FLUSH_PROCESS_NAME_LIST_VALUE_NAME = "DisableAutoFlushProcessNameList";
    [NativeTypeName("#define CERT_SRV_OCSP_RESP_MIN_VALIDITY_SECONDS_VALUE_NAME L\"SrvOcspRespMinValiditySeconds\"")]
    public const string CERT_SRV_OCSP_RESP_MIN_VALIDITY_SECONDS_VALUE_NAME = "SrvOcspRespMinValiditySeconds";
    [NativeTypeName("#define CERT_SRV_OCSP_RESP_MIN_VALIDITY_SECONDS_DEFAULT (10 * 60)")]
    public const int CERT_SRV_OCSP_RESP_MIN_VALIDITY_SECONDS_DEFAULT = (10 * 60);
    [NativeTypeName("#define CERT_SRV_OCSP_RESP_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_VALUE_NAME L\"SrvOcspRespUrlRetrievalTimeoutMilliseconds\"")]
    public const string CERT_SRV_OCSP_RESP_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_VALUE_NAME = "SrvOcspRespUrlRetrievalTimeoutMilliseconds";
    [NativeTypeName("#define CERT_SRV_OCSP_RESP_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_DEFAULT (15 * 1000)")]
    public const int CERT_SRV_OCSP_RESP_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_DEFAULT = (15 * 1000);
    [NativeTypeName("#define CERT_SRV_OCSP_RESP_MAX_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME L\"SrvOcspRespMaxBeforeNextUpdateSeconds\"")]
    public const string CERT_SRV_OCSP_RESP_MAX_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME = "SrvOcspRespMaxBeforeNextUpdateSeconds";
    [NativeTypeName("#define CERT_SRV_OCSP_RESP_MAX_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT (4 * 60 * 60)")]
    public const int CERT_SRV_OCSP_RESP_MAX_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT = (4 * 60 * 60);
    [NativeTypeName("#define CERT_SRV_OCSP_RESP_MIN_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME L\"SrvOcspRespMinBeforeNextUpdateSeconds\"")]
    public const string CERT_SRV_OCSP_RESP_MIN_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME = "SrvOcspRespMinBeforeNextUpdateSeconds";
    [NativeTypeName("#define CERT_SRV_OCSP_RESP_MIN_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT (2 * 60)")]
    public const int CERT_SRV_OCSP_RESP_MIN_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT = (2 * 60);
    [NativeTypeName("#define CERT_SRV_OCSP_RESP_MIN_AFTER_NEXT_UPDATE_SECONDS_VALUE_NAME L\"SrvOcspRespMinAfterNextUpdateSeconds\"")]
    public const string CERT_SRV_OCSP_RESP_MIN_AFTER_NEXT_UPDATE_SECONDS_VALUE_NAME = "SrvOcspRespMinAfterNextUpdateSeconds";
    [NativeTypeName("#define CERT_SRV_OCSP_RESP_MIN_AFTER_NEXT_UPDATE_SECONDS_DEFAULT (1 * 60)")]
    public const int CERT_SRV_OCSP_RESP_MIN_AFTER_NEXT_UPDATE_SECONDS_DEFAULT = (1 * 60);
    [NativeTypeName("#define CERT_SRV_OCSP_RESP_MIN_SYNC_CERT_FILE_SECONDS_VALUE_NAME L\"SrvOcspRespMinSyncCertFileSeconds\"")]
    public const string CERT_SRV_OCSP_RESP_MIN_SYNC_CERT_FILE_SECONDS_VALUE_NAME = "SrvOcspRespMinSyncCertFileSeconds";
    [NativeTypeName("#define CERT_SRV_OCSP_RESP_MIN_SYNC_CERT_FILE_SECONDS_DEFAULT 5")]
    public const int CERT_SRV_OCSP_RESP_MIN_SYNC_CERT_FILE_SECONDS_DEFAULT = 5;
    [NativeTypeName("#define CERT_SRV_OCSP_RESP_MAX_SYNC_CERT_FILE_SECONDS_VALUE_NAME L\"SrvOcspRespMaxSyncCertFileSeconds\"")]
    public const string CERT_SRV_OCSP_RESP_MAX_SYNC_CERT_FILE_SECONDS_VALUE_NAME = "SrvOcspRespMaxSyncCertFileSeconds";
    [NativeTypeName("#define CERT_SRV_OCSP_RESP_MAX_SYNC_CERT_FILE_SECONDS_DEFAULT (1 * 60 * 60)")]
    public const int CERT_SRV_OCSP_RESP_MAX_SYNC_CERT_FILE_SECONDS_DEFAULT = (1 * 60 * 60);
    [NativeTypeName("#define CERT_GROUP_POLICY_CHAIN_CONFIG_REGPATH CERT_GROUP_POLICY_SYSTEM_STORE_REGPATH L\"\\\\ChainEngine\\\\Config\"")]
    public const string CERT_GROUP_POLICY_CHAIN_CONFIG_REGPATH = "Software\\Policies\\Microsoft\\SystemCertificates\\ChainEngine\\Config";
    [NativeTypeName("#define CERT_CHAIN_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_VALUE_NAME L\"ChainUrlRetrievalTimeoutMilliseconds\"")]
    public const string CERT_CHAIN_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_VALUE_NAME = "ChainUrlRetrievalTimeoutMilliseconds";
    [NativeTypeName("#define CERT_CHAIN_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_DEFAULT (15 * 1000)")]
    public const int CERT_CHAIN_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_DEFAULT = (15 * 1000);
    [NativeTypeName("#define CERT_CHAIN_REV_ACCUMULATIVE_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_VALUE_NAME L\"ChainRevAccumulativeUrlRetrievalTimeoutMilliseconds\"")]
    public const string CERT_CHAIN_REV_ACCUMULATIVE_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_VALUE_NAME = "ChainRevAccumulativeUrlRetrievalTimeoutMilliseconds";
    [NativeTypeName("#define CERT_CHAIN_REV_ACCUMULATIVE_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_DEFAULT (20 * 1000)")]
    public const int CERT_CHAIN_REV_ACCUMULATIVE_URL_RETRIEVAL_TIMEOUT_MILLISECONDS_DEFAULT = (20 * 1000);
    [NativeTypeName("#define CERT_RETR_BEHAVIOR_INET_AUTH_VALUE_NAME L\"EnableInetUnknownAuth\"")]
    public const string CERT_RETR_BEHAVIOR_INET_AUTH_VALUE_NAME = "EnableInetUnknownAuth";
    [NativeTypeName("#define CERT_RETR_BEHAVIOR_INET_STATUS_VALUE_NAME L\"EnableInetLocal\"")]
    public const string CERT_RETR_BEHAVIOR_INET_STATUS_VALUE_NAME = "EnableInetLocal";
    [NativeTypeName("#define CERT_RETR_BEHAVIOR_FILE_VALUE_NAME L\"AllowFileUrlScheme\"")]
    public const string CERT_RETR_BEHAVIOR_FILE_VALUE_NAME = "AllowFileUrlScheme";
    [NativeTypeName("#define CERT_RETR_BEHAVIOR_LDAP_VALUE_NAME L\"DisableLDAPSignAndEncrypt\"")]
    public const string CERT_RETR_BEHAVIOR_LDAP_VALUE_NAME = "DisableLDAPSignAndEncrypt";
    [NativeTypeName("#define CERT_CHAIN_DISABLE_AIA_URL_RETRIEVAL_VALUE_NAME L\"DisableAIAUrlRetrieval\"")]
    public const string CERT_CHAIN_DISABLE_AIA_URL_RETRIEVAL_VALUE_NAME = "DisableAIAUrlRetrieval";
    [NativeTypeName("#define CERT_CHAIN_OPTIONS_VALUE_NAME L\"Options\"")]
    public const string CERT_CHAIN_OPTIONS_VALUE_NAME = "Options";
    [NativeTypeName("#define CERT_CHAIN_OPTION_DISABLE_AIA_URL_RETRIEVAL 0x2")]
    public const int CERT_CHAIN_OPTION_DISABLE_AIA_URL_RETRIEVAL = 0x2;
    [NativeTypeName("#define CERT_CHAIN_OPTION_ENABLE_SIA_URL_RETRIEVAL 0x4")]
    public const int CERT_CHAIN_OPTION_ENABLE_SIA_URL_RETRIEVAL = 0x4;
    [NativeTypeName("#define CERT_CHAIN_CROSS_CERT_DOWNLOAD_INTERVAL_HOURS_VALUE_NAME L\"CrossCertDownloadIntervalHours\"")]
    public const string CERT_CHAIN_CROSS_CERT_DOWNLOAD_INTERVAL_HOURS_VALUE_NAME = "CrossCertDownloadIntervalHours";
    [NativeTypeName("#define CERT_CHAIN_CROSS_CERT_DOWNLOAD_INTERVAL_HOURS_DEFAULT (24 * 7)")]
    public const int CERT_CHAIN_CROSS_CERT_DOWNLOAD_INTERVAL_HOURS_DEFAULT = (24 * 7);
    [NativeTypeName("#define CERT_CHAIN_CRL_VALIDITY_EXT_PERIOD_HOURS_VALUE_NAME L\"CRLValidityExtensionPeriod\"")]
    public const string CERT_CHAIN_CRL_VALIDITY_EXT_PERIOD_HOURS_VALUE_NAME = "CRLValidityExtensionPeriod";
    [NativeTypeName("#define CERT_CHAIN_CRL_VALIDITY_EXT_PERIOD_HOURS_DEFAULT 12")]
    public const int CERT_CHAIN_CRL_VALIDITY_EXT_PERIOD_HOURS_DEFAULT = 12;
    [NativeTypeName("#define CERT_CHAIN_CACHE_END_CERT 0x00000001")]
    public const int CERT_CHAIN_CACHE_END_CERT = 0x00000001;
    [NativeTypeName("#define CERT_CHAIN_THREAD_STORE_SYNC 0x00000002")]
    public const int CERT_CHAIN_THREAD_STORE_SYNC = 0x00000002;
    [NativeTypeName("#define CERT_CHAIN_CACHE_ONLY_URL_RETRIEVAL 0x00000004")]
    public const int CERT_CHAIN_CACHE_ONLY_URL_RETRIEVAL = 0x00000004;
    [NativeTypeName("#define CERT_CHAIN_USE_LOCAL_MACHINE_STORE 0x00000008")]
    public const int CERT_CHAIN_USE_LOCAL_MACHINE_STORE = 0x00000008;
    [NativeTypeName("#define CERT_CHAIN_ENABLE_CACHE_AUTO_UPDATE 0x00000010")]
    public const int CERT_CHAIN_ENABLE_CACHE_AUTO_UPDATE = 0x00000010;
    [NativeTypeName("#define CERT_CHAIN_ENABLE_SHARE_STORE 0x00000020")]
    public const int CERT_CHAIN_ENABLE_SHARE_STORE = 0x00000020;
    [NativeTypeName("#define CERT_CHAIN_EXCLUSIVE_ENABLE_CA_FLAG 0x00000001")]
    public const int CERT_CHAIN_EXCLUSIVE_ENABLE_CA_FLAG = 0x00000001;
    [NativeTypeName("#define CERT_TRUST_NO_ERROR 0x00000000")]
    public const int CERT_TRUST_NO_ERROR = 0x00000000;
    [NativeTypeName("#define CERT_TRUST_IS_NOT_TIME_VALID 0x00000001")]
    public const int CERT_TRUST_IS_NOT_TIME_VALID = 0x00000001;
    [NativeTypeName("#define CERT_TRUST_IS_NOT_TIME_NESTED 0x00000002")]
    public const int CERT_TRUST_IS_NOT_TIME_NESTED = 0x00000002;
    [NativeTypeName("#define CERT_TRUST_IS_REVOKED 0x00000004")]
    public const int CERT_TRUST_IS_REVOKED = 0x00000004;
    [NativeTypeName("#define CERT_TRUST_IS_NOT_SIGNATURE_VALID 0x00000008")]
    public const int CERT_TRUST_IS_NOT_SIGNATURE_VALID = 0x00000008;
    [NativeTypeName("#define CERT_TRUST_IS_NOT_VALID_FOR_USAGE 0x00000010")]
    public const int CERT_TRUST_IS_NOT_VALID_FOR_USAGE = 0x00000010;
    [NativeTypeName("#define CERT_TRUST_IS_UNTRUSTED_ROOT 0x00000020")]
    public const int CERT_TRUST_IS_UNTRUSTED_ROOT = 0x00000020;
    [NativeTypeName("#define CERT_TRUST_REVOCATION_STATUS_UNKNOWN 0x00000040")]
    public const int CERT_TRUST_REVOCATION_STATUS_UNKNOWN = 0x00000040;
    [NativeTypeName("#define CERT_TRUST_IS_CYCLIC 0x00000080")]
    public const int CERT_TRUST_IS_CYCLIC = 0x00000080;
    [NativeTypeName("#define CERT_TRUST_INVALID_EXTENSION 0x00000100")]
    public const int CERT_TRUST_INVALID_EXTENSION = 0x00000100;
    [NativeTypeName("#define CERT_TRUST_INVALID_POLICY_CONSTRAINTS 0x00000200")]
    public const int CERT_TRUST_INVALID_POLICY_CONSTRAINTS = 0x00000200;
    [NativeTypeName("#define CERT_TRUST_INVALID_BASIC_CONSTRAINTS 0x00000400")]
    public const int CERT_TRUST_INVALID_BASIC_CONSTRAINTS = 0x00000400;
    [NativeTypeName("#define CERT_TRUST_INVALID_NAME_CONSTRAINTS 0x00000800")]
    public const int CERT_TRUST_INVALID_NAME_CONSTRAINTS = 0x00000800;
    [NativeTypeName("#define CERT_TRUST_HAS_NOT_SUPPORTED_NAME_CONSTRAINT 0x00001000")]
    public const int CERT_TRUST_HAS_NOT_SUPPORTED_NAME_CONSTRAINT = 0x00001000;
    [NativeTypeName("#define CERT_TRUST_HAS_NOT_DEFINED_NAME_CONSTRAINT 0x00002000")]
    public const int CERT_TRUST_HAS_NOT_DEFINED_NAME_CONSTRAINT = 0x00002000;
    [NativeTypeName("#define CERT_TRUST_HAS_NOT_PERMITTED_NAME_CONSTRAINT 0x00004000")]
    public const int CERT_TRUST_HAS_NOT_PERMITTED_NAME_CONSTRAINT = 0x00004000;
    [NativeTypeName("#define CERT_TRUST_HAS_EXCLUDED_NAME_CONSTRAINT 0x00008000")]
    public const int CERT_TRUST_HAS_EXCLUDED_NAME_CONSTRAINT = 0x00008000;
    [NativeTypeName("#define CERT_TRUST_IS_OFFLINE_REVOCATION 0x01000000")]
    public const int CERT_TRUST_IS_OFFLINE_REVOCATION = 0x01000000;
    [NativeTypeName("#define CERT_TRUST_NO_ISSUANCE_CHAIN_POLICY 0x02000000")]
    public const int CERT_TRUST_NO_ISSUANCE_CHAIN_POLICY = 0x02000000;
    [NativeTypeName("#define CERT_TRUST_IS_EXPLICIT_DISTRUST 0x04000000")]
    public const int CERT_TRUST_IS_EXPLICIT_DISTRUST = 0x04000000;
    [NativeTypeName("#define CERT_TRUST_HAS_NOT_SUPPORTED_CRITICAL_EXT 0x08000000")]
    public const int CERT_TRUST_HAS_NOT_SUPPORTED_CRITICAL_EXT = 0x08000000;
    [NativeTypeName("#define CERT_TRUST_HAS_WEAK_SIGNATURE 0x00100000")]
    public const int CERT_TRUST_HAS_WEAK_SIGNATURE = 0x00100000;
    [NativeTypeName("#define CERT_TRUST_HAS_WEAK_HYGIENE 0x00200000")]
    public const int CERT_TRUST_HAS_WEAK_HYGIENE = 0x00200000;
    [NativeTypeName("#define CERT_TRUST_IS_PARTIAL_CHAIN 0x00010000")]
    public const int CERT_TRUST_IS_PARTIAL_CHAIN = 0x00010000;
    [NativeTypeName("#define CERT_TRUST_CTL_IS_NOT_TIME_VALID 0x00020000")]
    public const int CERT_TRUST_CTL_IS_NOT_TIME_VALID = 0x00020000;
    [NativeTypeName("#define CERT_TRUST_CTL_IS_NOT_SIGNATURE_VALID 0x00040000")]
    public const int CERT_TRUST_CTL_IS_NOT_SIGNATURE_VALID = 0x00040000;
    [NativeTypeName("#define CERT_TRUST_CTL_IS_NOT_VALID_FOR_USAGE 0x00080000")]
    public const int CERT_TRUST_CTL_IS_NOT_VALID_FOR_USAGE = 0x00080000;
    [NativeTypeName("#define CERT_TRUST_HAS_EXACT_MATCH_ISSUER 0x00000001")]
    public const int CERT_TRUST_HAS_EXACT_MATCH_ISSUER = 0x00000001;
    [NativeTypeName("#define CERT_TRUST_HAS_KEY_MATCH_ISSUER 0x00000002")]
    public const int CERT_TRUST_HAS_KEY_MATCH_ISSUER = 0x00000002;
    [NativeTypeName("#define CERT_TRUST_HAS_NAME_MATCH_ISSUER 0x00000004")]
    public const int CERT_TRUST_HAS_NAME_MATCH_ISSUER = 0x00000004;
    [NativeTypeName("#define CERT_TRUST_IS_SELF_SIGNED 0x00000008")]
    public const int CERT_TRUST_IS_SELF_SIGNED = 0x00000008;
    [NativeTypeName("#define CERT_TRUST_AUTO_UPDATE_CA_REVOCATION 0x00000010")]
    public const int CERT_TRUST_AUTO_UPDATE_CA_REVOCATION = 0x00000010;
    [NativeTypeName("#define CERT_TRUST_AUTO_UPDATE_END_REVOCATION 0x00000020")]
    public const int CERT_TRUST_AUTO_UPDATE_END_REVOCATION = 0x00000020;
    [NativeTypeName("#define CERT_TRUST_NO_OCSP_FAILOVER_TO_CRL 0x00000040")]
    public const int CERT_TRUST_NO_OCSP_FAILOVER_TO_CRL = 0x00000040;
    [NativeTypeName("#define CERT_TRUST_IS_KEY_ROLLOVER 0x00000080")]
    public const int CERT_TRUST_IS_KEY_ROLLOVER = 0x00000080;
    [NativeTypeName("#define CERT_TRUST_SSL_HANDSHAKE_OCSP 0x00040000")]
    public const int CERT_TRUST_SSL_HANDSHAKE_OCSP = 0x00040000;
    [NativeTypeName("#define CERT_TRUST_SSL_TIME_VALID_OCSP 0x00080000")]
    public const int CERT_TRUST_SSL_TIME_VALID_OCSP = 0x00080000;
    [NativeTypeName("#define CERT_TRUST_SSL_RECONNECT_OCSP 0x00100000")]
    public const int CERT_TRUST_SSL_RECONNECT_OCSP = 0x00100000;
    [NativeTypeName("#define CERT_TRUST_HAS_PREFERRED_ISSUER 0x00000100")]
    public const int CERT_TRUST_HAS_PREFERRED_ISSUER = 0x00000100;
    [NativeTypeName("#define CERT_TRUST_HAS_ISSUANCE_CHAIN_POLICY 0x00000200")]
    public const int CERT_TRUST_HAS_ISSUANCE_CHAIN_POLICY = 0x00000200;
    [NativeTypeName("#define CERT_TRUST_HAS_VALID_NAME_CONSTRAINTS 0x00000400")]
    public const int CERT_TRUST_HAS_VALID_NAME_CONSTRAINTS = 0x00000400;
    [NativeTypeName("#define CERT_TRUST_IS_PEER_TRUSTED 0x00000800")]
    public const int CERT_TRUST_IS_PEER_TRUSTED = 0x00000800;
    [NativeTypeName("#define CERT_TRUST_HAS_CRL_VALIDITY_EXTENDED 0x00001000")]
    public const int CERT_TRUST_HAS_CRL_VALIDITY_EXTENDED = 0x00001000;
    [NativeTypeName("#define CERT_TRUST_IS_FROM_EXCLUSIVE_TRUST_STORE 0x00002000")]
    public const int CERT_TRUST_IS_FROM_EXCLUSIVE_TRUST_STORE = 0x00002000;
    [NativeTypeName("#define CERT_TRUST_IS_CA_TRUSTED 0x00004000")]
    public const int CERT_TRUST_IS_CA_TRUSTED = 0x00004000;
    [NativeTypeName("#define CERT_TRUST_HAS_AUTO_UPDATE_WEAK_SIGNATURE 0x00008000")]
    public const int CERT_TRUST_HAS_AUTO_UPDATE_WEAK_SIGNATURE = 0x00008000;
    [NativeTypeName("#define CERT_TRUST_HAS_ALLOW_WEAK_SIGNATURE 0x00020000")]
    public const int CERT_TRUST_HAS_ALLOW_WEAK_SIGNATURE = 0x00020000;
    [NativeTypeName("#define CERT_TRUST_BEFORE_DISALLOWED_CA_FILETIME 0x00200000")]
    public const int CERT_TRUST_BEFORE_DISALLOWED_CA_FILETIME = 0x00200000;
    [NativeTypeName("#define CERT_TRUST_IS_COMPLEX_CHAIN 0x00010000")]
    public const int CERT_TRUST_IS_COMPLEX_CHAIN = 0x00010000;
    [NativeTypeName("#define CERT_TRUST_SSL_TIME_VALID 0x01000000")]
    public const int CERT_TRUST_SSL_TIME_VALID = 0x01000000;
    [NativeTypeName("#define CERT_TRUST_NO_TIME_CHECK 0x02000000")]
    public const int CERT_TRUST_NO_TIME_CHECK = 0x02000000;
    [NativeTypeName("#define CERT_CHAIN_STRONG_SIGN_DISABLE_END_CHECK_FLAG 0x00000001")]
    public const int CERT_CHAIN_STRONG_SIGN_DISABLE_END_CHECK_FLAG = 0x00000001;
    [NativeTypeName("#define CERT_CHAIN_REVOCATION_CHECK_END_CERT 0x10000000")]
    public const int CERT_CHAIN_REVOCATION_CHECK_END_CERT = 0x10000000;
    [NativeTypeName("#define CERT_CHAIN_REVOCATION_CHECK_CHAIN 0x20000000")]
    public const int CERT_CHAIN_REVOCATION_CHECK_CHAIN = 0x20000000;
    [NativeTypeName("#define CERT_CHAIN_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT 0x40000000")]
    public const int CERT_CHAIN_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 0x40000000;
    [NativeTypeName("#define CERT_CHAIN_REVOCATION_CHECK_CACHE_ONLY 0x80000000")]
    public const uint CERT_CHAIN_REVOCATION_CHECK_CACHE_ONLY = 0x80000000;
    [NativeTypeName("#define CERT_CHAIN_REVOCATION_ACCUMULATIVE_TIMEOUT 0x08000000")]
    public const int CERT_CHAIN_REVOCATION_ACCUMULATIVE_TIMEOUT = 0x08000000;
    [NativeTypeName("#define CERT_CHAIN_REVOCATION_CHECK_OCSP_CERT 0x04000000")]
    public const int CERT_CHAIN_REVOCATION_CHECK_OCSP_CERT = 0x04000000;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_PASS1_QUALITY_FILTERING 0x00000040")]
    public const int CERT_CHAIN_DISABLE_PASS1_QUALITY_FILTERING = 0x00000040;
    [NativeTypeName("#define CERT_CHAIN_RETURN_LOWER_QUALITY_CONTEXTS 0x00000080")]
    public const int CERT_CHAIN_RETURN_LOWER_QUALITY_CONTEXTS = 0x00000080;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_AUTH_ROOT_AUTO_UPDATE 0x00000100")]
    public const int CERT_CHAIN_DISABLE_AUTH_ROOT_AUTO_UPDATE = 0x00000100;
    [NativeTypeName("#define CERT_CHAIN_TIMESTAMP_TIME 0x00000200")]
    public const int CERT_CHAIN_TIMESTAMP_TIME = 0x00000200;
    [NativeTypeName("#define CERT_CHAIN_ENABLE_PEER_TRUST 0x00000400")]
    public const int CERT_CHAIN_ENABLE_PEER_TRUST = 0x00000400;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_MY_PEER_TRUST 0x00000800")]
    public const int CERT_CHAIN_DISABLE_MY_PEER_TRUST = 0x00000800;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_MD2_MD4 0x00001000")]
    public const int CERT_CHAIN_DISABLE_MD2_MD4 = 0x00001000;
    [NativeTypeName("#define CERT_CHAIN_DISABLE_AIA 0x00002000")]
    public const int CERT_CHAIN_DISABLE_AIA = 0x00002000;
    [NativeTypeName("#define CERT_CHAIN_HAS_MOTW 0x00004000")]
    public const int CERT_CHAIN_HAS_MOTW = 0x00004000;
    [NativeTypeName("#define CERT_CHAIN_ONLY_ADDITIONAL_AND_AUTH_ROOT 0x00008000")]
    public const int CERT_CHAIN_ONLY_ADDITIONAL_AND_AUTH_ROOT = 0x00008000;
    [NativeTypeName("#define CERT_CHAIN_OPT_IN_WEAK_SIGNATURE 0x00010000")]
    public const int CERT_CHAIN_OPT_IN_WEAK_SIGNATURE = 0x00010000;
    [NativeTypeName("#define CERT_CHAIN_ENABLE_DISALLOWED_CA 0x00020000")]
    public const int CERT_CHAIN_ENABLE_DISALLOWED_CA = 0x00020000;
    [NativeTypeName("#define CERT_CHAIN_FIND_BY_ISSUER 1")]
    public const int CERT_CHAIN_FIND_BY_ISSUER = 1;
    [NativeTypeName("#define CERT_CHAIN_FIND_BY_ISSUER_COMPARE_KEY_FLAG 0x0001")]
    public const int CERT_CHAIN_FIND_BY_ISSUER_COMPARE_KEY_FLAG = 0x0001;
    [NativeTypeName("#define CERT_CHAIN_FIND_BY_ISSUER_COMPLEX_CHAIN_FLAG 0x0002")]
    public const int CERT_CHAIN_FIND_BY_ISSUER_COMPLEX_CHAIN_FLAG = 0x0002;
    [NativeTypeName("#define CERT_CHAIN_FIND_BY_ISSUER_CACHE_ONLY_URL_FLAG 0x0004")]
    public const int CERT_CHAIN_FIND_BY_ISSUER_CACHE_ONLY_URL_FLAG = 0x0004;
    [NativeTypeName("#define CERT_CHAIN_FIND_BY_ISSUER_LOCAL_MACHINE_FLAG 0x0008")]
    public const int CERT_CHAIN_FIND_BY_ISSUER_LOCAL_MACHINE_FLAG = 0x0008;
    [NativeTypeName("#define CERT_CHAIN_FIND_BY_ISSUER_NO_KEY_FLAG 0x4000")]
    public const int CERT_CHAIN_FIND_BY_ISSUER_NO_KEY_FLAG = 0x4000;
    [NativeTypeName("#define CERT_CHAIN_FIND_BY_ISSUER_CACHE_ONLY_FLAG 0x8000")]
    public const int CERT_CHAIN_FIND_BY_ISSUER_CACHE_ONLY_FLAG = 0x8000;
    [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_NOT_TIME_VALID_FLAG 0x00000001")]
    public const int CERT_CHAIN_POLICY_IGNORE_NOT_TIME_VALID_FLAG = 0x00000001;
    [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_CTL_NOT_TIME_VALID_FLAG 0x00000002")]
    public const int CERT_CHAIN_POLICY_IGNORE_CTL_NOT_TIME_VALID_FLAG = 0x00000002;
    [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_NOT_TIME_NESTED_FLAG 0x00000004")]
    public const int CERT_CHAIN_POLICY_IGNORE_NOT_TIME_NESTED_FLAG = 0x00000004;
    [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_INVALID_BASIC_CONSTRAINTS_FLAG 0x00000008")]
    public const int CERT_CHAIN_POLICY_IGNORE_INVALID_BASIC_CONSTRAINTS_FLAG = 0x00000008;
    [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_ALL_NOT_TIME_VALID_FLAGS ( \\\r\n    CERT_CHAIN_POLICY_IGNORE_NOT_TIME_VALID_FLAG                | \\\r\n    CERT_CHAIN_POLICY_IGNORE_CTL_NOT_TIME_VALID_FLAG            | \\\r\n    CERT_CHAIN_POLICY_IGNORE_NOT_TIME_NESTED_FLAG                 \\\r\n    )")]
    public const int CERT_CHAIN_POLICY_IGNORE_ALL_NOT_TIME_VALID_FLAGS = (0x00000001 | 0x00000002 | 0x00000004);
    [NativeTypeName("#define CERT_CHAIN_POLICY_ALLOW_UNKNOWN_CA_FLAG 0x00000010")]
    public const int CERT_CHAIN_POLICY_ALLOW_UNKNOWN_CA_FLAG = 0x00000010;
    [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_WRONG_USAGE_FLAG 0x00000020")]
    public const int CERT_CHAIN_POLICY_IGNORE_WRONG_USAGE_FLAG = 0x00000020;
    [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_INVALID_NAME_FLAG 0x00000040")]
    public const int CERT_CHAIN_POLICY_IGNORE_INVALID_NAME_FLAG = 0x00000040;
    [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_INVALID_POLICY_FLAG 0x00000080")]
    public const int CERT_CHAIN_POLICY_IGNORE_INVALID_POLICY_FLAG = 0x00000080;
    [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_END_REV_UNKNOWN_FLAG 0x00000100")]
    public const int CERT_CHAIN_POLICY_IGNORE_END_REV_UNKNOWN_FLAG = 0x00000100;
    [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_CTL_SIGNER_REV_UNKNOWN_FLAG 0x00000200")]
    public const int CERT_CHAIN_POLICY_IGNORE_CTL_SIGNER_REV_UNKNOWN_FLAG = 0x00000200;
    [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_CA_REV_UNKNOWN_FLAG 0x00000400")]
    public const int CERT_CHAIN_POLICY_IGNORE_CA_REV_UNKNOWN_FLAG = 0x00000400;
    [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_ROOT_REV_UNKNOWN_FLAG 0x00000800")]
    public const int CERT_CHAIN_POLICY_IGNORE_ROOT_REV_UNKNOWN_FLAG = 0x00000800;
    [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_ALL_REV_UNKNOWN_FLAGS ( \\\r\n    CERT_CHAIN_POLICY_IGNORE_END_REV_UNKNOWN_FLAG         | \\\r\n    CERT_CHAIN_POLICY_IGNORE_CTL_SIGNER_REV_UNKNOWN_FLAG  | \\\r\n    CERT_CHAIN_POLICY_IGNORE_CA_REV_UNKNOWN_FLAG          | \\\r\n    CERT_CHAIN_POLICY_IGNORE_ROOT_REV_UNKNOWN_FLAG          \\\r\n    )")]
    public const int CERT_CHAIN_POLICY_IGNORE_ALL_REV_UNKNOWN_FLAGS = (0x00000100 | 0x00000200 | 0x00000400 | 0x00000800);
    [NativeTypeName("#define CERT_CHAIN_POLICY_ALLOW_TESTROOT_FLAG 0x00008000")]
    public const int CERT_CHAIN_POLICY_ALLOW_TESTROOT_FLAG = 0x00008000;
    [NativeTypeName("#define CERT_CHAIN_POLICY_TRUST_TESTROOT_FLAG 0x00004000")]
    public const int CERT_CHAIN_POLICY_TRUST_TESTROOT_FLAG = 0x00004000;
    [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_NOT_SUPPORTED_CRITICAL_EXT_FLAG 0x00002000")]
    public const int CERT_CHAIN_POLICY_IGNORE_NOT_SUPPORTED_CRITICAL_EXT_FLAG = 0x00002000;
    [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_PEER_TRUST_FLAG 0x00001000")]
    public const int CERT_CHAIN_POLICY_IGNORE_PEER_TRUST_FLAG = 0x00001000;
    [NativeTypeName("#define CERT_CHAIN_POLICY_IGNORE_WEAK_SIGNATURE_FLAG 0x08000000")]
    public const int CERT_CHAIN_POLICY_IGNORE_WEAK_SIGNATURE_FLAG = 0x08000000;
    [NativeTypeName("#define CERT_CHAIN_POLICY_BASE ((LPCSTR) 1)")]
    public static sbyte* CERT_CHAIN_POLICY_BASE => ((sbyte*)(1));

    [NativeTypeName("#define CERT_CHAIN_POLICY_AUTHENTICODE ((LPCSTR) 2)")]
    public static sbyte* CERT_CHAIN_POLICY_AUTHENTICODE => ((sbyte*)(2));

    [NativeTypeName("#define CERT_CHAIN_POLICY_AUTHENTICODE_TS ((LPCSTR) 3)")]
    public static sbyte* CERT_CHAIN_POLICY_AUTHENTICODE_TS => ((sbyte*)(3));

    [NativeTypeName("#define CERT_CHAIN_POLICY_SSL ((LPCSTR) 4)")]
    public static sbyte* CERT_CHAIN_POLICY_SSL => ((sbyte*)(4));

    [NativeTypeName("#define CERT_CHAIN_POLICY_BASIC_CONSTRAINTS ((LPCSTR) 5)")]
    public static sbyte* CERT_CHAIN_POLICY_BASIC_CONSTRAINTS => ((sbyte*)(5));

    [NativeTypeName("#define CERT_CHAIN_POLICY_NT_AUTH ((LPCSTR) 6)")]
    public static sbyte* CERT_CHAIN_POLICY_NT_AUTH => ((sbyte*)(6));

    [NativeTypeName("#define CERT_CHAIN_POLICY_MICROSOFT_ROOT ((LPCSTR) 7)")]
    public static sbyte* CERT_CHAIN_POLICY_MICROSOFT_ROOT => ((sbyte*)(7));

    [NativeTypeName("#define CERT_CHAIN_POLICY_EV ((LPCSTR) 8)")]
    public static sbyte* CERT_CHAIN_POLICY_EV => ((sbyte*)(8));

    [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_F12 ((LPCSTR) 9)")]
    public static sbyte* CERT_CHAIN_POLICY_SSL_F12 => ((sbyte*)(9));

    [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_HPKP_HEADER ((LPCSTR) 10)")]
    public static sbyte* CERT_CHAIN_POLICY_SSL_HPKP_HEADER => ((sbyte*)(10));

    [NativeTypeName("#define CERT_CHAIN_POLICY_THIRD_PARTY_ROOT ((LPCSTR) 11)")]
    public static sbyte* CERT_CHAIN_POLICY_THIRD_PARTY_ROOT => ((sbyte*)(11));

    [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_KEY_PIN ((LPCSTR) 12)")]
    public static sbyte* CERT_CHAIN_POLICY_SSL_KEY_PIN => ((sbyte*)(12));

    [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_F12_SUCCESS_LEVEL 0")]
    public const int CERT_CHAIN_POLICY_SSL_F12_SUCCESS_LEVEL = 0;
    [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_F12_WARNING_LEVEL 1")]
    public const int CERT_CHAIN_POLICY_SSL_F12_WARNING_LEVEL = 1;
    [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_F12_ERROR_LEVEL 2")]
    public const int CERT_CHAIN_POLICY_SSL_F12_ERROR_LEVEL = 2;
    [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_F12_NONE_CATEGORY 0")]
    public const int CERT_CHAIN_POLICY_SSL_F12_NONE_CATEGORY = 0;
    [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_F12_WEAK_CRYPTO_CATEGORY 1")]
    public const int CERT_CHAIN_POLICY_SSL_F12_WEAK_CRYPTO_CATEGORY = 1;
    [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_F12_ROOT_PROGRAM_CATEGORY 2")]
    public const int CERT_CHAIN_POLICY_SSL_F12_ROOT_PROGRAM_CATEGORY = 2;
    [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_KEY_PIN_MISMATCH_ERROR -2")]
    public const int CERT_CHAIN_POLICY_SSL_KEY_PIN_MISMATCH_ERROR = -2;
    [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_KEY_PIN_MITM_ERROR -1")]
    public const int CERT_CHAIN_POLICY_SSL_KEY_PIN_MITM_ERROR = -1;
    [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_KEY_PIN_SUCCESS 0")]
    public const int CERT_CHAIN_POLICY_SSL_KEY_PIN_SUCCESS = 0;
    [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_KEY_PIN_MITM_WARNING 1")]
    public const int CERT_CHAIN_POLICY_SSL_KEY_PIN_MITM_WARNING = 1;
    [NativeTypeName("#define CERT_CHAIN_POLICY_SSL_KEY_PIN_MISMATCH_WARNING 2")]
    public const int CERT_CHAIN_POLICY_SSL_KEY_PIN_MISMATCH_WARNING = 2;
    [NativeTypeName("#define CERT_SERVER_OCSP_RESPONSE_OPEN_PARA_READ_FLAG 0x00000001")]
    public const int CERT_SERVER_OCSP_RESPONSE_OPEN_PARA_READ_FLAG = 0x00000001;
    [NativeTypeName("#define CERT_SERVER_OCSP_RESPONSE_OPEN_PARA_WRITE_FLAG 0x00000002")]
    public const int CERT_SERVER_OCSP_RESPONSE_OPEN_PARA_WRITE_FLAG = 0x00000002;
    [NativeTypeName("#define CERT_SERVER_OCSP_RESPONSE_ASYNC_FLAG 0x00000001")]
    public const int CERT_SERVER_OCSP_RESPONSE_ASYNC_FLAG = 0x00000001;
    [NativeTypeName("#define CERT_RETRIEVE_ISSUER_LOGO ((LPCSTR) 1)")]
    public static sbyte* CERT_RETRIEVE_ISSUER_LOGO => ((sbyte*)(1));

    [NativeTypeName("#define CERT_RETRIEVE_SUBJECT_LOGO ((LPCSTR) 2)")]
    public static sbyte* CERT_RETRIEVE_SUBJECT_LOGO => ((sbyte*)(2));

    [NativeTypeName("#define CERT_RETRIEVE_COMMUNITY_LOGO ((LPCSTR) 3)")]
    public static sbyte* CERT_RETRIEVE_COMMUNITY_LOGO => ((sbyte*)(3));

    [NativeTypeName("#define CERT_RETRIEVE_BIOMETRIC_PREDEFINED_BASE_TYPE ((LPCSTR) 1000)")]
    public static sbyte* CERT_RETRIEVE_BIOMETRIC_PREDEFINED_BASE_TYPE => ((sbyte*)(1000));

    [NativeTypeName("#define CERT_RETRIEVE_BIOMETRIC_PICTURE_TYPE (CERT_RETRIEVE_BIOMETRIC_PREDEFINED_BASE_TYPE + CERT_BIOMETRIC_PICTURE_TYPE)")]
    public static sbyte* CERT_RETRIEVE_BIOMETRIC_PICTURE_TYPE => (((sbyte*)(1000)) + 0);

    [NativeTypeName("#define CERT_RETRIEVE_BIOMETRIC_SIGNATURE_TYPE (CERT_RETRIEVE_BIOMETRIC_PREDEFINED_BASE_TYPE + CERT_BIOMETRIC_SIGNATURE_TYPE)")]
    public static sbyte* CERT_RETRIEVE_BIOMETRIC_SIGNATURE_TYPE => (((sbyte*)(1000)) + 1);

    [NativeTypeName("#define CERT_SELECT_MAX_PARA 500")]
    public const int CERT_SELECT_MAX_PARA = 500;
    [NativeTypeName("#define CERT_SELECT_BY_ENHKEY_USAGE 1")]
    public const int CERT_SELECT_BY_ENHKEY_USAGE = 1;
    [NativeTypeName("#define CERT_SELECT_BY_KEY_USAGE 2")]
    public const int CERT_SELECT_BY_KEY_USAGE = 2;
    [NativeTypeName("#define CERT_SELECT_BY_POLICY_OID 3")]
    public const int CERT_SELECT_BY_POLICY_OID = 3;
    [NativeTypeName("#define CERT_SELECT_BY_PROV_NAME 4")]
    public const int CERT_SELECT_BY_PROV_NAME = 4;
    [NativeTypeName("#define CERT_SELECT_BY_EXTENSION 5")]
    public const int CERT_SELECT_BY_EXTENSION = 5;
    [NativeTypeName("#define CERT_SELECT_BY_SUBJECT_HOST_NAME 6")]
    public const int CERT_SELECT_BY_SUBJECT_HOST_NAME = 6;
    [NativeTypeName("#define CERT_SELECT_BY_ISSUER_ATTR 7")]
    public const int CERT_SELECT_BY_ISSUER_ATTR = 7;
    [NativeTypeName("#define CERT_SELECT_BY_SUBJECT_ATTR 8")]
    public const int CERT_SELECT_BY_SUBJECT_ATTR = 8;
    [NativeTypeName("#define CERT_SELECT_BY_ISSUER_NAME 9")]
    public const int CERT_SELECT_BY_ISSUER_NAME = 9;
    [NativeTypeName("#define CERT_SELECT_BY_PUBLIC_KEY 10")]
    public const int CERT_SELECT_BY_PUBLIC_KEY = 10;
    [NativeTypeName("#define CERT_SELECT_BY_TLS_SIGNATURES 11")]
    public const int CERT_SELECT_BY_TLS_SIGNATURES = 11;
    [NativeTypeName("#define CERT_SELECT_BY_ISSUER_DISPLAYNAME 12")]
    public const int CERT_SELECT_BY_ISSUER_DISPLAYNAME = 12;
    [NativeTypeName("#define CERT_SELECT_BY_FRIENDLYNAME 13")]
    public const int CERT_SELECT_BY_FRIENDLYNAME = 13;
    [NativeTypeName("#define CERT_SELECT_BY_THUMBPRINT 14")]
    public const int CERT_SELECT_BY_THUMBPRINT = 14;
    [NativeTypeName("#define CERT_SELECT_LAST CERT_SELECT_BY_TLS_SIGNATURES")]
    public const int CERT_SELECT_LAST = 11;
    [NativeTypeName("#define CERT_SELECT_MAX (CERT_SELECT_LAST * 3)")]
    public const int CERT_SELECT_MAX = (11 * 3);
    [NativeTypeName("#define CERT_SELECT_ALLOW_EXPIRED 0x00000001")]
    public const int CERT_SELECT_ALLOW_EXPIRED = 0x00000001;
    [NativeTypeName("#define CERT_SELECT_TRUSTED_ROOT 0x00000002")]
    public const int CERT_SELECT_TRUSTED_ROOT = 0x00000002;
    [NativeTypeName("#define CERT_SELECT_DISALLOW_SELFSIGNED 0x00000004")]
    public const int CERT_SELECT_DISALLOW_SELFSIGNED = 0x00000004;
    [NativeTypeName("#define CERT_SELECT_HAS_PRIVATE_KEY 0x00000008")]
    public const int CERT_SELECT_HAS_PRIVATE_KEY = 0x00000008;
    [NativeTypeName("#define CERT_SELECT_HAS_KEY_FOR_SIGNATURE 0x00000010")]
    public const int CERT_SELECT_HAS_KEY_FOR_SIGNATURE = 0x00000010;
    [NativeTypeName("#define CERT_SELECT_HAS_KEY_FOR_KEY_EXCHANGE 0x00000020")]
    public const int CERT_SELECT_HAS_KEY_FOR_KEY_EXCHANGE = 0x00000020;
    [NativeTypeName("#define CERT_SELECT_HARDWARE_ONLY 0x00000040")]
    public const int CERT_SELECT_HARDWARE_ONLY = 0x00000040;
    [NativeTypeName("#define CERT_SELECT_ALLOW_DUPLICATES 0x00000080")]
    public const int CERT_SELECT_ALLOW_DUPLICATES = 0x00000080;
    [NativeTypeName("#define CERT_SELECT_IGNORE_AUTOSELECT 0x00000100")]
    public const int CERT_SELECT_IGNORE_AUTOSELECT = 0x00000100;
    [NativeTypeName("#define CERT_FILE_HASH_USE_TYPE 1")]
    public const int CERT_FILE_HASH_USE_TYPE = 1;
    [NativeTypeName("#define CERT_TIMESTAMP_HASH_USE_TYPE 2")]
    public const int CERT_TIMESTAMP_HASH_USE_TYPE = 2;
}