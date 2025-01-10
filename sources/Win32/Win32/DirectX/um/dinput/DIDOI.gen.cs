// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DIDOI
{
    [NativeTypeName("#define DIDOI_FFACTUATOR 0x00000001")]
    public const int DIDOI_FFACTUATOR = 0x00000001;

    [NativeTypeName("#define DIDOI_FFEFFECTTRIGGER 0x00000002")]
    public const int DIDOI_FFEFFECTTRIGGER = 0x00000002;

    [NativeTypeName("#define DIDOI_POLLED 0x00008000")]
    public const int DIDOI_POLLED = 0x00008000;

    [NativeTypeName("#define DIDOI_ASPECTPOSITION 0x00000100")]
    public const int DIDOI_ASPECTPOSITION = 0x00000100;

    [NativeTypeName("#define DIDOI_ASPECTVELOCITY 0x00000200")]
    public const int DIDOI_ASPECTVELOCITY = 0x00000200;

    [NativeTypeName("#define DIDOI_ASPECTACCEL 0x00000300")]
    public const int DIDOI_ASPECTACCEL = 0x00000300;

    [NativeTypeName("#define DIDOI_ASPECTFORCE 0x00000400")]
    public const int DIDOI_ASPECTFORCE = 0x00000400;

    [NativeTypeName("#define DIDOI_ASPECTMASK 0x00000F00")]
    public const int DIDOI_ASPECTMASK = 0x00000F00;

    [NativeTypeName("#define DIDOI_GUIDISUSAGE 0x00010000")]
    public const int DIDOI_GUIDISUSAGE = 0x00010000;
}
