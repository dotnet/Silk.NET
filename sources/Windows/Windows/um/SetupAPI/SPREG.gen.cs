// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SPREG
{
    [NativeTypeName("#define SPREG_SUCCESS 0x00000000")]
    public const int SPREG_SUCCESS = 0x00000000;

    [NativeTypeName("#define SPREG_LOADLIBRARY 0x00000001")]
    public const int SPREG_LOADLIBRARY = 0x00000001;

    [NativeTypeName("#define SPREG_GETPROCADDR 0x00000002")]
    public const int SPREG_GETPROCADDR = 0x00000002;

    [NativeTypeName("#define SPREG_REGSVR 0x00000003")]
    public const int SPREG_REGSVR = 0x00000003;

    [NativeTypeName("#define SPREG_DLLINSTALL 0x00000004")]
    public const int SPREG_DLLINSTALL = 0x00000004;

    [NativeTypeName("#define SPREG_TIMEOUT 0x00000005")]
    public const int SPREG_TIMEOUT = 0x00000005;

    [NativeTypeName("#define SPREG_UNKNOWN 0xFFFFFFFF")]
    public const uint SPREG_UNKNOWN = 0xFFFFFFFF;
}
