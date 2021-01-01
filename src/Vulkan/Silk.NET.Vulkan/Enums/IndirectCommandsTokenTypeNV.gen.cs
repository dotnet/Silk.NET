// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkIndirectCommandsTokenTypeNV")]
    public enum IndirectCommandsTokenTypeNV : int
    {
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_SHADER_GROUP_NV")]
        IndirectCommandsTokenTypeShaderGroupNV = 0,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_STATE_FLAGS_NV")]
        IndirectCommandsTokenTypeStateFlagsNV = 1,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NV")]
        IndirectCommandsTokenTypeIndexBufferNV = 2,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NV")]
        IndirectCommandsTokenTypeVertexBufferNV = 3,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NV")]
        IndirectCommandsTokenTypePushConstantNV = 4,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NV")]
        IndirectCommandsTokenTypeDrawIndexedNV = 5,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NV")]
        IndirectCommandsTokenTypeDrawNV = 6,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_TASKS_NV")]
        IndirectCommandsTokenTypeDrawTasksNV = 7,
    }
}
