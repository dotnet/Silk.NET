// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define GXFPF_ROUND_NEAREST ( 0x1 )")]
    public const int GXFPF_ROUND_NEAREST = (0x1);

    [NativeTypeName("#define GXFPF_NEAREST ( 0x2 )")]
    public const int GXFPF_NEAREST = (0x2);
}
