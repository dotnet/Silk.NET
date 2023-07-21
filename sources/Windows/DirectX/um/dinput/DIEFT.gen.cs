// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

public static partial class DIEFT
{
    [NativeTypeName("#define DIEFT_ALL 0x00000000")]
    public const int DIEFT_ALL = 0x00000000;

    [NativeTypeName("#define DIEFT_CONSTANTFORCE 0x00000001")]
    public const int DIEFT_CONSTANTFORCE = 0x00000001;

    [NativeTypeName("#define DIEFT_RAMPFORCE 0x00000002")]
    public const int DIEFT_RAMPFORCE = 0x00000002;

    [NativeTypeName("#define DIEFT_PERIODIC 0x00000003")]
    public const int DIEFT_PERIODIC = 0x00000003;

    [NativeTypeName("#define DIEFT_CONDITION 0x00000004")]
    public const int DIEFT_CONDITION = 0x00000004;

    [NativeTypeName("#define DIEFT_CUSTOMFORCE 0x00000005")]
    public const int DIEFT_CUSTOMFORCE = 0x00000005;

    [NativeTypeName("#define DIEFT_HARDWARE 0x000000FF")]
    public const int DIEFT_HARDWARE = 0x000000FF;

    [NativeTypeName("#define DIEFT_FFATTACK 0x00000200")]
    public const int DIEFT_FFATTACK = 0x00000200;

    [NativeTypeName("#define DIEFT_FFFADE 0x00000400")]
    public const int DIEFT_FFFADE = 0x00000400;

    [NativeTypeName("#define DIEFT_SATURATION 0x00000800")]
    public const int DIEFT_SATURATION = 0x00000800;

    [NativeTypeName("#define DIEFT_POSNEGCOEFFICIENTS 0x00001000")]
    public const int DIEFT_POSNEGCOEFFICIENTS = 0x00001000;

    [NativeTypeName("#define DIEFT_POSNEGSATURATION 0x00002000")]
    public const int DIEFT_POSNEGSATURATION = 0x00002000;

    [NativeTypeName("#define DIEFT_DEADBAND 0x00004000")]
    public const int DIEFT_DEADBAND = 0x00004000;

    [NativeTypeName("#define DIEFT_STARTDELAY 0x00008000")]
    public const int DIEFT_STARTDELAY = 0x00008000;
}
