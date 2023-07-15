// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class DIEFF
{
    [NativeTypeName("#define DIEFF_OBJECTIDS 0x00000001")]
    public const int DIEFF_OBJECTIDS = 0x00000001;
    [NativeTypeName("#define DIEFF_OBJECTOFFSETS 0x00000002")]
    public const int DIEFF_OBJECTOFFSETS = 0x00000002;
    [NativeTypeName("#define DIEFF_CARTESIAN 0x00000010")]
    public const int DIEFF_CARTESIAN = 0x00000010;
    [NativeTypeName("#define DIEFF_POLAR 0x00000020")]
    public const int DIEFF_POLAR = 0x00000020;
    [NativeTypeName("#define DIEFF_SPHERICAL 0x00000040")]
    public const int DIEFF_SPHERICAL = 0x00000040;
}