// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_PARAMETER_DESC
{
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;

    [NativeTypeName("LPCSTR")]
    public sbyte* SemanticName;
    public D3D_SHADER_VARIABLE_TYPE Type;
    public D3D_SHADER_VARIABLE_CLASS Class;
    public uint Rows;
    public uint Columns;
    public D3D_INTERPOLATION_MODE InterpolationMode;
    public D3D_PARAMETER_FLAGS Flags;
    public uint FirstInRegister;
    public uint FirstInComponent;
    public uint FirstOutRegister;
    public uint FirstOutComponent;
}
