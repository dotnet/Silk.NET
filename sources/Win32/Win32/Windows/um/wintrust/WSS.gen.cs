// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class WSS
{
    [NativeTypeName("#define WSS_VERIFY_SPECIFIC 0x00000001")]
    public const int WSS_VERIFY_SPECIFIC = 0x00000001;

    [NativeTypeName("#define WSS_GET_SECONDARY_SIG_COUNT 0x00000002")]
    public const int WSS_GET_SECONDARY_SIG_COUNT = 0x00000002;

    [NativeTypeName("#define WSS_VERIFY_SEALING 0x00000004")]
    public const int WSS_VERIFY_SEALING = 0x00000004;

    [NativeTypeName("#define WSS_INPUT_FLAG_MASK 0x00000007")]
    public const int WSS_INPUT_FLAG_MASK = 0x00000007;

    [NativeTypeName("#define WSS_OUT_SEALING_STATUS_VERIFIED 0x80000000")]
    public const uint WSS_OUT_SEALING_STATUS_VERIFIED = 0x80000000;

    [NativeTypeName("#define WSS_OUT_HAS_SEALING_INTENT 0x40000000")]
    public const int WSS_OUT_HAS_SEALING_INTENT = 0x40000000;

    [NativeTypeName("#define WSS_OUT_FILE_SUPPORTS_SEAL 0x20000000")]
    public const int WSS_OUT_FILE_SUPPORTS_SEAL = 0x20000000;

    [NativeTypeName("#define WSS_OUTPUT_FLAG_MASK 0xe0000000")]
    public const uint WSS_OUTPUT_FLAG_MASK = 0xe0000000;

    [NativeTypeName("#define WSS_OBJTRUST_SUPPORT 0x00000001")]
    public const int WSS_OBJTRUST_SUPPORT = 0x00000001;

    [NativeTypeName("#define WSS_SIGTRUST_SUPPORT 0x00000002")]
    public const int WSS_SIGTRUST_SUPPORT = 0x00000002;

    [NativeTypeName("#define WSS_CERTTRUST_SUPPORT 0x00000004")]
    public const int WSS_CERTTRUST_SUPPORT = 0x00000004;
}
