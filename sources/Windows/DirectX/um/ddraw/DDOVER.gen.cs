// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public static partial class DDOVER
{
    [NativeTypeName("#define DDOVER_ALPHADEST 0x00000001l")]
    public const int DDOVER_ALPHADEST = 0x00000001;
    [NativeTypeName("#define DDOVER_ALPHADESTCONSTOVERRIDE 0x00000002l")]
    public const int DDOVER_ALPHADESTCONSTOVERRIDE = 0x00000002;
    [NativeTypeName("#define DDOVER_ALPHADESTNEG 0x00000004l")]
    public const int DDOVER_ALPHADESTNEG = 0x00000004;
    [NativeTypeName("#define DDOVER_ALPHADESTSURFACEOVERRIDE 0x00000008l")]
    public const int DDOVER_ALPHADESTSURFACEOVERRIDE = 0x00000008;
    [NativeTypeName("#define DDOVER_ALPHAEDGEBLEND 0x00000010l")]
    public const int DDOVER_ALPHAEDGEBLEND = 0x00000010;
    [NativeTypeName("#define DDOVER_ALPHASRC 0x00000020l")]
    public const int DDOVER_ALPHASRC = 0x00000020;
    [NativeTypeName("#define DDOVER_ALPHASRCCONSTOVERRIDE 0x00000040l")]
    public const int DDOVER_ALPHASRCCONSTOVERRIDE = 0x00000040;
    [NativeTypeName("#define DDOVER_ALPHASRCNEG 0x00000080l")]
    public const int DDOVER_ALPHASRCNEG = 0x00000080;
    [NativeTypeName("#define DDOVER_ALPHASRCSURFACEOVERRIDE 0x00000100l")]
    public const int DDOVER_ALPHASRCSURFACEOVERRIDE = 0x00000100;
    [NativeTypeName("#define DDOVER_HIDE 0x00000200l")]
    public const int DDOVER_HIDE = 0x00000200;
    [NativeTypeName("#define DDOVER_KEYDEST 0x00000400l")]
    public const int DDOVER_KEYDEST = 0x00000400;
    [NativeTypeName("#define DDOVER_KEYDESTOVERRIDE 0x00000800l")]
    public const int DDOVER_KEYDESTOVERRIDE = 0x00000800;
    [NativeTypeName("#define DDOVER_KEYSRC 0x00001000l")]
    public const int DDOVER_KEYSRC = 0x00001000;
    [NativeTypeName("#define DDOVER_KEYSRCOVERRIDE 0x00002000l")]
    public const int DDOVER_KEYSRCOVERRIDE = 0x00002000;
    [NativeTypeName("#define DDOVER_SHOW 0x00004000l")]
    public const int DDOVER_SHOW = 0x00004000;
    [NativeTypeName("#define DDOVER_ADDDIRTYRECT 0x00008000l")]
    public const int DDOVER_ADDDIRTYRECT = 0x00008000;
    [NativeTypeName("#define DDOVER_REFRESHDIRTYRECTS 0x00010000l")]
    public const int DDOVER_REFRESHDIRTYRECTS = 0x00010000;
    [NativeTypeName("#define DDOVER_REFRESHALL 0x00020000l")]
    public const int DDOVER_REFRESHALL = 0x00020000;
    [NativeTypeName("#define DDOVER_DDFX 0x00080000l")]
    public const int DDOVER_DDFX = 0x00080000;
    [NativeTypeName("#define DDOVER_AUTOFLIP 0x00100000l")]
    public const int DDOVER_AUTOFLIP = 0x00100000;
    [NativeTypeName("#define DDOVER_BOB 0x00200000l")]
    public const int DDOVER_BOB = 0x00200000;
    [NativeTypeName("#define DDOVER_OVERRIDEBOBWEAVE 0x00400000l")]
    public const int DDOVER_OVERRIDEBOBWEAVE = 0x00400000;
    [NativeTypeName("#define DDOVER_INTERLEAVED 0x00800000l")]
    public const int DDOVER_INTERLEAVED = 0x00800000;
    [NativeTypeName("#define DDOVER_BOBHARDWARE 0x01000000l")]
    public const int DDOVER_BOBHARDWARE = 0x01000000;
    [NativeTypeName("#define DDOVER_ARGBSCALEFACTORS 0x02000000l")]
    public const int DDOVER_ARGBSCALEFACTORS = 0x02000000;
    [NativeTypeName("#define DDOVER_DEGRADEARGBSCALING 0x04000000l")]
    public const int DDOVER_DEGRADEARGBSCALING = 0x04000000;
}