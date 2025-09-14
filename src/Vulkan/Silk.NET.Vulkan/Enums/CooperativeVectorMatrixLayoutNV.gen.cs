// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkCooperativeVectorMatrixLayoutNV")]
    public enum CooperativeVectorMatrixLayoutNV : int
    {
        [Obsolete("Deprecated in favour of \"RowMajorNV\"")]
        [NativeName("Name", "VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_ROW_MAJOR_NV")]
        CooperativeVectorMatrixLayoutRowMajorNV = 0,
        [Obsolete("Deprecated in favour of \"ColumnMajorNV\"")]
        [NativeName("Name", "VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_COLUMN_MAJOR_NV")]
        CooperativeVectorMatrixLayoutColumnMajorNV = 1,
        [Obsolete("Deprecated in favour of \"InferencingOptimalNV\"")]
        [NativeName("Name", "VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_INFERENCING_OPTIMAL_NV")]
        CooperativeVectorMatrixLayoutInferencingOptimalNV = 2,
        [Obsolete("Deprecated in favour of \"TrainingOptimalNV\"")]
        [NativeName("Name", "VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_TRAINING_OPTIMAL_NV")]
        CooperativeVectorMatrixLayoutTrainingOptimalNV = 3,
        [NativeName("Name", "VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_ROW_MAJOR_NV")]
        RowMajorNV = 0,
        [NativeName("Name", "VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_COLUMN_MAJOR_NV")]
        ColumnMajorNV = 1,
        [NativeName("Name", "VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_INFERENCING_OPTIMAL_NV")]
        InferencingOptimalNV = 2,
        [NativeName("Name", "VK_COOPERATIVE_VECTOR_MATRIX_LAYOUT_TRAINING_OPTIMAL_NV")]
        TrainingOptimalNV = 3,
    }
}
