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
    [NativeName("Name", "cl_mutable_base_config_khr")]
    public unsafe partial struct MutableBaseConfigKhr
    {
        public MutableBaseConfigKhr
        (
            CommandBufferStructureType? type = null,
            void* next = null,
            uint? numMutableDispatch = null,
            MutableDispatchConfigKhr* mutableDispatchList = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (numMutableDispatch is not null)
            {
                NumMutableDispatch = numMutableDispatch.Value;
            }

            if (mutableDispatchList is not null)
            {
                MutableDispatchList = mutableDispatchList;
            }
        }

/// <summary></summary>
        [NativeName("Type", "cl_command_buffer_structure_type_khr")]
        [NativeName("Type.Name", "cl_command_buffer_structure_type_khr")]
        [NativeName("Name", "type")]
        public CommandBufferStructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "num_mutable_dispatch")]
        public uint NumMutableDispatch;
/// <summary></summary>
        [NativeName("Type", "cl_mutable_dispatch_config_khr*")]
        [NativeName("Type.Name", "cl_mutable_dispatch_config_khr")]
        [NativeName("Name", "mutable_dispatch_list")]
        public MutableDispatchConfigKhr* MutableDispatchList;
    }
}
