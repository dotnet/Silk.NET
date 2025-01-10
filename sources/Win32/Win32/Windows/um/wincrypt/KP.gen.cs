// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class KP
{
    [NativeTypeName("#define KP_IV 1")]
    public const int KP_IV = 1;

    [NativeTypeName("#define KP_SALT 2")]
    public const int KP_SALT = 2;

    [NativeTypeName("#define KP_PADDING 3")]
    public const int KP_PADDING = 3;

    [NativeTypeName("#define KP_MODE 4")]
    public const int KP_MODE = 4;

    [NativeTypeName("#define KP_MODE_BITS 5")]
    public const int KP_MODE_BITS = 5;

    [NativeTypeName("#define KP_PERMISSIONS 6")]
    public const int KP_PERMISSIONS = 6;

    [NativeTypeName("#define KP_ALGID 7")]
    public const int KP_ALGID = 7;

    [NativeTypeName("#define KP_BLOCKLEN 8")]
    public const int KP_BLOCKLEN = 8;

    [NativeTypeName("#define KP_KEYLEN 9")]
    public const int KP_KEYLEN = 9;

    [NativeTypeName("#define KP_SALT_EX 10")]
    public const int KP_SALT_EX = 10;

    [NativeTypeName("#define KP_P 11")]
    public const int KP_P = 11;

    [NativeTypeName("#define KP_G 12")]
    public const int KP_G = 12;

    [NativeTypeName("#define KP_Q 13")]
    public const int KP_Q = 13;

    [NativeTypeName("#define KP_X 14")]
    public const int KP_X = 14;

    [NativeTypeName("#define KP_Y 15")]
    public const int KP_Y = 15;

    [NativeTypeName("#define KP_RA 16")]
    public const int KP_RA = 16;

    [NativeTypeName("#define KP_RB 17")]
    public const int KP_RB = 17;

    [NativeTypeName("#define KP_INFO 18")]
    public const int KP_INFO = 18;

    [NativeTypeName("#define KP_EFFECTIVE_KEYLEN 19")]
    public const int KP_EFFECTIVE_KEYLEN = 19;

    [NativeTypeName("#define KP_SCHANNEL_ALG 20")]
    public const int KP_SCHANNEL_ALG = 20;

    [NativeTypeName("#define KP_CLIENT_RANDOM 21")]
    public const int KP_CLIENT_RANDOM = 21;

    [NativeTypeName("#define KP_SERVER_RANDOM 22")]
    public const int KP_SERVER_RANDOM = 22;

    [NativeTypeName("#define KP_RP 23")]
    public const int KP_RP = 23;

    [NativeTypeName("#define KP_PRECOMP_MD5 24")]
    public const int KP_PRECOMP_MD5 = 24;

    [NativeTypeName("#define KP_PRECOMP_SHA 25")]
    public const int KP_PRECOMP_SHA = 25;

    [NativeTypeName("#define KP_CERTIFICATE 26")]
    public const int KP_CERTIFICATE = 26;

    [NativeTypeName("#define KP_CLEAR_KEY 27")]
    public const int KP_CLEAR_KEY = 27;

    [NativeTypeName("#define KP_PUB_EX_LEN 28")]
    public const int KP_PUB_EX_LEN = 28;

    [NativeTypeName("#define KP_PUB_EX_VAL 29")]
    public const int KP_PUB_EX_VAL = 29;

    [NativeTypeName("#define KP_KEYVAL 30")]
    public const int KP_KEYVAL = 30;

    [NativeTypeName("#define KP_ADMIN_PIN 31")]
    public const int KP_ADMIN_PIN = 31;

    [NativeTypeName("#define KP_KEYEXCHANGE_PIN 32")]
    public const int KP_KEYEXCHANGE_PIN = 32;

    [NativeTypeName("#define KP_SIGNATURE_PIN 33")]
    public const int KP_SIGNATURE_PIN = 33;

    [NativeTypeName("#define KP_PREHASH 34")]
    public const int KP_PREHASH = 34;

    [NativeTypeName("#define KP_ROUNDS 35")]
    public const int KP_ROUNDS = 35;

    [NativeTypeName("#define KP_OAEP_PARAMS 36")]
    public const int KP_OAEP_PARAMS = 36;

    [NativeTypeName("#define KP_CMS_KEY_INFO 37")]
    public const int KP_CMS_KEY_INFO = 37;

    [NativeTypeName("#define KP_CMS_DH_KEY_INFO 38")]
    public const int KP_CMS_DH_KEY_INFO = 38;

    [NativeTypeName("#define KP_PUB_PARAMS 39")]
    public const int KP_PUB_PARAMS = 39;

    [NativeTypeName("#define KP_VERIFY_PARAMS 40")]
    public const int KP_VERIFY_PARAMS = 40;

    [NativeTypeName("#define KP_HIGHEST_VERSION 41")]
    public const int KP_HIGHEST_VERSION = 41;

    [NativeTypeName("#define KP_GET_USE_COUNT 42")]
    public const int KP_GET_USE_COUNT = 42;

    [NativeTypeName("#define KP_PIN_ID 43")]
    public const int KP_PIN_ID = 43;

    [NativeTypeName("#define KP_PIN_INFO 44")]
    public const int KP_PIN_INFO = 44;
}
