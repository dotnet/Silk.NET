// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_pipe_info")]
public enum PipeInfo : uint
{
    [NativeName("CL_PIPE_PACKET_SIZE")]
    PacketSize = 4384,

    [NativeName("CL_PIPE_MAX_PACKETS")]
    MaxPackets = 4385,

    [NativeName("CL_PIPE_PROPERTIES")]
    Properties = 4386,
}
