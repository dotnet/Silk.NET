// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DIEP
{
    [NativeTypeName("#define DIEP_DURATION 0x00000001")]
    public const int DIEP_DURATION = 0x00000001;

    [NativeTypeName("#define DIEP_SAMPLEPERIOD 0x00000002")]
    public const int DIEP_SAMPLEPERIOD = 0x00000002;

    [NativeTypeName("#define DIEP_GAIN 0x00000004")]
    public const int DIEP_GAIN = 0x00000004;

    [NativeTypeName("#define DIEP_TRIGGERBUTTON 0x00000008")]
    public const int DIEP_TRIGGERBUTTON = 0x00000008;

    [NativeTypeName("#define DIEP_TRIGGERREPEATINTERVAL 0x00000010")]
    public const int DIEP_TRIGGERREPEATINTERVAL = 0x00000010;

    [NativeTypeName("#define DIEP_AXES 0x00000020")]
    public const int DIEP_AXES = 0x00000020;

    [NativeTypeName("#define DIEP_DIRECTION 0x00000040")]
    public const int DIEP_DIRECTION = 0x00000040;

    [NativeTypeName("#define DIEP_ENVELOPE 0x00000080")]
    public const int DIEP_ENVELOPE = 0x00000080;

    [NativeTypeName("#define DIEP_TYPESPECIFICPARAMS 0x00000100")]
    public const int DIEP_TYPESPECIFICPARAMS = 0x00000100;

    [NativeTypeName("#define DIEP_STARTDELAY 0x00000200")]
    public const int DIEP_STARTDELAY = 0x00000200;

    [NativeTypeName("#define DIEP_ALLPARAMS_DX5 0x000001FF")]
    public const int DIEP_ALLPARAMS_DX5 = 0x000001FF;

    [NativeTypeName("#define DIEP_ALLPARAMS 0x000003FF")]
    public const int DIEP_ALLPARAMS = 0x000003FF;

    [NativeTypeName("#define DIEP_START 0x20000000")]
    public const int DIEP_START = 0x20000000;

    [NativeTypeName("#define DIEP_NORESTART 0x40000000")]
    public const int DIEP_NORESTART = 0x40000000;

    [NativeTypeName("#define DIEP_NODOWNLOAD 0x80000000")]
    public const uint DIEP_NODOWNLOAD = 0x80000000;
}
