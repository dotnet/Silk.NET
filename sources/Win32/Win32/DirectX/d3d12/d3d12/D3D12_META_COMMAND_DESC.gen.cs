// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_META_COMMAND_DESC
{
    public Guid Id;

    [NativeTypeName("LPCWSTR")]
    public ushort* Name;
    public D3D12_GRAPHICS_STATES InitializationDirtyState;
    public D3D12_GRAPHICS_STATES ExecutionDirtyState;
}
