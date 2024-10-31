// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkIndirectCommandsTokenTypeEXT")]
    public enum IndirectCommandsTokenTypeEXT : int
    {
        [Obsolete("Deprecated in favour of \"ExecutionSetExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_EXECUTION_SET_EXT")]
        IndirectCommandsTokenTypeExecutionSetExt = 0,
        [Obsolete("Deprecated in favour of \"PushConstantExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_EXT")]
        IndirectCommandsTokenTypePushConstantExt = 1,
        [Obsolete("Deprecated in favour of \"SequenceIndexExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_SEQUENCE_INDEX_EXT")]
        IndirectCommandsTokenTypeSequenceIndexExt = 2,
        [Obsolete("Deprecated in favour of \"IndexBufferExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_EXT")]
        IndirectCommandsTokenTypeIndexBufferExt = 3,
        [Obsolete("Deprecated in favour of \"VertexBufferExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_EXT")]
        IndirectCommandsTokenTypeVertexBufferExt = 4,
        [Obsolete("Deprecated in favour of \"DrawIndexedExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_EXT")]
        IndirectCommandsTokenTypeDrawIndexedExt = 5,
        [Obsolete("Deprecated in favour of \"DrawExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_EXT")]
        IndirectCommandsTokenTypeDrawExt = 6,
        [Obsolete("Deprecated in favour of \"DrawIndexedCountExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_COUNT_EXT")]
        IndirectCommandsTokenTypeDrawIndexedCountExt = 7,
        [Obsolete("Deprecated in favour of \"DrawCountExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_COUNT_EXT")]
        IndirectCommandsTokenTypeDrawCountExt = 8,
        [Obsolete("Deprecated in favour of \"DispatchExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_EXT")]
        IndirectCommandsTokenTypeDispatchExt = 9,
        [Obsolete("Deprecated in favour of \"DrawMeshTasksNVExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_NV_EXT")]
        IndirectCommandsTokenTypeDrawMeshTasksNVExt = 1000202002,
        [Obsolete("Deprecated in favour of \"DrawMeshTasksCountNVExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_COUNT_NV_EXT")]
        IndirectCommandsTokenTypeDrawMeshTasksCountNVExt = 1000202003,
        [Obsolete("Deprecated in favour of \"DrawMeshTasksExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_EXT")]
        IndirectCommandsTokenTypeDrawMeshTasksExt = 1000328000,
        [Obsolete("Deprecated in favour of \"DrawMeshTasksCountExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_COUNT_EXT")]
        IndirectCommandsTokenTypeDrawMeshTasksCountExt = 1000328001,
        [Obsolete("Deprecated in favour of \"TraceRays2Ext\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_TRACE_RAYS2_EXT")]
        IndirectCommandsTokenTypeTraceRays2Ext = 1000386004,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_EXECUTION_SET_EXT")]
        ExecutionSetExt = 0,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_EXT")]
        PushConstantExt = 1,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_SEQUENCE_INDEX_EXT")]
        SequenceIndexExt = 2,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_EXT")]
        IndexBufferExt = 3,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_EXT")]
        VertexBufferExt = 4,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_EXT")]
        DrawIndexedExt = 5,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_EXT")]
        DrawExt = 6,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_COUNT_EXT")]
        DrawIndexedCountExt = 7,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_COUNT_EXT")]
        DrawCountExt = 8,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_EXT")]
        DispatchExt = 9,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_NV_EXT")]
        DrawMeshTasksNVExt = 1000202002,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_COUNT_NV_EXT")]
        DrawMeshTasksCountNVExt = 1000202003,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_EXT")]
        DrawMeshTasksExt = 1000328000,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_COUNT_EXT")]
        DrawMeshTasksCountExt = 1000328001,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_TOKEN_TYPE_TRACE_RAYS2_EXT")]
        TraceRays2Ext = 1000386004,
    }
}
