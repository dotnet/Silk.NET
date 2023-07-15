// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class MUTZ
{
    [NativeTypeName("#define MUTZ_NOSAVEDFILECHECK 0x00000001")]
    public const int MUTZ_NOSAVEDFILECHECK = 0x00000001;
    [NativeTypeName("#define MUTZ_ISFILE 0x00000002")]
    public const int MUTZ_ISFILE = 0x00000002;
    [NativeTypeName("#define MUTZ_ACCEPT_WILDCARD_SCHEME 0x00000080")]
    public const int MUTZ_ACCEPT_WILDCARD_SCHEME = 0x00000080;
    [NativeTypeName("#define MUTZ_ENFORCERESTRICTED 0x00000100")]
    public const int MUTZ_ENFORCERESTRICTED = 0x00000100;
    [NativeTypeName("#define MUTZ_RESERVED 0x00000200")]
    public const int MUTZ_RESERVED = 0x00000200;
    [NativeTypeName("#define MUTZ_REQUIRESAVEDFILECHECK 0x00000400")]
    public const int MUTZ_REQUIRESAVEDFILECHECK = 0x00000400;
    [NativeTypeName("#define MUTZ_DONT_UNESCAPE 0x00000800")]
    public const int MUTZ_DONT_UNESCAPE = 0x00000800;
    [NativeTypeName("#define MUTZ_DONT_USE_CACHE 0x00001000")]
    public const int MUTZ_DONT_USE_CACHE = 0x00001000;
    [NativeTypeName("#define MUTZ_FORCE_INTRANET_FLAGS 0x00002000")]
    public const int MUTZ_FORCE_INTRANET_FLAGS = 0x00002000;
    [NativeTypeName("#define MUTZ_IGNORE_ZONE_MAPPINGS 0x00004000")]
    public const int MUTZ_IGNORE_ZONE_MAPPINGS = 0x00004000;
}