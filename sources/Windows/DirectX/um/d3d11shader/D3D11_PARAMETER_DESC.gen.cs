// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC"]/*'/>
public unsafe partial struct D3D11_PARAMETER_DESC
{
    /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.Name"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;
    /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.SemanticName"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* SemanticName;
    /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.Type"]/*'/>
    public D3D_SHADER_VARIABLE_TYPE Type;
    /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.Class"]/*'/>
    public D3D_SHADER_VARIABLE_CLASS Class;
    /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.Rows"]/*'/>
    public uint Rows;
    /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.Columns"]/*'/>
    public uint Columns;
    /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.InterpolationMode"]/*'/>
    public D3D_INTERPOLATION_MODE InterpolationMode;
    /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.Flags"]/*'/>
    public D3D_PARAMETER_FLAGS Flags;
    /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.FirstInRegister"]/*'/>
    public uint FirstInRegister;
    /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.FirstInComponent"]/*'/>
    public uint FirstInComponent;
    /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.FirstOutRegister"]/*'/>
    public uint FirstOutRegister;
    /// <include file='D3D11_PARAMETER_DESC.xml' path='doc/member[@name="D3D11_PARAMETER_DESC.FirstOutComponent"]/*'/>
    public uint FirstOutComponent;
}