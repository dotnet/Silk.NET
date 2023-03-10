// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [Flags]
    [NativeName("Name", "cl_bool")]
    public enum Bool : int
    {
        [NativeName("Name", "CL_FALSE")]
        False = 0x0,
        [NativeName("Name", "CL_TRUE")]
        True = 0x1,
        [NativeName("Name", "CL_BLOCKING")]
        Blocking = 0x1,
        [NativeName("Name", "CL_NON_BLOCKING")]
        NonBlocking = 0x0,
    }
}
