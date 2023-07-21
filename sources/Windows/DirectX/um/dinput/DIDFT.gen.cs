// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

public static partial class DIDFT
{
    [NativeTypeName("#define DIDFT_ALL 0x00000000")]
    public const int DIDFT_ALL = 0x00000000;

    [NativeTypeName("#define DIDFT_RELAXIS 0x00000001")]
    public const int DIDFT_RELAXIS = 0x00000001;

    [NativeTypeName("#define DIDFT_ABSAXIS 0x00000002")]
    public const int DIDFT_ABSAXIS = 0x00000002;

    [NativeTypeName("#define DIDFT_AXIS 0x00000003")]
    public const int DIDFT_AXIS = 0x00000003;

    [NativeTypeName("#define DIDFT_PSHBUTTON 0x00000004")]
    public const int DIDFT_PSHBUTTON = 0x00000004;

    [NativeTypeName("#define DIDFT_TGLBUTTON 0x00000008")]
    public const int DIDFT_TGLBUTTON = 0x00000008;

    [NativeTypeName("#define DIDFT_BUTTON 0x0000000C")]
    public const int DIDFT_BUTTON = 0x0000000C;

    [NativeTypeName("#define DIDFT_POV 0x00000010")]
    public const int DIDFT_POV = 0x00000010;

    [NativeTypeName("#define DIDFT_COLLECTION 0x00000040")]
    public const int DIDFT_COLLECTION = 0x00000040;

    [NativeTypeName("#define DIDFT_NODATA 0x00000080")]
    public const int DIDFT_NODATA = 0x00000080;

    [NativeTypeName("#define DIDFT_ANYINSTANCE 0x00FFFF00")]
    public const int DIDFT_ANYINSTANCE = 0x00FFFF00;

    [NativeTypeName("#define DIDFT_INSTANCEMASK DIDFT_ANYINSTANCE")]
    public const int DIDFT_INSTANCEMASK = 0x00FFFF00;

    [NativeTypeName("#define DIDFT_FFACTUATOR 0x01000000")]
    public const int DIDFT_FFACTUATOR = 0x01000000;

    [NativeTypeName("#define DIDFT_FFEFFECTTRIGGER 0x02000000")]
    public const int DIDFT_FFEFFECTTRIGGER = 0x02000000;

    [NativeTypeName("#define DIDFT_OUTPUT 0x10000000")]
    public const int DIDFT_OUTPUT = 0x10000000;

    [NativeTypeName("#define DIDFT_VENDORDEFINED 0x04000000")]
    public const int DIDFT_VENDORDEFINED = 0x04000000;

    [NativeTypeName("#define DIDFT_ALIAS 0x08000000")]
    public const int DIDFT_ALIAS = 0x08000000;

    [NativeTypeName("#define DIDFT_NOCOLLECTION 0x00FFFF00")]
    public const int DIDFT_NOCOLLECTION = 0x00FFFF00;
}
