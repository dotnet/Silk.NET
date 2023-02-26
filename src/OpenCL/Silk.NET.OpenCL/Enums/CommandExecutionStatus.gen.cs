// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [Flags]
    [NativeName("Name", "clCommandExecutionStatus")]
    public enum CommandExecutionStatus : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_COMPLETE")]
        Complete = 0x0,
        [NativeName("Name", "CL_RUNNING")]
        Running = 0x1,
        [NativeName("Name", "CL_SUBMITTED")]
        Submitted = 0x2,
        [NativeName("Name", "CL_QUEUED")]
        Queued = 0x3,
    }
}
