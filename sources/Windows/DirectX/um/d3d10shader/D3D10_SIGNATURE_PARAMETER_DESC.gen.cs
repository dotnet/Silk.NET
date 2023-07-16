// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D10_SIGNATURE_PARAMETER_DESC.xml' path='doc/member[@name="D3D10_SIGNATURE_PARAMETER_DESC"]/*'/>
public unsafe partial struct D3D10_SIGNATURE_PARAMETER_DESC
{
    /// <include file='D3D10_SIGNATURE_PARAMETER_DESC.xml' path='doc/member[@name="D3D10_SIGNATURE_PARAMETER_DESC.SemanticName"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* SemanticName;
    /// <include file='D3D10_SIGNATURE_PARAMETER_DESC.xml' path='doc/member[@name="D3D10_SIGNATURE_PARAMETER_DESC.SemanticIndex"]/*'/>
    public uint SemanticIndex;
    /// <include file='D3D10_SIGNATURE_PARAMETER_DESC.xml' path='doc/member[@name="D3D10_SIGNATURE_PARAMETER_DESC.Register"]/*'/>
    public uint Register;
    /// <include file='D3D10_SIGNATURE_PARAMETER_DESC.xml' path='doc/member[@name="D3D10_SIGNATURE_PARAMETER_DESC.SystemValueType"]/*'/>
    [NativeTypeName("D3D10_NAME")]
    public D3D_NAME SystemValueType;
    /// <include file='D3D10_SIGNATURE_PARAMETER_DESC.xml' path='doc/member[@name="D3D10_SIGNATURE_PARAMETER_DESC.ComponentType"]/*'/>
    [NativeTypeName("D3D10_REGISTER_COMPONENT_TYPE")]
    public D3D_REGISTER_COMPONENT_TYPE ComponentType;
    /// <include file='D3D10_SIGNATURE_PARAMETER_DESC.xml' path='doc/member[@name="D3D10_SIGNATURE_PARAMETER_DESC.Mask"]/*'/>
    public byte Mask;
    /// <include file='D3D10_SIGNATURE_PARAMETER_DESC.xml' path='doc/member[@name="D3D10_SIGNATURE_PARAMETER_DESC.ReadWriteMask"]/*'/>
    public byte ReadWriteMask;
}