// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvCooperativeVectorMatrixLayout_")]
    public enum CooperativeVectorMatrixLayout : int
    {
        [NativeName("Name", "SpvCooperativeVectorMatrixLayoutRowMajorNV")]
        RowMajorNV = 0x0,
        [NativeName("Name", "SpvCooperativeVectorMatrixLayoutColumnMajorNV")]
        ColumnMajorNV = 0x1,
        [NativeName("Name", "SpvCooperativeVectorMatrixLayoutInferencingOptimalNV")]
        InferencingOptimalNV = 0x2,
        [NativeName("Name", "SpvCooperativeVectorMatrixLayoutTrainingOptimalNV")]
        TrainingOptimalNV = 0x3,
        [NativeName("Name", "SpvCooperativeVectorMatrixLayoutMax")]
        Max = 0x7FFFFFFF,
    }
}
