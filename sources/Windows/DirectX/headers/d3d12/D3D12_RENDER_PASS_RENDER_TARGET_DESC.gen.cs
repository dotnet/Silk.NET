// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_RENDER_PASS_RENDER_TARGET_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_RENDER_TARGET_DESC"]/*' />
public partial struct D3D12_RENDER_PASS_RENDER_TARGET_DESC
{
    /// <include file='D3D12_RENDER_PASS_RENDER_TARGET_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_RENDER_TARGET_DESC.cpuDescriptor"]/*' />
    public D3D12_CPU_DESCRIPTOR_HANDLE cpuDescriptor;

    /// <include file='D3D12_RENDER_PASS_RENDER_TARGET_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_RENDER_TARGET_DESC.BeginningAccess"]/*' />
    public D3D12_RENDER_PASS_BEGINNING_ACCESS BeginningAccess;

    /// <include file='D3D12_RENDER_PASS_RENDER_TARGET_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_RENDER_TARGET_DESC.EndingAccess"]/*' />
    public D3D12_RENDER_PASS_ENDING_ACCESS EndingAccess;
}
