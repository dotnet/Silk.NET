// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_mutable_dispatch_config_khr")]
    public unsafe partial struct MutableDispatchConfigKhr
    {
        public MutableDispatchConfigKhr
        (
            nint? command = null,
            uint? numArgs = null,
            uint? numSvmArgs = null,
            uint? numExecInfos = null,
            uint? workDim = null,
            MutableDispatchArgKhr* argList = null,
            MutableDispatchArgKhr* argSvmList = null,
            MutableDispatchExecInfoKhr* execInfoList = null,
            nuint* globalWorkOffset = null,
            nuint* globalWorkSize = null,
            nuint* localWorkSize = null
        ) : this()
        {
            if (command is not null)
            {
                Command = command.Value;
            }

            if (numArgs is not null)
            {
                NumArgs = numArgs.Value;
            }

            if (numSvmArgs is not null)
            {
                NumSvmArgs = numSvmArgs.Value;
            }

            if (numExecInfos is not null)
            {
                NumExecInfos = numExecInfos.Value;
            }

            if (workDim is not null)
            {
                WorkDim = workDim.Value;
            }

            if (argList is not null)
            {
                ArgList = argList;
            }

            if (argSvmList is not null)
            {
                ArgSvmList = argSvmList;
            }

            if (execInfoList is not null)
            {
                ExecInfoList = execInfoList;
            }

            if (globalWorkOffset is not null)
            {
                GlobalWorkOffset = globalWorkOffset;
            }

            if (globalWorkSize is not null)
            {
                GlobalWorkSize = globalWorkSize;
            }

            if (localWorkSize is not null)
            {
                LocalWorkSize = localWorkSize;
            }
        }

/// <summary></summary>
        [NativeName("Type", "cl_mutable_command_khr")]
        [NativeName("Type.Name", "cl_mutable_command_khr")]
        [NativeName("Name", "command")]
        public nint Command;
/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "num_args")]
        public uint NumArgs;
/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "num_svm_args")]
        public uint NumSvmArgs;
/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "num_exec_infos")]
        public uint NumExecInfos;
/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "work_dim")]
        public uint WorkDim;
/// <summary></summary>
        [NativeName("Type", "cl_mutable_dispatch_arg_khr*")]
        [NativeName("Type.Name", "cl_mutable_dispatch_arg_khr")]
        [NativeName("Name", "arg_list")]
        public MutableDispatchArgKhr* ArgList;
/// <summary></summary>
        [NativeName("Type", "cl_mutable_dispatch_arg_khr*")]
        [NativeName("Type.Name", "cl_mutable_dispatch_arg_khr")]
        [NativeName("Name", "arg_svm_list")]
        public MutableDispatchArgKhr* ArgSvmList;
/// <summary></summary>
        [NativeName("Type", "cl_mutable_dispatch_exec_info_khr*")]
        [NativeName("Type.Name", "cl_mutable_dispatch_exec_info_khr")]
        [NativeName("Name", "exec_info_list")]
        public MutableDispatchExecInfoKhr* ExecInfoList;
/// <summary></summary>
        [NativeName("Type", "size_t*")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "global_work_offset")]
        public nuint* GlobalWorkOffset;
/// <summary></summary>
        [NativeName("Type", "size_t*")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "global_work_size")]
        public nuint* GlobalWorkSize;
/// <summary></summary>
        [NativeName("Type", "size_t*")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "local_work_size")]
        public nuint* LocalWorkSize;
    }
}
