// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class NIIF
{
    [NativeTypeName("#define NIIF_NONE 0x00000000")]
    public const int NIIF_NONE = 0x00000000;
    [NativeTypeName("#define NIIF_INFO 0x00000001")]
    public const int NIIF_INFO = 0x00000001;
    [NativeTypeName("#define NIIF_WARNING 0x00000002")]
    public const int NIIF_WARNING = 0x00000002;
    [NativeTypeName("#define NIIF_ERROR 0x00000003")]
    public const int NIIF_ERROR = 0x00000003;
    [NativeTypeName("#define NIIF_USER 0x00000004")]
    public const int NIIF_USER = 0x00000004;
    [NativeTypeName("#define NIIF_ICON_MASK 0x0000000F")]
    public const int NIIF_ICON_MASK = 0x0000000F;
    [NativeTypeName("#define NIIF_NOSOUND 0x00000010")]
    public const int NIIF_NOSOUND = 0x00000010;
    [NativeTypeName("#define NIIF_LARGE_ICON 0x00000020")]
    public const int NIIF_LARGE_ICON = 0x00000020;
    [NativeTypeName("#define NIIF_RESPECT_QUIET_TIME 0x00000080")]
    public const int NIIF_RESPECT_QUIET_TIME = 0x00000080;
}