// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D10_PASS_DESC.xml' path='doc/member[@name="D3D10_PASS_DESC"]/*'/>
public unsafe partial struct D3D10_PASS_DESC
{
    /// <include file='D3D10_PASS_DESC.xml' path='doc/member[@name="D3D10_PASS_DESC.Name"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;
    /// <include file='D3D10_PASS_DESC.xml' path='doc/member[@name="D3D10_PASS_DESC.Annotations"]/*'/>
    public uint Annotations;
    /// <include file='D3D10_PASS_DESC.xml' path='doc/member[@name="D3D10_PASS_DESC.pIAInputSignature"]/*'/>
    public byte* pIAInputSignature;
    /// <include file='D3D10_PASS_DESC.xml' path='doc/member[@name="D3D10_PASS_DESC.IAInputSignatureSize"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint IAInputSignatureSize;
    /// <include file='D3D10_PASS_DESC.xml' path='doc/member[@name="D3D10_PASS_DESC.StencilRef"]/*'/>
    public uint StencilRef;
    /// <include file='D3D10_PASS_DESC.xml' path='doc/member[@name="D3D10_PASS_DESC.SampleMask"]/*'/>
    public uint SampleMask;
    /// <include file='D3D10_PASS_DESC.xml' path='doc/member[@name="D3D10_PASS_DESC.BlendFactor"]/*'/>
    [NativeTypeName("FLOAT[4]")]
    public fixed float BlendFactor[4];
}