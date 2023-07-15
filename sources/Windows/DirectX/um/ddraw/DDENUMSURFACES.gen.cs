// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class DDENUMSURFACES
{
    [NativeTypeName("#define DDENUMSURFACES_ALL 0x00000001l")]
    public const int DDENUMSURFACES_ALL = 0x00000001;
    [NativeTypeName("#define DDENUMSURFACES_MATCH 0x00000002l")]
    public const int DDENUMSURFACES_MATCH = 0x00000002;
    [NativeTypeName("#define DDENUMSURFACES_NOMATCH 0x00000004l")]
    public const int DDENUMSURFACES_NOMATCH = 0x00000004;
    [NativeTypeName("#define DDENUMSURFACES_CANBECREATED 0x00000008l")]
    public const int DDENUMSURFACES_CANBECREATED = 0x00000008;
    [NativeTypeName("#define DDENUMSURFACES_DOESEXIST 0x00000010l")]
    public const int DDENUMSURFACES_DOESEXIST = 0x00000010;
}