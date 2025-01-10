// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DirectX
{
    [NativeTypeName("#define D3DMIN30SHADERINSTRUCTIONS 512")]
    public const int D3DMIN30SHADERINSTRUCTIONS = 512;

    [NativeTypeName("#define D3DMAX30SHADERINSTRUCTIONS 32768")]
    public const int D3DMAX30SHADERINSTRUCTIONS = 32768;
}
