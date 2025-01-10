// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MS
{
    [NativeTypeName("#define MS_DEF_PROV_A \"Microsoft Base Cryptographic Provider v1.0\"")]
    public static ReadOnlySpan<byte> MS_DEF_PROV_A =>
        "Microsoft Base Cryptographic Provider v1.0"u8;

    [NativeTypeName("#define MS_DEF_PROV_W L\"Microsoft Base Cryptographic Provider v1.0\"")]
    public const string MS_DEF_PROV_W = "Microsoft Base Cryptographic Provider v1.0";

    [NativeTypeName("#define MS_DEF_PROV MS_DEF_PROV_W")]
    public const string MS_DEF_PROV = "Microsoft Base Cryptographic Provider v1.0";

    [NativeTypeName(
        "#define MS_ENHANCED_PROV_A \"Microsoft Enhanced Cryptographic Provider v1.0\""
    )]
    public static ReadOnlySpan<byte> MS_ENHANCED_PROV_A =>
        "Microsoft Enhanced Cryptographic Provider v1.0"u8;

    [NativeTypeName(
        "#define MS_ENHANCED_PROV_W L\"Microsoft Enhanced Cryptographic Provider v1.0\""
    )]
    public const string MS_ENHANCED_PROV_W = "Microsoft Enhanced Cryptographic Provider v1.0";

    [NativeTypeName("#define MS_ENHANCED_PROV MS_ENHANCED_PROV_W")]
    public const string MS_ENHANCED_PROV = "Microsoft Enhanced Cryptographic Provider v1.0";

    [NativeTypeName("#define MS_STRONG_PROV_A \"Microsoft Strong Cryptographic Provider\"")]
    public static ReadOnlySpan<byte> MS_STRONG_PROV_A =>
        "Microsoft Strong Cryptographic Provider"u8;

    [NativeTypeName("#define MS_STRONG_PROV_W L\"Microsoft Strong Cryptographic Provider\"")]
    public const string MS_STRONG_PROV_W = "Microsoft Strong Cryptographic Provider";

    [NativeTypeName("#define MS_STRONG_PROV MS_STRONG_PROV_W")]
    public const string MS_STRONG_PROV = "Microsoft Strong Cryptographic Provider";

    [NativeTypeName(
        "#define MS_DEF_RSA_SIG_PROV_A \"Microsoft RSA Signature Cryptographic Provider\""
    )]
    public static ReadOnlySpan<byte> MS_DEF_RSA_SIG_PROV_A =>
        "Microsoft RSA Signature Cryptographic Provider"u8;

    [NativeTypeName(
        "#define MS_DEF_RSA_SIG_PROV_W L\"Microsoft RSA Signature Cryptographic Provider\""
    )]
    public const string MS_DEF_RSA_SIG_PROV_W = "Microsoft RSA Signature Cryptographic Provider";

    [NativeTypeName("#define MS_DEF_RSA_SIG_PROV MS_DEF_RSA_SIG_PROV_W")]
    public const string MS_DEF_RSA_SIG_PROV = "Microsoft RSA Signature Cryptographic Provider";

    [NativeTypeName(
        "#define MS_DEF_RSA_SCHANNEL_PROV_A \"Microsoft RSA SChannel Cryptographic Provider\""
    )]
    public static ReadOnlySpan<byte> MS_DEF_RSA_SCHANNEL_PROV_A =>
        "Microsoft RSA SChannel Cryptographic Provider"u8;

    [NativeTypeName(
        "#define MS_DEF_RSA_SCHANNEL_PROV_W L\"Microsoft RSA SChannel Cryptographic Provider\""
    )]
    public const string MS_DEF_RSA_SCHANNEL_PROV_W =
        "Microsoft RSA SChannel Cryptographic Provider";

    [NativeTypeName("#define MS_DEF_RSA_SCHANNEL_PROV MS_DEF_RSA_SCHANNEL_PROV_W")]
    public const string MS_DEF_RSA_SCHANNEL_PROV = "Microsoft RSA SChannel Cryptographic Provider";

    [NativeTypeName("#define MS_DEF_DSS_PROV_A \"Microsoft Base DSS Cryptographic Provider\"")]
    public static ReadOnlySpan<byte> MS_DEF_DSS_PROV_A =>
        "Microsoft Base DSS Cryptographic Provider"u8;

    [NativeTypeName("#define MS_DEF_DSS_PROV_W L\"Microsoft Base DSS Cryptographic Provider\"")]
    public const string MS_DEF_DSS_PROV_W = "Microsoft Base DSS Cryptographic Provider";

    [NativeTypeName("#define MS_DEF_DSS_PROV MS_DEF_DSS_PROV_W")]
    public const string MS_DEF_DSS_PROV = "Microsoft Base DSS Cryptographic Provider";

    [NativeTypeName(
        "#define MS_DEF_DSS_DH_PROV_A \"Microsoft Base DSS and Diffie-Hellman Cryptographic Provider\""
    )]
    public static ReadOnlySpan<byte> MS_DEF_DSS_DH_PROV_A =>
        "Microsoft Base DSS and Diffie-Hellman Cryptographic Provider"u8;

    [NativeTypeName(
        "#define MS_DEF_DSS_DH_PROV_W L\"Microsoft Base DSS and Diffie-Hellman Cryptographic Provider\""
    )]
    public const string MS_DEF_DSS_DH_PROV_W =
        "Microsoft Base DSS and Diffie-Hellman Cryptographic Provider";

    [NativeTypeName("#define MS_DEF_DSS_DH_PROV MS_DEF_DSS_DH_PROV_W")]
    public const string MS_DEF_DSS_DH_PROV =
        "Microsoft Base DSS and Diffie-Hellman Cryptographic Provider";

    [NativeTypeName(
        "#define MS_ENH_DSS_DH_PROV_A \"Microsoft Enhanced DSS and Diffie-Hellman Cryptographic Provider\""
    )]
    public static ReadOnlySpan<byte> MS_ENH_DSS_DH_PROV_A =>
        "Microsoft Enhanced DSS and Diffie-Hellman Cryptographic Provider"u8;

    [NativeTypeName(
        "#define MS_ENH_DSS_DH_PROV_W L\"Microsoft Enhanced DSS and Diffie-Hellman Cryptographic Provider\""
    )]
    public const string MS_ENH_DSS_DH_PROV_W =
        "Microsoft Enhanced DSS and Diffie-Hellman Cryptographic Provider";

    [NativeTypeName("#define MS_ENH_DSS_DH_PROV MS_ENH_DSS_DH_PROV_W")]
    public const string MS_ENH_DSS_DH_PROV =
        "Microsoft Enhanced DSS and Diffie-Hellman Cryptographic Provider";

    [NativeTypeName(
        "#define MS_DEF_DH_SCHANNEL_PROV_A \"Microsoft DH SChannel Cryptographic Provider\""
    )]
    public static ReadOnlySpan<byte> MS_DEF_DH_SCHANNEL_PROV_A =>
        "Microsoft DH SChannel Cryptographic Provider"u8;

    [NativeTypeName(
        "#define MS_DEF_DH_SCHANNEL_PROV_W L\"Microsoft DH SChannel Cryptographic Provider\""
    )]
    public const string MS_DEF_DH_SCHANNEL_PROV_W = "Microsoft DH SChannel Cryptographic Provider";

    [NativeTypeName("#define MS_DEF_DH_SCHANNEL_PROV MS_DEF_DH_SCHANNEL_PROV_W")]
    public const string MS_DEF_DH_SCHANNEL_PROV = "Microsoft DH SChannel Cryptographic Provider";

    [NativeTypeName("#define MS_SCARD_PROV_A \"Microsoft Base Smart Card Crypto Provider\"")]
    public static ReadOnlySpan<byte> MS_SCARD_PROV_A =>
        "Microsoft Base Smart Card Crypto Provider"u8;

    [NativeTypeName("#define MS_SCARD_PROV_W L\"Microsoft Base Smart Card Crypto Provider\"")]
    public const string MS_SCARD_PROV_W = "Microsoft Base Smart Card Crypto Provider";

    [NativeTypeName("#define MS_SCARD_PROV MS_SCARD_PROV_W")]
    public const string MS_SCARD_PROV = "Microsoft Base Smart Card Crypto Provider";

    [NativeTypeName(
        "#define MS_ENH_RSA_AES_PROV_A \"Microsoft Enhanced RSA and AES Cryptographic Provider\""
    )]
    public static ReadOnlySpan<byte> MS_ENH_RSA_AES_PROV_A =>
        "Microsoft Enhanced RSA and AES Cryptographic Provider"u8;

    [NativeTypeName(
        "#define MS_ENH_RSA_AES_PROV_W L\"Microsoft Enhanced RSA and AES Cryptographic Provider\""
    )]
    public const string MS_ENH_RSA_AES_PROV_W =
        "Microsoft Enhanced RSA and AES Cryptographic Provider";

    [NativeTypeName(
        "#define MS_ENH_RSA_AES_PROV_XP_A \"Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype)\""
    )]
    public static ReadOnlySpan<byte> MS_ENH_RSA_AES_PROV_XP_A =>
        "Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype)"u8;

    [NativeTypeName(
        "#define MS_ENH_RSA_AES_PROV_XP_W L\"Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype)\""
    )]
    public const string MS_ENH_RSA_AES_PROV_XP_W =
        "Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype)";

    [NativeTypeName("#define MS_ENH_RSA_AES_PROV_XP MS_ENH_RSA_AES_PROV_XP_W")]
    public const string MS_ENH_RSA_AES_PROV_XP =
        "Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype)";

    [NativeTypeName("#define MS_ENH_RSA_AES_PROV MS_ENH_RSA_AES_PROV_W")]
    public const string MS_ENH_RSA_AES_PROV =
        "Microsoft Enhanced RSA and AES Cryptographic Provider";
}
