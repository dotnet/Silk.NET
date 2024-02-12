// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkIndirectCommandsTokenTypeNV")]
    public enum IndirectCommandsTokenTypeNV : int
    {
        [Obsolete("Deprecated in favour of \"ShaderGroupNV\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_SHADER_GROUP_NV")]
        IndirectCommandsTokenTypeShaderGroupNV = 0,
        [Obsolete("Deprecated in favour of \"StateFlagsNV\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_STATE_FLAGS_NV")]
        IndirectCommandsTokenTypeStateFlagsNV = 1,
        [Obsolete("Deprecated in favour of \"IndexBufferNV\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NV")]
        IndirectCommandsTokenTypeIndexBufferNV = 2,
        [Obsolete("Deprecated in favour of \"VertexBufferNV\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NV")]
        IndirectCommandsTokenTypeVertexBufferNV = 3,
        [Obsolete("Deprecated in favour of \"PushConstantNV\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NV")]
        IndirectCommandsTokenTypePushConstantNV = 4,
        [Obsolete("Deprecated in favour of \"DrawIndexedNV\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NV")]
        IndirectCommandsTokenTypeDrawIndexedNV = 5,
        [Obsolete("Deprecated in favour of \"DrawNV\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NV")]
        IndirectCommandsTokenTypeDrawNV = 6,
        [Obsolete("Deprecated in favour of \"DrawTasksNV\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_TASKS_NV")]
        IndirectCommandsTokenTypeDrawTasksNV = 7,
        [Obsolete("Deprecated in favour of \"DrawMeshTasksNV\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_NV")]
        IndirectCommandsTokenTypeDrawMeshTasksNV = 1000328000,
        [Obsolete("Deprecated in favour of \"PipelineNV\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_PIPELINE_NV")]
        IndirectCommandsTokenTypePipelineNV = 1000428003,
        [Obsolete("Deprecated in favour of \"DispatchNV\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_NV")]
        IndirectCommandsTokenTypeDispatchNV = 1000428004,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_SHADER_GROUP_NV")]
        ShaderGroupNV = 0,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_STATE_FLAGS_NV")]
        StateFlagsNV = 1,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NV")]
        IndexBufferNV = 2,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NV")]
        VertexBufferNV = 3,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NV")]
        PushConstantNV = 4,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NV")]
        DrawIndexedNV = 5,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NV")]
        DrawNV = 6,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_TASKS_NV")]
        DrawTasksNV = 7,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_NV")]
        DrawMeshTasksNV = 1000328000,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_PIPELINE_NV")]
        PipelineNV = 1000428003,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_NV")]
        DispatchNV = 1000428004,
    }
}
