// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/reason.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class Windows
{
    [NativeTypeName("#define PCLEANUI (SHTDN_REASON_FLAG_PLANNED | SHTDN_REASON_FLAG_CLEAN_UI)")]
    public const uint PCLEANUI = (0x80000000 | 0x04000000);
    [NativeTypeName("#define UCLEANUI (SHTDN_REASON_FLAG_CLEAN_UI)")]
    public const int UCLEANUI = (0x04000000);
    [NativeTypeName("#define PDIRTYUI (SHTDN_REASON_FLAG_PLANNED | SHTDN_REASON_FLAG_DIRTY_UI)")]
    public const uint PDIRTYUI = (0x80000000 | 0x08000000);
    [NativeTypeName("#define UDIRTYUI (SHTDN_REASON_FLAG_DIRTY_UI)")]
    public const int UDIRTYUI = (0x08000000);
    [NativeTypeName("#define SNAPSHOT_POLICY_NEVER 0")]
    public const int SNAPSHOT_POLICY_NEVER = 0;
    [NativeTypeName("#define SNAPSHOT_POLICY_ALWAYS 1")]
    public const int SNAPSHOT_POLICY_ALWAYS = 1;
    [NativeTypeName("#define SNAPSHOT_POLICY_UNPLANNED 2")]
    public const int SNAPSHOT_POLICY_UNPLANNED = 2;
}