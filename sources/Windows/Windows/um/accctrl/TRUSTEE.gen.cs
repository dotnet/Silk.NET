// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class TRUSTEE
{
    [NativeTypeName("#define TRUSTEE_ACCESS_ALLOWED 0x00000001L")]
    public const int TRUSTEE_ACCESS_ALLOWED = 0x00000001;

    [NativeTypeName("#define TRUSTEE_ACCESS_READ 0x00000002L")]
    public const int TRUSTEE_ACCESS_READ = 0x00000002;

    [NativeTypeName("#define TRUSTEE_ACCESS_WRITE 0x00000004L")]
    public const int TRUSTEE_ACCESS_WRITE = 0x00000004;

    [NativeTypeName("#define TRUSTEE_ACCESS_EXPLICIT 0x00000001L")]
    public const int TRUSTEE_ACCESS_EXPLICIT = 0x00000001;

    [NativeTypeName("#define TRUSTEE_ACCESS_READ_WRITE (TRUSTEE_ACCESS_READ |                  \\\r\n                                     TRUSTEE_ACCESS_WRITE)")]
    public const int TRUSTEE_ACCESS_READ_WRITE = (0x00000002 | 0x00000004);

    [NativeTypeName("#define TRUSTEE_ACCESS_ALL 0xFFFFFFFFL")]
    public const uint TRUSTEE_ACCESS_ALL = 0xFFFFFFFF;
}
