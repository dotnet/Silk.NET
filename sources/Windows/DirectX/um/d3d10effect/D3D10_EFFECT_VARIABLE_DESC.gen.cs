// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D10_EFFECT_VARIABLE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_VARIABLE_DESC"]/*'/>
public unsafe partial struct D3D10_EFFECT_VARIABLE_DESC
{
    /// <include file='D3D10_EFFECT_VARIABLE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_VARIABLE_DESC.Name"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;
    /// <include file='D3D10_EFFECT_VARIABLE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_VARIABLE_DESC.Semantic"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* Semantic;
    /// <include file='D3D10_EFFECT_VARIABLE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_VARIABLE_DESC.Flags"]/*'/>
    public uint Flags;
    /// <include file='D3D10_EFFECT_VARIABLE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_VARIABLE_DESC.Annotations"]/*'/>
    public uint Annotations;
    /// <include file='D3D10_EFFECT_VARIABLE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_VARIABLE_DESC.BufferOffset"]/*'/>
    public uint BufferOffset;
    /// <include file='D3D10_EFFECT_VARIABLE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_VARIABLE_DESC.ExplicitBindPoint"]/*'/>
    public uint ExplicitBindPoint;
}