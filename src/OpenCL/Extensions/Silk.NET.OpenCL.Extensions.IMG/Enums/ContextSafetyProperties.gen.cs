// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.IMG
{
    [System.Flags]
    [NativeName("Name", "cl_context_safety_properties_img")]
    public enum ContextSafetyProperties : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_CONTEXT_WORKGROUP_PROTECTION_IMG")]
        WorkgroupProtection = 0x1,
        [NativeName("Name", "CL_CONTEXT_ENHANCED_EVENT_EXECUTION_STATUS_IMG")]
        EnhancedEventExecutionStatus = 0x2,
    }
}
