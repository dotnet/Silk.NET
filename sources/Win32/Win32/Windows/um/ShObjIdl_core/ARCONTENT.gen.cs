// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class ARCONTENT
{
    [NativeTypeName("#define ARCONTENT_AUTORUNINF 0x00000002")]
    public const int ARCONTENT_AUTORUNINF = 0x00000002;

    [NativeTypeName("#define ARCONTENT_AUDIOCD 0x00000004")]
    public const int ARCONTENT_AUDIOCD = 0x00000004;

    [NativeTypeName("#define ARCONTENT_DVDMOVIE 0x00000008")]
    public const int ARCONTENT_DVDMOVIE = 0x00000008;

    [NativeTypeName("#define ARCONTENT_BLANKCD 0x00000010")]
    public const int ARCONTENT_BLANKCD = 0x00000010;

    [NativeTypeName("#define ARCONTENT_BLANKDVD 0x00000020")]
    public const int ARCONTENT_BLANKDVD = 0x00000020;

    [NativeTypeName("#define ARCONTENT_UNKNOWNCONTENT 0x00000040")]
    public const int ARCONTENT_UNKNOWNCONTENT = 0x00000040;

    [NativeTypeName("#define ARCONTENT_AUTOPLAYPIX 0x00000080")]
    public const int ARCONTENT_AUTOPLAYPIX = 0x00000080;

    [NativeTypeName("#define ARCONTENT_AUTOPLAYMUSIC 0x00000100")]
    public const int ARCONTENT_AUTOPLAYMUSIC = 0x00000100;

    [NativeTypeName("#define ARCONTENT_AUTOPLAYVIDEO 0x00000200")]
    public const int ARCONTENT_AUTOPLAYVIDEO = 0x00000200;

    [NativeTypeName("#define ARCONTENT_VCD 0x00000400")]
    public const int ARCONTENT_VCD = 0x00000400;

    [NativeTypeName("#define ARCONTENT_SVCD 0x00000800")]
    public const int ARCONTENT_SVCD = 0x00000800;

    [NativeTypeName("#define ARCONTENT_DVDAUDIO 0x00001000")]
    public const int ARCONTENT_DVDAUDIO = 0x00001000;

    [NativeTypeName("#define ARCONTENT_BLANKBD 0x00002000")]
    public const int ARCONTENT_BLANKBD = 0x00002000;

    [NativeTypeName("#define ARCONTENT_BLURAY 0x00004000")]
    public const int ARCONTENT_BLURAY = 0x00004000;

    [NativeTypeName("#define ARCONTENT_CAMERASTORAGE 0x00008000")]
    public const int ARCONTENT_CAMERASTORAGE = 0x00008000;

    [NativeTypeName("#define ARCONTENT_CUSTOMEVENT 0x00010000")]
    public const int ARCONTENT_CUSTOMEVENT = 0x00010000;

    [NativeTypeName("#define ARCONTENT_NONE 0x00000000")]
    public const int ARCONTENT_NONE = 0x00000000;

    [NativeTypeName("#define ARCONTENT_MASK 0x0001FFFE")]
    public const int ARCONTENT_MASK = 0x0001FFFE;

    [NativeTypeName("#define ARCONTENT_PHASE_UNKNOWN 0x00000000")]
    public const int ARCONTENT_PHASE_UNKNOWN = 0x00000000;

    [NativeTypeName("#define ARCONTENT_PHASE_PRESNIFF 0x10000000")]
    public const int ARCONTENT_PHASE_PRESNIFF = 0x10000000;

    [NativeTypeName("#define ARCONTENT_PHASE_SNIFFING 0x20000000")]
    public const int ARCONTENT_PHASE_SNIFFING = 0x20000000;

    [NativeTypeName("#define ARCONTENT_PHASE_FINAL 0x40000000")]
    public const int ARCONTENT_PHASE_FINAL = 0x40000000;

    [NativeTypeName("#define ARCONTENT_PHASE_MASK 0x70000000")]
    public const int ARCONTENT_PHASE_MASK = 0x70000000;
}
