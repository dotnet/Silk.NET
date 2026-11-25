// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_mutable_dispatch_arg_khr")]
public unsafe partial struct MutableDispatchArgKHR
{
    [NativeName("arg_index")]
    public uint ArgIndex;

    [NativeName("arg_size")]
    public nuint ArgSize;

    [NativeName("arg_value")]
    public void* ArgValue;
}
