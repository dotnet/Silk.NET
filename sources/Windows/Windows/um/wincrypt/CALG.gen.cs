// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class CALG
{
    [NativeTypeName("#define CALG_MD2 (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_MD2)")]
    public const int CALG_MD2 = ((4 << 13) | (0) | 1);

    [NativeTypeName("#define CALG_MD4 (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_MD4)")]
    public const int CALG_MD4 = ((4 << 13) | (0) | 2);

    [NativeTypeName("#define CALG_MD5 (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_MD5)")]
    public const int CALG_MD5 = ((4 << 13) | (0) | 3);

    [NativeTypeName("#define CALG_SHA (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA)")]
    public const int CALG_SHA = ((4 << 13) | (0) | 4);

    [NativeTypeName("#define CALG_SHA1 (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA1)")]
    public const int CALG_SHA1 = ((4 << 13) | (0) | 4);

    [NativeTypeName("#define CALG_MAC (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_MAC)")]
    public const int CALG_MAC = ((4 << 13) | (0) | 5);

    [NativeTypeName("#define CALG_RSA_SIGN (ALG_CLASS_SIGNATURE | ALG_TYPE_RSA | ALG_SID_RSA_ANY)")]
    public const int CALG_RSA_SIGN = ((1 << 13) | (2 << 9) | 0);

    [NativeTypeName("#define CALG_DSS_SIGN (ALG_CLASS_SIGNATURE | ALG_TYPE_DSS | ALG_SID_DSS_ANY)")]
    public const int CALG_DSS_SIGN = ((1 << 13) | (1 << 9) | 0);

    [NativeTypeName("#define CALG_NO_SIGN (ALG_CLASS_SIGNATURE | ALG_TYPE_ANY | ALG_SID_ANY)")]
    public const int CALG_NO_SIGN = ((1 << 13) | (0) | (0));

    [NativeTypeName("#define CALG_RSA_KEYX (ALG_CLASS_KEY_EXCHANGE|ALG_TYPE_RSA|ALG_SID_RSA_ANY)")]
    public const int CALG_RSA_KEYX = ((5 << 13) | (2 << 9) | 0);

    [NativeTypeName("#define CALG_DES (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_DES)")]
    public const int CALG_DES = ((3 << 13) | (3 << 9) | 1);

    [NativeTypeName("#define CALG_3DES_112 (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_3DES_112)")]
    public const int CALG_3DES_112 = ((3 << 13) | (3 << 9) | 9);

    [NativeTypeName("#define CALG_3DES (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_3DES)")]
    public const int CALG_3DES = ((3 << 13) | (3 << 9) | 3);

    [NativeTypeName("#define CALG_DESX (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_DESX)")]
    public const int CALG_DESX = ((3 << 13) | (3 << 9) | 4);

    [NativeTypeName("#define CALG_RC2 (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_RC2)")]
    public const int CALG_RC2 = ((3 << 13) | (3 << 9) | 2);

    [NativeTypeName("#define CALG_RC4 (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_STREAM|ALG_SID_RC4)")]
    public const int CALG_RC4 = ((3 << 13) | (4 << 9) | 1);

    [NativeTypeName("#define CALG_SEAL (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_STREAM|ALG_SID_SEAL)")]
    public const int CALG_SEAL = ((3 << 13) | (4 << 9) | 2);

    [NativeTypeName("#define CALG_DH_SF (ALG_CLASS_KEY_EXCHANGE|ALG_TYPE_DH|ALG_SID_DH_SANDF)")]
    public const int CALG_DH_SF = ((5 << 13) | (5 << 9) | 1);

    [NativeTypeName("#define CALG_DH_EPHEM (ALG_CLASS_KEY_EXCHANGE|ALG_TYPE_DH|ALG_SID_DH_EPHEM)")]
    public const int CALG_DH_EPHEM = ((5 << 13) | (5 << 9) | 2);

    [NativeTypeName("#define CALG_AGREEDKEY_ANY (ALG_CLASS_KEY_EXCHANGE|ALG_TYPE_DH|ALG_SID_AGREED_KEY_ANY)")]
    public const int CALG_AGREEDKEY_ANY = ((5 << 13) | (5 << 9) | 3);

    [NativeTypeName("#define CALG_KEA_KEYX (ALG_CLASS_KEY_EXCHANGE|ALG_TYPE_DH|ALG_SID_KEA)")]
    public const int CALG_KEA_KEYX = ((5 << 13) | (5 << 9) | 4);

    [NativeTypeName("#define CALG_HUGHES_MD5 (ALG_CLASS_KEY_EXCHANGE|ALG_TYPE_ANY|ALG_SID_MD5)")]
    public const int CALG_HUGHES_MD5 = ((5 << 13) | (0) | 3);

    [NativeTypeName("#define CALG_SKIPJACK (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_SKIPJACK)")]
    public const int CALG_SKIPJACK = ((3 << 13) | (3 << 9) | 10);

    [NativeTypeName("#define CALG_TEK (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_TEK)")]
    public const int CALG_TEK = ((3 << 13) | (3 << 9) | 11);

    [NativeTypeName("#define CALG_CYLINK_MEK (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_CYLINK_MEK)")]
    public const int CALG_CYLINK_MEK = ((3 << 13) | (3 << 9) | 12);

    [NativeTypeName("#define CALG_SSL3_SHAMD5 (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SSL3SHAMD5)")]
    public const int CALG_SSL3_SHAMD5 = ((4 << 13) | (0) | 8);

    [NativeTypeName("#define CALG_SSL3_MASTER (ALG_CLASS_MSG_ENCRYPT|ALG_TYPE_SECURECHANNEL|ALG_SID_SSL3_MASTER)")]
    public const int CALG_SSL3_MASTER = ((2 << 13) | (6 << 9) | 1);

    [NativeTypeName("#define CALG_SCHANNEL_MASTER_HASH (ALG_CLASS_MSG_ENCRYPT|ALG_TYPE_SECURECHANNEL|ALG_SID_SCHANNEL_MASTER_HASH)")]
    public const int CALG_SCHANNEL_MASTER_HASH = ((2 << 13) | (6 << 9) | 2);

    [NativeTypeName("#define CALG_SCHANNEL_MAC_KEY (ALG_CLASS_MSG_ENCRYPT|ALG_TYPE_SECURECHANNEL|ALG_SID_SCHANNEL_MAC_KEY)")]
    public const int CALG_SCHANNEL_MAC_KEY = ((2 << 13) | (6 << 9) | 3);

    [NativeTypeName("#define CALG_SCHANNEL_ENC_KEY (ALG_CLASS_MSG_ENCRYPT|ALG_TYPE_SECURECHANNEL|ALG_SID_SCHANNEL_ENC_KEY)")]
    public const int CALG_SCHANNEL_ENC_KEY = ((2 << 13) | (6 << 9) | 7);

    [NativeTypeName("#define CALG_PCT1_MASTER (ALG_CLASS_MSG_ENCRYPT|ALG_TYPE_SECURECHANNEL|ALG_SID_PCT1_MASTER)")]
    public const int CALG_PCT1_MASTER = ((2 << 13) | (6 << 9) | 4);

    [NativeTypeName("#define CALG_SSL2_MASTER (ALG_CLASS_MSG_ENCRYPT|ALG_TYPE_SECURECHANNEL|ALG_SID_SSL2_MASTER)")]
    public const int CALG_SSL2_MASTER = ((2 << 13) | (6 << 9) | 5);

    [NativeTypeName("#define CALG_TLS1_MASTER (ALG_CLASS_MSG_ENCRYPT|ALG_TYPE_SECURECHANNEL|ALG_SID_TLS1_MASTER)")]
    public const int CALG_TLS1_MASTER = ((2 << 13) | (6 << 9) | 6);

    [NativeTypeName("#define CALG_RC5 (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_RC5)")]
    public const int CALG_RC5 = ((3 << 13) | (3 << 9) | 13);

    [NativeTypeName("#define CALG_HMAC (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_HMAC)")]
    public const int CALG_HMAC = ((4 << 13) | (0) | 9);

    [NativeTypeName("#define CALG_TLS1PRF (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_TLS1PRF)")]
    public const int CALG_TLS1PRF = ((4 << 13) | (0) | 10);

    [NativeTypeName("#define CALG_HASH_REPLACE_OWF (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_HASH_REPLACE_OWF)")]
    public const int CALG_HASH_REPLACE_OWF = ((4 << 13) | (0) | 11);

    [NativeTypeName("#define CALG_AES_128 (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_AES_128)")]
    public const int CALG_AES_128 = ((3 << 13) | (3 << 9) | 14);

    [NativeTypeName("#define CALG_AES_192 (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_AES_192)")]
    public const int CALG_AES_192 = ((3 << 13) | (3 << 9) | 15);

    [NativeTypeName("#define CALG_AES_256 (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_AES_256)")]
    public const int CALG_AES_256 = ((3 << 13) | (3 << 9) | 16);

    [NativeTypeName("#define CALG_AES (ALG_CLASS_DATA_ENCRYPT|ALG_TYPE_BLOCK|ALG_SID_AES)")]
    public const int CALG_AES = ((3 << 13) | (3 << 9) | 17);

    [NativeTypeName("#define CALG_SHA_256 (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA_256)")]
    public const int CALG_SHA_256 = ((4 << 13) | (0) | 12);

    [NativeTypeName("#define CALG_SHA_384 (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA_384)")]
    public const int CALG_SHA_384 = ((4 << 13) | (0) | 13);

    [NativeTypeName("#define CALG_SHA_512 (ALG_CLASS_HASH | ALG_TYPE_ANY | ALG_SID_SHA_512)")]
    public const int CALG_SHA_512 = ((4 << 13) | (0) | 14);

    [NativeTypeName("#define CALG_ECDH (ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_DH | ALG_SID_ECDH)")]
    public const int CALG_ECDH = ((5 << 13) | (5 << 9) | 5);

    [NativeTypeName("#define CALG_ECDH_EPHEM (ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_ECDH | ALG_SID_ECDH_EPHEM)")]
    public const int CALG_ECDH_EPHEM = ((5 << 13) | (7 << 9) | 6);

    [NativeTypeName("#define CALG_ECMQV (ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_ANY | ALG_SID_ECMQV)")]
    public const int CALG_ECMQV = ((5 << 13) | (0) | 1);

    [NativeTypeName("#define CALG_ECDSA (ALG_CLASS_SIGNATURE | ALG_TYPE_DSS | ALG_SID_ECDSA)")]
    public const int CALG_ECDSA = ((1 << 13) | (1 << 9) | 3);

    [NativeTypeName("#define CALG_NULLCIPHER (ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_ANY | 0)")]
    public const int CALG_NULLCIPHER = ((3 << 13) | (0) | 0);

    [NativeTypeName("#define CALG_THIRDPARTY_KEY_EXCHANGE (ALG_CLASS_KEY_EXCHANGE | ALG_TYPE_THIRDPARTY | ALG_SID_THIRDPARTY_ANY)")]
    public const int CALG_THIRDPARTY_KEY_EXCHANGE = ((5 << 13) | (8 << 9) | (0));

    [NativeTypeName("#define CALG_THIRDPARTY_SIGNATURE (ALG_CLASS_SIGNATURE    | ALG_TYPE_THIRDPARTY | ALG_SID_THIRDPARTY_ANY)")]
    public const int CALG_THIRDPARTY_SIGNATURE = ((1 << 13) | (8 << 9) | (0));

    [NativeTypeName("#define CALG_THIRDPARTY_CIPHER (ALG_CLASS_DATA_ENCRYPT | ALG_TYPE_THIRDPARTY | ALG_SID_THIRDPARTY_ANY)")]
    public const int CALG_THIRDPARTY_CIPHER = ((3 << 13) | (8 << 9) | (0));

    [NativeTypeName("#define CALG_THIRDPARTY_HASH (ALG_CLASS_HASH         | ALG_TYPE_THIRDPARTY | ALG_SID_THIRDPARTY_ANY)")]
    public const int CALG_THIRDPARTY_HASH = ((4 << 13) | (8 << 9) | (0));

    [NativeTypeName("#define CALG_OID_INFO_CNG_ONLY 0xFFFFFFFF")]
    public const uint CALG_OID_INFO_CNG_ONLY = 0xFFFFFFFF;

    [NativeTypeName("#define CALG_OID_INFO_PARAMETERS 0xFFFFFFFE")]
    public const uint CALG_OID_INFO_PARAMETERS = 0xFFFFFFFE;
}
