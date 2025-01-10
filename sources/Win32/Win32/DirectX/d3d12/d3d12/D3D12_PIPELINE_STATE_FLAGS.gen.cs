// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
public enum D3D12_PIPELINE_STATE_FLAGS
{
    D3D12_PIPELINE_STATE_FLAG_NONE = 0,
    D3D12_PIPELINE_STATE_FLAG_TOOL_DEBUG = 0x1,
    D3D12_PIPELINE_STATE_FLAG_DYNAMIC_DEPTH_BIAS = 0x4,
    D3D12_PIPELINE_STATE_FLAG_DYNAMIC_INDEX_BUFFER_STRIP_CUT = 0x8,
}
