// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class DDCAPS
{
    [NativeTypeName("#define DDCAPS_3D 0x00000001l")]
    public const int DDCAPS_3D = 0x00000001;
    [NativeTypeName("#define DDCAPS_ALIGNBOUNDARYDEST 0x00000002l")]
    public const int DDCAPS_ALIGNBOUNDARYDEST = 0x00000002;
    [NativeTypeName("#define DDCAPS_ALIGNSIZEDEST 0x00000004l")]
    public const int DDCAPS_ALIGNSIZEDEST = 0x00000004;
    [NativeTypeName("#define DDCAPS_ALIGNBOUNDARYSRC 0x00000008l")]
    public const int DDCAPS_ALIGNBOUNDARYSRC = 0x00000008;
    [NativeTypeName("#define DDCAPS_ALIGNSIZESRC 0x00000010l")]
    public const int DDCAPS_ALIGNSIZESRC = 0x00000010;
    [NativeTypeName("#define DDCAPS_ALIGNSTRIDE 0x00000020l")]
    public const int DDCAPS_ALIGNSTRIDE = 0x00000020;
    [NativeTypeName("#define DDCAPS_BLT 0x00000040l")]
    public const int DDCAPS_BLT = 0x00000040;
    [NativeTypeName("#define DDCAPS_BLTQUEUE 0x00000080l")]
    public const int DDCAPS_BLTQUEUE = 0x00000080;
    [NativeTypeName("#define DDCAPS_BLTFOURCC 0x00000100l")]
    public const int DDCAPS_BLTFOURCC = 0x00000100;
    [NativeTypeName("#define DDCAPS_BLTSTRETCH 0x00000200l")]
    public const int DDCAPS_BLTSTRETCH = 0x00000200;
    [NativeTypeName("#define DDCAPS_GDI 0x00000400l")]
    public const int DDCAPS_GDI = 0x00000400;
    [NativeTypeName("#define DDCAPS_OVERLAY 0x00000800l")]
    public const int DDCAPS_OVERLAY = 0x00000800;
    [NativeTypeName("#define DDCAPS_OVERLAYCANTCLIP 0x00001000l")]
    public const int DDCAPS_OVERLAYCANTCLIP = 0x00001000;
    [NativeTypeName("#define DDCAPS_OVERLAYFOURCC 0x00002000l")]
    public const int DDCAPS_OVERLAYFOURCC = 0x00002000;
    [NativeTypeName("#define DDCAPS_OVERLAYSTRETCH 0x00004000l")]
    public const int DDCAPS_OVERLAYSTRETCH = 0x00004000;
    [NativeTypeName("#define DDCAPS_PALETTE 0x00008000l")]
    public const int DDCAPS_PALETTE = 0x00008000;
    [NativeTypeName("#define DDCAPS_PALETTEVSYNC 0x00010000l")]
    public const int DDCAPS_PALETTEVSYNC = 0x00010000;
    [NativeTypeName("#define DDCAPS_READSCANLINE 0x00020000l")]
    public const int DDCAPS_READSCANLINE = 0x00020000;
    [NativeTypeName("#define DDCAPS_RESERVED1 0x00040000l")]
    public const int DDCAPS_RESERVED1 = 0x00040000;
    [NativeTypeName("#define DDCAPS_VBI 0x00080000l")]
    public const int DDCAPS_VBI = 0x00080000;
    [NativeTypeName("#define DDCAPS_ZBLTS 0x00100000l")]
    public const int DDCAPS_ZBLTS = 0x00100000;
    [NativeTypeName("#define DDCAPS_ZOVERLAYS 0x00200000l")]
    public const int DDCAPS_ZOVERLAYS = 0x00200000;
    [NativeTypeName("#define DDCAPS_COLORKEY 0x00400000l")]
    public const int DDCAPS_COLORKEY = 0x00400000;
    [NativeTypeName("#define DDCAPS_ALPHA 0x00800000l")]
    public const int DDCAPS_ALPHA = 0x00800000;
    [NativeTypeName("#define DDCAPS_COLORKEYHWASSIST 0x01000000l")]
    public const int DDCAPS_COLORKEYHWASSIST = 0x01000000;
    [NativeTypeName("#define DDCAPS_NOHARDWARE 0x02000000l")]
    public const int DDCAPS_NOHARDWARE = 0x02000000;
    [NativeTypeName("#define DDCAPS_BLTCOLORFILL 0x04000000l")]
    public const int DDCAPS_BLTCOLORFILL = 0x04000000;
    [NativeTypeName("#define DDCAPS_BANKSWITCHED 0x08000000l")]
    public const int DDCAPS_BANKSWITCHED = 0x08000000;
    [NativeTypeName("#define DDCAPS_BLTDEPTHFILL 0x10000000l")]
    public const int DDCAPS_BLTDEPTHFILL = 0x10000000;
    [NativeTypeName("#define DDCAPS_CANCLIP 0x20000000l")]
    public const int DDCAPS_CANCLIP = 0x20000000;
    [NativeTypeName("#define DDCAPS_CANCLIPSTRETCHED 0x40000000l")]
    public const int DDCAPS_CANCLIPSTRETCHED = 0x40000000;
    [NativeTypeName("#define DDCAPS_CANBLTSYSMEM 0x80000000l")]
    public const uint DDCAPS_CANBLTSYSMEM = 0x80000000;
}