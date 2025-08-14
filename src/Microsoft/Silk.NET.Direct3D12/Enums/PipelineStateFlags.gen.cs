// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_PIPELINE_STATE_FLAGS")]
    public enum PipelineStateFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_FLAG_NONE")]
        PipelineStateFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"ToolDebug\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_FLAG_TOOL_DEBUG")]
        PipelineStateFlagToolDebug = 0x1,
        [Obsolete("Deprecated in favour of \"DynamicDepthBias\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_FLAG_DYNAMIC_DEPTH_BIAS")]
        PipelineStateFlagDynamicDepthBias = 0x4,
        [Obsolete("Deprecated in favour of \"DynamicIndexBufferStripCut\"")]
        [NativeName("Name", "D3D12_PIPELINE_STATE_FLAG_DYNAMIC_INDEX_BUFFER_STRIP_CUT")]
        PipelineStateFlagDynamicIndexBufferStripCut = 0x8,
        [NativeName("Name", "D3D12_PIPELINE_STATE_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_PIPELINE_STATE_FLAG_TOOL_DEBUG")]
        ToolDebug = 0x1,
        [NativeName("Name", "D3D12_PIPELINE_STATE_FLAG_DYNAMIC_DEPTH_BIAS")]
        DynamicDepthBias = 0x4,
        [NativeName("Name", "D3D12_PIPELINE_STATE_FLAG_DYNAMIC_INDEX_BUFFER_STRIP_CUT")]
        DynamicIndexBufferStripCut = 0x8,
    }
}
