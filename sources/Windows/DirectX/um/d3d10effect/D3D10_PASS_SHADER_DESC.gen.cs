// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D10_PASS_SHADER_DESC.xml' path='doc/member[@name="D3D10_PASS_SHADER_DESC"]/*' />
public unsafe partial struct D3D10_PASS_SHADER_DESC
{
    /// <include file='D3D10_PASS_SHADER_DESC.xml' path='doc/member[@name="D3D10_PASS_SHADER_DESC.pShaderVariable"]/*' />
    public ID3D10EffectShaderVariable* pShaderVariable;

    /// <include file='D3D10_PASS_SHADER_DESC.xml' path='doc/member[@name="D3D10_PASS_SHADER_DESC.ShaderIndex"]/*' />
    public uint ShaderIndex;
}
