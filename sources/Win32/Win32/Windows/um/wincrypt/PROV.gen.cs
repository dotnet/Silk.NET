// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class PROV
{
    [NativeTypeName("#define PROV_RSA_FULL 1")]
    public const int PROV_RSA_FULL = 1;

    [NativeTypeName("#define PROV_RSA_SIG 2")]
    public const int PROV_RSA_SIG = 2;

    [NativeTypeName("#define PROV_DSS 3")]
    public const int PROV_DSS = 3;

    [NativeTypeName("#define PROV_FORTEZZA 4")]
    public const int PROV_FORTEZZA = 4;

    [NativeTypeName("#define PROV_MS_EXCHANGE 5")]
    public const int PROV_MS_EXCHANGE = 5;

    [NativeTypeName("#define PROV_SSL 6")]
    public const int PROV_SSL = 6;

    [NativeTypeName("#define PROV_RSA_SCHANNEL 12")]
    public const int PROV_RSA_SCHANNEL = 12;

    [NativeTypeName("#define PROV_DSS_DH 13")]
    public const int PROV_DSS_DH = 13;

    [NativeTypeName("#define PROV_EC_ECDSA_SIG 14")]
    public const int PROV_EC_ECDSA_SIG = 14;

    [NativeTypeName("#define PROV_EC_ECNRA_SIG 15")]
    public const int PROV_EC_ECNRA_SIG = 15;

    [NativeTypeName("#define PROV_EC_ECDSA_FULL 16")]
    public const int PROV_EC_ECDSA_FULL = 16;

    [NativeTypeName("#define PROV_EC_ECNRA_FULL 17")]
    public const int PROV_EC_ECNRA_FULL = 17;

    [NativeTypeName("#define PROV_DH_SCHANNEL 18")]
    public const int PROV_DH_SCHANNEL = 18;

    [NativeTypeName("#define PROV_SPYRUS_LYNKS 20")]
    public const int PROV_SPYRUS_LYNKS = 20;

    [NativeTypeName("#define PROV_RNG 21")]
    public const int PROV_RNG = 21;

    [NativeTypeName("#define PROV_INTEL_SEC 22")]
    public const int PROV_INTEL_SEC = 22;

    [NativeTypeName("#define PROV_REPLACE_OWF 23")]
    public const int PROV_REPLACE_OWF = 23;

    [NativeTypeName("#define PROV_RSA_AES 24")]
    public const int PROV_RSA_AES = 24;
}
