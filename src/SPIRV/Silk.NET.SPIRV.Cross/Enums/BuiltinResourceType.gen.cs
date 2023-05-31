// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_builtin_resource_type")]
    public enum BuiltinResourceType : int
    {
        [NativeName("Name", "SPVC_BUILTIN_RESOURCE_TYPE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "SPVC_BUILTIN_RESOURCE_TYPE_STAGE_INPUT")]
        StageInput = 0x1,
        [NativeName("Name", "SPVC_BUILTIN_RESOURCE_TYPE_STAGE_OUTPUT")]
        StageOutput = 0x2,
        [NativeName("Name", "SPVC_BUILTIN_RESOURCE_TYPE_INT_MAX")]
        IntMax = 0x7FFFFFFF,
    }
}
