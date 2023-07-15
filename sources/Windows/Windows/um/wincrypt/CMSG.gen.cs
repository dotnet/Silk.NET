// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
public static unsafe partial class CMSG
{
    [NativeTypeName("#define CMSG_ENCODING_TYPE_MASK 0xFFFF0000")]
    public const uint CMSG_ENCODING_TYPE_MASK = 0xFFFF0000;
    [NativeTypeName("#define CMSG_DATA 1")]
    public const int CMSG_DATA = 1;
    [NativeTypeName("#define CMSG_SIGNED 2")]
    public const int CMSG_SIGNED = 2;
    [NativeTypeName("#define CMSG_ENVELOPED 3")]
    public const int CMSG_ENVELOPED = 3;
    [NativeTypeName("#define CMSG_SIGNED_AND_ENVELOPED 4")]
    public const int CMSG_SIGNED_AND_ENVELOPED = 4;
    [NativeTypeName("#define CMSG_HASHED 5")]
    public const int CMSG_HASHED = 5;
    [NativeTypeName("#define CMSG_ENCRYPTED 6")]
    public const int CMSG_ENCRYPTED = 6;
    [NativeTypeName("#define CMSG_ALL_FLAGS (~0UL)")]
    public const uint CMSG_ALL_FLAGS = (~0U);
    [NativeTypeName("#define CMSG_DATA_FLAG (1 << CMSG_DATA)")]
    public const int CMSG_DATA_FLAG = (1 << 1);
    [NativeTypeName("#define CMSG_SIGNED_FLAG (1 << CMSG_SIGNED)")]
    public const int CMSG_SIGNED_FLAG = (1 << 2);
    [NativeTypeName("#define CMSG_ENVELOPED_FLAG (1 << CMSG_ENVELOPED)")]
    public const int CMSG_ENVELOPED_FLAG = (1 << 3);
    [NativeTypeName("#define CMSG_SIGNED_AND_ENVELOPED_FLAG (1 << CMSG_SIGNED_AND_ENVELOPED)")]
    public const int CMSG_SIGNED_AND_ENVELOPED_FLAG = (1 << 4);
    [NativeTypeName("#define CMSG_HASHED_FLAG (1 << CMSG_HASHED)")]
    public const int CMSG_HASHED_FLAG = (1 << 5);
    [NativeTypeName("#define CMSG_ENCRYPTED_FLAG (1 << CMSG_ENCRYPTED)")]
    public const int CMSG_ENCRYPTED_FLAG = (1 << 6);
    [NativeTypeName("#define CMSG_KEY_AGREE_EPHEMERAL_KEY_CHOICE 1")]
    public const int CMSG_KEY_AGREE_EPHEMERAL_KEY_CHOICE = 1;
    [NativeTypeName("#define CMSG_KEY_AGREE_STATIC_KEY_CHOICE 2")]
    public const int CMSG_KEY_AGREE_STATIC_KEY_CHOICE = 2;
    [NativeTypeName("#define CMSG_MAIL_LIST_HANDLE_KEY_CHOICE 1")]
    public const int CMSG_MAIL_LIST_HANDLE_KEY_CHOICE = 1;
    [NativeTypeName("#define CMSG_KEY_TRANS_RECIPIENT 1")]
    public const int CMSG_KEY_TRANS_RECIPIENT = 1;
    [NativeTypeName("#define CMSG_KEY_AGREE_RECIPIENT 2")]
    public const int CMSG_KEY_AGREE_RECIPIENT = 2;
    [NativeTypeName("#define CMSG_MAIL_LIST_RECIPIENT 3")]
    public const int CMSG_MAIL_LIST_RECIPIENT = 3;
    [NativeTypeName("#define CMSG_SP3_COMPATIBLE_ENCRYPT_FLAG 0x80000000")]
    public const uint CMSG_SP3_COMPATIBLE_ENCRYPT_FLAG = 0x80000000;
    [NativeTypeName("#define CMSG_RC4_NO_SALT_FLAG 0x40000000")]
    public const int CMSG_RC4_NO_SALT_FLAG = 0x40000000;
    [NativeTypeName("#define CMSG_INDEFINITE_LENGTH (0xFFFFFFFF)")]
    public const uint CMSG_INDEFINITE_LENGTH = (0xFFFFFFFF);
    [NativeTypeName("#define CMSG_BARE_CONTENT_FLAG 0x00000001")]
    public const int CMSG_BARE_CONTENT_FLAG = 0x00000001;
    [NativeTypeName("#define CMSG_LENGTH_ONLY_FLAG 0x00000002")]
    public const int CMSG_LENGTH_ONLY_FLAG = 0x00000002;
    [NativeTypeName("#define CMSG_DETACHED_FLAG 0x00000004")]
    public const int CMSG_DETACHED_FLAG = 0x00000004;
    [NativeTypeName("#define CMSG_AUTHENTICATED_ATTRIBUTES_FLAG 0x00000008")]
    public const int CMSG_AUTHENTICATED_ATTRIBUTES_FLAG = 0x00000008;
    [NativeTypeName("#define CMSG_CONTENTS_OCTETS_FLAG 0x00000010")]
    public const int CMSG_CONTENTS_OCTETS_FLAG = 0x00000010;
    [NativeTypeName("#define CMSG_MAX_LENGTH_FLAG 0x00000020")]
    public const int CMSG_MAX_LENGTH_FLAG = 0x00000020;
    [NativeTypeName("#define CMSG_CMS_ENCAPSULATED_CONTENT_FLAG 0x00000040")]
    public const int CMSG_CMS_ENCAPSULATED_CONTENT_FLAG = 0x00000040;
    [NativeTypeName("#define CMSG_SIGNED_DATA_NO_SIGN_FLAG 0x00000080")]
    public const int CMSG_SIGNED_DATA_NO_SIGN_FLAG = 0x00000080;
    [NativeTypeName("#define CMSG_CRYPT_RELEASE_CONTEXT_FLAG 0x00008000")]
    public const int CMSG_CRYPT_RELEASE_CONTEXT_FLAG = 0x00008000;
    [NativeTypeName("#define CMSG_TYPE_PARAM 1")]
    public const int CMSG_TYPE_PARAM = 1;
    [NativeTypeName("#define CMSG_CONTENT_PARAM 2")]
    public const int CMSG_CONTENT_PARAM = 2;
    [NativeTypeName("#define CMSG_BARE_CONTENT_PARAM 3")]
    public const int CMSG_BARE_CONTENT_PARAM = 3;
    [NativeTypeName("#define CMSG_INNER_CONTENT_TYPE_PARAM 4")]
    public const int CMSG_INNER_CONTENT_TYPE_PARAM = 4;
    [NativeTypeName("#define CMSG_SIGNER_COUNT_PARAM 5")]
    public const int CMSG_SIGNER_COUNT_PARAM = 5;
    [NativeTypeName("#define CMSG_SIGNER_INFO_PARAM 6")]
    public const int CMSG_SIGNER_INFO_PARAM = 6;
    [NativeTypeName("#define CMSG_SIGNER_CERT_INFO_PARAM 7")]
    public const int CMSG_SIGNER_CERT_INFO_PARAM = 7;
    [NativeTypeName("#define CMSG_SIGNER_HASH_ALGORITHM_PARAM 8")]
    public const int CMSG_SIGNER_HASH_ALGORITHM_PARAM = 8;
    [NativeTypeName("#define CMSG_SIGNER_AUTH_ATTR_PARAM 9")]
    public const int CMSG_SIGNER_AUTH_ATTR_PARAM = 9;
    [NativeTypeName("#define CMSG_SIGNER_UNAUTH_ATTR_PARAM 10")]
    public const int CMSG_SIGNER_UNAUTH_ATTR_PARAM = 10;
    [NativeTypeName("#define CMSG_CERT_COUNT_PARAM 11")]
    public const int CMSG_CERT_COUNT_PARAM = 11;
    [NativeTypeName("#define CMSG_CERT_PARAM 12")]
    public const int CMSG_CERT_PARAM = 12;
    [NativeTypeName("#define CMSG_CRL_COUNT_PARAM 13")]
    public const int CMSG_CRL_COUNT_PARAM = 13;
    [NativeTypeName("#define CMSG_CRL_PARAM 14")]
    public const int CMSG_CRL_PARAM = 14;
    [NativeTypeName("#define CMSG_ENVELOPE_ALGORITHM_PARAM 15")]
    public const int CMSG_ENVELOPE_ALGORITHM_PARAM = 15;
    [NativeTypeName("#define CMSG_RECIPIENT_COUNT_PARAM 17")]
    public const int CMSG_RECIPIENT_COUNT_PARAM = 17;
    [NativeTypeName("#define CMSG_RECIPIENT_INDEX_PARAM 18")]
    public const int CMSG_RECIPIENT_INDEX_PARAM = 18;
    [NativeTypeName("#define CMSG_RECIPIENT_INFO_PARAM 19")]
    public const int CMSG_RECIPIENT_INFO_PARAM = 19;
    [NativeTypeName("#define CMSG_HASH_ALGORITHM_PARAM 20")]
    public const int CMSG_HASH_ALGORITHM_PARAM = 20;
    [NativeTypeName("#define CMSG_HASH_DATA_PARAM 21")]
    public const int CMSG_HASH_DATA_PARAM = 21;
    [NativeTypeName("#define CMSG_COMPUTED_HASH_PARAM 22")]
    public const int CMSG_COMPUTED_HASH_PARAM = 22;
    [NativeTypeName("#define CMSG_ENCRYPT_PARAM 26")]
    public const int CMSG_ENCRYPT_PARAM = 26;
    [NativeTypeName("#define CMSG_ENCRYPTED_DIGEST 27")]
    public const int CMSG_ENCRYPTED_DIGEST = 27;
    [NativeTypeName("#define CMSG_ENCODED_SIGNER 28")]
    public const int CMSG_ENCODED_SIGNER = 28;
    [NativeTypeName("#define CMSG_ENCODED_MESSAGE 29")]
    public const int CMSG_ENCODED_MESSAGE = 29;
    [NativeTypeName("#define CMSG_VERSION_PARAM 30")]
    public const int CMSG_VERSION_PARAM = 30;
    [NativeTypeName("#define CMSG_ATTR_CERT_COUNT_PARAM 31")]
    public const int CMSG_ATTR_CERT_COUNT_PARAM = 31;
    [NativeTypeName("#define CMSG_ATTR_CERT_PARAM 32")]
    public const int CMSG_ATTR_CERT_PARAM = 32;
    [NativeTypeName("#define CMSG_CMS_RECIPIENT_COUNT_PARAM 33")]
    public const int CMSG_CMS_RECIPIENT_COUNT_PARAM = 33;
    [NativeTypeName("#define CMSG_CMS_RECIPIENT_INDEX_PARAM 34")]
    public const int CMSG_CMS_RECIPIENT_INDEX_PARAM = 34;
    [NativeTypeName("#define CMSG_CMS_RECIPIENT_ENCRYPTED_KEY_INDEX_PARAM 35")]
    public const int CMSG_CMS_RECIPIENT_ENCRYPTED_KEY_INDEX_PARAM = 35;
    [NativeTypeName("#define CMSG_CMS_RECIPIENT_INFO_PARAM 36")]
    public const int CMSG_CMS_RECIPIENT_INFO_PARAM = 36;
    [NativeTypeName("#define CMSG_UNPROTECTED_ATTR_PARAM 37")]
    public const int CMSG_UNPROTECTED_ATTR_PARAM = 37;
    [NativeTypeName("#define CMSG_SIGNER_CERT_ID_PARAM 38")]
    public const int CMSG_SIGNER_CERT_ID_PARAM = 38;
    [NativeTypeName("#define CMSG_CMS_SIGNER_INFO_PARAM 39")]
    public const int CMSG_CMS_SIGNER_INFO_PARAM = 39;
    [NativeTypeName("#define CMSG_SIGNED_DATA_V1 1")]
    public const int CMSG_SIGNED_DATA_V1 = 1;
    [NativeTypeName("#define CMSG_SIGNED_DATA_V3 3")]
    public const int CMSG_SIGNED_DATA_V3 = 3;
    [NativeTypeName("#define CMSG_SIGNED_DATA_PKCS_1_5_VERSION CMSG_SIGNED_DATA_V1")]
    public const int CMSG_SIGNED_DATA_PKCS_1_5_VERSION = 1;
    [NativeTypeName("#define CMSG_SIGNED_DATA_CMS_VERSION CMSG_SIGNED_DATA_V3")]
    public const int CMSG_SIGNED_DATA_CMS_VERSION = 3;
    [NativeTypeName("#define CMSG_SIGNER_INFO_V1 1")]
    public const int CMSG_SIGNER_INFO_V1 = 1;
    [NativeTypeName("#define CMSG_SIGNER_INFO_V3 3")]
    public const int CMSG_SIGNER_INFO_V3 = 3;
    [NativeTypeName("#define CMSG_SIGNER_INFO_PKCS_1_5_VERSION CMSG_SIGNER_INFO_V1")]
    public const int CMSG_SIGNER_INFO_PKCS_1_5_VERSION = 1;
    [NativeTypeName("#define CMSG_SIGNER_INFO_CMS_VERSION CMSG_SIGNER_INFO_V3")]
    public const int CMSG_SIGNER_INFO_CMS_VERSION = 3;
    [NativeTypeName("#define CMSG_HASHED_DATA_V0 0")]
    public const int CMSG_HASHED_DATA_V0 = 0;
    [NativeTypeName("#define CMSG_HASHED_DATA_V2 2")]
    public const int CMSG_HASHED_DATA_V2 = 2;
    [NativeTypeName("#define CMSG_HASHED_DATA_PKCS_1_5_VERSION CMSG_HASHED_DATA_V0")]
    public const int CMSG_HASHED_DATA_PKCS_1_5_VERSION = 0;
    [NativeTypeName("#define CMSG_HASHED_DATA_CMS_VERSION CMSG_HASHED_DATA_V2")]
    public const int CMSG_HASHED_DATA_CMS_VERSION = 2;
    [NativeTypeName("#define CMSG_ENVELOPED_DATA_V0 0")]
    public const int CMSG_ENVELOPED_DATA_V0 = 0;
    [NativeTypeName("#define CMSG_ENVELOPED_DATA_V2 2")]
    public const int CMSG_ENVELOPED_DATA_V2 = 2;
    [NativeTypeName("#define CMSG_ENVELOPED_DATA_PKCS_1_5_VERSION CMSG_ENVELOPED_DATA_V0")]
    public const int CMSG_ENVELOPED_DATA_PKCS_1_5_VERSION = 0;
    [NativeTypeName("#define CMSG_ENVELOPED_DATA_CMS_VERSION CMSG_ENVELOPED_DATA_V2")]
    public const int CMSG_ENVELOPED_DATA_CMS_VERSION = 2;
    [NativeTypeName("#define CMSG_KEY_AGREE_ORIGINATOR_CERT 1")]
    public const int CMSG_KEY_AGREE_ORIGINATOR_CERT = 1;
    [NativeTypeName("#define CMSG_KEY_AGREE_ORIGINATOR_PUBLIC_KEY 2")]
    public const int CMSG_KEY_AGREE_ORIGINATOR_PUBLIC_KEY = 2;
    [NativeTypeName("#define CMSG_ENVELOPED_RECIPIENT_V0 0")]
    public const int CMSG_ENVELOPED_RECIPIENT_V0 = 0;
    [NativeTypeName("#define CMSG_ENVELOPED_RECIPIENT_V2 2")]
    public const int CMSG_ENVELOPED_RECIPIENT_V2 = 2;
    [NativeTypeName("#define CMSG_ENVELOPED_RECIPIENT_V3 3")]
    public const int CMSG_ENVELOPED_RECIPIENT_V3 = 3;
    [NativeTypeName("#define CMSG_ENVELOPED_RECIPIENT_V4 4")]
    public const int CMSG_ENVELOPED_RECIPIENT_V4 = 4;
    [NativeTypeName("#define CMSG_KEY_TRANS_PKCS_1_5_VERSION CMSG_ENVELOPED_RECIPIENT_V0")]
    public const int CMSG_KEY_TRANS_PKCS_1_5_VERSION = 0;
    [NativeTypeName("#define CMSG_KEY_TRANS_CMS_VERSION CMSG_ENVELOPED_RECIPIENT_V2")]
    public const int CMSG_KEY_TRANS_CMS_VERSION = 2;
    [NativeTypeName("#define CMSG_KEY_AGREE_VERSION CMSG_ENVELOPED_RECIPIENT_V3")]
    public const int CMSG_KEY_AGREE_VERSION = 3;
    [NativeTypeName("#define CMSG_MAIL_LIST_VERSION CMSG_ENVELOPED_RECIPIENT_V4")]
    public const int CMSG_MAIL_LIST_VERSION = 4;
    [NativeTypeName("#define CMSG_CTRL_VERIFY_SIGNATURE 1")]
    public const int CMSG_CTRL_VERIFY_SIGNATURE = 1;
    [NativeTypeName("#define CMSG_CTRL_DECRYPT 2")]
    public const int CMSG_CTRL_DECRYPT = 2;
    [NativeTypeName("#define CMSG_CTRL_VERIFY_HASH 5")]
    public const int CMSG_CTRL_VERIFY_HASH = 5;
    [NativeTypeName("#define CMSG_CTRL_ADD_SIGNER 6")]
    public const int CMSG_CTRL_ADD_SIGNER = 6;
    [NativeTypeName("#define CMSG_CTRL_DEL_SIGNER 7")]
    public const int CMSG_CTRL_DEL_SIGNER = 7;
    [NativeTypeName("#define CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR 8")]
    public const int CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR = 8;
    [NativeTypeName("#define CMSG_CTRL_DEL_SIGNER_UNAUTH_ATTR 9")]
    public const int CMSG_CTRL_DEL_SIGNER_UNAUTH_ATTR = 9;
    [NativeTypeName("#define CMSG_CTRL_ADD_CERT 10")]
    public const int CMSG_CTRL_ADD_CERT = 10;
    [NativeTypeName("#define CMSG_CTRL_DEL_CERT 11")]
    public const int CMSG_CTRL_DEL_CERT = 11;
    [NativeTypeName("#define CMSG_CTRL_ADD_CRL 12")]
    public const int CMSG_CTRL_ADD_CRL = 12;
    [NativeTypeName("#define CMSG_CTRL_DEL_CRL 13")]
    public const int CMSG_CTRL_DEL_CRL = 13;
    [NativeTypeName("#define CMSG_CTRL_ADD_ATTR_CERT 14")]
    public const int CMSG_CTRL_ADD_ATTR_CERT = 14;
    [NativeTypeName("#define CMSG_CTRL_DEL_ATTR_CERT 15")]
    public const int CMSG_CTRL_DEL_ATTR_CERT = 15;
    [NativeTypeName("#define CMSG_CTRL_KEY_TRANS_DECRYPT 16")]
    public const int CMSG_CTRL_KEY_TRANS_DECRYPT = 16;
    [NativeTypeName("#define CMSG_CTRL_KEY_AGREE_DECRYPT 17")]
    public const int CMSG_CTRL_KEY_AGREE_DECRYPT = 17;
    [NativeTypeName("#define CMSG_CTRL_MAIL_LIST_DECRYPT 18")]
    public const int CMSG_CTRL_MAIL_LIST_DECRYPT = 18;
    [NativeTypeName("#define CMSG_CTRL_VERIFY_SIGNATURE_EX 19")]
    public const int CMSG_CTRL_VERIFY_SIGNATURE_EX = 19;
    [NativeTypeName("#define CMSG_CTRL_ADD_CMS_SIGNER_INFO 20")]
    public const int CMSG_CTRL_ADD_CMS_SIGNER_INFO = 20;
    [NativeTypeName("#define CMSG_CTRL_ENABLE_STRONG_SIGNATURE 21")]
    public const int CMSG_CTRL_ENABLE_STRONG_SIGNATURE = 21;
    [NativeTypeName("#define CMSG_VERIFY_SIGNER_PUBKEY 1")]
    public const int CMSG_VERIFY_SIGNER_PUBKEY = 1;
    [NativeTypeName("#define CMSG_VERIFY_SIGNER_CERT 2")]
    public const int CMSG_VERIFY_SIGNER_CERT = 2;
    [NativeTypeName("#define CMSG_VERIFY_SIGNER_CHAIN 3")]
    public const int CMSG_VERIFY_SIGNER_CHAIN = 3;
    [NativeTypeName("#define CMSG_VERIFY_SIGNER_NULL 4")]
    public const int CMSG_VERIFY_SIGNER_NULL = 4;
    [NativeTypeName("#define CMSG_VERIFY_COUNTER_SIGN_ENABLE_STRONG_FLAG 0x00000001")]
    public const int CMSG_VERIFY_COUNTER_SIGN_ENABLE_STRONG_FLAG = 0x00000001;
    [NativeTypeName("#define CMSG_OID_GEN_ENCRYPT_KEY_FUNC \"CryptMsgDllGenEncryptKey\"")]
    public static ReadOnlySpan<byte> CMSG_OID_GEN_ENCRYPT_KEY_FUNC => "CryptMsgDllGenEncryptKey"u8;

