// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DDCAPS2
{
    [NativeTypeName("#define DDCAPS2_CERTIFIED 0x00000001l")]
    public const int DDCAPS2_CERTIFIED = 0x00000001;

    [NativeTypeName("#define DDCAPS2_NO2DDURING3DSCENE 0x00000002l")]
    public const int DDCAPS2_NO2DDURING3DSCENE = 0x00000002;

    [NativeTypeName("#define DDCAPS2_VIDEOPORT 0x00000004l")]
    public const int DDCAPS2_VIDEOPORT = 0x00000004;

    [NativeTypeName("#define DDCAPS2_AUTOFLIPOVERLAY 0x00000008l")]
    public const int DDCAPS2_AUTOFLIPOVERLAY = 0x00000008;

    [NativeTypeName("#define DDCAPS2_CANBOBINTERLEAVED 0x00000010l")]
    public const int DDCAPS2_CANBOBINTERLEAVED = 0x00000010;

    [NativeTypeName("#define DDCAPS2_CANBOBNONINTERLEAVED 0x00000020l")]
    public const int DDCAPS2_CANBOBNONINTERLEAVED = 0x00000020;

    [NativeTypeName("#define DDCAPS2_COLORCONTROLOVERLAY 0x00000040l")]
    public const int DDCAPS2_COLORCONTROLOVERLAY = 0x00000040;

    [NativeTypeName("#define DDCAPS2_COLORCONTROLPRIMARY 0x00000080l")]
    public const int DDCAPS2_COLORCONTROLPRIMARY = 0x00000080;

    [NativeTypeName("#define DDCAPS2_CANDROPZ16BIT 0x00000100l")]
    public const int DDCAPS2_CANDROPZ16BIT = 0x00000100;

    [NativeTypeName("#define DDCAPS2_NONLOCALVIDMEM 0x00000200l")]
    public const int DDCAPS2_NONLOCALVIDMEM = 0x00000200;

    [NativeTypeName("#define DDCAPS2_NONLOCALVIDMEMCAPS 0x00000400l")]
    public const int DDCAPS2_NONLOCALVIDMEMCAPS = 0x00000400;

    [NativeTypeName("#define DDCAPS2_NOPAGELOCKREQUIRED 0x00000800l")]
    public const int DDCAPS2_NOPAGELOCKREQUIRED = 0x00000800;

    [NativeTypeName("#define DDCAPS2_WIDESURFACES 0x00001000l")]
    public const int DDCAPS2_WIDESURFACES = 0x00001000;

    [NativeTypeName("#define DDCAPS2_CANFLIPODDEVEN 0x00002000l")]
    public const int DDCAPS2_CANFLIPODDEVEN = 0x00002000;

    [NativeTypeName("#define DDCAPS2_CANBOBHARDWARE 0x00004000l")]
    public const int DDCAPS2_CANBOBHARDWARE = 0x00004000;

    [NativeTypeName("#define DDCAPS2_COPYFOURCC 0x00008000l")]
    public const int DDCAPS2_COPYFOURCC = 0x00008000;

    [NativeTypeName("#define DDCAPS2_PRIMARYGAMMA 0x00020000l")]
    public const int DDCAPS2_PRIMARYGAMMA = 0x00020000;

    [NativeTypeName("#define DDCAPS2_CANRENDERWINDOWED 0x00080000l")]
    public const int DDCAPS2_CANRENDERWINDOWED = 0x00080000;

    [NativeTypeName("#define DDCAPS2_CANCALIBRATEGAMMA 0x00100000l")]
    public const int DDCAPS2_CANCALIBRATEGAMMA = 0x00100000;

    [NativeTypeName("#define DDCAPS2_FLIPINTERVAL 0x00200000l")]
    public const int DDCAPS2_FLIPINTERVAL = 0x00200000;

    [NativeTypeName("#define DDCAPS2_FLIPNOVSYNC 0x00400000l")]
    public const int DDCAPS2_FLIPNOVSYNC = 0x00400000;

    [NativeTypeName("#define DDCAPS2_CANMANAGETEXTURE 0x00800000l")]
    public const int DDCAPS2_CANMANAGETEXTURE = 0x00800000;

    [NativeTypeName("#define DDCAPS2_TEXMANINNONLOCALVIDMEM 0x01000000l")]
    public const int DDCAPS2_TEXMANINNONLOCALVIDMEM = 0x01000000;

    [NativeTypeName("#define DDCAPS2_STEREO 0x02000000L")]
    public const int DDCAPS2_STEREO = 0x02000000;

    [NativeTypeName("#define DDCAPS2_SYSTONONLOCAL_AS_SYSTOLOCAL 0x04000000L")]
    public const int DDCAPS2_SYSTONONLOCAL_AS_SYSTOLOCAL = 0x04000000;

    [NativeTypeName("#define DDCAPS2_RESERVED1 0x08000000L")]
    public const int DDCAPS2_RESERVED1 = 0x08000000;

    [NativeTypeName("#define DDCAPS2_CANMANAGERESOURCE 0x10000000L")]
    public const int DDCAPS2_CANMANAGERESOURCE = 0x10000000;

    [NativeTypeName("#define DDCAPS2_DYNAMICTEXTURES 0x20000000L")]
    public const int DDCAPS2_DYNAMICTEXTURES = 0x20000000;

    [NativeTypeName("#define DDCAPS2_CANAUTOGENMIPMAP 0x40000000L")]
    public const int DDCAPS2_CANAUTOGENMIPMAP = 0x40000000;

    [NativeTypeName("#define DDCAPS2_CANSHARERESOURCE 0x80000000L")]
    public const uint DDCAPS2_CANSHARERESOURCE = 0x80000000;
}
