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
    [NativeName("Name", "cl_mutable_dispatch_arg_khr")]
    public unsafe partial struct MutableDispatchArgKhr
    {
        public MutableDispatchArgKhr
        (
            uint? argIndex = null,
            nuint? argSize = null,
            void* argValue = null
        ) : this()
        {
            if (argIndex is not null)
            {
                ArgIndex = argIndex.Value;
            }

            if (argSize is not null)
            {
                ArgSize = argSize.Value;
            }

            if (argValue is not null)
            {
                ArgValue = argValue;
            }
        }

/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "arg_index")]
        public uint ArgIndex;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "arg_size")]
        public nuint ArgSize;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "arg_value")]
        public void* ArgValue;
    }
}
