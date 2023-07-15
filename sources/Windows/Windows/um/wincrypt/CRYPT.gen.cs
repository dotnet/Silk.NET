// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
public static unsafe partial class CRYPT
{
    [NativeTypeName("#define CRYPT_MODE_CBCI 6")]
    public const int CRYPT_MODE_CBCI = 6;
    [NativeTypeName("#define CRYPT_MODE_CFBP 7")]
    public const int CRYPT_MODE_CFBP = 7;
    [NativeTypeName("#define CRYPT_MODE_OFBP 8")]
    public const int CRYPT_MODE_OFBP = 8;
    [NativeTypeName("#define CRYPT_MODE_CBCOFM 9")]
    public const int CRYPT_MODE_CBCOFM = 9;
    [NativeTypeName("#define CRYPT_MODE_CBCOFMI 10")]
    public const int CRYPT_MODE_CBCOFMI = 10;
    [NativeTypeName("#define CRYPT_VERIFYCONTEXT 0xF0000000")]
    public const uint CRYPT_VERIFYCONTEXT = 0xF0000000;
    [NativeTypeName("#define CRYPT_NEWKEYSET 0x00000008")]
    public const int CRYPT_NEWKEYSET = 0x00000008;
    [NativeTypeName("#define CRYPT_DELETEKEYSET 0x00000010")]
    public const int CRYPT_DELETEKEYSET = 0x00000010;
    [NativeTypeName("#define CRYPT_MACHINE_KEYSET 0x00000020")]
    public const int CRYPT_MACHINE_KEYSET = 0x00000020;
    [NativeTypeName("#define CRYPT_SILENT 0x00000040")]
    public const int CRYPT_SILENT = 0x00000040;
    [NativeTypeName("#define CRYPT_DEFAULT_CONTAINER_OPTIONAL 0x00000080")]
    public const int CRYPT_DEFAULT_CONTAINER_OPTIONAL = 0x00000080;
    [NativeTypeName("#define CRYPT_EXPORTABLE 0x00000001")]
    public const int CRYPT_EXPORTABLE = 0x00000001;
    [NativeTypeName("#define CRYPT_USER_PROTECTED 0x00000002")]
    public const int CRYPT_USER_PROTECTED = 0x00000002;
    [NativeTypeName("#define CRYPT_CREATE_SALT 0x00000004")]
    public const int CRYPT_CREATE_SALT = 0x00000004;
    [NativeTypeName("#define CRYPT_UPDATE_KEY 0x00000008")]
    public const int CRYPT_UPDATE_KEY = 0x00000008;
    [NativeTypeName("#define CRYPT_NO_SALT 0x00000010")]
    public const int CRYPT_NO_SALT = 0x00000010;
    [NativeTypeName("#define CRYPT_PREGEN 0x00000040")]
    public const int CRYPT_PREGEN = 0x00000040;
    [NativeTypeName("#define CRYPT_RECIPIENT 0x00000010")]
    public const int CRYPT_RECIPIENT = 0x00000010;
    [NativeTypeName("#define CRYPT_INITIATOR 0x00000040")]
    public const int CRYPT_INITIATOR = 0x00000040;
    [NativeTypeName("#define CRYPT_ONLINE 0x00000080")]
    public const int CRYPT_ONLINE = 0x00000080;
    [NativeTypeName("#define CRYPT_SF 0x00000100")]
    public const int CRYPT_SF = 0x00000100;
    [NativeTypeName("#define CRYPT_CREATE_IV 0x00000200")]
    public const int CRYPT_CREATE_IV = 0x00000200;
    [NativeTypeName("#define CRYPT_KEK 0x00000400")]
    public const int CRYPT_KEK = 0x00000400;
    [NativeTypeName("#define CRYPT_DATA_KEY 0x00000800")]
    public const int CRYPT_DATA_KEY = 0x00000800;
    [NativeTypeName("#define CRYPT_VOLATILE 0x00001000")]
    public const int CRYPT_VOLATILE = 0x00001000;
    [NativeTypeName("#define CRYPT_SGCKEY 0x00002000")]
    public const int CRYPT_SGCKEY = 0x00002000;
    [NativeTypeName("#define CRYPT_USER_PROTECTED_STRONG 0x00100000")]
    public const int CRYPT_USER_PROTECTED_STRONG = 0x00100000;
    [NativeTypeName("#define CRYPT_ARCHIVABLE 0x00004000")]
    public const int CRYPT_ARCHIVABLE = 0x00004000;
    [NativeTypeName("#define CRYPT_FORCE_KEY_PROTECTION_HIGH 0x00008000")]
    public const int CRYPT_FORCE_KEY_PROTECTION_HIGH = 0x00008000;
    [NativeTypeName("#define CRYPT_SERVER 0x00000400")]
    public const int CRYPT_SERVER = 0x00000400;
    [NativeTypeName("#define CRYPT_Y_ONLY 0x00000001")]
    public const int CRYPT_Y_ONLY = 0x00000001;
    [NativeTypeName("#define CRYPT_SSL2_FALLBACK 0x00000002")]
    public const int CRYPT_SSL2_FALLBACK = 0x00000002;
    [NativeTypeName("#define CRYPT_DESTROYKEY 0x00000004")]
    public const int CRYPT_DESTROYKEY = 0x00000004;
    [NativeTypeName("#define CRYPT_OAEP 0x00000040")]
    public const int CRYPT_OAEP = 0x00000040;
    [NativeTypeName("#define CRYPT_BLOB_VER3 0x00000080")]
    public const int CRYPT_BLOB_VER3 = 0x00000080;
    [NativeTypeName("#define CRYPT_IPSEC_HMAC_KEY 0x00000100")]
    public const int CRYPT_IPSEC_HMAC_KEY = 0x00000100;
    [NativeTypeName("#define CRYPT_DECRYPT_RSA_NO_PADDING_CHECK 0x00000020")]
    public const int CRYPT_DECRYPT_RSA_NO_PADDING_CHECK = 0x00000020;
    [NativeTypeName("#define CRYPT_SECRETDIGEST 0x00000001")]
    public const int CRYPT_SECRETDIGEST = 0x00000001;
    [NativeTypeName("#define CRYPT_OWF_REPL_LM_HASH 0x00000001")]
    public const int CRYPT_OWF_REPL_LM_HASH = 0x00000001;
    [NativeTypeName("#define CRYPT_LITTLE_ENDIAN 0x00000001")]
    public const int CRYPT_LITTLE_ENDIAN = 0x00000001;
    [NativeTypeName("#define CRYPT_NOHASHOID 0x00000001")]
    public const int CRYPT_NOHASHOID = 0x00000001;
    [NativeTypeName("#define CRYPT_TYPE2_FORMAT 0x00000002")]
    public const int CRYPT_TYPE2_FORMAT = 0x00000002;
    [NativeTypeName("#define CRYPT_X931_FORMAT 0x00000004")]
    public const int CRYPT_X931_FORMAT = 0x00000004;
    [NativeTypeName("#define CRYPT_MACHINE_DEFAULT 0x00000001")]
    public const int CRYPT_MACHINE_DEFAULT = 0x00000001;
    [NativeTypeName("#define CRYPT_USER_DEFAULT 0x00000002")]
    public const int CRYPT_USER_DEFAULT = 0x00000002;
    [NativeTypeName("#define CRYPT_DELETE_DEFAULT 0x00000004")]
    public const int CRYPT_DELETE_DEFAULT = 0x00000004;
    [NativeTypeName("#define CRYPT_USERDATA 1")]
    public const int CRYPT_USERDATA = 1;
    [NativeTypeName("#define CRYPT_MODE_CBC 1")]
    public const int CRYPT_MODE_CBC = 1;
    [NativeTypeName("#define CRYPT_MODE_ECB 2")]
    public const int CRYPT_MODE_ECB = 2;
    [NativeTypeName("#define CRYPT_MODE_OFB 3")]
    public const int CRYPT_MODE_OFB = 3;
    [NativeTypeName("#define CRYPT_MODE_CFB 4")]
    public const int CRYPT_MODE_CFB = 4;
    [NativeTypeName("#define CRYPT_MODE_CTS 5")]
    public const int CRYPT_MODE_CTS = 5;
    [NativeTypeName("#define CRYPT_ENCRYPT 0x0001")]
    public const int CRYPT_ENCRYPT = 0x0001;
    [NativeTypeName("#define CRYPT_DECRYPT 0x0002")]
    public const int CRYPT_DECRYPT = 0x0002;
    [NativeTypeName("#define CRYPT_EXPORT 0x0004")]
    public const int CRYPT_EXPORT = 0x0004;
    [NativeTypeName("#define CRYPT_READ 0x0008")]
    public const int CRYPT_READ = 0x0008;
    [NativeTypeName("#define CRYPT_WRITE 0x0010")]
    public const int CRYPT_WRITE = 0x0010;
    [NativeTypeName("#define CRYPT_MAC 0x0020")]
    public const int CRYPT_MAC = 0x0020;
    [NativeTypeName("#define CRYPT_EXPORT_KEY 0x0040")]
    public const int CRYPT_EXPORT_KEY = 0x0040;
    [NativeTypeName("#define CRYPT_IMPORT_KEY 0x0080")]
    public const int CRYPT_IMPORT_KEY = 0x0080;
    [NativeTypeName("#define CRYPT_ARCHIVE 0x0100")]
    public const int CRYPT_ARCHIVE = 0x0100;
    [NativeTypeName("#define CRYPT_FAILED FALSE")]
    public const int CRYPT_FAILED = 0;
    [NativeTypeName("#define CRYPT_SUCCEED TRUE")]
    public const int CRYPT_SUCCEED = 1;
    [NativeTypeName("#define CRYPT_FIRST 1")]
    public const int CRYPT_FIRST = 1;
    [NativeTypeName("#define CRYPT_NEXT 2")]
    public const int CRYPT_NEXT = 2;
    [NativeTypeName("#define CRYPT_SGC_ENUM 4")]
    public const int CRYPT_SGC_ENUM = 4;
    [NativeTypeName("#define CRYPT_IMPL_HARDWARE 1")]
    public const int CRYPT_IMPL_HARDWARE = 1;
    [NativeTypeName("#define CRYPT_IMPL_SOFTWARE 2")]
    public const int CRYPT_IMPL_SOFTWARE = 2;
    [NativeTypeName("#define CRYPT_IMPL_MIXED 3")]
    public const int CRYPT_IMPL_MIXED = 3;
    [NativeTypeName("#define CRYPT_IMPL_UNKNOWN 4")]
    public const int CRYPT_IMPL_UNKNOWN = 4;
    [NativeTypeName("#define CRYPT_IMPL_REMOVABLE 8")]
    public const int CRYPT_IMPL_REMOVABLE = 8;
    [NativeTypeName("#define CRYPT_SEC_DESCR 0x00000001")]
    public const int CRYPT_SEC_DESCR = 0x00000001;
    [NativeTypeName("#define CRYPT_PSTORE 0x00000002")]
    public const int CRYPT_PSTORE = 0x00000002;
    [NativeTypeName("#define CRYPT_UI_PROMPT 0x00000004")]
    public const int CRYPT_UI_PROMPT = 0x00000004;
    [NativeTypeName("#define CRYPT_FLAG_PCT1 0x0001")]
    public const int CRYPT_FLAG_PCT1 = 0x0001;
    [NativeTypeName("#define CRYPT_FLAG_SSL2 0x0002")]
    public const int CRYPT_FLAG_SSL2 = 0x0002;
    [NativeTypeName("#define CRYPT_FLAG_SSL3 0x0004")]
    public const int CRYPT_FLAG_SSL3 = 0x0004;
    [NativeTypeName("#define CRYPT_FLAG_TLS1 0x0008")]
    public const int CRYPT_FLAG_TLS1 = 0x0008;
    [NativeTypeName("#define CRYPT_FLAG_IPSEC 0x0010")]
    public const int CRYPT_FLAG_IPSEC = 0x0010;
    [NativeTypeName("#define CRYPT_FLAG_SIGNING 0x0020")]
    public const int CRYPT_FLAG_SIGNING = 0x0020;
    [NativeTypeName("#define CRYPT_SGC 0x0001")]
    public const int CRYPT_SGC = 0x0001;
    [NativeTypeName("#define CRYPT_FASTSGC 0x0002")]
    public const int CRYPT_FASTSGC = 0x0002;
    [NativeTypeName("#define CRYPT_ECC_PRIVATE_KEY_INFO_v1 1")]
    public const int CRYPT_ECC_PRIVATE_KEY_INFO_v1 = 1;
    [NativeTypeName("#define CRYPT_ASN_ENCODING 0x00000001")]
    public const int CRYPT_ASN_ENCODING = 0x00000001;
    [NativeTypeName("#define CRYPT_NDR_ENCODING 0x00000002")]
    public const int CRYPT_NDR_ENCODING = 0x00000002;
    [NativeTypeName("#define CRYPT_FORMAT_STR_MULTI_LINE 0x0001")]
    public const int CRYPT_FORMAT_STR_MULTI_LINE = 0x0001;
    [NativeTypeName("#define CRYPT_FORMAT_STR_NO_HEX 0x0010")]
    public const int CRYPT_FORMAT_STR_NO_HEX = 0x0010;
    [NativeTypeName("#define CRYPT_FORMAT_SIMPLE 0x0001")]
    public const int CRYPT_FORMAT_SIMPLE = 0x0001;
    [NativeTypeName("#define CRYPT_FORMAT_X509 0x0002")]
    public const int CRYPT_FORMAT_X509 = 0x0002;
    [NativeTypeName("#define CRYPT_FORMAT_OID 0x0004")]
    public const int CRYPT_FORMAT_OID = 0x0004;
    [NativeTypeName("#define CRYPT_FORMAT_RDN_SEMICOLON 0x0100")]
    public const int CRYPT_FORMAT_RDN_SEMICOLON = 0x0100;
    [NativeTypeName("#define CRYPT_FORMAT_RDN_CRLF 0x0200")]
    public const int CRYPT_FORMAT_RDN_CRLF = 0x0200;
    [NativeTypeName("#define CRYPT_FORMAT_RDN_UNQUOTE 0x0400")]
    public const int CRYPT_FORMAT_RDN_UNQUOTE = 0x0400;
    [NativeTypeName("#define CRYPT_FORMAT_RDN_REVERSE 0x0800")]
    public const int CRYPT_FORMAT_RDN_REVERSE = 0x0800;
    [NativeTypeName("#define CRYPT_FORMAT_COMMA 0x1000")]
    public const int CRYPT_FORMAT_COMMA = 0x1000;
    [NativeTypeName("#define CRYPT_FORMAT_SEMICOLON CRYPT_FORMAT_RDN_SEMICOLON")]
    public const int CRYPT_FORMAT_SEMICOLON = 0x0100;
    [NativeTypeName("#define CRYPT_FORMAT_CRLF CRYPT_FORMAT_RDN_CRLF")]
    public const int CRYPT_FORMAT_CRLF = 0x0200;
    [NativeTypeName("#define CRYPT_ENCODE_NO_SIGNATURE_BYTE_REVERSAL_FLAG 0x8")]
    public const int CRYPT_ENCODE_NO_SIGNATURE_BYTE_REVERSAL_FLAG = 0x8;
    [NativeTypeName("#define CRYPT_ENCODE_ALLOC_FLAG 0x8000")]
    public const int CRYPT_ENCODE_ALLOC_FLAG = 0x8000;
    [NativeTypeName("#define CRYPT_UNICODE_NAME_ENCODE_ENABLE_T61_UNICODE_FLAG CERT_RDN_ENABLE_T61_UNICODE_FLAG")]
    public const uint CRYPT_UNICODE_NAME_ENCODE_ENABLE_T61_UNICODE_FLAG = 0x80000000;
    [NativeTypeName("#define CRYPT_UNICODE_NAME_ENCODE_ENABLE_UTF8_UNICODE_FLAG CERT_RDN_ENABLE_UTF8_UNICODE_FLAG")]
    public const int CRYPT_UNICODE_NAME_ENCODE_ENABLE_UTF8_UNICODE_FLAG = 0x20000000;
    [NativeTypeName("#define CRYPT_UNICODE_NAME_ENCODE_FORCE_UTF8_UNICODE_FLAG CERT_RDN_FORCE_UTF8_UNICODE_FLAG")]
    public const int CRYPT_UNICODE_NAME_ENCODE_FORCE_UTF8_UNICODE_FLAG = 0x10000000;
    [NativeTypeName("#define CRYPT_UNICODE_NAME_ENCODE_DISABLE_CHECK_TYPE_FLAG CERT_RDN_DISABLE_CHECK_TYPE_FLAG")]
    public const int CRYPT_UNICODE_NAME_ENCODE_DISABLE_CHECK_TYPE_FLAG = 0x40000000;
    [NativeTypeName("#define CRYPT_SORTED_CTL_ENCODE_HASHED_SUBJECT_IDENTIFIER_FLAG 0x10000")]
    public const int CRYPT_SORTED_CTL_ENCODE_HASHED_SUBJECT_IDENTIFIER_FLAG = 0x10000;
    [NativeTypeName("#define CRYPT_ENCODE_ENABLE_PUNYCODE_FLAG 0x20000")]
    public const int CRYPT_ENCODE_ENABLE_PUNYCODE_FLAG = 0x20000;
    [NativeTypeName("#define CRYPT_ENCODE_ENABLE_UTF8PERCENT_FLAG 0x40000")]
    public const int CRYPT_ENCODE_ENABLE_UTF8PERCENT_FLAG = 0x40000;
    [NativeTypeName("#define CRYPT_ENCODE_ENABLE_IA5CONVERSION_FLAG (CRYPT_ENCODE_ENABLE_PUNYCODE_FLAG | CRYPT_ENCODE_ENABLE_UTF8PERCENT_FLAG)")]
    public const int CRYPT_ENCODE_ENABLE_IA5CONVERSION_FLAG = (0x20000 | 0x40000);
    [NativeTypeName("#define CRYPT_DECODE_NOCOPY_FLAG 0x1")]
    public const int CRYPT_DECODE_NOCOPY_FLAG = 0x1;
    [NativeTypeName("#define CRYPT_DECODE_TO_BE_SIGNED_FLAG 0x2")]
    public const int CRYPT_DECODE_TO_BE_SIGNED_FLAG = 0x2;
    [NativeTypeName("#define CRYPT_DECODE_SHARE_OID_STRING_FLAG 0x4")]
    public const int CRYPT_DECODE_SHARE_OID_STRING_FLAG = 0x4;
    [NativeTypeName("#define CRYPT_DECODE_NO_SIGNATURE_BYTE_REVERSAL_FLAG 0x8")]
    public const int CRYPT_DECODE_NO_SIGNATURE_BYTE_REVERSAL_FLAG = 0x8;
    [NativeTypeName("#define CRYPT_DECODE_ALLOC_FLAG 0x8000")]
    public const int CRYPT_DECODE_ALLOC_FLAG = 0x8000;
    [NativeTypeName("#define CRYPT_UNICODE_NAME_DECODE_DISABLE_IE4_UTF8_FLAG CERT_RDN_DISABLE_IE4_UTF8_FLAG")]
    public const int CRYPT_UNICODE_NAME_DECODE_DISABLE_IE4_UTF8_FLAG = 0x01000000;
    [NativeTypeName("#define CRYPT_DECODE_ENABLE_PUNYCODE_FLAG 0x02000000")]
    public const int CRYPT_DECODE_ENABLE_PUNYCODE_FLAG = 0x02000000;
    [NativeTypeName("#define CRYPT_DECODE_ENABLE_UTF8PERCENT_FLAG 0x04000000")]
    public const int CRYPT_DECODE_ENABLE_UTF8PERCENT_FLAG = 0x04000000;
    [NativeTypeName("#define CRYPT_DECODE_ENABLE_IA5CONVERSION_FLAG (CRYPT_DECODE_ENABLE_PUNYCODE_FLAG | CRYPT_DECODE_ENABLE_UTF8PERCENT_FLAG)")]
    public const int CRYPT_DECODE_ENABLE_IA5CONVERSION_FLAG = (0x02000000 | 0x04000000);
    [NativeTypeName("#define CRYPT_ENCODE_DECODE_NONE 0")]
    public const int CRYPT_ENCODE_DECODE_NONE = 0;
    [NativeTypeName("#define CRYPT_X942_COUNTER_BYTE_LENGTH 4")]
    public const int CRYPT_X942_COUNTER_BYTE_LENGTH = 4;
    [NativeTypeName("#define CRYPT_X942_KEY_LENGTH_BYTE_LENGTH 4")]
    public const int CRYPT_X942_KEY_LENGTH_BYTE_LENGTH = 4;
    [NativeTypeName("#define CRYPT_X942_PUB_INFO_BYTE_LENGTH (512/8)")]
    public const int CRYPT_X942_PUB_INFO_BYTE_LENGTH = (512 / 8);
    [NativeTypeName("#define CRYPT_ECC_CMS_SHARED_INFO_SUPPPUBINFO_BYTE_LENGTH 4")]
    public const int CRYPT_ECC_CMS_SHARED_INFO_SUPPPUBINFO_BYTE_LENGTH = 4;
    [NativeTypeName("#define CRYPT_RC2_40BIT_VERSION 160")]
    public const int CRYPT_RC2_40BIT_VERSION = 160;
    [NativeTypeName("#define CRYPT_RC2_56BIT_VERSION 52")]
    public const int CRYPT_RC2_56BIT_VERSION = 52;
    [NativeTypeName("#define CRYPT_RC2_64BIT_VERSION 120")]
    public const int CRYPT_RC2_64BIT_VERSION = 120;
    [NativeTypeName("#define CRYPT_RC2_128BIT_VERSION 58")]
    public const int CRYPT_RC2_128BIT_VERSION = 58;
    [NativeTypeName("#define CRYPT_OID_ENCODE_OBJECT_FUNC \"CryptDllEncodeObject\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_ENCODE_OBJECT_FUNC => "CryptDllEncodeObject"u8;

    [NativeTypeName("#define CRYPT_OID_DECODE_OBJECT_FUNC \"CryptDllDecodeObject\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_DECODE_OBJECT_FUNC => "CryptDllDecodeObject"u8;

    [NativeTypeName("#define CRYPT_OID_ENCODE_OBJECT_EX_FUNC \"CryptDllEncodeObjectEx\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_ENCODE_OBJECT_EX_FUNC => "CryptDllEncodeObjectEx"u8;

    [NativeTypeName("#define CRYPT_OID_DECODE_OBJECT_EX_FUNC \"CryptDllDecodeObjectEx\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_DECODE_OBJECT_EX_FUNC => "CryptDllDecodeObjectEx"u8;

    [NativeTypeName("#define CRYPT_OID_CREATE_COM_OBJECT_FUNC \"CryptDllCreateCOMObject\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_CREATE_COM_OBJECT_FUNC => "CryptDllCreateCOMObject"u8;

    [NativeTypeName("#define CRYPT_OID_VERIFY_REVOCATION_FUNC \"CertDllVerifyRevocation\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_VERIFY_REVOCATION_FUNC => "CertDllVerifyRevocation"u8;

    [NativeTypeName("#define CRYPT_OID_VERIFY_CTL_USAGE_FUNC \"CertDllVerifyCTLUsage\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_VERIFY_CTL_USAGE_FUNC => "CertDllVerifyCTLUsage"u8;

    [NativeTypeName("#define CRYPT_OID_FORMAT_OBJECT_FUNC \"CryptDllFormatObject\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_FORMAT_OBJECT_FUNC => "CryptDllFormatObject"u8;

    [NativeTypeName("#define CRYPT_OID_FIND_OID_INFO_FUNC \"CryptDllFindOIDInfo\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_FIND_OID_INFO_FUNC => "CryptDllFindOIDInfo"u8;

    [NativeTypeName("#define CRYPT_OID_FIND_LOCALIZED_NAME_FUNC \"CryptDllFindLocalizedName\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_FIND_LOCALIZED_NAME_FUNC => "CryptDllFindLocalizedName"u8;

    [NativeTypeName("#define CRYPT_OID_REGPATH \"Software\\\\Microsoft\\\\Cryptography\\\\OID\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_REGPATH => "Software\\Microsoft\\Cryptography\\OID"u8;

    [NativeTypeName("#define CRYPT_OID_REG_ENCODING_TYPE_PREFIX \"EncodingType \"")]
    public static ReadOnlySpan<byte> CRYPT_OID_REG_ENCODING_TYPE_PREFIX => "EncodingType "u8;

    [NativeTypeName("#define CRYPT_OID_REG_DLL_VALUE_NAME L\"Dll\"")]
    public const string CRYPT_OID_REG_DLL_VALUE_NAME = "Dll";
    [NativeTypeName("#define CRYPT_OID_REG_FUNC_NAME_VALUE_NAME L\"FuncName\"")]
    public const string CRYPT_OID_REG_FUNC_NAME_VALUE_NAME = "FuncName";
    [NativeTypeName("#define CRYPT_OID_REG_FUNC_NAME_VALUE_NAME_A \"FuncName\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_REG_FUNC_NAME_VALUE_NAME_A => "FuncName"u8;

    [NativeTypeName("#define CRYPT_OID_REG_FLAGS_VALUE_NAME L\"CryptFlags\"")]
    public const string CRYPT_OID_REG_FLAGS_VALUE_NAME = "CryptFlags";
    [NativeTypeName("#define CRYPT_DEFAULT_OID \"DEFAULT\"")]
    public static ReadOnlySpan<byte> CRYPT_DEFAULT_OID => "DEFAULT"u8;

    [NativeTypeName("#define CRYPT_INSTALL_OID_FUNC_BEFORE_FLAG 1")]
    public const int CRYPT_INSTALL_OID_FUNC_BEFORE_FLAG = 1;
    [NativeTypeName("#define CRYPT_GET_INSTALLED_OID_FUNC_FLAG 0x1")]
    public const int CRYPT_GET_INSTALLED_OID_FUNC_FLAG = 0x1;
    [NativeTypeName("#define CRYPT_REGISTER_FIRST_INDEX 0")]
    public const int CRYPT_REGISTER_FIRST_INDEX = 0;
    [NativeTypeName("#define CRYPT_REGISTER_LAST_INDEX 0xFFFFFFFF")]
    public const uint CRYPT_REGISTER_LAST_INDEX = 0xFFFFFFFF;
    [NativeTypeName("#define CRYPT_MATCH_ANY_ENCODING_TYPE 0xFFFFFFFF")]
    public const uint CRYPT_MATCH_ANY_ENCODING_TYPE = 0xFFFFFFFF;
    [NativeTypeName("#define CRYPT_OID_INFO_HASH_PARAMETERS_ALGORITHM L\"CryptOIDInfoHashParameters\"")]
    public const string CRYPT_OID_INFO_HASH_PARAMETERS_ALGORITHM = "CryptOIDInfoHashParameters";
    [NativeTypeName("#define CRYPT_OID_INFO_ECC_PARAMETERS_ALGORITHM L\"CryptOIDInfoECCParameters\"")]
    public const string CRYPT_OID_INFO_ECC_PARAMETERS_ALGORITHM = "CryptOIDInfoECCParameters";
    [NativeTypeName("#define CRYPT_OID_INFO_MGF1_PARAMETERS_ALGORITHM L\"CryptOIDInfoMgf1Parameters\"")]
    public const string CRYPT_OID_INFO_MGF1_PARAMETERS_ALGORITHM = "CryptOIDInfoMgf1Parameters";
    [NativeTypeName("#define CRYPT_OID_INFO_NO_SIGN_ALGORITHM L\"CryptOIDInfoNoSign\"")]
    public const string CRYPT_OID_INFO_NO_SIGN_ALGORITHM = "CryptOIDInfoNoSign";
    [NativeTypeName("#define CRYPT_OID_INFO_OAEP_PARAMETERS_ALGORITHM L\"CryptOIDInfoOAEPParameters\"")]
    public const string CRYPT_OID_INFO_OAEP_PARAMETERS_ALGORITHM = "CryptOIDInfoOAEPParameters";
    [NativeTypeName("#define CRYPT_OID_INFO_ECC_WRAP_PARAMETERS_ALGORITHM L\"CryptOIDInfoECCWrapParameters\"")]
    public const string CRYPT_OID_INFO_ECC_WRAP_PARAMETERS_ALGORITHM = "CryptOIDInfoECCWrapParameters";
    [NativeTypeName("#define CRYPT_OID_INFO_NO_PARAMETERS_ALGORITHM L\"CryptOIDInfoNoParameters\"")]
    public const string CRYPT_OID_INFO_NO_PARAMETERS_ALGORITHM = "CryptOIDInfoNoParameters";
    [NativeTypeName("#define CRYPT_HASH_ALG_OID_GROUP_ID 1")]
    public const int CRYPT_HASH_ALG_OID_GROUP_ID = 1;
    [NativeTypeName("#define CRYPT_ENCRYPT_ALG_OID_GROUP_ID 2")]
    public const int CRYPT_ENCRYPT_ALG_OID_GROUP_ID = 2;
    [NativeTypeName("#define CRYPT_PUBKEY_ALG_OID_GROUP_ID 3")]
    public const int CRYPT_PUBKEY_ALG_OID_GROUP_ID = 3;
    [NativeTypeName("#define CRYPT_SIGN_ALG_OID_GROUP_ID 4")]
    public const int CRYPT_SIGN_ALG_OID_GROUP_ID = 4;
    [NativeTypeName("#define CRYPT_RDN_ATTR_OID_GROUP_ID 5")]
    public const int CRYPT_RDN_ATTR_OID_GROUP_ID = 5;
    [NativeTypeName("#define CRYPT_EXT_OR_ATTR_OID_GROUP_ID 6")]
    public const int CRYPT_EXT_OR_ATTR_OID_GROUP_ID = 6;
    [NativeTypeName("#define CRYPT_ENHKEY_USAGE_OID_GROUP_ID 7")]
    public const int CRYPT_ENHKEY_USAGE_OID_GROUP_ID = 7;
    [NativeTypeName("#define CRYPT_POLICY_OID_GROUP_ID 8")]
    public const int CRYPT_POLICY_OID_GROUP_ID = 8;
    [NativeTypeName("#define CRYPT_TEMPLATE_OID_GROUP_ID 9")]
    public const int CRYPT_TEMPLATE_OID_GROUP_ID = 9;
    [NativeTypeName("#define CRYPT_KDF_OID_GROUP_ID 10")]
    public const int CRYPT_KDF_OID_GROUP_ID = 10;
    [NativeTypeName("#define CRYPT_LAST_OID_GROUP_ID 10")]
    public const int CRYPT_LAST_OID_GROUP_ID = 10;
    [NativeTypeName("#define CRYPT_FIRST_ALG_OID_GROUP_ID CRYPT_HASH_ALG_OID_GROUP_ID")]
    public const int CRYPT_FIRST_ALG_OID_GROUP_ID = 1;
    [NativeTypeName("#define CRYPT_LAST_ALG_OID_GROUP_ID CRYPT_SIGN_ALG_OID_GROUP_ID")]
    public const int CRYPT_LAST_ALG_OID_GROUP_ID = 4;
    [NativeTypeName("#define CRYPT_OID_INHIBIT_SIGNATURE_FORMAT_FLAG 0x00000001")]
    public const int CRYPT_OID_INHIBIT_SIGNATURE_FORMAT_FLAG = 0x00000001;
    [NativeTypeName("#define CRYPT_OID_USE_PUBKEY_PARA_FOR_PKCS7_FLAG 0x00000002")]
    public const int CRYPT_OID_USE_PUBKEY_PARA_FOR_PKCS7_FLAG = 0x00000002;
    [NativeTypeName("#define CRYPT_OID_NO_NULL_ALGORITHM_PARA_FLAG 0x00000004")]
    public const int CRYPT_OID_NO_NULL_ALGORITHM_PARA_FLAG = 0x00000004;
    [NativeTypeName("#define CRYPT_OID_PUBKEY_SIGN_ONLY_FLAG 0x80000000")]
    public const uint CRYPT_OID_PUBKEY_SIGN_ONLY_FLAG = 0x80000000;
    [NativeTypeName("#define CRYPT_OID_PUBKEY_ENCRYPT_ONLY_FLAG 0x40000000")]
    public const int CRYPT_OID_PUBKEY_ENCRYPT_ONLY_FLAG = 0x40000000;
    [NativeTypeName("#define CRYPT_OID_USE_CURVE_NAME_FOR_ENCODE_FLAG 0x20000000")]
    public const int CRYPT_OID_USE_CURVE_NAME_FOR_ENCODE_FLAG = 0x20000000;
    [NativeTypeName("#define CRYPT_OID_USE_CURVE_PARAMETERS_FOR_ENCODE_FLAG 0x10000000")]
    public const int CRYPT_OID_USE_CURVE_PARAMETERS_FOR_ENCODE_FLAG = 0x10000000;
    [NativeTypeName("#define CRYPT_OID_INFO_OID_KEY 1")]
    public const int CRYPT_OID_INFO_OID_KEY = 1;
    [NativeTypeName("#define CRYPT_OID_INFO_NAME_KEY 2")]
    public const int CRYPT_OID_INFO_NAME_KEY = 2;
    [NativeTypeName("#define CRYPT_OID_INFO_ALGID_KEY 3")]
    public const int CRYPT_OID_INFO_ALGID_KEY = 3;
    [NativeTypeName("#define CRYPT_OID_INFO_SIGN_KEY 4")]
    public const int CRYPT_OID_INFO_SIGN_KEY = 4;
    [NativeTypeName("#define CRYPT_OID_INFO_CNG_ALGID_KEY 5")]
    public const int CRYPT_OID_INFO_CNG_ALGID_KEY = 5;
    [NativeTypeName("#define CRYPT_OID_INFO_CNG_SIGN_KEY 6")]
    public const int CRYPT_OID_INFO_CNG_SIGN_KEY = 6;
    [NativeTypeName("#define CRYPT_OID_INFO_OID_KEY_FLAGS_MASK 0xFFFF0000")]
    public const uint CRYPT_OID_INFO_OID_KEY_FLAGS_MASK = 0xFFFF0000;
    [NativeTypeName("#define CRYPT_OID_INFO_PUBKEY_SIGN_KEY_FLAG 0x80000000")]
    public const uint CRYPT_OID_INFO_PUBKEY_SIGN_KEY_FLAG = 0x80000000;
    [NativeTypeName("#define CRYPT_OID_INFO_PUBKEY_ENCRYPT_KEY_FLAG 0x40000000")]
    public const int CRYPT_OID_INFO_PUBKEY_ENCRYPT_KEY_FLAG = 0x40000000;
    [NativeTypeName("#define CRYPT_OID_DISABLE_SEARCH_DS_FLAG 0x80000000")]
    public const uint CRYPT_OID_DISABLE_SEARCH_DS_FLAG = 0x80000000;
    [NativeTypeName("#define CRYPT_OID_INFO_OID_GROUP_BIT_LEN_MASK 0x0FFF0000")]
    public const int CRYPT_OID_INFO_OID_GROUP_BIT_LEN_MASK = 0x0FFF0000;
    [NativeTypeName("#define CRYPT_OID_INFO_OID_GROUP_BIT_LEN_SHIFT 16")]
    public const int CRYPT_OID_INFO_OID_GROUP_BIT_LEN_SHIFT = 16;
    [NativeTypeName("#define CRYPT_INSTALL_OID_INFO_BEFORE_FLAG 1")]
    public const int CRYPT_INSTALL_OID_INFO_BEFORE_FLAG = 1;
    [NativeTypeName("#define CRYPT_LOCALIZED_NAME_ENCODING_TYPE 0")]
    public const int CRYPT_LOCALIZED_NAME_ENCODING_TYPE = 0;
    [NativeTypeName("#define CRYPT_LOCALIZED_NAME_OID \"LocalizedNames\"")]
    public static ReadOnlySpan<byte> CRYPT_LOCALIZED_NAME_OID => "LocalizedNames"u8;

    [NativeTypeName("#define CRYPT_OID_OPEN_STORE_PROV_FUNC \"CertDllOpenStoreProv\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_OPEN_STORE_PROV_FUNC => "CertDllOpenStoreProv"u8;

    [NativeTypeName("#define CRYPT_OID_OPEN_SYSTEM_STORE_PROV_FUNC \"CertDllOpenSystemStoreProv\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_OPEN_SYSTEM_STORE_PROV_FUNC => "CertDllOpenSystemStoreProv"u8;

    [NativeTypeName("#define CRYPT_OID_REGISTER_SYSTEM_STORE_FUNC \"CertDllRegisterSystemStore\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_REGISTER_SYSTEM_STORE_FUNC => "CertDllRegisterSystemStore"u8;

    [NativeTypeName("#define CRYPT_OID_UNREGISTER_SYSTEM_STORE_FUNC \"CertDllUnregisterSystemStore\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_UNREGISTER_SYSTEM_STORE_FUNC => "CertDllUnregisterSystemStore"u8;

    [NativeTypeName("#define CRYPT_OID_ENUM_SYSTEM_STORE_FUNC \"CertDllEnumSystemStore\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_ENUM_SYSTEM_STORE_FUNC => "CertDllEnumSystemStore"u8;

    [NativeTypeName("#define CRYPT_OID_REGISTER_PHYSICAL_STORE_FUNC \"CertDllRegisterPhysicalStore\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_REGISTER_PHYSICAL_STORE_FUNC => "CertDllRegisterPhysicalStore"u8;

    [NativeTypeName("#define CRYPT_OID_UNREGISTER_PHYSICAL_STORE_FUNC \"CertDllUnregisterPhysicalStore\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_UNREGISTER_PHYSICAL_STORE_FUNC => "CertDllUnregisterPhysicalStore"u8;

    [NativeTypeName("#define CRYPT_OID_ENUM_PHYSICAL_STORE_FUNC \"CertDllEnumPhysicalStore\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_ENUM_PHYSICAL_STORE_FUNC => "CertDllEnumPhysicalStore"u8;

    [NativeTypeName("#define CRYPT_OID_SYSTEM_STORE_LOCATION_VALUE_NAME L\"SystemStoreLocation\"")]
    public const string CRYPT_OID_SYSTEM_STORE_LOCATION_VALUE_NAME = "SystemStoreLocation";
    [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_SUBJECT_BLOB 1")]
    public const int CRYPT_VERIFY_CERT_SIGN_SUBJECT_BLOB = 1;
    [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_SUBJECT_CERT 2")]
    public const int CRYPT_VERIFY_CERT_SIGN_SUBJECT_CERT = 2;
    [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_SUBJECT_CRL 3")]
    public const int CRYPT_VERIFY_CERT_SIGN_SUBJECT_CRL = 3;
    [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_SUBJECT_OCSP_BASIC_SIGNED_RESPONSE 4")]
    public const int CRYPT_VERIFY_CERT_SIGN_SUBJECT_OCSP_BASIC_SIGNED_RESPONSE = 4;
    [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_ISSUER_PUBKEY 1")]
    public const int CRYPT_VERIFY_CERT_SIGN_ISSUER_PUBKEY = 1;
    [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_ISSUER_CERT 2")]
    public const int CRYPT_VERIFY_CERT_SIGN_ISSUER_CERT = 2;
    [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_ISSUER_CHAIN 3")]
    public const int CRYPT_VERIFY_CERT_SIGN_ISSUER_CHAIN = 3;
    [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_ISSUER_NULL 4")]
    public const int CRYPT_VERIFY_CERT_SIGN_ISSUER_NULL = 4;
    [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_DISABLE_MD2_MD4_FLAG 0x00000001")]
    public const int CRYPT_VERIFY_CERT_SIGN_DISABLE_MD2_MD4_FLAG = 0x00000001;
    [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_SET_STRONG_PROPERTIES_FLAG 0x00000002")]
    public const int CRYPT_VERIFY_CERT_SIGN_SET_STRONG_PROPERTIES_FLAG = 0x00000002;
    [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_RETURN_STRONG_PROPERTIES_FLAG 0x00000004")]
    public const int CRYPT_VERIFY_CERT_SIGN_RETURN_STRONG_PROPERTIES_FLAG = 0x00000004;
    [NativeTypeName("#define CRYPT_VERIFY_CERT_SIGN_CHECK_WEAK_HASH_FLAG 0x00000008")]
    public const int CRYPT_VERIFY_CERT_SIGN_CHECK_WEAK_HASH_FLAG = 0x00000008;
    [NativeTypeName("#define CRYPT_OID_EXTRACT_ENCODED_SIGNATURE_PARAMETERS_FUNC \"CryptDllExtractEncodedSignatureParameters\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_EXTRACT_ENCODED_SIGNATURE_PARAMETERS_FUNC => "CryptDllExtractEncodedSignatureParameters"u8;

    [NativeTypeName("#define CRYPT_OID_SIGN_AND_ENCODE_HASH_FUNC \"CryptDllSignAndEncodeHash\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_SIGN_AND_ENCODE_HASH_FUNC => "CryptDllSignAndEncodeHash"u8;

    [NativeTypeName("#define CRYPT_OID_VERIFY_ENCODED_SIGNATURE_FUNC \"CryptDllVerifyEncodedSignature\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_VERIFY_ENCODED_SIGNATURE_FUNC => "CryptDllVerifyEncodedSignature"u8;

    [NativeTypeName("#define CRYPT_DEFAULT_CONTEXT_AUTO_RELEASE_FLAG 0x00000001")]
    public const int CRYPT_DEFAULT_CONTEXT_AUTO_RELEASE_FLAG = 0x00000001;
    [NativeTypeName("#define CRYPT_DEFAULT_CONTEXT_PROCESS_FLAG 0x00000002")]
    public const int CRYPT_DEFAULT_CONTEXT_PROCESS_FLAG = 0x00000002;
    [NativeTypeName("#define CRYPT_DEFAULT_CONTEXT_CERT_SIGN_OID 1")]
    public const int CRYPT_DEFAULT_CONTEXT_CERT_SIGN_OID = 1;
    [NativeTypeName("#define CRYPT_DEFAULT_CONTEXT_MULTI_CERT_SIGN_OID 2")]
    public const int CRYPT_DEFAULT_CONTEXT_MULTI_CERT_SIGN_OID = 2;
    [NativeTypeName("#define CRYPT_OID_EXPORT_PUBLIC_KEY_INFO_FUNC \"CryptDllExportPublicKeyInfoEx\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_EXPORT_PUBLIC_KEY_INFO_FUNC => "CryptDllExportPublicKeyInfoEx"u8;

    [NativeTypeName("#define CRYPT_OID_EXPORT_PUBLIC_KEY_INFO_EX2_FUNC \"CryptDllExportPublicKeyInfoEx2\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_EXPORT_PUBLIC_KEY_INFO_EX2_FUNC => "CryptDllExportPublicKeyInfoEx2"u8;

    [NativeTypeName("#define CRYPT_OID_EXPORT_PUBLIC_KEY_INFO_FROM_BCRYPT_HANDLE_FUNC \"CryptDllExportPublicKeyInfoFromBCryptKeyHandle\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_EXPORT_PUBLIC_KEY_INFO_FROM_BCRYPT_HANDLE_FUNC => "CryptDllExportPublicKeyInfoFromBCryptKeyHandle"u8;

    [NativeTypeName("#define CRYPT_OID_IMPORT_PUBLIC_KEY_INFO_FUNC \"CryptDllImportPublicKeyInfoEx\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_IMPORT_PUBLIC_KEY_INFO_FUNC => "CryptDllImportPublicKeyInfoEx"u8;

    [NativeTypeName("#define CRYPT_OID_IMPORT_PUBLIC_KEY_INFO_EX2_FUNC \"CryptDllImportPublicKeyInfoEx2\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_IMPORT_PUBLIC_KEY_INFO_EX2_FUNC => "CryptDllImportPublicKeyInfoEx2"u8;

    [NativeTypeName("#define CRYPT_ACQUIRE_CACHE_FLAG 0x00000001")]
    public const int CRYPT_ACQUIRE_CACHE_FLAG = 0x00000001;
    [NativeTypeName("#define CRYPT_ACQUIRE_USE_PROV_INFO_FLAG 0x00000002")]
    public const int CRYPT_ACQUIRE_USE_PROV_INFO_FLAG = 0x00000002;
    [NativeTypeName("#define CRYPT_ACQUIRE_COMPARE_KEY_FLAG 0x00000004")]
    public const int CRYPT_ACQUIRE_COMPARE_KEY_FLAG = 0x00000004;
    [NativeTypeName("#define CRYPT_ACQUIRE_NO_HEALING 0x00000008")]
    public const int CRYPT_ACQUIRE_NO_HEALING = 0x00000008;
    [NativeTypeName("#define CRYPT_ACQUIRE_SILENT_FLAG 0x00000040")]
    public const int CRYPT_ACQUIRE_SILENT_FLAG = 0x00000040;
    [NativeTypeName("#define CRYPT_ACQUIRE_WINDOW_HANDLE_FLAG 0x00000080")]
    public const int CRYPT_ACQUIRE_WINDOW_HANDLE_FLAG = 0x00000080;
    [NativeTypeName("#define CRYPT_ACQUIRE_NCRYPT_KEY_FLAGS_MASK 0x00070000")]
    public const int CRYPT_ACQUIRE_NCRYPT_KEY_FLAGS_MASK = 0x00070000;
    [NativeTypeName("#define CRYPT_ACQUIRE_ALLOW_NCRYPT_KEY_FLAG 0x00010000")]
    public const int CRYPT_ACQUIRE_ALLOW_NCRYPT_KEY_FLAG = 0x00010000;
    [NativeTypeName("#define CRYPT_ACQUIRE_PREFER_NCRYPT_KEY_FLAG 0x00020000")]
    public const int CRYPT_ACQUIRE_PREFER_NCRYPT_KEY_FLAG = 0x00020000;
    [NativeTypeName("#define CRYPT_ACQUIRE_ONLY_NCRYPT_KEY_FLAG 0x00040000")]
    public const int CRYPT_ACQUIRE_ONLY_NCRYPT_KEY_FLAG = 0x00040000;
    [NativeTypeName("#define CRYPT_FIND_USER_KEYSET_FLAG 0x00000001")]
    public const int CRYPT_FIND_USER_KEYSET_FLAG = 0x00000001;
    [NativeTypeName("#define CRYPT_FIND_MACHINE_KEYSET_FLAG 0x00000002")]
    public const int CRYPT_FIND_MACHINE_KEYSET_FLAG = 0x00000002;
    [NativeTypeName("#define CRYPT_FIND_SILENT_KEYSET_FLAG 0x00000040")]
    public const int CRYPT_FIND_SILENT_KEYSET_FLAG = 0x00000040;
    [NativeTypeName("#define CRYPT_OID_IMPORT_PRIVATE_KEY_INFO_FUNC \"CryptDllImportPrivateKeyInfoEx\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_IMPORT_PRIVATE_KEY_INFO_FUNC => "CryptDllImportPrivateKeyInfoEx"u8;

    [NativeTypeName("#define CRYPT_OID_EXPORT_PRIVATE_KEY_INFO_FUNC \"CryptDllExportPrivateKeyInfoEx\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_EXPORT_PRIVATE_KEY_INFO_FUNC => "CryptDllExportPrivateKeyInfoEx"u8;

    [NativeTypeName("#define CRYPT_DELETE_KEYSET CRYPT_DELETEKEYSET")]
    public const int CRYPT_DELETE_KEYSET = 0x00000010;
    [NativeTypeName("#define CRYPT_MESSAGE_BARE_CONTENT_OUT_FLAG 0x00000001")]
    public const int CRYPT_MESSAGE_BARE_CONTENT_OUT_FLAG = 0x00000001;
    [NativeTypeName("#define CRYPT_MESSAGE_ENCAPSULATED_CONTENT_OUT_FLAG 0x00000002")]
    public const int CRYPT_MESSAGE_ENCAPSULATED_CONTENT_OUT_FLAG = 0x00000002;
    [NativeTypeName("#define CRYPT_MESSAGE_KEYID_SIGNER_FLAG 0x00000004")]
    public const int CRYPT_MESSAGE_KEYID_SIGNER_FLAG = 0x00000004;
    [NativeTypeName("#define CRYPT_MESSAGE_SILENT_KEYSET_FLAG 0x00000040")]
    public const int CRYPT_MESSAGE_SILENT_KEYSET_FLAG = 0x00000040;
    [NativeTypeName("#define CRYPT_MESSAGE_KEYID_RECIPIENT_FLAG 0x4")]
    public const int CRYPT_MESSAGE_KEYID_RECIPIENT_FLAG = 0x4;
    [NativeTypeName("#define CRYPT_RETRIEVE_MULTIPLE_OBJECTS 0x00000001")]
    public const int CRYPT_RETRIEVE_MULTIPLE_OBJECTS = 0x00000001;
    [NativeTypeName("#define CRYPT_CACHE_ONLY_RETRIEVAL 0x00000002")]
    public const int CRYPT_CACHE_ONLY_RETRIEVAL = 0x00000002;
    [NativeTypeName("#define CRYPT_WIRE_ONLY_RETRIEVAL 0x00000004")]
    public const int CRYPT_WIRE_ONLY_RETRIEVAL = 0x00000004;
    [NativeTypeName("#define CRYPT_DONT_CACHE_RESULT 0x00000008")]
    public const int CRYPT_DONT_CACHE_RESULT = 0x00000008;
    [NativeTypeName("#define CRYPT_ASYNC_RETRIEVAL 0x00000010")]
    public const int CRYPT_ASYNC_RETRIEVAL = 0x00000010;
    [NativeTypeName("#define CRYPT_STICKY_CACHE_RETRIEVAL 0x00001000")]
    public const int CRYPT_STICKY_CACHE_RETRIEVAL = 0x00001000;
    [NativeTypeName("#define CRYPT_LDAP_SCOPE_BASE_ONLY_RETRIEVAL 0x00002000")]
    public const int CRYPT_LDAP_SCOPE_BASE_ONLY_RETRIEVAL = 0x00002000;
    [NativeTypeName("#define CRYPT_OFFLINE_CHECK_RETRIEVAL 0x00004000")]
    public const int CRYPT_OFFLINE_CHECK_RETRIEVAL = 0x00004000;
    [NativeTypeName("#define CRYPT_LDAP_INSERT_ENTRY_ATTRIBUTE 0x00008000")]
    public const int CRYPT_LDAP_INSERT_ENTRY_ATTRIBUTE = 0x00008000;
    [NativeTypeName("#define CRYPT_LDAP_SIGN_RETRIEVAL 0x00010000")]
    public const int CRYPT_LDAP_SIGN_RETRIEVAL = 0x00010000;
    [NativeTypeName("#define CRYPT_NO_AUTH_RETRIEVAL 0x00020000")]
    public const int CRYPT_NO_AUTH_RETRIEVAL = 0x00020000;
    [NativeTypeName("#define CRYPT_LDAP_AREC_EXCLUSIVE_RETRIEVAL 0x00040000")]
    public const int CRYPT_LDAP_AREC_EXCLUSIVE_RETRIEVAL = 0x00040000;
    [NativeTypeName("#define CRYPT_AIA_RETRIEVAL 0x00080000")]
    public const int CRYPT_AIA_RETRIEVAL = 0x00080000;
    [NativeTypeName("#define CRYPT_HTTP_POST_RETRIEVAL 0x00100000")]
    public const int CRYPT_HTTP_POST_RETRIEVAL = 0x00100000;
    [NativeTypeName("#define CRYPT_PROXY_CACHE_RETRIEVAL 0x00200000")]
    public const int CRYPT_PROXY_CACHE_RETRIEVAL = 0x00200000;
    [NativeTypeName("#define CRYPT_NOT_MODIFIED_RETRIEVAL 0x00400000")]
    public const int CRYPT_NOT_MODIFIED_RETRIEVAL = 0x00400000;
    [NativeTypeName("#define CRYPT_ENABLE_SSL_REVOCATION_RETRIEVAL 0x00800000")]
    public const int CRYPT_ENABLE_SSL_REVOCATION_RETRIEVAL = 0x00800000;
    [NativeTypeName("#define CRYPT_RANDOM_QUERY_STRING_RETRIEVAL 0x04000000")]
    public const int CRYPT_RANDOM_QUERY_STRING_RETRIEVAL = 0x04000000;
    [NativeTypeName("#define CRYPT_ENABLE_FILE_RETRIEVAL 0x08000000")]
    public const int CRYPT_ENABLE_FILE_RETRIEVAL = 0x08000000;
    [NativeTypeName("#define CRYPT_CREATE_NEW_FLUSH_ENTRY 0x10000000")]
    public const int CRYPT_CREATE_NEW_FLUSH_ENTRY = 0x10000000;
    [NativeTypeName("#define CRYPT_VERIFY_CONTEXT_SIGNATURE 0x00000020")]
    public const int CRYPT_VERIFY_CONTEXT_SIGNATURE = 0x00000020;
    [NativeTypeName("#define CRYPT_VERIFY_DATA_HASH 0x00000040")]
    public const int CRYPT_VERIFY_DATA_HASH = 0x00000040;
    [NativeTypeName("#define CRYPT_KEEP_TIME_VALID 0x00000080")]
    public const int CRYPT_KEEP_TIME_VALID = 0x00000080;
    [NativeTypeName("#define CRYPT_DONT_VERIFY_SIGNATURE 0x00000100")]
    public const int CRYPT_DONT_VERIFY_SIGNATURE = 0x00000100;
    [NativeTypeName("#define CRYPT_DONT_CHECK_TIME_VALIDITY 0x00000200")]
    public const int CRYPT_DONT_CHECK_TIME_VALIDITY = 0x00000200;
    [NativeTypeName("#define CRYPT_CHECK_FRESHNESS_TIME_VALIDITY 0x00000400")]
    public const int CRYPT_CHECK_FRESHNESS_TIME_VALIDITY = 0x00000400;
    [NativeTypeName("#define CRYPT_ACCUMULATIVE_TIMEOUT 0x00000800")]
    public const int CRYPT_ACCUMULATIVE_TIMEOUT = 0x00000800;
    [NativeTypeName("#define CRYPT_OCSP_ONLY_RETRIEVAL 0x01000000")]
    public const int CRYPT_OCSP_ONLY_RETRIEVAL = 0x01000000;
    [NativeTypeName("#define CRYPT_NO_OCSP_FAILOVER_TO_CRL_RETRIEVAL 0x02000000")]
    public const int CRYPT_NO_OCSP_FAILOVER_TO_CRL_RETRIEVAL = 0x02000000;
    [NativeTypeName("#define CRYPT_RETRIEVE_MAX_ERROR_CONTENT_LENGTH 0x1000")]
    public const int CRYPT_RETRIEVE_MAX_ERROR_CONTENT_LENGTH = 0x1000;
    [NativeTypeName("#define CRYPT_PARAM_ASYNC_RETRIEVAL_COMPLETION ((LPCSTR)1)")]
    public static sbyte* CRYPT_PARAM_ASYNC_RETRIEVAL_COMPLETION => ((sbyte*)(1));

    [NativeTypeName("#define CRYPT_PARAM_CANCEL_ASYNC_RETRIEVAL ((LPCSTR)2)")]
    public static sbyte* CRYPT_PARAM_CANCEL_ASYNC_RETRIEVAL => ((sbyte*)(2));

    [NativeTypeName("#define CRYPT_GET_URL_FROM_PROPERTY 0x00000001")]
    public const int CRYPT_GET_URL_FROM_PROPERTY = 0x00000001;
    [NativeTypeName("#define CRYPT_GET_URL_FROM_EXTENSION 0x00000002")]
    public const int CRYPT_GET_URL_FROM_EXTENSION = 0x00000002;
    [NativeTypeName("#define CRYPT_GET_URL_FROM_UNAUTH_ATTRIBUTE 0x00000004")]
    public const int CRYPT_GET_URL_FROM_UNAUTH_ATTRIBUTE = 0x00000004;
    [NativeTypeName("#define CRYPT_GET_URL_FROM_AUTH_ATTRIBUTE 0x00000008")]
    public const int CRYPT_GET_URL_FROM_AUTH_ATTRIBUTE = 0x00000008;
    [NativeTypeName("#define CRYPT_KEYID_MACHINE_FLAG 0x00000020")]
    public const int CRYPT_KEYID_MACHINE_FLAG = 0x00000020;
    [NativeTypeName("#define CRYPT_KEYID_ALLOC_FLAG 0x00008000")]
    public const int CRYPT_KEYID_ALLOC_FLAG = 0x00008000;
    [NativeTypeName("#define CRYPT_KEYID_DELETE_FLAG 0x00000010")]
    public const int CRYPT_KEYID_DELETE_FLAG = 0x00000010;
    [NativeTypeName("#define CRYPT_KEYID_SET_NEW_FLAG 0x00002000")]
    public const int CRYPT_KEYID_SET_NEW_FLAG = 0x00002000;
    [NativeTypeName("#define CRYPT_OID_VERIFY_CERTIFICATE_CHAIN_POLICY_FUNC \"CertDllVerifyCertificateChainPolicy\"")]
    public static ReadOnlySpan<byte> CRYPT_OID_VERIFY_CERTIFICATE_CHAIN_POLICY_FUNC => "CertDllVerifyCertificateChainPolicy"u8;

    [NativeTypeName("#define CRYPT_STRING_BASE64HEADER 0x00000000")]
    public const int CRYPT_STRING_BASE64HEADER = 0x00000000;
    [NativeTypeName("#define CRYPT_STRING_BASE64 0x00000001")]
    public const int CRYPT_STRING_BASE64 = 0x00000001;
    [NativeTypeName("#define CRYPT_STRING_BINARY 0x00000002")]
    public const int CRYPT_STRING_BINARY = 0x00000002;
    [NativeTypeName("#define CRYPT_STRING_BASE64REQUESTHEADER 0x00000003")]
    public const int CRYPT_STRING_BASE64REQUESTHEADER = 0x00000003;
    [NativeTypeName("#define CRYPT_STRING_HEX 0x00000004")]
    public const int CRYPT_STRING_HEX = 0x00000004;
    [NativeTypeName("#define CRYPT_STRING_HEXASCII 0x00000005")]
    public const int CRYPT_STRING_HEXASCII = 0x00000005;
    [NativeTypeName("#define CRYPT_STRING_BASE64_ANY 0x00000006")]
    public const int CRYPT_STRING_BASE64_ANY = 0x00000006;
    [NativeTypeName("#define CRYPT_STRING_ANY 0x00000007")]
    public const int CRYPT_STRING_ANY = 0x00000007;
    [NativeTypeName("#define CRYPT_STRING_HEX_ANY 0x00000008")]
    public const int CRYPT_STRING_HEX_ANY = 0x00000008;
    [NativeTypeName("#define CRYPT_STRING_BASE64X509CRLHEADER 0x00000009")]
    public const int CRYPT_STRING_BASE64X509CRLHEADER = 0x00000009;
    [NativeTypeName("#define CRYPT_STRING_HEXADDR 0x0000000a")]
    public const int CRYPT_STRING_HEXADDR = 0x0000000a;
    [NativeTypeName("#define CRYPT_STRING_HEXASCIIADDR 0x0000000b")]
    public const int CRYPT_STRING_HEXASCIIADDR = 0x0000000b;
    [NativeTypeName("#define CRYPT_STRING_HEXRAW 0x0000000c")]
    public const int CRYPT_STRING_HEXRAW = 0x0000000c;
    [NativeTypeName("#define CRYPT_STRING_BASE64URI 0x0000000d")]
    public const int CRYPT_STRING_BASE64URI = 0x0000000d;
    [NativeTypeName("#define CRYPT_STRING_ENCODEMASK 0x000000ff")]
    public const int CRYPT_STRING_ENCODEMASK = 0x000000ff;
    [NativeTypeName("#define CRYPT_STRING_RESERVED100 0x00000100")]
    public const int CRYPT_STRING_RESERVED100 = 0x00000100;
    [NativeTypeName("#define CRYPT_STRING_RESERVED200 0x00000200")]
    public const int CRYPT_STRING_RESERVED200 = 0x00000200;
    [NativeTypeName("#define CRYPT_STRING_PERCENTESCAPE 0x08000000")]
    public const int CRYPT_STRING_PERCENTESCAPE = 0x08000000;
    [NativeTypeName("#define CRYPT_STRING_HASHDATA 0x10000000")]
    public const int CRYPT_STRING_HASHDATA = 0x10000000;
    [NativeTypeName("#define CRYPT_STRING_STRICT 0x20000000")]
    public const int CRYPT_STRING_STRICT = 0x20000000;
    [NativeTypeName("#define CRYPT_STRING_NOCRLF 0x40000000")]
    public const int CRYPT_STRING_NOCRLF = 0x40000000;
    [NativeTypeName("#define CRYPT_STRING_NOCR 0x80000000")]
    public const uint CRYPT_STRING_NOCR = 0x80000000;
    [NativeTypeName("#define CRYPT_USER_KEYSET 0x00001000")]
    public const int CRYPT_USER_KEYSET = 0x00001000;
    [NativeTypeName("#define CRYPT_OBJECT_LOCATOR_SPN_NAME_TYPE 1")]
    public const int CRYPT_OBJECT_LOCATOR_SPN_NAME_TYPE = 1;
    [NativeTypeName("#define CRYPT_OBJECT_LOCATOR_LAST_RESERVED_NAME_TYPE 32")]
    public const int CRYPT_OBJECT_LOCATOR_LAST_RESERVED_NAME_TYPE = 32;
    [NativeTypeName("#define CRYPT_OBJECT_LOCATOR_FIRST_RESERVED_USER_NAME_TYPE 33")]
    public const int CRYPT_OBJECT_LOCATOR_FIRST_RESERVED_USER_NAME_TYPE = 33;
    [NativeTypeName("#define CRYPT_OBJECT_LOCATOR_LAST_RESERVED_USER_NAME_TYPE 0x0000FFFF")]
    public const int CRYPT_OBJECT_LOCATOR_LAST_RESERVED_USER_NAME_TYPE = 0x0000FFFF;
    [NativeTypeName("#define CRYPT_OBJECT_LOCATOR_RELEASE_SYSTEM_SHUTDOWN 1")]
    public const int CRYPT_OBJECT_LOCATOR_RELEASE_SYSTEM_SHUTDOWN = 1;
    [NativeTypeName("#define CRYPT_OBJECT_LOCATOR_RELEASE_SERVICE_STOP 2")]
    public const int CRYPT_OBJECT_LOCATOR_RELEASE_SERVICE_STOP = 2;
    [NativeTypeName("#define CRYPT_OBJECT_LOCATOR_RELEASE_PROCESS_EXIT 3")]
    public const int CRYPT_OBJECT_LOCATOR_RELEASE_PROCESS_EXIT = 3;
    [NativeTypeName("#define CRYPT_OBJECT_LOCATOR_RELEASE_DLL_UNLOAD 4")]
    public const int CRYPT_OBJECT_LOCATOR_RELEASE_DLL_UNLOAD = 4;
}