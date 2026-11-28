// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_mutable_dispatch_exec_info_khr")]
public unsafe partial struct MutableDispatchExecInfoKHR
{
    [NativeName("param_name")]
    public uint ParamName;

    [NativeName("param_value_size")]
    public nuint ParamValueSize;

    [NativeName("param_value")]
    public void* ParamValue;
}
