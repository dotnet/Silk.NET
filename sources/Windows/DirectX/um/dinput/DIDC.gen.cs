// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public static partial class DIDC
{
    [NativeTypeName("#define DIDC_ATTACHED 0x00000001")]
    public const int DIDC_ATTACHED = 0x00000001;
    [NativeTypeName("#define DIDC_POLLEDDEVICE 0x00000002")]
    public const int DIDC_POLLEDDEVICE = 0x00000002;
    [NativeTypeName("#define DIDC_EMULATED 0x00000004")]
    public const int DIDC_EMULATED = 0x00000004;
    [NativeTypeName("#define DIDC_POLLEDDATAFORMAT 0x00000008")]
    public const int DIDC_POLLEDDATAFORMAT = 0x00000008;
    [NativeTypeName("#define DIDC_FORCEFEEDBACK 0x00000100")]
    public const int DIDC_FORCEFEEDBACK = 0x00000100;
    [NativeTypeName("#define DIDC_FFATTACK 0x00000200")]
    public const int DIDC_FFATTACK = 0x00000200;
    [NativeTypeName("#define DIDC_FFFADE 0x00000400")]
    public const int DIDC_FFFADE = 0x00000400;
    [NativeTypeName("#define DIDC_SATURATION 0x00000800")]
    public const int DIDC_SATURATION = 0x00000800;
    [NativeTypeName("#define DIDC_POSNEGCOEFFICIENTS 0x00001000")]
    public const int DIDC_POSNEGCOEFFICIENTS = 0x00001000;
    [NativeTypeName("#define DIDC_POSNEGSATURATION 0x00002000")]
    public const int DIDC_POSNEGSATURATION = 0x00002000;
    [NativeTypeName("#define DIDC_DEADBAND 0x00004000")]
    public const int DIDC_DEADBAND = 0x00004000;
    [NativeTypeName("#define DIDC_STARTDELAY 0x00008000")]
    public const int DIDC_STARTDELAY = 0x00008000;
    [NativeTypeName("#define DIDC_ALIAS 0x00010000")]
    public const int DIDC_ALIAS = 0x00010000;
    [NativeTypeName("#define DIDC_PHANTOM 0x00020000")]
    public const int DIDC_PHANTOM = 0x00020000;
    [NativeTypeName("#define DIDC_HIDDEN 0x00040000")]
    public const int DIDC_HIDDEN = 0x00040000;
}