// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_SHADER_TYPE_DESC
{
    public D3D_SHADER_VARIABLE_CLASS Class;
    public D3D_SHADER_VARIABLE_TYPE Type;
    public uint Rows;
    public uint Columns;
    public uint Elements;
    public uint Members;
    public uint Offset;

    [NativeTypeName("LPCSTR")]
    public sbyte* Name;
}
