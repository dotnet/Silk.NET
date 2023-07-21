// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static unsafe partial class PKCS
{
    [NativeTypeName("#define PKCS_7_ASN_ENCODING 0x00010000")]
    public const int PKCS_7_ASN_ENCODING = 0x00010000;

    [NativeTypeName("#define PKCS_7_NDR_ENCODING 0x00020000")]
    public const int PKCS_7_NDR_ENCODING = 0x00020000;

    [NativeTypeName("#define PKCS_UTC_TIME ((LPCSTR) 17)")]
    public static sbyte* PKCS_UTC_TIME => ((sbyte*)(17));

    [NativeTypeName("#define PKCS_TIME_REQUEST ((LPCSTR) 18)")]
    public static sbyte* PKCS_TIME_REQUEST => ((sbyte*)(18));

    [NativeTypeName("#define PKCS_ATTRIBUTE ((LPCSTR) 22)")]
    public static sbyte* PKCS_ATTRIBUTE => ((sbyte*)(22));

    [NativeTypeName("#define PKCS_CONTENT_INFO_SEQUENCE_OF_ANY ((LPCSTR) 23)")]
    public static sbyte* PKCS_CONTENT_INFO_SEQUENCE_OF_ANY => ((sbyte*)(23));

    [NativeTypeName("#define PKCS_CONTENT_INFO ((LPCSTR) 33)")]
    public static sbyte* PKCS_CONTENT_INFO => ((sbyte*)(33));

    [NativeTypeName("#define PKCS_CTL ((LPCSTR) 37)")]
    public static sbyte* PKCS_CTL => ((sbyte*)(37));

    [NativeTypeName("#define PKCS_RC2_CBC_PARAMETERS ((LPCSTR) 41)")]
    public static sbyte* PKCS_RC2_CBC_PARAMETERS => ((sbyte*)(41));

    [NativeTypeName("#define PKCS_SMIME_CAPABILITIES ((LPCSTR) 42)")]
    public static sbyte* PKCS_SMIME_CAPABILITIES => ((sbyte*)(42));

    [NativeTypeName("#define PKCS_RSA_PRIVATE_KEY ((LPCSTR) 43)")]
    public static sbyte* PKCS_RSA_PRIVATE_KEY => ((sbyte*)(43));

    [NativeTypeName("#define PKCS_PRIVATE_KEY_INFO ((LPCSTR) 44)")]
    public static sbyte* PKCS_PRIVATE_KEY_INFO => ((sbyte*)(44));

    [NativeTypeName("#define PKCS_ENCRYPTED_PRIVATE_KEY_INFO ((LPCSTR) 45)")]
    public static sbyte* PKCS_ENCRYPTED_PRIVATE_KEY_INFO => ((sbyte*)(45));

    [NativeTypeName("#define PKCS_ATTRIBUTES ((LPCSTR) 48)")]
    public static sbyte* PKCS_ATTRIBUTES => ((sbyte*)(48));

    [NativeTypeName("#define PKCS_SORTED_CTL ((LPCSTR) 49)")]
    public static sbyte* PKCS_SORTED_CTL => ((sbyte*)(49));

    [NativeTypeName("#define PKCS_RSA_SSA_PSS_PARAMETERS ((LPCSTR) 75)")]
    public static sbyte* PKCS_RSA_SSA_PSS_PARAMETERS => ((sbyte*)(75));

    [NativeTypeName("#define PKCS_RSAES_OAEP_PARAMETERS ((LPCSTR) 76)")]
    public static sbyte* PKCS_RSAES_OAEP_PARAMETERS => ((sbyte*)(76));

    [NativeTypeName("#define PKCS_RSA_SSA_PSS_TRAILER_FIELD_BC 1")]
    public const int PKCS_RSA_SSA_PSS_TRAILER_FIELD_BC = 1;
}
