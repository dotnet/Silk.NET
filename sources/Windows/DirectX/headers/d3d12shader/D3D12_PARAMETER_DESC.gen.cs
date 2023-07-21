// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC"]/*' />
public unsafe partial struct D3D12_PARAMETER_DESC
{
    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.Name"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.SemanticName"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* SemanticName;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.Type"]/*' />
    public D3D_SHADER_VARIABLE_TYPE Type;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.Class"]/*' />
    public D3D_SHADER_VARIABLE_CLASS Class;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.Rows"]/*' />
    public uint Rows;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.Columns"]/*' />
    public uint Columns;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.InterpolationMode"]/*' />
    public D3D_INTERPOLATION_MODE InterpolationMode;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.Flags"]/*' />
    public D3D_PARAMETER_FLAGS Flags;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.FirstInRegister"]/*' />
    public uint FirstInRegister;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.FirstInComponent"]/*' />
    public uint FirstInComponent;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.FirstOutRegister"]/*' />
    public uint FirstOutRegister;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.FirstOutComponent"]/*' />
    public uint FirstOutComponent;
}
