// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using static Silk.NET.DirectX.D3D12_HEAP_FLAGS;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("struct CD3DX12_HEAP_DESC : D3D12_HEAP_DESC")]
[NativeInheritance("D3D12_HEAP_DESC")]
public unsafe partial struct D3D12_HEAP_DESC
{
    public D3D12_HEAP_DESC(
        [NativeTypeName("UINT64")] ulong size,
        D3D12_HEAP_PROPERTIES properties,
        [NativeTypeName("UINT64")] ulong alignment = 0,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE
    )
    {
        SizeInBytes = size;
        Properties = properties;
        Alignment = alignment;
        Flags = flags;
    }

    public D3D12_HEAP_DESC(
        [NativeTypeName("UINT64")] ulong size,
        D3D12_HEAP_TYPE type,
        [NativeTypeName("UINT64")] ulong alignment = 0,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE
    )
    {
        SizeInBytes = size;
        Properties = new D3D12_HEAP_PROPERTIES(type);
        Alignment = alignment;
        Flags = flags;
    }

    public D3D12_HEAP_DESC(
        [NativeTypeName("UINT64")] ulong size,
        D3D12_CPU_PAGE_PROPERTY cpuPageProperty,
        D3D12_MEMORY_POOL memoryPoolPreference,
        [NativeTypeName("UINT64")] ulong alignment = 0,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE
    )
    {
        SizeInBytes = size;
        Properties = new D3D12_HEAP_PROPERTIES(cpuPageProperty, memoryPoolPreference);
        Alignment = alignment;
        Flags = flags;
    }

    public D3D12_HEAP_DESC(
        [NativeTypeName("const D3D12_RESOURCE_ALLOCATION_INFO &")]
            D3D12_RESOURCE_ALLOCATION_INFO* resAllocInfo,
        D3D12_HEAP_PROPERTIES properties,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE
    )
    {
        SizeInBytes = resAllocInfo->SizeInBytes;
        Properties = properties;
        Alignment = resAllocInfo->Alignment;
        Flags = flags;
    }

    public D3D12_HEAP_DESC(
        [NativeTypeName("const D3D12_RESOURCE_ALLOCATION_INFO &")]
            D3D12_RESOURCE_ALLOCATION_INFO* resAllocInfo,
        D3D12_HEAP_TYPE type,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE
    )
    {
        SizeInBytes = resAllocInfo->SizeInBytes;
        Properties = new D3D12_HEAP_PROPERTIES(type);
        Alignment = resAllocInfo->Alignment;
        Flags = flags;
    }

    public D3D12_HEAP_DESC(
        [NativeTypeName("const D3D12_RESOURCE_ALLOCATION_INFO &")]
            D3D12_RESOURCE_ALLOCATION_INFO* resAllocInfo,
        D3D12_CPU_PAGE_PROPERTY cpuPageProperty,
        D3D12_MEMORY_POOL memoryPoolPreference,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE
    )
    {
        SizeInBytes = resAllocInfo->SizeInBytes;
        Properties = new D3D12_HEAP_PROPERTIES(cpuPageProperty, memoryPoolPreference);
        Alignment = resAllocInfo->Alignment;
        Flags = flags;
    }
}