    [NativeTypeName("#define CMSG_OID_EXPORT_ENCRYPT_KEY_FUNC \"CryptMsgDllExportEncryptKey\"")]
    public static ReadOnlySpan<byte> CMSG_OID_EXPORT_ENCRYPT_KEY_FUNC => "CryptMsgDllExportEncryptKey"u8;

    [NativeTypeName("#define CMSG_OID_IMPORT_ENCRYPT_KEY_FUNC \"CryptMsgDllImportEncryptKey\"")]
    public static ReadOnlySpan<byte> CMSG_OID_IMPORT_ENCRYPT_KEY_FUNC => "CryptMsgDllImportEncryptKey"u8;

    [NativeTypeName("#define CMSG_DEFAULT_INSTALLABLE_FUNC_OID ((LPCSTR) 1)")]
    public static sbyte* CMSG_DEFAULT_INSTALLABLE_FUNC_OID => ((sbyte*)(1));

    [NativeTypeName("#define CMSG_CONTENT_ENCRYPT_PAD_ENCODED_LEN_FLAG 0x00000001")]
    public const int CMSG_CONTENT_ENCRYPT_PAD_ENCODED_LEN_FLAG = 0x00000001;
    [NativeTypeName("#define CMSG_CONTENT_ENCRYPT_FREE_PARA_FLAG 0x00000001")]
    public const int CMSG_CONTENT_ENCRYPT_FREE_PARA_FLAG = 0x00000001;
    [NativeTypeName("#define CMSG_CONTENT_ENCRYPT_FREE_OBJID_FLAG 0x00000002")]
    public const int CMSG_CONTENT_ENCRYPT_FREE_OBJID_FLAG = 0x00000002;
    [NativeTypeName("#define CMSG_CONTENT_ENCRYPT_RELEASE_CONTEXT_FLAG 0x00008000")]
    public const int CMSG_CONTENT_ENCRYPT_RELEASE_CONTEXT_FLAG = 0x00008000;
    [NativeTypeName("#define CMSG_OID_GEN_CONTENT_ENCRYPT_KEY_FUNC \"CryptMsgDllGenContentEncryptKey\"")]
    public static ReadOnlySpan<byte> CMSG_OID_GEN_CONTENT_ENCRYPT_KEY_FUNC => "CryptMsgDllGenContentEncryptKey"u8;

