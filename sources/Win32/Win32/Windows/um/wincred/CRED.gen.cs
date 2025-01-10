// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CRED
{
    [NativeTypeName("#define CRED_MAX_STRING_LENGTH 256")]
    public const int CRED_MAX_STRING_LENGTH = 256;

    [NativeTypeName("#define CRED_MAX_USERNAME_LENGTH (256+1+256)")]
    public const int CRED_MAX_USERNAME_LENGTH = (256 + 1 + 256);

    [NativeTypeName("#define CRED_MAX_GENERIC_TARGET_NAME_LENGTH 32767")]
    public const int CRED_MAX_GENERIC_TARGET_NAME_LENGTH = 32767;

    [NativeTypeName("#define CRED_MAX_DOMAIN_TARGET_NAME_LENGTH (256+1+80)")]
    public const int CRED_MAX_DOMAIN_TARGET_NAME_LENGTH = (256 + 1 + 80);

    [NativeTypeName("#define CRED_MAX_TARGETNAME_NAMESPACE_LENGTH (256)")]
    public const int CRED_MAX_TARGETNAME_NAMESPACE_LENGTH = (256);

    [NativeTypeName("#define CRED_MAX_TARGETNAME_ATTRIBUTE_LENGTH (256)")]
    public const int CRED_MAX_TARGETNAME_ATTRIBUTE_LENGTH = (256);

    [NativeTypeName("#define CRED_MAX_VALUE_SIZE (256)")]
    public const int CRED_MAX_VALUE_SIZE = (256);

    [NativeTypeName("#define CRED_MAX_ATTRIBUTES 64")]
    public const int CRED_MAX_ATTRIBUTES = 64;

    [NativeTypeName("#define CRED_SESSION_WILDCARD_NAME_W L\"*Session\"")]
    public const string CRED_SESSION_WILDCARD_NAME_W = "*Session";

    [NativeTypeName("#define CRED_SESSION_WILDCARD_NAME_A \"*Session\"")]
    public static ReadOnlySpan<byte> CRED_SESSION_WILDCARD_NAME_A => "*Session"u8;

    [NativeTypeName("#define CRED_UNIVERSAL_WILDCARD_W L'*'")]
    public const ushort CRED_UNIVERSAL_WILDCARD_W = '*';

    [NativeTypeName("#define CRED_UNIVERSAL_WILDCARD_A '*'")]
    public const sbyte CRED_UNIVERSAL_WILDCARD_A = (sbyte)('*');

    [NativeTypeName(
        "#define CRED_SESSION_WILDCARD_NAME_LENGTH (sizeof(CRED_SESSION_WILDCARD_NAME_A)-1)"
    )]
    public const uint CRED_SESSION_WILDCARD_NAME_LENGTH = (9 - 1);

    [NativeTypeName("#define CRED_TARGETNAME_DOMAIN_NAMESPACE_W L\"Domain\"")]
    public const string CRED_TARGETNAME_DOMAIN_NAMESPACE_W = "Domain";

    [NativeTypeName("#define CRED_TARGETNAME_DOMAIN_NAMESPACE_A \"Domain\"")]
    public static ReadOnlySpan<byte> CRED_TARGETNAME_DOMAIN_NAMESPACE_A => "Domain"u8;

    [NativeTypeName(
        "#define CRED_TARGETNAME_DOMAIN_NAMESPACE_LENGTH (sizeof(CRED_TARGETNAME_DOMAIN_NAMESPACE_A)-1)"
    )]
    public const uint CRED_TARGETNAME_DOMAIN_NAMESPACE_LENGTH = (7 - 1);

    [NativeTypeName("#define CRED_TARGETNAME_LEGACYGENERIC_NAMESPACE_W L\"LegacyGeneric\"")]
    public const string CRED_TARGETNAME_LEGACYGENERIC_NAMESPACE_W = "LegacyGeneric";

    [NativeTypeName("#define CRED_TARGETNAME_LEGACYGENERIC_NAMESPACE_A \"LegacyGeneric\"")]
    public static ReadOnlySpan<byte> CRED_TARGETNAME_LEGACYGENERIC_NAMESPACE_A => "LegacyGeneric"u8;

    [NativeTypeName(
        "#define CRED_TARGETNAME_LEGACYGENERIC_NAMESPACE_LENGTH (sizeof(CRED_TARGETNAME_LEGACYGENERIC_NAMESPACE_A)-1)"
    )]
    public const uint CRED_TARGETNAME_LEGACYGENERIC_NAMESPACE_LENGTH = (14 - 1);

    [NativeTypeName("#define CRED_TARGETNAME_NAMESPACE_SEPERATOR_W L':'")]
    public const ushort CRED_TARGETNAME_NAMESPACE_SEPERATOR_W = ':';

    [NativeTypeName("#define CRED_TARGETNAME_NAMESPACE_SEPERATOR_A ':'")]
    public const sbyte CRED_TARGETNAME_NAMESPACE_SEPERATOR_A = (sbyte)(':');

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_SEPERATOR_W L'='")]
    public const ushort CRED_TARGETNAME_ATTRIBUTE_SEPERATOR_W = '=';

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_SEPERATOR_A '='")]
    public const sbyte CRED_TARGETNAME_ATTRIBUTE_SEPERATOR_A = (sbyte)('=');

    [NativeTypeName("#define CRED_TARGETNAME_DOMAIN_EXTENDED_USERNAME_SEPARATOR_W L'|'")]
    public const ushort CRED_TARGETNAME_DOMAIN_EXTENDED_USERNAME_SEPARATOR_W = '|';

    [NativeTypeName("#define CRED_TARGETNAME_DOMAIN_EXTENDED_USERNAME_SEPARATOR_A '|'")]
    public const sbyte CRED_TARGETNAME_DOMAIN_EXTENDED_USERNAME_SEPARATOR_A = (sbyte)('|');

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_TARGET_W L\"target\"")]
    public const string CRED_TARGETNAME_ATTRIBUTE_TARGET_W = "target";

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_TARGET_A \"target\"")]
    public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_TARGET_A => "target"u8;

    [NativeTypeName(
        "#define CRED_TARGETNAME_ATTRIBUTE_TARGET_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_TARGET_A)-1)"
    )]
    public const uint CRED_TARGETNAME_ATTRIBUTE_TARGET_LENGTH = (7 - 1);

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NAME_W L\"name\"")]
    public const string CRED_TARGETNAME_ATTRIBUTE_NAME_W = "name";

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NAME_A \"name\"")]
    public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_NAME_A => "name"u8;

    [NativeTypeName(
        "#define CRED_TARGETNAME_ATTRIBUTE_NAME_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_NAME_A)-1)"
    )]
    public const uint CRED_TARGETNAME_ATTRIBUTE_NAME_LENGTH = (5 - 1);

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_BATCH_W L\"batch\"")]
    public const string CRED_TARGETNAME_ATTRIBUTE_BATCH_W = "batch";

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_BATCH_A \"batch\"")]
    public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_BATCH_A => "batch"u8;

    [NativeTypeName(
        "#define CRED_TARGETNAME_ATTRIBUTE_BATCH_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_BATCH_A)-1)"
    )]
    public const uint CRED_TARGETNAME_ATTRIBUTE_BATCH_LENGTH = (6 - 1);

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE_W L\"interactive\"")]
    public const string CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE_W = "interactive";

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE_A \"interactive\"")]
    public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE_A => "interactive"u8;

    [NativeTypeName(
        "#define CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE_A)-1)"
    )]
    public const uint CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE_LENGTH = (12 - 1);

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_SERVICE_W L\"service\"")]
    public const string CRED_TARGETNAME_ATTRIBUTE_SERVICE_W = "service";

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_SERVICE_A \"service\"")]
    public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_SERVICE_A => "service"u8;

    [NativeTypeName(
        "#define CRED_TARGETNAME_ATTRIBUTE_SERVICE_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_SERVICE_A)-1)"
    )]
    public const uint CRED_TARGETNAME_ATTRIBUTE_SERVICE_LENGTH = (8 - 1);

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NETWORK_W L\"network\"")]
    public const string CRED_TARGETNAME_ATTRIBUTE_NETWORK_W = "network";

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NETWORK_A \"network\"")]
    public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_NETWORK_A => "network"u8;

    [NativeTypeName(
        "#define CRED_TARGETNAME_ATTRIBUTE_NETWORK_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_NETWORK_A)-1)"
    )]
    public const uint CRED_TARGETNAME_ATTRIBUTE_NETWORK_LENGTH = (8 - 1);

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT_W L\"networkcleartext\"")]
    public const string CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT_W = "networkcleartext";

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT_A \"networkcleartext\"")]
    public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT_A =>
        "networkcleartext"u8;

    [NativeTypeName(
        "#define CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT_A)-1)"
    )]
    public const uint CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT_LENGTH = (17 - 1);

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE_W L\"remoteinteractive\"")]
    public const string CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE_W = "remoteinteractive";

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE_A \"remoteinteractive\"")]
    public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE_A =>
        "remoteinteractive"u8;

    [NativeTypeName(
        "#define CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE_A)-1)"
    )]
    public const uint CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE_LENGTH = (18 - 1);

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE_W L\"cachedinteractive\"")]
    public const string CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE_W = "cachedinteractive";

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE_A \"cachedinteractive\"")]
    public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE_A =>
        "cachedinteractive"u8;

    [NativeTypeName(
        "#define CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE_A)-1)"
    )]
    public const uint CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE_LENGTH = (18 - 1);

    [NativeTypeName("#define CRED_SESSION_WILDCARD_NAME CRED_SESSION_WILDCARD_NAME_W")]
    public const string CRED_SESSION_WILDCARD_NAME = "*Session";

    [NativeTypeName("#define CRED_TARGETNAME_DOMAIN_NAMESPACE CRED_TARGETNAME_DOMAIN_NAMESPACE_W")]
    public const string CRED_TARGETNAME_DOMAIN_NAMESPACE = "Domain";

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NAME CRED_TARGETNAME_ATTRIBUTE_NAME_W")]
    public const string CRED_TARGETNAME_ATTRIBUTE_NAME = "name";

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_TARGET CRED_TARGETNAME_ATTRIBUTE_TARGET_W")]
    public const string CRED_TARGETNAME_ATTRIBUTE_TARGET = "target";

    [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_BATCH CRED_TARGETNAME_ATTRIBUTE_BATCH_W")]
    public const string CRED_TARGETNAME_ATTRIBUTE_BATCH = "batch";

    [NativeTypeName(
        "#define CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE_W"
    )]
    public const string CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE = "interactive";

    [NativeTypeName(
        "#define CRED_TARGETNAME_ATTRIBUTE_SERVICE CRED_TARGETNAME_ATTRIBUTE_SERVICE_W"
    )]
    public const string CRED_TARGETNAME_ATTRIBUTE_SERVICE = "service";

    [NativeTypeName(
        "#define CRED_TARGETNAME_ATTRIBUTE_NETWORK CRED_TARGETNAME_ATTRIBUTE_NETWORK_W"
    )]
    public const string CRED_TARGETNAME_ATTRIBUTE_NETWORK = "network";

    [NativeTypeName(
        "#define CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT_W"
    )]
    public const string CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT = "networkcleartext";

    [NativeTypeName(
        "#define CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE_W"
    )]
    public const string CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE = "remoteinteractive";

    [NativeTypeName(
        "#define CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE_W"
    )]
    public const string CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE = "cachedinteractive";

    [NativeTypeName("#define CRED_LOGON_TYPES_MASK 0xF000")]
    public const int CRED_LOGON_TYPES_MASK = 0xF000;

    [NativeTypeName("#define CRED_FLAGS_PASSWORD_FOR_CERT 0x0001")]
    public const int CRED_FLAGS_PASSWORD_FOR_CERT = 0x0001;

    [NativeTypeName("#define CRED_FLAGS_PROMPT_NOW 0x0002")]
    public const int CRED_FLAGS_PROMPT_NOW = 0x0002;

    [NativeTypeName("#define CRED_FLAGS_USERNAME_TARGET 0x0004")]
    public const int CRED_FLAGS_USERNAME_TARGET = 0x0004;

    [NativeTypeName("#define CRED_FLAGS_OWF_CRED_BLOB 0x0008")]
    public const int CRED_FLAGS_OWF_CRED_BLOB = 0x0008;

    [NativeTypeName("#define CRED_FLAGS_REQUIRE_CONFIRMATION 0x0010")]
    public const int CRED_FLAGS_REQUIRE_CONFIRMATION = 0x0010;

    [NativeTypeName("#define CRED_FLAGS_WILDCARD_MATCH 0x0020")]
    public const int CRED_FLAGS_WILDCARD_MATCH = 0x0020;

    [NativeTypeName("#define CRED_FLAGS_VSM_PROTECTED 0x0040")]
    public const int CRED_FLAGS_VSM_PROTECTED = 0x0040;

    [NativeTypeName("#define CRED_FLAGS_NGC_CERT 0x0080")]
    public const int CRED_FLAGS_NGC_CERT = 0x0080;

    [NativeTypeName("#define CRED_FLAGS_VALID_FLAGS 0xF0FF")]
    public const int CRED_FLAGS_VALID_FLAGS = 0xF0FF;

    [NativeTypeName("#define CRED_FLAGS_VALID_INPUT_FLAGS 0xF09F")]
    public const int CRED_FLAGS_VALID_INPUT_FLAGS = 0xF09F;

    [NativeTypeName("#define CRED_TYPE_GENERIC 1")]
    public const int CRED_TYPE_GENERIC = 1;

    [NativeTypeName("#define CRED_TYPE_DOMAIN_PASSWORD 2")]
    public const int CRED_TYPE_DOMAIN_PASSWORD = 2;

    [NativeTypeName("#define CRED_TYPE_DOMAIN_CERTIFICATE 3")]
    public const int CRED_TYPE_DOMAIN_CERTIFICATE = 3;

    [NativeTypeName("#define CRED_TYPE_DOMAIN_VISIBLE_PASSWORD 4")]
    public const int CRED_TYPE_DOMAIN_VISIBLE_PASSWORD = 4;

    [NativeTypeName("#define CRED_TYPE_GENERIC_CERTIFICATE 5")]
    public const int CRED_TYPE_GENERIC_CERTIFICATE = 5;

    [NativeTypeName("#define CRED_TYPE_DOMAIN_EXTENDED 6")]
    public const int CRED_TYPE_DOMAIN_EXTENDED = 6;

    [NativeTypeName("#define CRED_TYPE_MAXIMUM 7")]
    public const int CRED_TYPE_MAXIMUM = 7;

    [NativeTypeName("#define CRED_TYPE_MAXIMUM_EX (CRED_TYPE_MAXIMUM+1000)")]
    public const int CRED_TYPE_MAXIMUM_EX = (7 + 1000);

    [NativeTypeName("#define CRED_MAX_CREDENTIAL_BLOB_SIZE (5*512)")]
    public const int CRED_MAX_CREDENTIAL_BLOB_SIZE = (5 * 512);

    [NativeTypeName("#define CRED_PERSIST_NONE 0")]
    public const int CRED_PERSIST_NONE = 0;

    [NativeTypeName("#define CRED_PERSIST_SESSION 1")]
    public const int CRED_PERSIST_SESSION = 1;

    [NativeTypeName("#define CRED_PERSIST_LOCAL_MACHINE 2")]
    public const int CRED_PERSIST_LOCAL_MACHINE = 2;

    [NativeTypeName("#define CRED_PERSIST_ENTERPRISE 3")]
    public const int CRED_PERSIST_ENTERPRISE = 3;

    [NativeTypeName("#define CRED_TI_SERVER_FORMAT_UNKNOWN 0x0001")]
    public const int CRED_TI_SERVER_FORMAT_UNKNOWN = 0x0001;

    [NativeTypeName("#define CRED_TI_DOMAIN_FORMAT_UNKNOWN 0x0002")]
    public const int CRED_TI_DOMAIN_FORMAT_UNKNOWN = 0x0002;

    [NativeTypeName("#define CRED_TI_ONLY_PASSWORD_REQUIRED 0x0004")]
    public const int CRED_TI_ONLY_PASSWORD_REQUIRED = 0x0004;

    [NativeTypeName("#define CRED_TI_USERNAME_TARGET 0x0008")]
    public const int CRED_TI_USERNAME_TARGET = 0x0008;

    [NativeTypeName("#define CRED_TI_CREATE_EXPLICIT_CRED 0x0010")]
    public const int CRED_TI_CREATE_EXPLICIT_CRED = 0x0010;

    [NativeTypeName("#define CRED_TI_WORKGROUP_MEMBER 0x0020")]
    public const int CRED_TI_WORKGROUP_MEMBER = 0x0020;

    [NativeTypeName("#define CRED_TI_DNSTREE_IS_DFS_SERVER 0x0040")]
    public const int CRED_TI_DNSTREE_IS_DFS_SERVER = 0x0040;

    [NativeTypeName("#define CRED_TI_VALID_FLAGS 0xF07F")]
    public const int CRED_TI_VALID_FLAGS = 0xF07F;

    [NativeTypeName("#define CRED_PACK_PROTECTED_CREDENTIALS 0x1")]
    public const int CRED_PACK_PROTECTED_CREDENTIALS = 0x1;

    [NativeTypeName("#define CRED_PACK_WOW_BUFFER 0x2")]
    public const int CRED_PACK_WOW_BUFFER = 0x2;

    [NativeTypeName("#define CRED_PACK_GENERIC_CREDENTIALS 0x4")]
    public const int CRED_PACK_GENERIC_CREDENTIALS = 0x4;

    [NativeTypeName("#define CRED_PACK_ID_PROVIDER_CREDENTIALS 0x8")]
    public const int CRED_PACK_ID_PROVIDER_CREDENTIALS = 0x8;

    [NativeTypeName("#define CRED_PRESERVE_CREDENTIAL_BLOB 0x1")]
    public const int CRED_PRESERVE_CREDENTIAL_BLOB = 0x1;

    [NativeTypeName("#define CRED_ENUMERATE_ALL_CREDENTIALS 0x1")]
    public const int CRED_ENUMERATE_ALL_CREDENTIALS = 0x1;

    [NativeTypeName("#define CRED_CACHE_TARGET_INFORMATION 0x1")]
    public const int CRED_CACHE_TARGET_INFORMATION = 0x1;

    [NativeTypeName("#define CRED_ALLOW_NAME_RESOLUTION 0x1")]
    public const int CRED_ALLOW_NAME_RESOLUTION = 0x1;

    [NativeTypeName("#define CRED_PROTECT_AS_SELF 0x1")]
    public const int CRED_PROTECT_AS_SELF = 0x1;

    [NativeTypeName("#define CRED_PROTECT_TO_SYSTEM 0x2")]
    public const int CRED_PROTECT_TO_SYSTEM = 0x2;

    [NativeTypeName(
        "#define CRED_PROTECT_VALID_FLAGS (CRED_PROTECT_AS_SELF | CRED_PROTECT_TO_SYSTEM)"
    )]
    public const int CRED_PROTECT_VALID_FLAGS = (0x1 | 0x2);

    [NativeTypeName("#define CRED_UNPROTECT_AS_SELF 0x1")]
    public const int CRED_UNPROTECT_AS_SELF = 0x1;

    [NativeTypeName("#define CRED_UNPROTECT_ALLOW_TO_SYSTEM 0x2")]
    public const int CRED_UNPROTECT_ALLOW_TO_SYSTEM = 0x2;

    [NativeTypeName(
        "#define CRED_UNPROTECT_VALID_FLAGS (CRED_UNPROTECT_AS_SELF | CRED_UNPROTECT_ALLOW_TO_SYSTEM)"
    )]
    public const int CRED_UNPROTECT_VALID_FLAGS = (0x1 | 0x2);
}
