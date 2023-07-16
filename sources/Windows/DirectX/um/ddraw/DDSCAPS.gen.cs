// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public partial struct DDSCAPS
{
    /// <include file='DDSCAPS.xml' path='doc/member[@name="DDSCAPS.dwCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCaps;
    [NativeTypeName("#define DDSCAPS_RESERVED1 0x00000001l")]
    public const int DDSCAPS_RESERVED1 = 0x00000001;
    [NativeTypeName("#define DDSCAPS_ALPHA 0x00000002l")]
    public const int DDSCAPS_ALPHA = 0x00000002;
    [NativeTypeName("#define DDSCAPS_BACKBUFFER 0x00000004l")]
    public const int DDSCAPS_BACKBUFFER = 0x00000004;
    [NativeTypeName("#define DDSCAPS_COMPLEX 0x00000008l")]
    public const int DDSCAPS_COMPLEX = 0x00000008;
    [NativeTypeName("#define DDSCAPS_FLIP 0x00000010l")]
    public const int DDSCAPS_FLIP = 0x00000010;
    [NativeTypeName("#define DDSCAPS_FRONTBUFFER 0x00000020l")]
    public const int DDSCAPS_FRONTBUFFER = 0x00000020;
    [NativeTypeName("#define DDSCAPS_OFFSCREENPLAIN 0x00000040l")]
    public const int DDSCAPS_OFFSCREENPLAIN = 0x00000040;
    [NativeTypeName("#define DDSCAPS_OVERLAY 0x00000080l")]
    public const int DDSCAPS_OVERLAY = 0x00000080;
    [NativeTypeName("#define DDSCAPS_PALETTE 0x00000100l")]
    public const int DDSCAPS_PALETTE = 0x00000100;
    [NativeTypeName("#define DDSCAPS_PRIMARYSURFACE 0x00000200l")]
    public const int DDSCAPS_PRIMARYSURFACE = 0x00000200;
    [NativeTypeName("#define DDSCAPS_RESERVED3 0x00000400l")]
    public const int DDSCAPS_RESERVED3 = 0x00000400;
    [NativeTypeName("#define DDSCAPS_PRIMARYSURFACELEFT 0x00000000l")]
    public const int DDSCAPS_PRIMARYSURFACELEFT = 0x00000000;
    [NativeTypeName("#define DDSCAPS_SYSTEMMEMORY 0x00000800l")]
    public const int DDSCAPS_SYSTEMMEMORY = 0x00000800;
    [NativeTypeName("#define DDSCAPS_TEXTURE 0x00001000l")]
    public const int DDSCAPS_TEXTURE = 0x00001000;
    [NativeTypeName("#define DDSCAPS_3DDEVICE 0x00002000l")]
    public const int DDSCAPS_3DDEVICE = 0x00002000;
    [NativeTypeName("#define DDSCAPS_VIDEOMEMORY 0x00004000l")]
    public const int DDSCAPS_VIDEOMEMORY = 0x00004000;
    [NativeTypeName("#define DDSCAPS_VISIBLE 0x00008000l")]
    public const int DDSCAPS_VISIBLE = 0x00008000;
    [NativeTypeName("#define DDSCAPS_WRITEONLY 0x00010000l")]
    public const int DDSCAPS_WRITEONLY = 0x00010000;
    [NativeTypeName("#define DDSCAPS_ZBUFFER 0x00020000l")]
    public const int DDSCAPS_ZBUFFER = 0x00020000;
    [NativeTypeName("#define DDSCAPS_OWNDC 0x00040000l")]
    public const int DDSCAPS_OWNDC = 0x00040000;
    [NativeTypeName("#define DDSCAPS_LIVEVIDEO 0x00080000l")]
    public const int DDSCAPS_LIVEVIDEO = 0x00080000;
    [NativeTypeName("#define DDSCAPS_HWCODEC 0x00100000l")]
    public const int DDSCAPS_HWCODEC = 0x00100000;
    [NativeTypeName("#define DDSCAPS_MODEX 0x00200000l")]
    public const int DDSCAPS_MODEX = 0x00200000;
    [NativeTypeName("#define DDSCAPS_MIPMAP 0x00400000l")]
    public const int DDSCAPS_MIPMAP = 0x00400000;
    [NativeTypeName("#define DDSCAPS_RESERVED2 0x00800000l")]
    public const int DDSCAPS_RESERVED2 = 0x00800000;
    [NativeTypeName("#define DDSCAPS_ALLOCONLOAD 0x04000000l")]
    public const int DDSCAPS_ALLOCONLOAD = 0x04000000;
    [NativeTypeName("#define DDSCAPS_VIDEOPORT 0x08000000l")]
    public const int DDSCAPS_VIDEOPORT = 0x08000000;
    [NativeTypeName("#define DDSCAPS_LOCALVIDMEM 0x10000000l")]
    public const int DDSCAPS_LOCALVIDMEM = 0x10000000;
    [NativeTypeName("#define DDSCAPS_NONLOCALVIDMEM 0x20000000l")]
    public const int DDSCAPS_NONLOCALVIDMEM = 0x20000000;
    [NativeTypeName("#define DDSCAPS_STANDARDVGAMODE 0x40000000l")]
    public const int DDSCAPS_STANDARDVGAMODE = 0x40000000;
    [NativeTypeName("#define DDSCAPS_OPTIMIZED 0x80000000l")]
    public const uint DDSCAPS_OPTIMIZED = 0x80000000;
}