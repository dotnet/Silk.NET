// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Shaderc
{
    [NativeName("AnonymousName", "__AnonymousEnum_shaderc_L101_C9")]
    [NativeName("Name", "shaderc_optimization_level")]
    public enum OptimizationLevel : int
    {
        [NativeName("Name", "shaderc_optimization_level_zero")]
        Zero = 0x0,
        [NativeName("Name", "shaderc_optimization_level_size")]
        Size = 0x1,
        [NativeName("Name", "shaderc_optimization_level_performance")]
        Performance = 0x2,
    }
}