    [NativeTypeName("#define CMSG_OID_CAPI1_GEN_CONTENT_ENCRYPT_KEY_FUNC CMSG_OID_GEN_CONTENT_ENCRYPT_KEY_FUNC")]
    public static ReadOnlySpan<byte> CMSG_OID_CAPI1_GEN_CONTENT_ENCRYPT_KEY_FUNC => "CryptMsgDllGenContentEncryptKey"u8;

    [NativeTypeName("#define CMSG_OID_CNG_GEN_CONTENT_ENCRYPT_KEY_FUNC \"CryptMsgDllCNGGenContentEncryptKey\"")]
    public static ReadOnlySpan<byte> CMSG_OID_CNG_GEN_CONTENT_ENCRYPT_KEY_FUNC => "CryptMsgDllCNGGenContentEncryptKey"u8;

    [NativeTypeName("#define CMSG_KEY_TRANS_ENCRYPT_FREE_PARA_FLAG 0x00000001")]
    public const int CMSG_KEY_TRANS_ENCRYPT_FREE_PARA_FLAG = 0x00000001;
    [NativeTypeName("#define CMSG_KEY_TRANS_ENCRYPT_FREE_OBJID_FLAG 0x00000002")]
    public const int CMSG_KEY_TRANS_ENCRYPT_FREE_OBJID_FLAG = 0x00000002;
    [NativeTypeName("#define CMSG_OID_EXPORT_KEY_TRANS_FUNC \"CryptMsgDllExportKeyTrans\"")]
    public static ReadOnlySpan<byte> CMSG_OID_EXPORT_KEY_TRANS_FUNC => "CryptMsgDllExportKeyTrans"u8;

