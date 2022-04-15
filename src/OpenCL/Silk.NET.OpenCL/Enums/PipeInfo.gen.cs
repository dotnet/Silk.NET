// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_pipe_info")]
    public enum PipeInfo : int
    {
        [NativeName("Name", "CL_PIPE_PACKET_SIZE")]
        PacketSize = 0x1120,
        [NativeName("Name", "CL_PIPE_MAX_PACKETS")]
        MaxPackets = 0x1121,
        [NativeName("Name", "CL_PIPE_PROPERTIES")]
        Properties = 0x1122,
    }
}
