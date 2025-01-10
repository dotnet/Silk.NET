// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12compatibility.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
public enum D3D12_COMPATIBILITY_SHARED_FLAGS
{
    D3D12_COMPATIBILITY_SHARED_FLAG_NONE = 0,
    D3D12_COMPATIBILITY_SHARED_FLAG_NON_NT_HANDLE = 0x1,
    D3D12_COMPATIBILITY_SHARED_FLAG_KEYED_MUTEX = 0x2,
    D3D12_COMPATIBILITY_SHARED_FLAG_9_ON_12 = 0x4,
}
