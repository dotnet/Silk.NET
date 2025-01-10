// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DDSD
{
    [NativeTypeName("#define DDSD_CAPS 0x00000001l")]
    public const int DDSD_CAPS = 0x00000001;

    [NativeTypeName("#define DDSD_HEIGHT 0x00000002l")]
    public const int DDSD_HEIGHT = 0x00000002;

    [NativeTypeName("#define DDSD_WIDTH 0x00000004l")]
    public const int DDSD_WIDTH = 0x00000004;

    [NativeTypeName("#define DDSD_PITCH 0x00000008l")]
    public const int DDSD_PITCH = 0x00000008;

    [NativeTypeName("#define DDSD_BACKBUFFERCOUNT 0x00000020l")]
    public const int DDSD_BACKBUFFERCOUNT = 0x00000020;

    [NativeTypeName("#define DDSD_ZBUFFERBITDEPTH 0x00000040l")]
    public const int DDSD_ZBUFFERBITDEPTH = 0x00000040;

    [NativeTypeName("#define DDSD_ALPHABITDEPTH 0x00000080l")]
    public const int DDSD_ALPHABITDEPTH = 0x00000080;

    [NativeTypeName("#define DDSD_LPSURFACE 0x00000800l")]
    public const int DDSD_LPSURFACE = 0x00000800;

    [NativeTypeName("#define DDSD_PIXELFORMAT 0x00001000l")]
    public const int DDSD_PIXELFORMAT = 0x00001000;

    [NativeTypeName("#define DDSD_CKDESTOVERLAY 0x00002000l")]
    public const int DDSD_CKDESTOVERLAY = 0x00002000;

    [NativeTypeName("#define DDSD_CKDESTBLT 0x00004000l")]
    public const int DDSD_CKDESTBLT = 0x00004000;

    [NativeTypeName("#define DDSD_CKSRCOVERLAY 0x00008000l")]
    public const int DDSD_CKSRCOVERLAY = 0x00008000;

    [NativeTypeName("#define DDSD_CKSRCBLT 0x00010000l")]
    public const int DDSD_CKSRCBLT = 0x00010000;

    [NativeTypeName("#define DDSD_MIPMAPCOUNT 0x00020000l")]
    public const int DDSD_MIPMAPCOUNT = 0x00020000;

    [NativeTypeName("#define DDSD_REFRESHRATE 0x00040000l")]
    public const int DDSD_REFRESHRATE = 0x00040000;

    [NativeTypeName("#define DDSD_LINEARSIZE 0x00080000l")]
    public const int DDSD_LINEARSIZE = 0x00080000;

    [NativeTypeName("#define DDSD_TEXTURESTAGE 0x00100000l")]
    public const int DDSD_TEXTURESTAGE = 0x00100000;

    [NativeTypeName("#define DDSD_FVF 0x00200000l")]
    public const int DDSD_FVF = 0x00200000;

    [NativeTypeName("#define DDSD_SRCVBHANDLE 0x00400000l")]
    public const int DDSD_SRCVBHANDLE = 0x00400000;

    [NativeTypeName("#define DDSD_DEPTH 0x00800000l")]
    public const int DDSD_DEPTH = 0x00800000;

    [NativeTypeName("#define DDSD_ALL 0x00fff9eel")]
    public const int DDSD_ALL = 0x00fff9ee;
}
