// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [System.Flags]
    [NativeName("Name", "cl_mutable_dispatch_asserts_khr")]
    public enum MutableDispatchAsserts : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_MUTABLE_DISPATCH_ASSERT_NO_ADDITIONAL_WORK_GROUPS_KHR")]
        NoAdditionalWorkGroups = 0x1,
    }
}
