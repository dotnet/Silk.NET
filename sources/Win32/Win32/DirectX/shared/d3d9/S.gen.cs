// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class S
{
    [NativeTypeName("#define S_NOT_RESIDENT MAKE_D3DSTATUS(2165)")]
    public const int S_NOT_RESIDENT = unchecked(
        (int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2165)))
    );

    [NativeTypeName("#define S_RESIDENT_IN_SHARED_MEMORY MAKE_D3DSTATUS(2166)")]
    public const int S_RESIDENT_IN_SHARED_MEMORY = unchecked(
        (int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2166)))
    );

    [NativeTypeName("#define S_PRESENT_MODE_CHANGED MAKE_D3DSTATUS(2167)")]
    public const int S_PRESENT_MODE_CHANGED = unchecked(
        (int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2167)))
    );

    [NativeTypeName("#define S_PRESENT_OCCLUDED MAKE_D3DSTATUS(2168)")]
    public const int S_PRESENT_OCCLUDED = unchecked(
        (int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2168)))
    );
}
