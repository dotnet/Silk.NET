// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_SHADER_CACHE_SESSION_DESC
{
    public Guid Identifier;
    public D3D12_SHADER_CACHE_MODE Mode;
    public D3D12_SHADER_CACHE_FLAGS Flags;
    public uint MaximumInMemoryCacheSizeBytes;
    public uint MaximumInMemoryCacheEntries;
    public uint MaximumValueFileSizeBytes;

    [NativeTypeName("UINT64")]
    public ulong Version;
}
