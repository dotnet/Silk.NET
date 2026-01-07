// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [System.Flags]
    [NativeName("Name", "cl_svm_free_flags_khr")]
    public enum SvmFreeFlags : ulong
    {
        [NativeName("Name", "")]
        None = 0,
    }
}
