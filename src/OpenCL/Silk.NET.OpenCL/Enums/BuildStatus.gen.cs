// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_build_status")]
    public enum BuildStatus : int
    {
        [NativeName("Name", "CL_BUILD_SUCCESS")]
        BuildSuccess = 0x0,
        [NativeName("Name", "CL_BUILD_NONE")]
        BuildNone = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "CL_BUILD_ERROR")]
        BuildError = unchecked((int) 0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "CL_BUILD_IN_PROGRESS")]
        BuildInProgress = unchecked((int) 0xFFFFFFFFFFFFFFFD),
    }
}
