// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_mutable_dispatch_config_khr")]
public unsafe partial struct MutableDispatchConfigKHR
{
    [NativeName("command")]
    public MutableCommandHandleKHR Command;

    [NativeName("num_args")]
    public uint NumArgs;

    [NativeName("num_svm_args")]
    public uint NumSvmArgs;

    [NativeName("num_exec_infos")]
    public uint NumExecInfos;

    [NativeName("work_dim")]
    public uint WorkDim;

    [NativeName("arg_list")]
    public MutableDispatchArgKHR* ArgList;

    [NativeName("arg_svm_list")]
    public MutableDispatchArgKHR* ArgSvmList;

    [NativeName("exec_info_list")]
    public MutableDispatchExecInfoKHR* ExecInfoList;

    [NativeName("global_work_offset")]
    public nuint* GlobalWorkOffset;

    [NativeName("global_work_size")]
    public nuint* GlobalWorkSize;

    [NativeName("local_work_size")]
    public nuint* LocalWorkSize;
}
