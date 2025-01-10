// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DOK
{
    [NativeTypeName("#define D3DOK_NOAUTOGEN MAKE_D3DSTATUS(2159)")]
    public const int D3DOK_NOAUTOGEN = unchecked(
        (int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2159)))
    );
}
