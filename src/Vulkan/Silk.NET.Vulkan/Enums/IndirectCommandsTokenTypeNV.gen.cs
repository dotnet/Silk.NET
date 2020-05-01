// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public enum IndirectCommandsTokenTypeNV
    {
        IndirectCommandsTokenTypeShaderGroupNV = 0,
        IndirectCommandsTokenTypeStateFlagsNV = 1,
        IndirectCommandsTokenTypeIndexBufferNV = 2,
        IndirectCommandsTokenTypeVertexBufferNV = 3,
        IndirectCommandsTokenTypePushConstantNV = 4,
        IndirectCommandsTokenTypeDrawIndexedNV = 5,
        IndirectCommandsTokenTypeDrawNV = 6,
        IndirectCommandsTokenTypeDrawTasksNV = 7,
    }
}
