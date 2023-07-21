// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class ALG
{
    [NativeTypeName("#define ALG_CLASS_ANY (0)")]
    public const int ALG_CLASS_ANY = (0);

    [NativeTypeName("#define ALG_CLASS_SIGNATURE (1 << 13)")]
    public const int ALG_CLASS_SIGNATURE = (1 << 13);

    [NativeTypeName("#define ALG_CLASS_MSG_ENCRYPT (2 << 13)")]
    public const int ALG_CLASS_MSG_ENCRYPT = (2 << 13);

    [NativeTypeName("#define ALG_CLASS_DATA_ENCRYPT (3 << 13)")]
    public const int ALG_CLASS_DATA_ENCRYPT = (3 << 13);

    [NativeTypeName("#define ALG_CLASS_HASH (4 << 13)")]
    public const int ALG_CLASS_HASH = (4 << 13);

    [NativeTypeName("#define ALG_CLASS_KEY_EXCHANGE (5 << 13)")]
    public const int ALG_CLASS_KEY_EXCHANGE = (5 << 13);

    [NativeTypeName("#define ALG_CLASS_ALL (7 << 13)")]
    public const int ALG_CLASS_ALL = (7 << 13);

    [NativeTypeName("#define ALG_TYPE_ANY (0)")]
    public const int ALG_TYPE_ANY = (0);

    [NativeTypeName("#define ALG_TYPE_DSS (1 << 9)")]
    public const int ALG_TYPE_DSS = (1 << 9);

    [NativeTypeName("#define ALG_TYPE_RSA (2 << 9)")]
    public const int ALG_TYPE_RSA = (2 << 9);

    [NativeTypeName("#define ALG_TYPE_BLOCK (3 << 9)")]
    public const int ALG_TYPE_BLOCK = (3 << 9);

    [NativeTypeName("#define ALG_TYPE_STREAM (4 << 9)")]
    public const int ALG_TYPE_STREAM = (4 << 9);

    [NativeTypeName("#define ALG_TYPE_DH (5 << 9)")]
    public const int ALG_TYPE_DH = (5 << 9);

    [NativeTypeName("#define ALG_TYPE_SECURECHANNEL (6 << 9)")]
    public const int ALG_TYPE_SECURECHANNEL = (6 << 9);

    [NativeTypeName("#define ALG_TYPE_ECDH (7 << 9)")]
    public const int ALG_TYPE_ECDH = (7 << 9);

    [NativeTypeName("#define ALG_TYPE_THIRDPARTY (8 << 9)")]
    public const int ALG_TYPE_THIRDPARTY = (8 << 9);

    [NativeTypeName("#define ALG_SID_ANY (0)")]
    public const int ALG_SID_ANY = (0);

    [NativeTypeName("#define ALG_SID_THIRDPARTY_ANY (0)")]
    public const int ALG_SID_THIRDPARTY_ANY = (0);

    [NativeTypeName("#define ALG_SID_RSA_ANY 0")]
    public const int ALG_SID_RSA_ANY = 0;

    [NativeTypeName("#define ALG_SID_RSA_PKCS 1")]
    public const int ALG_SID_RSA_PKCS = 1;

    [NativeTypeName("#define ALG_SID_RSA_MSATWORK 2")]
    public const int ALG_SID_RSA_MSATWORK = 2;

    [NativeTypeName("#define ALG_SID_RSA_ENTRUST 3")]
    public const int ALG_SID_RSA_ENTRUST = 3;

    [NativeTypeName("#define ALG_SID_RSA_PGP 4")]
    public const int ALG_SID_RSA_PGP = 4;

    [NativeTypeName("#define ALG_SID_DSS_ANY 0")]
    public const int ALG_SID_DSS_ANY = 0;

    [NativeTypeName("#define ALG_SID_DSS_PKCS 1")]
    public const int ALG_SID_DSS_PKCS = 1;

    [NativeTypeName("#define ALG_SID_DSS_DMS 2")]
    public const int ALG_SID_DSS_DMS = 2;

    [NativeTypeName("#define ALG_SID_ECDSA 3")]
    public const int ALG_SID_ECDSA = 3;

    [NativeTypeName("#define ALG_SID_DES 1")]
    public const int ALG_SID_DES = 1;

    [NativeTypeName("#define ALG_SID_3DES 3")]
    public const int ALG_SID_3DES = 3;

    [NativeTypeName("#define ALG_SID_DESX 4")]
    public const int ALG_SID_DESX = 4;

    [NativeTypeName("#define ALG_SID_IDEA 5")]
    public const int ALG_SID_IDEA = 5;

    [NativeTypeName("#define ALG_SID_CAST 6")]
    public const int ALG_SID_CAST = 6;

    [NativeTypeName("#define ALG_SID_SAFERSK64 7")]
    public const int ALG_SID_SAFERSK64 = 7;

    [NativeTypeName("#define ALG_SID_SAFERSK128 8")]
    public const int ALG_SID_SAFERSK128 = 8;

    [NativeTypeName("#define ALG_SID_3DES_112 9")]
    public const int ALG_SID_3DES_112 = 9;

    [NativeTypeName("#define ALG_SID_CYLINK_MEK 12")]
    public const int ALG_SID_CYLINK_MEK = 12;

    [NativeTypeName("#define ALG_SID_RC5 13")]
    public const int ALG_SID_RC5 = 13;

    [NativeTypeName("#define ALG_SID_AES_128 14")]
    public const int ALG_SID_AES_128 = 14;

    [NativeTypeName("#define ALG_SID_AES_192 15")]
    public const int ALG_SID_AES_192 = 15;

    [NativeTypeName("#define ALG_SID_AES_256 16")]
    public const int ALG_SID_AES_256 = 16;

    [NativeTypeName("#define ALG_SID_AES 17")]
    public const int ALG_SID_AES = 17;

    [NativeTypeName("#define ALG_SID_SKIPJACK 10")]
    public const int ALG_SID_SKIPJACK = 10;

    [NativeTypeName("#define ALG_SID_TEK 11")]
    public const int ALG_SID_TEK = 11;

    [NativeTypeName("#define ALG_SID_RC2 2")]
    public const int ALG_SID_RC2 = 2;

    [NativeTypeName("#define ALG_SID_RC4 1")]
    public const int ALG_SID_RC4 = 1;

    [NativeTypeName("#define ALG_SID_SEAL 2")]
    public const int ALG_SID_SEAL = 2;

    [NativeTypeName("#define ALG_SID_DH_SANDF 1")]
    public const int ALG_SID_DH_SANDF = 1;

    [NativeTypeName("#define ALG_SID_DH_EPHEM 2")]
    public const int ALG_SID_DH_EPHEM = 2;

    [NativeTypeName("#define ALG_SID_AGREED_KEY_ANY 3")]
    public const int ALG_SID_AGREED_KEY_ANY = 3;

    [NativeTypeName("#define ALG_SID_KEA 4")]
    public const int ALG_SID_KEA = 4;

    [NativeTypeName("#define ALG_SID_ECDH 5")]
    public const int ALG_SID_ECDH = 5;

    [NativeTypeName("#define ALG_SID_ECDH_EPHEM 6")]
    public const int ALG_SID_ECDH_EPHEM = 6;

    [NativeTypeName("#define ALG_SID_MD2 1")]
    public const int ALG_SID_MD2 = 1;

    [NativeTypeName("#define ALG_SID_MD4 2")]
    public const int ALG_SID_MD4 = 2;

    [NativeTypeName("#define ALG_SID_MD5 3")]
    public const int ALG_SID_MD5 = 3;

    [NativeTypeName("#define ALG_SID_SHA 4")]
    public const int ALG_SID_SHA = 4;

    [NativeTypeName("#define ALG_SID_SHA1 4")]
    public const int ALG_SID_SHA1 = 4;

    [NativeTypeName("#define ALG_SID_MAC 5")]
    public const int ALG_SID_MAC = 5;

    [NativeTypeName("#define ALG_SID_RIPEMD 6")]
    public const int ALG_SID_RIPEMD = 6;

    [NativeTypeName("#define ALG_SID_RIPEMD160 7")]
    public const int ALG_SID_RIPEMD160 = 7;

    [NativeTypeName("#define ALG_SID_SSL3SHAMD5 8")]
    public const int ALG_SID_SSL3SHAMD5 = 8;

    [NativeTypeName("#define ALG_SID_HMAC 9")]
    public const int ALG_SID_HMAC = 9;

    [NativeTypeName("#define ALG_SID_TLS1PRF 10")]
    public const int ALG_SID_TLS1PRF = 10;

    [NativeTypeName("#define ALG_SID_HASH_REPLACE_OWF 11")]
    public const int ALG_SID_HASH_REPLACE_OWF = 11;

    [NativeTypeName("#define ALG_SID_SHA_256 12")]
    public const int ALG_SID_SHA_256 = 12;

    [NativeTypeName("#define ALG_SID_SHA_384 13")]
    public const int ALG_SID_SHA_384 = 13;

    [NativeTypeName("#define ALG_SID_SHA_512 14")]
    public const int ALG_SID_SHA_512 = 14;

    [NativeTypeName("#define ALG_SID_SSL3_MASTER 1")]
    public const int ALG_SID_SSL3_MASTER = 1;

    [NativeTypeName("#define ALG_SID_SCHANNEL_MASTER_HASH 2")]
    public const int ALG_SID_SCHANNEL_MASTER_HASH = 2;

    [NativeTypeName("#define ALG_SID_SCHANNEL_MAC_KEY 3")]
    public const int ALG_SID_SCHANNEL_MAC_KEY = 3;

    [NativeTypeName("#define ALG_SID_PCT1_MASTER 4")]
    public const int ALG_SID_PCT1_MASTER = 4;

    [NativeTypeName("#define ALG_SID_SSL2_MASTER 5")]
    public const int ALG_SID_SSL2_MASTER = 5;

    [NativeTypeName("#define ALG_SID_TLS1_MASTER 6")]
    public const int ALG_SID_TLS1_MASTER = 6;

    [NativeTypeName("#define ALG_SID_SCHANNEL_ENC_KEY 7")]
    public const int ALG_SID_SCHANNEL_ENC_KEY = 7;

    [NativeTypeName("#define ALG_SID_ECMQV 1")]
    public const int ALG_SID_ECMQV = 1;

    [NativeTypeName("#define ALG_SID_EXAMPLE 80")]
    public const int ALG_SID_EXAMPLE = 80;
}
