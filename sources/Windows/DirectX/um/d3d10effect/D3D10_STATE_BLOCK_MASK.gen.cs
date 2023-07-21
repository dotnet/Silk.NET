// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK"]/*' />
public unsafe partial struct D3D10_STATE_BLOCK_MASK
{
    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.VS"]/*' />
    public byte VS;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.VSSamplers"]/*' />
    [NativeTypeName("BYTE[2]")]
    public fixed byte VSSamplers[2];

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.VSShaderResources"]/*' />
    [NativeTypeName("BYTE[16]")]
    public fixed byte VSShaderResources[16];

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.VSConstantBuffers"]/*' />
    [NativeTypeName("BYTE[2]")]
    public fixed byte VSConstantBuffers[2];

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.GS"]/*' />
    public byte GS;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.GSSamplers"]/*' />
    [NativeTypeName("BYTE[2]")]
    public fixed byte GSSamplers[2];

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.GSShaderResources"]/*' />
    [NativeTypeName("BYTE[16]")]
    public fixed byte GSShaderResources[16];

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.GSConstantBuffers"]/*' />
    [NativeTypeName("BYTE[2]")]
    public fixed byte GSConstantBuffers[2];

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.PS"]/*' />
    public byte PS;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.PSSamplers"]/*' />
    [NativeTypeName("BYTE[2]")]
    public fixed byte PSSamplers[2];

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.PSShaderResources"]/*' />
    [NativeTypeName("BYTE[16]")]
    public fixed byte PSShaderResources[16];

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.PSConstantBuffers"]/*' />
    [NativeTypeName("BYTE[2]")]
    public fixed byte PSConstantBuffers[2];

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.IAVertexBuffers"]/*' />
    [NativeTypeName("BYTE[2]")]
    public fixed byte IAVertexBuffers[2];

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.IAIndexBuffer"]/*' />
    public byte IAIndexBuffer;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.IAInputLayout"]/*' />
    public byte IAInputLayout;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.IAPrimitiveTopology"]/*' />
    public byte IAPrimitiveTopology;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.OMRenderTargets"]/*' />
    public byte OMRenderTargets;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.OMDepthStencilState"]/*' />
    public byte OMDepthStencilState;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.OMBlendState"]/*' />
    public byte OMBlendState;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.RSViewports"]/*' />
    public byte RSViewports;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.RSScissorRects"]/*' />
    public byte RSScissorRects;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.RSRasterizerState"]/*' />
    public byte RSRasterizerState;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.SOBuffers"]/*' />
    public byte SOBuffers;

    /// <include file='D3D10_STATE_BLOCK_MASK.xml' path='doc/member[@name="D3D10_STATE_BLOCK_MASK.Predication"]/*' />
    public byte Predication;
}
