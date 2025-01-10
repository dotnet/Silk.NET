// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_DRED_ALLOCATION_NODE1
{
    [NativeTypeName("const char *")]
    public sbyte* ObjectNameA;

    [NativeTypeName("const wchar_t *")]
    public ushort* ObjectNameW;
    public D3D12_DRED_ALLOCATION_TYPE AllocationType;

    [NativeTypeName("const struct D3D12_DRED_ALLOCATION_NODE1 *")]
    public D3D12_DRED_ALLOCATION_NODE1* pNext;

    [NativeTypeName("const IUnknown *")]
    public IUnknown pObject;
}
