// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MEASUREMENTS_ACTION")]
    public enum MeasurementsAction : int
    {
        [Obsolete("Deprecated in favour of \"KeepAll\"")]
        [NativeName("Name", "D3D12_MEASUREMENTS_ACTION_KEEP_ALL")]
        MeasurementsActionKeepAll = 0x0,
        [Obsolete("Deprecated in favour of \"CommitResults\"")]
        [NativeName("Name", "D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS")]
        MeasurementsActionCommitResults = 0x1,
        [Obsolete("Deprecated in favour of \"CommitResultsHighPriority\"")]
        [NativeName("Name", "D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS_HIGH_PRIORITY")]
        MeasurementsActionCommitResultsHighPriority = 0x2,
        [Obsolete("Deprecated in favour of \"DiscardPrevious\"")]
        [NativeName("Name", "D3D12_MEASUREMENTS_ACTION_DISCARD_PREVIOUS")]
        MeasurementsActionDiscardPrevious = 0x3,
        [NativeName("Name", "D3D12_MEASUREMENTS_ACTION_KEEP_ALL")]
        KeepAll = 0x0,
        [NativeName("Name", "D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS")]
        CommitResults = 0x1,
        [NativeName("Name", "D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS_HIGH_PRIORITY")]
        CommitResultsHighPriority = 0x2,
        [NativeName("Name", "D3D12_MEASUREMENTS_ACTION_DISCARD_PREVIOUS")]
        DiscardPrevious = 0x3,
    }
}
