// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_COMMAND_LIST_TYPE
{
    D3D12_COMMAND_LIST_TYPE_DIRECT = 0,
    D3D12_COMMAND_LIST_TYPE_BUNDLE = 1,
    D3D12_COMMAND_LIST_TYPE_COMPUTE = 2,
    D3D12_COMMAND_LIST_TYPE_COPY = 3,
    D3D12_COMMAND_LIST_TYPE_VIDEO_DECODE = 4,
    D3D12_COMMAND_LIST_TYPE_VIDEO_PROCESS = 5,
    D3D12_COMMAND_LIST_TYPE_VIDEO_ENCODE = 6,
    D3D12_COMMAND_LIST_TYPE_NONE = -1,
}
