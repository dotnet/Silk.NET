// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DVS20CAPS
{
    [NativeTypeName("#define D3DVS20CAPS_PREDICATION (1<<0)")]
    public const int D3DVS20CAPS_PREDICATION = (1 << 0);
}
