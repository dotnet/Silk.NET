// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkCooperativeVectorMatrixLayoutNV : uint
{
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_ROW_MAJOR_NV = 0,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_COLUMN_MAJOR_NV = 1,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_INFERENCING_OPTIMAL_NV = 2,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_TRAINING_OPTIMAL_NV = 3,

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_MAX_ENUM_NV = 0x7FFFFFFF,
}
