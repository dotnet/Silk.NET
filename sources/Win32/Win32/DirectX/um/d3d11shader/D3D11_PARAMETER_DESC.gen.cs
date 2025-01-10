// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D11_PARAMETER_DESC
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
