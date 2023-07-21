// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D10_SHADER_DEBUG_OUTPUTVAR.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTVAR"]/*' />
public partial struct D3D10_SHADER_DEBUG_OUTPUTVAR
{
    /// <include file='D3D10_SHADER_DEBUG_OUTPUTVAR.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTVAR.Var"]/*' />
    public uint Var;

    /// <include file='D3D10_SHADER_DEBUG_OUTPUTVAR.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTVAR.uValueMin"]/*' />
    public uint uValueMin;

    /// <include file='D3D10_SHADER_DEBUG_OUTPUTVAR.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTVAR.uValueMax"]/*' />
    public uint uValueMax;

    /// <include file='D3D10_SHADER_DEBUG_OUTPUTVAR.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTVAR.iValueMin"]/*' />
    public int iValueMin;

    /// <include file='D3D10_SHADER_DEBUG_OUTPUTVAR.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTVAR.iValueMax"]/*' />
    public int iValueMax;

    /// <include file='D3D10_SHADER_DEBUG_OUTPUTVAR.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTVAR.fValueMin"]/*' />
    public float fValueMin;

    /// <include file='D3D10_SHADER_DEBUG_OUTPUTVAR.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTVAR.fValueMax"]/*' />
    public float fValueMax;

    /// <include file='D3D10_SHADER_DEBUG_OUTPUTVAR.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTVAR.bNaNPossible"]/*' />
    public BOOL bNaNPossible;

    /// <include file='D3D10_SHADER_DEBUG_OUTPUTVAR.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTVAR.bInfPossible"]/*' />
    public BOOL bInfPossible;
}
