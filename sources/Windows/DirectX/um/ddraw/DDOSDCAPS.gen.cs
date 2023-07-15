// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class DDOSDCAPS
{
    [NativeTypeName("#define DDOSDCAPS_OPTCOMPRESSED 0x00000001l")]
    public const int DDOSDCAPS_OPTCOMPRESSED = 0x00000001;
    [NativeTypeName("#define DDOSDCAPS_OPTREORDERED 0x00000002l")]
    public const int DDOSDCAPS_OPTREORDERED = 0x00000002;
    [NativeTypeName("#define DDOSDCAPS_MONOLITHICMIPMAP 0x00000004l")]
    public const int DDOSDCAPS_MONOLITHICMIPMAP = 0x00000004;
    [NativeTypeName("#define DDOSDCAPS_VALIDSCAPS 0x30004800l")]
    public const int DDOSDCAPS_VALIDSCAPS = 0x30004800;
    [NativeTypeName("#define DDOSDCAPS_VALIDOSCAPS 0x00000007l")]
    public const int DDOSDCAPS_VALIDOSCAPS = 0x00000007;
}