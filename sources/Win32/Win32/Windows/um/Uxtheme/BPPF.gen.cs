// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class BPPF
{
    [NativeTypeName("#define BPPF_ERASE 0x0001")]
    public const int BPPF_ERASE = 0x0001;

    [NativeTypeName("#define BPPF_NOCLIP 0x0002")]
    public const int BPPF_NOCLIP = 0x0002;

    [NativeTypeName("#define BPPF_NONCLIENT 0x0004")]
    public const int BPPF_NONCLIENT = 0x0004;
}
