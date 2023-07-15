// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class SIGNERSCORE
{
    [NativeTypeName("#define SIGNERSCORE_UNKNOWN 0xFF000000")]
    public const uint SIGNERSCORE_UNKNOWN = 0xFF000000;
    [NativeTypeName("#define SIGNERSCORE_W9X_SUSPECT 0xC0000000")]
    public const uint SIGNERSCORE_W9X_SUSPECT = 0xC0000000;
    [NativeTypeName("#define SIGNERSCORE_UNSIGNED 0x80000000")]
    public const uint SIGNERSCORE_UNSIGNED = 0x80000000;
    [NativeTypeName("#define SIGNERSCORE_AUTHENTICODE 0x0F000000")]
    public const int SIGNERSCORE_AUTHENTICODE = 0x0F000000;
    [NativeTypeName("#define SIGNERSCORE_WHQL 0x0D000005")]
    public const int SIGNERSCORE_WHQL = 0x0D000005;
    [NativeTypeName("#define SIGNERSCORE_UNCLASSIFIED 0x0D000004")]
    public const int SIGNERSCORE_UNCLASSIFIED = 0x0D000004;
    [NativeTypeName("#define SIGNERSCORE_INBOX 0x0D000003")]
    public const int SIGNERSCORE_INBOX = 0x0D000003;
    [NativeTypeName("#define SIGNERSCORE_LOGO_STANDARD 0x0D000002")]
    public const int SIGNERSCORE_LOGO_STANDARD = 0x0D000002;
    [NativeTypeName("#define SIGNERSCORE_LOGO_PREMIUM 0x0D000001")]
    public const int SIGNERSCORE_LOGO_PREMIUM = 0x0D000001;
    [NativeTypeName("#define SIGNERSCORE_MASK 0xFF000000")]
    public const uint SIGNERSCORE_MASK = 0xFF000000;
    [NativeTypeName("#define SIGNERSCORE_SIGNED_MASK 0xF0000000")]
    public const uint SIGNERSCORE_SIGNED_MASK = 0xF0000000;
}