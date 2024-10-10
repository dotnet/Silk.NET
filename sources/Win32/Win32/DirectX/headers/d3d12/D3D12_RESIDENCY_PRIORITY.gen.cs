// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_RESIDENCY_PRIORITY.xml' path='doc/member[@name="D3D12_RESIDENCY_PRIORITY"]/*'/>
public enum D3D12_RESIDENCY_PRIORITY
{
    /// <include file='D3D12_RESIDENCY_PRIORITY.xml' path='doc/member[@name="D3D12_RESIDENCY_PRIORITY.D3D12_RESIDENCY_PRIORITY_MINIMUM"]/*'/>

    D3D12_RESIDENCY_PRIORITY_MINIMUM = 0x28000000,

    /// <include file='D3D12_RESIDENCY_PRIORITY.xml' path='doc/member[@name="D3D12_RESIDENCY_PRIORITY.D3D12_RESIDENCY_PRIORITY_LOW"]/*'/>

    D3D12_RESIDENCY_PRIORITY_LOW = 0x50000000,

    /// <include file='D3D12_RESIDENCY_PRIORITY.xml' path='doc/member[@name="D3D12_RESIDENCY_PRIORITY.D3D12_RESIDENCY_PRIORITY_NORMAL"]/*'/>

    D3D12_RESIDENCY_PRIORITY_NORMAL = 0x78000000,

    /// <include file='D3D12_RESIDENCY_PRIORITY.xml' path='doc/member[@name="D3D12_RESIDENCY_PRIORITY.D3D12_RESIDENCY_PRIORITY_HIGH"]/*'/>

    D3D12_RESIDENCY_PRIORITY_HIGH = unchecked((int)(0xa0010000)),

    /// <include file='D3D12_RESIDENCY_PRIORITY.xml' path='doc/member[@name="D3D12_RESIDENCY_PRIORITY.D3D12_RESIDENCY_PRIORITY_MAXIMUM"]/*'/>

    D3D12_RESIDENCY_PRIORITY_MAXIMUM = unchecked((int)(0xc8000000)),
}
