// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkIndirectCommandsTokenTypeEXT")]
public enum IndirectCommandsTokenTypeEXT : uint
{
    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_EXECUTION_SET_EXT")]
    ExecutionSet = 0,

    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_EXT")]
    PushConstant = 1,

    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_SEQUENCE_INDEX_EXT")]
    SequenceIndex = 2,

    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_EXT")]
    IndexBuffer = 3,

    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_EXT")]
    VertexBuffer = 4,

    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_EXT")]
    DrawIndexed = 5,

    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_EXT")]
    Draw = 6,

    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_COUNT_EXT")]
    DrawIndexedCount = 7,

    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_COUNT_EXT")]
    DrawCount = 8,

    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_EXT")]
    Dispatch = 9,

    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_DATA_EXT")]
    PushData = 1000135000,

    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_DATA_SEQUENCE_INDEX_EXT")]
    PushDataSequenceIndex = 1000135001,

    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_NV_EXT")]
    DrawMeshTasksNv = 1000202002,

    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_COUNT_NV_EXT")]
    DrawMeshTasksCountNv = 1000202003,

    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_EXT")]
    DrawMeshTasks = 1000328000,

    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_COUNT_EXT")]
    DrawMeshTasksCount = 1000328001,

    [NativeName("VK_INDIRECT_COMMANDS_TOKEN_TYPE_TRACE_RAYS2_EXT")]
    TraceRays2 = 1000386004,
}
