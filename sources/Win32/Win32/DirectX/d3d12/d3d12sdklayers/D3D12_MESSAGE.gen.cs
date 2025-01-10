// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_MESSAGE
{
    public D3D12_MESSAGE_CATEGORY Category;
    public D3D12_MESSAGE_SEVERITY Severity;
    public D3D12_MESSAGE_ID ID;

    [NativeTypeName("const char *")]
    public sbyte* pDescription;

    [NativeTypeName("SIZE_T")]
    public nuint DescriptionByteLength;
}
