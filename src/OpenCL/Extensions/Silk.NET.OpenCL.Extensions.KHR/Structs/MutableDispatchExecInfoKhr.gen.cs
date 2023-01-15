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
    [NativeName("Name", "cl_mutable_dispatch_exec_info_khr")]
    public unsafe partial struct MutableDispatchExecInfoKhr
    {
        public MutableDispatchExecInfoKhr
        (
            uint? paramName = null,
            nuint? paramValueSize = null,
            void* paramValue = null
        ) : this()
        {
            if (paramName is not null)
            {
                ParamName = paramName.Value;
            }

            if (paramValueSize is not null)
            {
                ParamValueSize = paramValueSize.Value;
            }

            if (paramValue is not null)
            {
                ParamValue = paramValue;
            }
        }

/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "param_name")]
        public uint ParamName;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "param_value_size")]
        public nuint ParamValueSize;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "param_value")]
        public void* ParamValue;
    }
}
