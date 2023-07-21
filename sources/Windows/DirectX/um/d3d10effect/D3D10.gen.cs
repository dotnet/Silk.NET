// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

public static partial class D3D10
{
    [NativeTypeName("#define D3D10_EFFECT_COMPILE_CHILD_EFFECT (1 << 0)")]
    public const int D3D10_EFFECT_COMPILE_CHILD_EFFECT = (1 << 0);

    [NativeTypeName("#define D3D10_EFFECT_COMPILE_ALLOW_SLOW_OPS (1 << 1)")]
    public const int D3D10_EFFECT_COMPILE_ALLOW_SLOW_OPS = (1 << 1);

    [NativeTypeName("#define D3D10_EFFECT_SINGLE_THREADED (1 << 3)")]
    public const int D3D10_EFFECT_SINGLE_THREADED = (1 << 3);

    [NativeTypeName("#define D3D10_EFFECT_VARIABLE_POOLED (1 << 0)")]
    public const int D3D10_EFFECT_VARIABLE_POOLED = (1 << 0);

    [NativeTypeName("#define D3D10_EFFECT_VARIABLE_ANNOTATION (1 << 1)")]
    public const int D3D10_EFFECT_VARIABLE_ANNOTATION = (1 << 1);

    [NativeTypeName("#define D3D10_EFFECT_VARIABLE_EXPLICIT_BIND_POINT (1 << 2)")]
    public const int D3D10_EFFECT_VARIABLE_EXPLICIT_BIND_POINT = (1 << 2);
}
