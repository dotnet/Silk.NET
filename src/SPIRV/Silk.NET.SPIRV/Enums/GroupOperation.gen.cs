// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvGroupOperation_")]
    public enum GroupOperation : int
    {
        [NativeName("Name", "SpvGroupOperationReduce")]
        Reduce = 0x0,
        [NativeName("Name", "SpvGroupOperationInclusiveScan")]
        InclusiveScan = 0x1,
        [NativeName("Name", "SpvGroupOperationExclusiveScan")]
        ExclusiveScan = 0x2,
        [NativeName("Name", "SpvGroupOperationClusteredReduce")]
        ClusteredReduce = 0x3,
        [NativeName("Name", "SpvGroupOperationPartitionedReduceNV")]
        PartitionedReduceNV = 0x6,
        [NativeName("Name", "SpvGroupOperationPartitionedInclusiveScanNV")]
        PartitionedInclusiveScanNV = 0x7,
        [NativeName("Name", "SpvGroupOperationPartitionedExclusiveScanNV")]
        PartitionedExclusiveScanNV = 0x8,
        [NativeName("Name", "SpvGroupOperationMax")]
        Max = 0x7FFFFFFF,
    }
}
