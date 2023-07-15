// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class DIEDBS
{
    [NativeTypeName("#define DIEDBS_MAPPEDPRI1 0x00000001")]
    public const int DIEDBS_MAPPEDPRI1 = 0x00000001;
    [NativeTypeName("#define DIEDBS_MAPPEDPRI2 0x00000002")]
    public const int DIEDBS_MAPPEDPRI2 = 0x00000002;
    [NativeTypeName("#define DIEDBS_RECENTDEVICE 0x00000010")]
    public const int DIEDBS_RECENTDEVICE = 0x00000010;
    [NativeTypeName("#define DIEDBS_NEWDEVICE 0x00000020")]
    public const int DIEDBS_NEWDEVICE = 0x00000020;
}