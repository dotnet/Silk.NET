// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class BSIS
{
    [NativeTypeName("#define BSIS_AUTOGRIPPER 0x00000000")]
    public const int BSIS_AUTOGRIPPER = 0x00000000;
    [NativeTypeName("#define BSIS_NOGRIPPER 0x00000001")]
    public const int BSIS_NOGRIPPER = 0x00000001;
    [NativeTypeName("#define BSIS_ALWAYSGRIPPER 0x00000002")]
    public const int BSIS_ALWAYSGRIPPER = 0x00000002;
    [NativeTypeName("#define BSIS_LEFTALIGN 0x00000004")]
    public const int BSIS_LEFTALIGN = 0x00000004;
    [NativeTypeName("#define BSIS_SINGLECLICK 0x00000008")]
    public const int BSIS_SINGLECLICK = 0x00000008;
    [NativeTypeName("#define BSIS_NOCONTEXTMENU 0x00000010")]
    public const int BSIS_NOCONTEXTMENU = 0x00000010;
    [NativeTypeName("#define BSIS_NODROPTARGET 0x00000020")]
    public const int BSIS_NODROPTARGET = 0x00000020;
    [NativeTypeName("#define BSIS_NOCAPTION 0x00000040")]
    public const int BSIS_NOCAPTION = 0x00000040;
    [NativeTypeName("#define BSIS_PREFERNOLINEBREAK 0x00000080")]
    public const int BSIS_PREFERNOLINEBREAK = 0x00000080;
    [NativeTypeName("#define BSIS_LOCKED 0x00000100")]
    public const int BSIS_LOCKED = 0x00000100;
    [NativeTypeName("#define BSIS_PRESERVEORDERDURINGLAYOUT 0x00000200")]
    public const int BSIS_PRESERVEORDERDURINGLAYOUT = 0x00000200;
    [NativeTypeName("#define BSIS_FIXEDORDER 0x00000400")]
    public const int BSIS_FIXEDORDER = 0x00000400;
}