// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class DDFXCAPS
{
    [NativeTypeName("#define DDFXCAPS_BLTARITHSTRETCHY 0x00000020l")]
    public const int DDFXCAPS_BLTARITHSTRETCHY = 0x00000020;
    [NativeTypeName("#define DDFXCAPS_BLTARITHSTRETCHYN 0x00000010l")]
    public const int DDFXCAPS_BLTARITHSTRETCHYN = 0x00000010;
    [NativeTypeName("#define DDFXCAPS_BLTMIRRORLEFTRIGHT 0x00000040l")]
    public const int DDFXCAPS_BLTMIRRORLEFTRIGHT = 0x00000040;
    [NativeTypeName("#define DDFXCAPS_BLTMIRRORUPDOWN 0x00000080l")]
    public const int DDFXCAPS_BLTMIRRORUPDOWN = 0x00000080;
    [NativeTypeName("#define DDFXCAPS_BLTROTATION 0x00000100l")]
    public const int DDFXCAPS_BLTROTATION = 0x00000100;
    [NativeTypeName("#define DDFXCAPS_BLTROTATION90 0x00000200l")]
    public const int DDFXCAPS_BLTROTATION90 = 0x00000200;
    [NativeTypeName("#define DDFXCAPS_BLTSHRINKX 0x00000400l")]
    public const int DDFXCAPS_BLTSHRINKX = 0x00000400;
    [NativeTypeName("#define DDFXCAPS_BLTSHRINKXN 0x00000800l")]
    public const int DDFXCAPS_BLTSHRINKXN = 0x00000800;
    [NativeTypeName("#define DDFXCAPS_BLTSHRINKY 0x00001000l")]
    public const int DDFXCAPS_BLTSHRINKY = 0x00001000;
    [NativeTypeName("#define DDFXCAPS_BLTSHRINKYN 0x00002000l")]
    public const int DDFXCAPS_BLTSHRINKYN = 0x00002000;
    [NativeTypeName("#define DDFXCAPS_BLTSTRETCHX 0x00004000l")]
    public const int DDFXCAPS_BLTSTRETCHX = 0x00004000;
    [NativeTypeName("#define DDFXCAPS_BLTSTRETCHXN 0x00008000l")]
    public const int DDFXCAPS_BLTSTRETCHXN = 0x00008000;
    [NativeTypeName("#define DDFXCAPS_BLTSTRETCHY 0x00010000l")]
    public const int DDFXCAPS_BLTSTRETCHY = 0x00010000;
    [NativeTypeName("#define DDFXCAPS_BLTSTRETCHYN 0x00020000l")]
    public const int DDFXCAPS_BLTSTRETCHYN = 0x00020000;
    [NativeTypeName("#define DDFXCAPS_OVERLAYARITHSTRETCHY 0x00040000l")]
    public const int DDFXCAPS_OVERLAYARITHSTRETCHY = 0x00040000;
    [NativeTypeName("#define DDFXCAPS_OVERLAYARITHSTRETCHYN 0x00000008l")]
    public const int DDFXCAPS_OVERLAYARITHSTRETCHYN = 0x00000008;
    [NativeTypeName("#define DDFXCAPS_OVERLAYSHRINKX 0x00080000l")]
    public const int DDFXCAPS_OVERLAYSHRINKX = 0x00080000;
    [NativeTypeName("#define DDFXCAPS_OVERLAYSHRINKXN 0x00100000l")]
    public const int DDFXCAPS_OVERLAYSHRINKXN = 0x00100000;
    [NativeTypeName("#define DDFXCAPS_OVERLAYSHRINKY 0x00200000l")]
    public const int DDFXCAPS_OVERLAYSHRINKY = 0x00200000;
    [NativeTypeName("#define DDFXCAPS_OVERLAYSHRINKYN 0x00400000l")]
    public const int DDFXCAPS_OVERLAYSHRINKYN = 0x00400000;
    [NativeTypeName("#define DDFXCAPS_OVERLAYSTRETCHX 0x00800000l")]
    public const int DDFXCAPS_OVERLAYSTRETCHX = 0x00800000;
    [NativeTypeName("#define DDFXCAPS_OVERLAYSTRETCHXN 0x01000000l")]
    public const int DDFXCAPS_OVERLAYSTRETCHXN = 0x01000000;
    [NativeTypeName("#define DDFXCAPS_OVERLAYSTRETCHY 0x02000000l")]
    public const int DDFXCAPS_OVERLAYSTRETCHY = 0x02000000;
    [NativeTypeName("#define DDFXCAPS_OVERLAYSTRETCHYN 0x04000000l")]
    public const int DDFXCAPS_OVERLAYSTRETCHYN = 0x04000000;
    [NativeTypeName("#define DDFXCAPS_OVERLAYMIRRORLEFTRIGHT 0x08000000l")]
    public const int DDFXCAPS_OVERLAYMIRRORLEFTRIGHT = 0x08000000;
    [NativeTypeName("#define DDFXCAPS_OVERLAYMIRRORUPDOWN 0x10000000l")]
    public const int DDFXCAPS_OVERLAYMIRRORUPDOWN = 0x10000000;
    [NativeTypeName("#define DDFXCAPS_OVERLAYDEINTERLACE 0x20000000l")]
    public const int DDFXCAPS_OVERLAYDEINTERLACE = 0x20000000;
    [NativeTypeName("#define DDFXCAPS_BLTALPHA 0x00000001l")]
    public const int DDFXCAPS_BLTALPHA = 0x00000001;
    [NativeTypeName("#define DDFXCAPS_BLTFILTER DDFXCAPS_BLTARITHSTRETCHY")]
    public const int DDFXCAPS_BLTFILTER = 0x00000020;
    [NativeTypeName("#define DDFXCAPS_OVERLAYALPHA 0x00000004l")]
    public const int DDFXCAPS_OVERLAYALPHA = 0x00000004;
    [NativeTypeName("#define DDFXCAPS_OVERLAYFILTER DDFXCAPS_OVERLAYARITHSTRETCHY")]
    public const int DDFXCAPS_OVERLAYFILTER = 0x00040000;
}