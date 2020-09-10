// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_PIPELINE_STATE_FLAGS")]
    public enum PipelineStateFlags
    {
        [NativeName("Name", "D3D12_PIPELINE_STATE_FLAG_NONE")]
        PipelineStateFlagNone = 0x0,
        [NativeName("Name", "D3D12_PIPELINE_STATE_FLAG_TOOL_DEBUG")]
        PipelineStateFlagToolDebug = 0x1,
    }
}
