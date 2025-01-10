// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_BROADCASTING_LAUNCH_OVERRIDES
{
    [NativeTypeName("const UINT *")]
    public uint* pLocalRootArgumentsTableIndex;

    [NativeTypeName("const BOOL *")]
    public BOOL* pProgramEntry;

    [NativeTypeName("const D3D12_NODE_ID *")]
    public D3D12_NODE_ID* pNewName;

    [NativeTypeName("const D3D12_NODE_ID *")]
    public D3D12_NODE_ID* pShareInputOf;

    [NativeTypeName("const UINT *")]
    public uint* pDispatchGrid;

    [NativeTypeName("const UINT *")]
    public uint* pMaxDispatchGrid;
    public uint NumOutputOverrides;

    [NativeTypeName("const D3D12_NODE_OUTPUT_OVERRIDES *")]
    public D3D12_NODE_OUTPUT_OVERRIDES* pOutputOverrides;
}
