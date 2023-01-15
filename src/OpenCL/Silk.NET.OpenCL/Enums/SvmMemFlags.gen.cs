// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [System.Flags]
    [NativeName("Name", "cl_svm_mem_flags")]
    public enum SvmMemFlags : ulong
    {
        [NativeName("Name", "")]
        None = 0,
    }
}
