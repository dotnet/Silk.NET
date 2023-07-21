// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class GCL
{
    [NativeTypeName("#define GCL_CONVERSION 0x0001")]
    public const int GCL_CONVERSION = 0x0001;

    [NativeTypeName("#define GCL_REVERSECONVERSION 0x0002")]
    public const int GCL_REVERSECONVERSION = 0x0002;

    [NativeTypeName("#define GCL_REVERSE_LENGTH 0x0003")]
    public const int GCL_REVERSE_LENGTH = 0x0003;
}
