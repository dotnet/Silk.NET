// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
public enum D3D11_FENCE_FLAG
{
    D3D11_FENCE_FLAG_NONE = 0,
    D3D11_FENCE_FLAG_SHARED = 0x2,
    D3D11_FENCE_FLAG_SHARED_CROSS_ADAPTER = 0x4,
    D3D11_FENCE_FLAG_NON_MONITORED = 0x8,
}
