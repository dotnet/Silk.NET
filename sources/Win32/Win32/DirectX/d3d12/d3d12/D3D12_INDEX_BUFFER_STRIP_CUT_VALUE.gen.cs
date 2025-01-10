// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_INDEX_BUFFER_STRIP_CUT_VALUE
{
    D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_DISABLED = 0,
    D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFF = 1,
    D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFFFFFF = 2,
}
