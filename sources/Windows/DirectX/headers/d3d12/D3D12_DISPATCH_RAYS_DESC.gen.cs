// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_DISPATCH_RAYS_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_RAYS_DESC"]/*' />
public partial struct D3D12_DISPATCH_RAYS_DESC
{
    /// <include file='D3D12_DISPATCH_RAYS_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_RAYS_DESC.RayGenerationShaderRecord"]/*' />
    public D3D12_GPU_VIRTUAL_ADDRESS_RANGE RayGenerationShaderRecord;

    /// <include file='D3D12_DISPATCH_RAYS_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_RAYS_DESC.MissShaderTable"]/*' />
    public D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE MissShaderTable;

    /// <include file='D3D12_DISPATCH_RAYS_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_RAYS_DESC.HitGroupTable"]/*' />
    public D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE HitGroupTable;

    /// <include file='D3D12_DISPATCH_RAYS_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_RAYS_DESC.CallableShaderTable"]/*' />
    public D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE CallableShaderTable;

    /// <include file='D3D12_DISPATCH_RAYS_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_RAYS_DESC.Width"]/*' />
    public uint Width;

    /// <include file='D3D12_DISPATCH_RAYS_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_RAYS_DESC.Height"]/*' />
    public uint Height;

    /// <include file='D3D12_DISPATCH_RAYS_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_RAYS_DESC.Depth"]/*' />
    public uint Depth;
}
