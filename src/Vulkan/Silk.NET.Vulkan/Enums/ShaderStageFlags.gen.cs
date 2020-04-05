// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum ShaderStageFlags
    {
        ShaderStageVertexBit = 1,
        ShaderStageTessellationControlBit = 2,
        ShaderStageTessellationEvaluationBit = 4,
        ShaderStageGeometryBit = 8,
        ShaderStageFragmentBit = 16,
        ShaderStageComputeBit = 32,
        ShaderStageAllGraphics = 31,
        ShaderStageAll = 2147483647,
        ShaderStageRaygenBitKhr = 256,
        ShaderStageAnyHitBitKhr = 512,
        ShaderStageClosestHitBitKhr = 1024,
        ShaderStageMissBitKhr = 2048,
        ShaderStageIntersectionBitKhr = 4096,
        ShaderStageCallableBitKhr = 8192,
        ShaderStageRaygenBitNV = 256,
        ShaderStageAnyHitBitNV = 512,
        ShaderStageClosestHitBitNV = 1024,
        ShaderStageMissBitNV = 2048,
        ShaderStageIntersectionBitNV = 4096,
        ShaderStageCallableBitNV = 8192,
        ShaderStageTaskBitNV = 64,
        ShaderStageMeshBitNV = 128,
    }
}
