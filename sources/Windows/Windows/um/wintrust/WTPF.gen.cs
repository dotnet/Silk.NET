// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class WTPF
{
    [NativeTypeName("#define WTPF_TRUSTTEST 0x00000020")]
    public const int WTPF_TRUSTTEST = 0x00000020;

    [NativeTypeName("#define WTPF_TESTCANBEVALID 0x00000080")]
    public const int WTPF_TESTCANBEVALID = 0x00000080;

    [NativeTypeName("#define WTPF_IGNOREEXPIRATION 0x00000100")]
    public const int WTPF_IGNOREEXPIRATION = 0x00000100;

    [NativeTypeName("#define WTPF_IGNOREREVOKATION 0x00000200")]
    public const int WTPF_IGNOREREVOKATION = 0x00000200;

    [NativeTypeName("#define WTPF_OFFLINEOK_IND 0x00000400")]
    public const int WTPF_OFFLINEOK_IND = 0x00000400;

    [NativeTypeName("#define WTPF_OFFLINEOK_COM 0x00000800")]
    public const int WTPF_OFFLINEOK_COM = 0x00000800;

    [NativeTypeName("#define WTPF_OFFLINEOKNBU_IND 0x00001000")]
    public const int WTPF_OFFLINEOKNBU_IND = 0x00001000;

    [NativeTypeName("#define WTPF_OFFLINEOKNBU_COM 0x00002000")]
    public const int WTPF_OFFLINEOKNBU_COM = 0x00002000;

    [NativeTypeName("#define WTPF_VERIFY_V1_OFF 0x00010000")]
    public const int WTPF_VERIFY_V1_OFF = 0x00010000;

    [NativeTypeName("#define WTPF_IGNOREREVOCATIONONTS 0x00020000")]
    public const int WTPF_IGNOREREVOCATIONONTS = 0x00020000;

    [NativeTypeName("#define WTPF_ALLOWONLYPERTRUST 0x00040000")]
    public const int WTPF_ALLOWONLYPERTRUST = 0x00040000;
}
