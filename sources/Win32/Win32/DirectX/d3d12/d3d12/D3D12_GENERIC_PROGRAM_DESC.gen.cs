// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_GENERIC_PROGRAM_DESC
{
    [NativeTypeName("LPCWSTR")]
    public ushort* ProgramName;
    public uint NumExports;

    [NativeTypeName("LPCWSTR *")]
    public ushort** pExports;
    public uint NumSubobjects;

    [NativeTypeName("const D3D12_STATE_SUBOBJECT *const *")]
    public D3D12_STATE_SUBOBJECT** ppSubobjects;
}