    [NativeTypeName("#define CMSG_OID_CAPI1_EXPORT_KEY_TRANS_FUNC CMSG_OID_EXPORT_KEY_TRANS_FUNC")]
    public static ReadOnlySpan<byte> CMSG_OID_CAPI1_EXPORT_KEY_TRANS_FUNC => "CryptMsgDllExportKeyTrans"u8;

    [NativeTypeName("#define CMSG_OID_CNG_EXPORT_KEY_TRANS_FUNC \"CryptMsgDllCNGExportKeyTrans\"")]
    public static ReadOnlySpan<byte> CMSG_OID_CNG_EXPORT_KEY_TRANS_FUNC => "CryptMsgDllCNGExportKeyTrans"u8;

    [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_PARA_FLAG 0x00000001")]
    public const int CMSG_KEY_AGREE_ENCRYPT_FREE_PARA_FLAG = 0x00000001;
    [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_MATERIAL_FLAG 0x00000002")]
    public const int CMSG_KEY_AGREE_ENCRYPT_FREE_MATERIAL_FLAG = 0x00000002;
    [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_ALG_FLAG 0x00000004")]
    public const int CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_ALG_FLAG = 0x00000004;
    [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_PARA_FLAG 0x00000008")]
    public const int CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_PARA_FLAG = 0x00000008;
    [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_BITS_FLAG 0x00000010")]
    public const int CMSG_KEY_AGREE_ENCRYPT_FREE_PUBKEY_BITS_FLAG = 0x00000010;
    [NativeTypeName("#define CMSG_KEY_AGREE_ENCRYPT_FREE_OBJID_FLAG 0x00000020")]
    public const int CMSG_KEY_AGREE_ENCRYPT_FREE_OBJID_FLAG = 0x00000020;
    [NativeTypeName("#define CMSG_OID_EXPORT_KEY_AGREE_FUNC \"CryptMsgDllExportKeyAgree\"")]
    public static ReadOnlySpan<byte> CMSG_OID_EXPORT_KEY_AGREE_FUNC => "CryptMsgDllExportKeyAgree"u8;

    [NativeTypeName("#define CMSG_OID_CAPI1_EXPORT_KEY_AGREE_FUNC CMSG_OID_EXPORT_KEY_AGREE_FUNC")]
    public static ReadOnlySpan<byte> CMSG_OID_CAPI1_EXPORT_KEY_AGREE_FUNC => "CryptMsgDllExportKeyAgree"u8;

    [NativeTypeName("#define CMSG_OID_CNG_EXPORT_KEY_AGREE_FUNC \"CryptMsgDllCNGExportKeyAgree\"")]
    public static ReadOnlySpan<byte> CMSG_OID_CNG_EXPORT_KEY_AGREE_FUNC => "CryptMsgDllCNGExportKeyAgree"u8;

    [NativeTypeName("#define CMSG_MAIL_LIST_ENCRYPT_FREE_PARA_FLAG 0x00000001")]
    public const int CMSG_MAIL_LIST_ENCRYPT_FREE_PARA_FLAG = 0x00000001;
    [NativeTypeName("#define CMSG_MAIL_LIST_ENCRYPT_FREE_OBJID_FLAG 0x00000002")]
    public const int CMSG_MAIL_LIST_ENCRYPT_FREE_OBJID_FLAG = 0x00000002;
    [NativeTypeName("#define CMSG_OID_EXPORT_MAIL_LIST_FUNC \"CryptMsgDllExportMailList\"")]
    public static ReadOnlySpan<byte> CMSG_OID_EXPORT_MAIL_LIST_FUNC => "CryptMsgDllExportMailList"u8;

    [NativeTypeName("#define CMSG_OID_CAPI1_EXPORT_MAIL_LIST_FUNC CMSG_OID_EXPORT_MAIL_LIST_FUNC")]
    public static ReadOnlySpan<byte> CMSG_OID_CAPI1_EXPORT_MAIL_LIST_FUNC => "CryptMsgDllExportMailList"u8;

    [NativeTypeName("#define CMSG_OID_IMPORT_KEY_TRANS_FUNC \"CryptMsgDllImportKeyTrans\"")]
    public static ReadOnlySpan<byte> CMSG_OID_IMPORT_KEY_TRANS_FUNC => "CryptMsgDllImportKeyTrans"u8;

    [NativeTypeName("#define CMSG_OID_CAPI1_IMPORT_KEY_TRANS_FUNC CMSG_OID_IMPORT_KEY_TRANS_FUNC")]
    public static ReadOnlySpan<byte> CMSG_OID_CAPI1_IMPORT_KEY_TRANS_FUNC => "CryptMsgDllImportKeyTrans"u8;

    [NativeTypeName("#define CMSG_OID_IMPORT_KEY_AGREE_FUNC \"CryptMsgDllImportKeyAgree\"")]
    public static ReadOnlySpan<byte> CMSG_OID_IMPORT_KEY_AGREE_FUNC => "CryptMsgDllImportKeyAgree"u8;

    [NativeTypeName("#define CMSG_OID_CAPI1_IMPORT_KEY_AGREE_FUNC CMSG_OID_IMPORT_KEY_AGREE_FUNC")]
    public static ReadOnlySpan<byte> CMSG_OID_CAPI1_IMPORT_KEY_AGREE_FUNC => "CryptMsgDllImportKeyAgree"u8;

    [NativeTypeName("#define CMSG_OID_IMPORT_MAIL_LIST_FUNC \"CryptMsgDllImportMailList\"")]
    public static ReadOnlySpan<byte> CMSG_OID_IMPORT_MAIL_LIST_FUNC => "CryptMsgDllImportMailList"u8;

    [NativeTypeName("#define CMSG_OID_CAPI1_IMPORT_MAIL_LIST_FUNC CMSG_OID_IMPORT_MAIL_LIST_FUNC")]
    public static ReadOnlySpan<byte> CMSG_OID_CAPI1_IMPORT_MAIL_LIST_FUNC => "CryptMsgDllImportMailList"u8;

    [NativeTypeName("#define CMSG_OID_CNG_IMPORT_KEY_TRANS_FUNC \"CryptMsgDllCNGImportKeyTrans\"")]
    public static ReadOnlySpan<byte> CMSG_OID_CNG_IMPORT_KEY_TRANS_FUNC => "CryptMsgDllCNGImportKeyTrans"u8;

    [NativeTypeName("#define CMSG_OID_CNG_IMPORT_KEY_AGREE_FUNC \"CryptMsgDllCNGImportKeyAgree\"")]
    public static ReadOnlySpan<byte> CMSG_OID_CNG_IMPORT_KEY_AGREE_FUNC => "CryptMsgDllCNGImportKeyAgree"u8;

    [NativeTypeName("#define CMSG_OID_CNG_IMPORT_CONTENT_ENCRYPT_KEY_FUNC \"CryptMsgDllCNGImportContentEncryptKey\"")]
    public static ReadOnlySpan<byte> CMSG_OID_CNG_IMPORT_CONTENT_ENCRYPT_KEY_FUNC => "CryptMsgDllCNGImportContentEncryptKey"u8;

    [NativeTypeName("#define CMSG_TRUSTED_SIGNER_FLAG 0x1")]
    public const int CMSG_TRUSTED_SIGNER_FLAG = 0x1;
    [NativeTypeName("#define CMSG_SIGNER_ONLY_FLAG 0x2")]
    public const int CMSG_SIGNER_ONLY_FLAG = 0x2;
    [NativeTypeName("#define CMSG_USE_SIGNER_INDEX_FLAG 0x4")]
    public const int CMSG_USE_SIGNER_INDEX_FLAG = 0x4;
    [NativeTypeName("#define CMSG_CMS_ENCAPSULATED_CTL_FLAG 0x00008000")]
    public const int CMSG_CMS_ENCAPSULATED_CTL_FLAG = 0x00008000;
    [NativeTypeName("#define CMSG_ENCODE_SORTED_CTL_FLAG 0x1")]
    public const int CMSG_ENCODE_SORTED_CTL_FLAG = 0x1;
    [NativeTypeName("#define CMSG_ENCODE_HASHED_SUBJECT_IDENTIFIER_FLAG 0x2")]
    public const int CMSG_ENCODE_HASHED_SUBJECT_IDENTIFIER_FLAG = 0x2;
}