// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D10_STATE_BLOCK_MASK
{
    public byte VS;

    [NativeTypeName("BYTE[2]")]
    public _VSSamplers_e__FixedBuffer VSSamplers;

    [NativeTypeName("BYTE[16]")]
    public _VSShaderResources_e__FixedBuffer VSShaderResources;

    [NativeTypeName("BYTE[2]")]
    public _VSConstantBuffers_e__FixedBuffer VSConstantBuffers;
    public byte GS;

    [NativeTypeName("BYTE[2]")]
    public _GSSamplers_e__FixedBuffer GSSamplers;

    [NativeTypeName("BYTE[16]")]
    public _GSShaderResources_e__FixedBuffer GSShaderResources;

    [NativeTypeName("BYTE[2]")]
    public _GSConstantBuffers_e__FixedBuffer GSConstantBuffers;
    public byte PS;

    [NativeTypeName("BYTE[2]")]
    public _PSSamplers_e__FixedBuffer PSSamplers;

    [NativeTypeName("BYTE[16]")]
    public _PSShaderResources_e__FixedBuffer PSShaderResources;

    [NativeTypeName("BYTE[2]")]
    public _PSConstantBuffers_e__FixedBuffer PSConstantBuffers;

    [NativeTypeName("BYTE[2]")]
    public _IAVertexBuffers_e__FixedBuffer IAVertexBuffers;
    public byte IAIndexBuffer;
    public byte IAInputLayout;
    public byte IAPrimitiveTopology;
    public byte OMRenderTargets;
    public byte OMDepthStencilState;
    public byte OMBlendState;
    public byte RSViewports;
    public byte RSScissorRects;
    public byte RSRasterizerState;
    public byte SOBuffers;
    public byte Predication;

    [InlineArray(2)]
    public partial struct _VSSamplers_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _VSShaderResources_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _VSConstantBuffers_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _GSSamplers_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _GSShaderResources_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _GSConstantBuffers_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _PSSamplers_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _PSShaderResources_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _PSConstantBuffers_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _IAVertexBuffers_e__FixedBuffer
    {
        public byte e0;
    }
}
