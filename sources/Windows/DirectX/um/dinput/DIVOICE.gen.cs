// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public static partial class DIVOICE
{
    [NativeTypeName("#define DIVOICE_CHANNEL1 0x83000401")]
    public const uint DIVOICE_CHANNEL1 = 0x83000401;
    [NativeTypeName("#define DIVOICE_CHANNEL2 0x83000402")]
    public const uint DIVOICE_CHANNEL2 = 0x83000402;
    [NativeTypeName("#define DIVOICE_CHANNEL3 0x83000403")]
    public const uint DIVOICE_CHANNEL3 = 0x83000403;
    [NativeTypeName("#define DIVOICE_CHANNEL4 0x83000404")]
    public const uint DIVOICE_CHANNEL4 = 0x83000404;
    [NativeTypeName("#define DIVOICE_CHANNEL5 0x83000405")]
    public const uint DIVOICE_CHANNEL5 = 0x83000405;
    [NativeTypeName("#define DIVOICE_CHANNEL6 0x83000406")]
    public const uint DIVOICE_CHANNEL6 = 0x83000406;
    [NativeTypeName("#define DIVOICE_CHANNEL7 0x83000407")]
    public const uint DIVOICE_CHANNEL7 = 0x83000407;
    [NativeTypeName("#define DIVOICE_CHANNEL8 0x83000408")]
    public const uint DIVOICE_CHANNEL8 = 0x83000408;
    [NativeTypeName("#define DIVOICE_TEAM 0x83000409")]
    public const uint DIVOICE_TEAM = 0x83000409;
    [NativeTypeName("#define DIVOICE_ALL 0x8300040A")]
    public const uint DIVOICE_ALL = 0x8300040A;
    [NativeTypeName("#define DIVOICE_RECORDMUTE 0x8300040B")]
    public const uint DIVOICE_RECORDMUTE = 0x8300040B;
    [NativeTypeName("#define DIVOICE_PLAYBACKMUTE 0x8300040C")]
    public const uint DIVOICE_PLAYBACKMUTE = 0x8300040C;
    [NativeTypeName("#define DIVOICE_TRANSMIT 0x8300040D")]
    public const uint DIVOICE_TRANSMIT = 0x8300040D;
    [NativeTypeName("#define DIVOICE_VOICECOMMAND 0x83000410")]
    public const uint DIVOICE_VOICECOMMAND = 0x83000410;
}