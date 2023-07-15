// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class TBS
{
    [NativeTypeName("#define TBS_CONTEXT_VERSION_ONE 1")]
    public const int TBS_CONTEXT_VERSION_ONE = 1;
    [NativeTypeName("#define TBS_COMMAND_PRIORITY_LOW 100")]
    public const int TBS_COMMAND_PRIORITY_LOW = 100;
    [NativeTypeName("#define TBS_COMMAND_PRIORITY_NORMAL 200")]
    public const int TBS_COMMAND_PRIORITY_NORMAL = 200;
    [NativeTypeName("#define TBS_COMMAND_PRIORITY_HIGH 300")]
    public const int TBS_COMMAND_PRIORITY_HIGH = 300;
    [NativeTypeName("#define TBS_COMMAND_PRIORITY_SYSTEM 400")]
    public const int TBS_COMMAND_PRIORITY_SYSTEM = 400;
    [NativeTypeName("#define TBS_COMMAND_PRIORITY_MAX 0x80000000")]
    public const uint TBS_COMMAND_PRIORITY_MAX = 0x80000000;
    [NativeTypeName("#define TBS_COMMAND_LOCALITY_ZERO 0")]
    public const int TBS_COMMAND_LOCALITY_ZERO = 0;
    [NativeTypeName("#define TBS_COMMAND_LOCALITY_ONE 1")]
    public const int TBS_COMMAND_LOCALITY_ONE = 1;
    [NativeTypeName("#define TBS_COMMAND_LOCALITY_TWO 2")]
    public const int TBS_COMMAND_LOCALITY_TWO = 2;
    [NativeTypeName("#define TBS_COMMAND_LOCALITY_THREE 3")]
    public const int TBS_COMMAND_LOCALITY_THREE = 3;
    [NativeTypeName("#define TBS_COMMAND_LOCALITY_FOUR 4")]
    public const int TBS_COMMAND_LOCALITY_FOUR = 4;
    [NativeTypeName("#define TBS_SUCCESS 0")]
    public const int TBS_SUCCESS = 0;
    [NativeTypeName("#define TBS_IN_OUT_BUF_SIZE_MAX (256*1024)")]
    public const int TBS_IN_OUT_BUF_SIZE_MAX = (256 * 1024);
    [NativeTypeName("#define TBS_OWNERAUTH_TYPE_FULL 1")]
    public const int TBS_OWNERAUTH_TYPE_FULL = 1;
    [NativeTypeName("#define TBS_OWNERAUTH_TYPE_ADMIN 2")]
    public const int TBS_OWNERAUTH_TYPE_ADMIN = 2;
    [NativeTypeName("#define TBS_OWNERAUTH_TYPE_USER 3")]
    public const int TBS_OWNERAUTH_TYPE_USER = 3;
    [NativeTypeName("#define TBS_OWNERAUTH_TYPE_ENDORSEMENT 4")]
    public const int TBS_OWNERAUTH_TYPE_ENDORSEMENT = 4;
    [NativeTypeName("#define TBS_OWNERAUTH_TYPE_ENDORSEMENT_20 12")]
    public const int TBS_OWNERAUTH_TYPE_ENDORSEMENT_20 = 12;
    [NativeTypeName("#define TBS_OWNERAUTH_TYPE_STORAGE_20 13")]
    public const int TBS_OWNERAUTH_TYPE_STORAGE_20 = 13;
    [NativeTypeName("#define TBS_CONTEXT_VERSION_TWO 2")]
    public const int TBS_CONTEXT_VERSION_TWO = 2;
    [NativeTypeName("#define TBS_TCGLOG_SRTM_CURRENT 0")]
    public const int TBS_TCGLOG_SRTM_CURRENT = 0;
    [NativeTypeName("#define TBS_TCGLOG_DRTM_CURRENT 1")]
    public const int TBS_TCGLOG_DRTM_CURRENT = 1;
    [NativeTypeName("#define TBS_TCGLOG_SRTM_BOOT 2")]
    public const int TBS_TCGLOG_SRTM_BOOT = 2;
    [NativeTypeName("#define TBS_TCGLOG_SRTM_RESUME 3")]
    public const int TBS_TCGLOG_SRTM_RESUME = 3;
    [NativeTypeName("#define TBS_TCGLOG_DRTM_BOOT 4")]
    public const int TBS_TCGLOG_DRTM_BOOT = 4;
    [NativeTypeName("#define TBS_TCGLOG_DRTM_RESUME 5")]
    public const int TBS_TCGLOG_DRTM_RESUME = 5;
}