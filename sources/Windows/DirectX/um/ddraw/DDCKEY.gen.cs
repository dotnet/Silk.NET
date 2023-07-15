// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class DDCKEY
{
    [NativeTypeName("#define DDCKEY_COLORSPACE 0x00000001l")]
    public const int DDCKEY_COLORSPACE = 0x00000001;
    [NativeTypeName("#define DDCKEY_DESTBLT 0x00000002l")]
    public const int DDCKEY_DESTBLT = 0x00000002;
    [NativeTypeName("#define DDCKEY_DESTOVERLAY 0x00000004l")]
    public const int DDCKEY_DESTOVERLAY = 0x00000004;
    [NativeTypeName("#define DDCKEY_SRCBLT 0x00000008l")]
    public const int DDCKEY_SRCBLT = 0x00000008;
    [NativeTypeName("#define DDCKEY_SRCOVERLAY 0x00000010l")]
    public const int DDCKEY_SRCOVERLAY = 0x00000010;
}