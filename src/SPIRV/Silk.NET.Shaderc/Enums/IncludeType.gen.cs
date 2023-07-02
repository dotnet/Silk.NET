// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Shaderc
{
    [NativeName("Name", "shaderc_include_type")]
    public enum IncludeType : int
    {
        [NativeName("Name", "shaderc_include_type_relative")]
        Relative = 0x0,
        [NativeName("Name", "shaderc_include_type_standard")]
        Standard = 0x1,
    }
}
