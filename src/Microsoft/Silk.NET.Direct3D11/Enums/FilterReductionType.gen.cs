// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_FILTER_REDUCTION_TYPE")]
    public enum FilterReductionType : int
    {
        [NativeName("Name", "D3D11_FILTER_REDUCTION_TYPE_STANDARD")]
        FilterReductionTypeStandard = 0x0,
        [NativeName("Name", "D3D11_FILTER_REDUCTION_TYPE_COMPARISON")]
        FilterReductionTypeComparison = 0x1,
        [NativeName("Name", "D3D11_FILTER_REDUCTION_TYPE_MINIMUM")]
        FilterReductionTypeMinimum = 0x2,
        [NativeName("Name", "D3D11_FILTER_REDUCTION_TYPE_MAXIMUM")]
        FilterReductionTypeMaximum = 0x3,
    }
}
