// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_STANDARD_MULTISAMPLE_QUALITY_LEVELS")]
    public enum StandardMultisampleQualityLevels : int
    {
        [NativeName("Name", "D3D12_STANDARD_MULTISAMPLE_PATTERN")]
        StandardMultisamplePattern = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D3D12_CENTER_MULTISAMPLE_PATTERN")]
        CenterMultisamplePattern = unchecked((int) 0xFFFFFFFFFFFFFFFE),
    }
}
