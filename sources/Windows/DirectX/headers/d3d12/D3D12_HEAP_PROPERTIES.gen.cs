// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_HEAP_PROPERTIES.xml' path='doc/member[@name="D3D12_HEAP_PROPERTIES"]/*'/>
public partial struct D3D12_HEAP_PROPERTIES
{
    /// <include file='D3D12_HEAP_PROPERTIES.xml' path='doc/member[@name="D3D12_HEAP_PROPERTIES.Type"]/*'/>
    public D3D12_HEAP_TYPE Type;
    /// <include file='D3D12_HEAP_PROPERTIES.xml' path='doc/member[@name="D3D12_HEAP_PROPERTIES.CPUPageProperty"]/*'/>
    public D3D12_CPU_PAGE_PROPERTY CPUPageProperty;
    /// <include file='D3D12_HEAP_PROPERTIES.xml' path='doc/member[@name="D3D12_HEAP_PROPERTIES.MemoryPoolPreference"]/*'/>
    public D3D12_MEMORY_POOL MemoryPoolPreference;
    /// <include file='D3D12_HEAP_PROPERTIES.xml' path='doc/member[@name="D3D12_HEAP_PROPERTIES.CreationNodeMask"]/*'/>
    public uint CreationNodeMask;
    /// <include file='D3D12_HEAP_PROPERTIES.xml' path='doc/member[@name="D3D12_HEAP_PROPERTIES.VisibleNodeMask"]/*'/>
    public uint VisibleNodeMask;
}