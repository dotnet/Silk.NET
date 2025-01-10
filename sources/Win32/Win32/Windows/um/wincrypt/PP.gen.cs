// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class PP
{
    [NativeTypeName("#define PP_ENUMALGS 1")]
    public const int PP_ENUMALGS = 1;

    [NativeTypeName("#define PP_ENUMCONTAINERS 2")]
    public const int PP_ENUMCONTAINERS = 2;

    [NativeTypeName("#define PP_IMPTYPE 3")]
    public const int PP_IMPTYPE = 3;

    [NativeTypeName("#define PP_NAME 4")]
    public const int PP_NAME = 4;

    [NativeTypeName("#define PP_VERSION 5")]
    public const int PP_VERSION = 5;

    [NativeTypeName("#define PP_CONTAINER 6")]
    public const int PP_CONTAINER = 6;

    [NativeTypeName("#define PP_CHANGE_PASSWORD 7")]
    public const int PP_CHANGE_PASSWORD = 7;

    [NativeTypeName("#define PP_KEYSET_SEC_DESCR 8")]
    public const int PP_KEYSET_SEC_DESCR = 8;

    [NativeTypeName("#define PP_CERTCHAIN 9")]
    public const int PP_CERTCHAIN = 9;

    [NativeTypeName("#define PP_KEY_TYPE_SUBTYPE 10")]
    public const int PP_KEY_TYPE_SUBTYPE = 10;

    [NativeTypeName("#define PP_PROVTYPE 16")]
    public const int PP_PROVTYPE = 16;

    [NativeTypeName("#define PP_KEYSTORAGE 17")]
    public const int PP_KEYSTORAGE = 17;

    [NativeTypeName("#define PP_APPLI_CERT 18")]
    public const int PP_APPLI_CERT = 18;

    [NativeTypeName("#define PP_SYM_KEYSIZE 19")]
    public const int PP_SYM_KEYSIZE = 19;

    [NativeTypeName("#define PP_SESSION_KEYSIZE 20")]
    public const int PP_SESSION_KEYSIZE = 20;

    [NativeTypeName("#define PP_UI_PROMPT 21")]
    public const int PP_UI_PROMPT = 21;

    [NativeTypeName("#define PP_ENUMALGS_EX 22")]
    public const int PP_ENUMALGS_EX = 22;

    [NativeTypeName("#define PP_ENUMMANDROOTS 25")]
    public const int PP_ENUMMANDROOTS = 25;

    [NativeTypeName("#define PP_ENUMELECTROOTS 26")]
    public const int PP_ENUMELECTROOTS = 26;

    [NativeTypeName("#define PP_KEYSET_TYPE 27")]
    public const int PP_KEYSET_TYPE = 27;

    [NativeTypeName("#define PP_ADMIN_PIN 31")]
    public const int PP_ADMIN_PIN = 31;

    [NativeTypeName("#define PP_KEYEXCHANGE_PIN 32")]
    public const int PP_KEYEXCHANGE_PIN = 32;

    [NativeTypeName("#define PP_SIGNATURE_PIN 33")]
    public const int PP_SIGNATURE_PIN = 33;

    [NativeTypeName("#define PP_SIG_KEYSIZE_INC 34")]
    public const int PP_SIG_KEYSIZE_INC = 34;

    [NativeTypeName("#define PP_KEYX_KEYSIZE_INC 35")]
    public const int PP_KEYX_KEYSIZE_INC = 35;

    [NativeTypeName("#define PP_UNIQUE_CONTAINER 36")]
    public const int PP_UNIQUE_CONTAINER = 36;

    [NativeTypeName("#define PP_SGC_INFO 37")]
    public const int PP_SGC_INFO = 37;

    [NativeTypeName("#define PP_USE_HARDWARE_RNG 38")]
    public const int PP_USE_HARDWARE_RNG = 38;

    [NativeTypeName("#define PP_KEYSPEC 39")]
    public const int PP_KEYSPEC = 39;

    [NativeTypeName("#define PP_ENUMEX_SIGNING_PROT 40")]
    public const int PP_ENUMEX_SIGNING_PROT = 40;

    [NativeTypeName("#define PP_CRYPT_COUNT_KEY_USE 41")]
    public const int PP_CRYPT_COUNT_KEY_USE = 41;

    [NativeTypeName("#define PP_USER_CERTSTORE 42")]
    public const int PP_USER_CERTSTORE = 42;

    [NativeTypeName("#define PP_SMARTCARD_READER 43")]
    public const int PP_SMARTCARD_READER = 43;

    [NativeTypeName("#define PP_SMARTCARD_GUID 45")]
    public const int PP_SMARTCARD_GUID = 45;

    [NativeTypeName("#define PP_ROOT_CERTSTORE 46")]
    public const int PP_ROOT_CERTSTORE = 46;

    [NativeTypeName("#define PP_SMARTCARD_READER_ICON 47")]
    public const int PP_SMARTCARD_READER_ICON = 47;

    [NativeTypeName("#define PP_CLIENT_HWND 1")]
    public const int PP_CLIENT_HWND = 1;

    [NativeTypeName("#define PP_CONTEXT_INFO 11")]
    public const int PP_CONTEXT_INFO = 11;

    [NativeTypeName("#define PP_KEYEXCHANGE_KEYSIZE 12")]
    public const int PP_KEYEXCHANGE_KEYSIZE = 12;

    [NativeTypeName("#define PP_SIGNATURE_KEYSIZE 13")]
    public const int PP_SIGNATURE_KEYSIZE = 13;

    [NativeTypeName("#define PP_KEYEXCHANGE_ALG 14")]
    public const int PP_KEYEXCHANGE_ALG = 14;

    [NativeTypeName("#define PP_SIGNATURE_ALG 15")]
    public const int PP_SIGNATURE_ALG = 15;

    [NativeTypeName("#define PP_DELETEKEY 24")]
    public const int PP_DELETEKEY = 24;

    [NativeTypeName("#define PP_PIN_PROMPT_STRING 44")]
    public const int PP_PIN_PROMPT_STRING = 44;

    [NativeTypeName("#define PP_SECURE_KEYEXCHANGE_PIN 47")]
    public const int PP_SECURE_KEYEXCHANGE_PIN = 47;

    [NativeTypeName("#define PP_SECURE_SIGNATURE_PIN 48")]
    public const int PP_SECURE_SIGNATURE_PIN = 48;

    [NativeTypeName("#define PP_DISMISS_PIN_UI_SEC 49")]
    public const int PP_DISMISS_PIN_UI_SEC = 49;

    [NativeTypeName("#define PP_IS_PFX_EPHEMERAL 50")]
    public const int PP_IS_PFX_EPHEMERAL = 50;
}
