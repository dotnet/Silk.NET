// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class TRUST
{
    [NativeTypeName("#define TRUST_DIRECTION_DISABLED 0x00000000")]
    public const int TRUST_DIRECTION_DISABLED = 0x00000000;
    [NativeTypeName("#define TRUST_DIRECTION_INBOUND 0x00000001")]
    public const int TRUST_DIRECTION_INBOUND = 0x00000001;
    [NativeTypeName("#define TRUST_DIRECTION_OUTBOUND 0x00000002")]
    public const int TRUST_DIRECTION_OUTBOUND = 0x00000002;
    [NativeTypeName("#define TRUST_DIRECTION_BIDIRECTIONAL (TRUST_DIRECTION_INBOUND | TRUST_DIRECTION_OUTBOUND)")]
    public const int TRUST_DIRECTION_BIDIRECTIONAL = (0x00000001 | 0x00000002);
    [NativeTypeName("#define TRUST_TYPE_DOWNLEVEL 0x00000001")]
    public const int TRUST_TYPE_DOWNLEVEL = 0x00000001;
    [NativeTypeName("#define TRUST_TYPE_UPLEVEL 0x00000002")]
    public const int TRUST_TYPE_UPLEVEL = 0x00000002;
    [NativeTypeName("#define TRUST_TYPE_MIT 0x00000003")]
    public const int TRUST_TYPE_MIT = 0x00000003;
    [NativeTypeName("#define TRUST_TYPE_AAD 0x00000005")]
    public const int TRUST_TYPE_AAD = 0x00000005;
    [NativeTypeName("#define TRUST_ATTRIBUTE_NON_TRANSITIVE 0x00000001")]
    public const int TRUST_ATTRIBUTE_NON_TRANSITIVE = 0x00000001;
    [NativeTypeName("#define TRUST_ATTRIBUTE_UPLEVEL_ONLY 0x00000002")]
    public const int TRUST_ATTRIBUTE_UPLEVEL_ONLY = 0x00000002;
    [NativeTypeName("#define TRUST_ATTRIBUTE_QUARANTINED_DOMAIN 0x00000004")]
    public const int TRUST_ATTRIBUTE_QUARANTINED_DOMAIN = 0x00000004;
    [NativeTypeName("#define TRUST_ATTRIBUTE_FOREST_TRANSITIVE 0x00000008")]
    public const int TRUST_ATTRIBUTE_FOREST_TRANSITIVE = 0x00000008;
    [NativeTypeName("#define TRUST_ATTRIBUTE_CROSS_ORGANIZATION 0x00000010")]
    public const int TRUST_ATTRIBUTE_CROSS_ORGANIZATION = 0x00000010;
    [NativeTypeName("#define TRUST_ATTRIBUTE_WITHIN_FOREST 0x00000020")]
    public const int TRUST_ATTRIBUTE_WITHIN_FOREST = 0x00000020;
    [NativeTypeName("#define TRUST_ATTRIBUTE_TREAT_AS_EXTERNAL 0x00000040")]
    public const int TRUST_ATTRIBUTE_TREAT_AS_EXTERNAL = 0x00000040;
    [NativeTypeName("#define TRUST_ATTRIBUTE_TRUST_USES_RC4_ENCRYPTION 0x00000080")]
    public const int TRUST_ATTRIBUTE_TRUST_USES_RC4_ENCRYPTION = 0x00000080;
    [NativeTypeName("#define TRUST_ATTRIBUTE_TRUST_USES_AES_KEYS 0x00000100")]
    public const int TRUST_ATTRIBUTE_TRUST_USES_AES_KEYS = 0x00000100;
    [NativeTypeName("#define TRUST_ATTRIBUTE_CROSS_ORGANIZATION_NO_TGT_DELEGATION 0x00000200")]
    public const int TRUST_ATTRIBUTE_CROSS_ORGANIZATION_NO_TGT_DELEGATION = 0x00000200;
    [NativeTypeName("#define TRUST_ATTRIBUTE_PIM_TRUST 0x00000400")]
    public const int TRUST_ATTRIBUTE_PIM_TRUST = 0x00000400;
    [NativeTypeName("#define TRUST_ATTRIBUTE_CROSS_ORGANIZATION_ENABLE_TGT_DELEGATION 0x00000800")]
    public const int TRUST_ATTRIBUTE_CROSS_ORGANIZATION_ENABLE_TGT_DELEGATION = 0x00000800;
    [NativeTypeName("#define TRUST_ATTRIBUTE_DISABLE_AUTH_TARGET_VALIDATION 0x00001000")]
    public const int TRUST_ATTRIBUTE_DISABLE_AUTH_TARGET_VALIDATION = 0x00001000;
    [NativeTypeName("#define TRUST_AUTH_TYPE_NONE 0")]
    public const int TRUST_AUTH_TYPE_NONE = 0;
    [NativeTypeName("#define TRUST_AUTH_TYPE_NT4OWF 1")]
    public const int TRUST_AUTH_TYPE_NT4OWF = 1;
    [NativeTypeName("#define TRUST_AUTH_TYPE_CLEAR 2")]
    public const int TRUST_AUTH_TYPE_CLEAR = 2;
    [NativeTypeName("#define TRUST_AUTH_TYPE_VERSION 3")]
    public const int TRUST_AUTH_TYPE_VERSION = 3;
}