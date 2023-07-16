// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class SDC
{
    [NativeTypeName("#define SDC_TOPOLOGY_INTERNAL 0x00000001")]
    public const int SDC_TOPOLOGY_INTERNAL = 0x00000001;
    [NativeTypeName("#define SDC_TOPOLOGY_CLONE 0x00000002")]
    public const int SDC_TOPOLOGY_CLONE = 0x00000002;
    [NativeTypeName("#define SDC_TOPOLOGY_EXTEND 0x00000004")]
    public const int SDC_TOPOLOGY_EXTEND = 0x00000004;
    [NativeTypeName("#define SDC_TOPOLOGY_EXTERNAL 0x00000008")]
    public const int SDC_TOPOLOGY_EXTERNAL = 0x00000008;
    [NativeTypeName("#define SDC_TOPOLOGY_SUPPLIED 0x00000010")]
    public const int SDC_TOPOLOGY_SUPPLIED = 0x00000010;
    [NativeTypeName("#define SDC_USE_DATABASE_CURRENT (SDC_TOPOLOGY_INTERNAL | SDC_TOPOLOGY_CLONE | SDC_TOPOLOGY_EXTEND | SDC_TOPOLOGY_EXTERNAL)")]
    public const int SDC_USE_DATABASE_CURRENT = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008);
    [NativeTypeName("#define SDC_USE_SUPPLIED_DISPLAY_CONFIG 0x00000020")]
    public const int SDC_USE_SUPPLIED_DISPLAY_CONFIG = 0x00000020;
    [NativeTypeName("#define SDC_VALIDATE 0x00000040")]
    public const int SDC_VALIDATE = 0x00000040;
    [NativeTypeName("#define SDC_APPLY 0x00000080")]
    public const int SDC_APPLY = 0x00000080;
    [NativeTypeName("#define SDC_NO_OPTIMIZATION 0x00000100")]
    public const int SDC_NO_OPTIMIZATION = 0x00000100;
    [NativeTypeName("#define SDC_SAVE_TO_DATABASE 0x00000200")]
    public const int SDC_SAVE_TO_DATABASE = 0x00000200;
    [NativeTypeName("#define SDC_ALLOW_CHANGES 0x00000400")]
    public const int SDC_ALLOW_CHANGES = 0x00000400;
    [NativeTypeName("#define SDC_PATH_PERSIST_IF_REQUIRED 0x00000800")]
    public const int SDC_PATH_PERSIST_IF_REQUIRED = 0x00000800;
    [NativeTypeName("#define SDC_FORCE_MODE_ENUMERATION 0x00001000")]
    public const int SDC_FORCE_MODE_ENUMERATION = 0x00001000;
    [NativeTypeName("#define SDC_ALLOW_PATH_ORDER_CHANGES 0x00002000")]
    public const int SDC_ALLOW_PATH_ORDER_CHANGES = 0x00002000;
    [NativeTypeName("#define SDC_VIRTUAL_MODE_AWARE 0x00008000")]
    public const int SDC_VIRTUAL_MODE_AWARE = 0x00008000;
    [NativeTypeName("#define SDC_VIRTUAL_REFRESH_RATE_AWARE 0x00020000")]
    public const int SDC_VIRTUAL_REFRESH_RATE_AWARE = 0x00020000;
}