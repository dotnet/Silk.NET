// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_buffer_create_type")]
    public enum BufferCreateType : int
    {
        [NativeName("Name", "CL_BUFFER_CREATE_TYPE_REGION")]
        Region = 0x1220,
    }
}
