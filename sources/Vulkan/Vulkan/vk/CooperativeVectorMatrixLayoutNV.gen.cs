// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCooperativeVectorMatrixLayoutNV")]
public enum CooperativeVectorMatrixLayoutNV : uint
{
    [NativeName("VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_ROW_MAJOR_NV")]
    RowMajor = 0,

    [NativeName("VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_COLUMN_MAJOR_NV")]
    ColumnMajor = 1,

    [NativeName("VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_INFERENCING_OPTIMAL_NV")]
    InferencingOptimal = 2,

    [NativeName("VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_TRAINING_OPTIMAL_NV")]
    TrainingOptimal = 3,
}
