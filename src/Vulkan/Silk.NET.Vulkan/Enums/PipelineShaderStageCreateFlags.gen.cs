// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum PipelineShaderStageCreateFlags
    {
        PipelineShaderStageCreateReserved2BitNV = 4,
        PipelineShaderStageCreateAllowVaryingSubgroupSizeBitExt = 1,
        PipelineShaderStageCreateRequireFullSubgroupsBitExt = 2,
        PipelineShaderStageCreateReserved3BitKhr = 8,
    }
}
