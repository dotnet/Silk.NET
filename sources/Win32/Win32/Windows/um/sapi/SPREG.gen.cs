// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SPREG
{
    [NativeTypeName("#define SPREG_USER_ROOT L\"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech\"")]
    public const string SPREG_USER_ROOT = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech";

    [NativeTypeName(
        "#define SPREG_LOCAL_MACHINE_ROOT L\"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\""
    )]
    public const string SPREG_LOCAL_MACHINE_ROOT =
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech";

    [NativeTypeName(
        "#define SPREG_SAFE_USER_TOKENS L\"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\UserTokens\""
    )]
    public const string SPREG_SAFE_USER_TOKENS =
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\UserTokens";
}
