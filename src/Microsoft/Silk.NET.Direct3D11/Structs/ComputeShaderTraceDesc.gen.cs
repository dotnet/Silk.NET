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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_COMPUTE_SHADER_TRACE_DESC")]
    public unsafe partial struct ComputeShaderTraceDesc
    {
        public ComputeShaderTraceDesc
        (
            ulong? invocation = null
        ) : this()
        {
            if (invocation is not null)
            {
                Invocation = invocation.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Invocation")]
        public ulong Invocation;
        [NativeName("Type", "UINT[3]")]
        [NativeName("Type.Name", "UINT[3]")]
        [NativeName("Name", "ThreadIDInGroup")]
        public fixed uint ThreadIDInGroup[3];
        [NativeName("Type", "UINT[3]")]
        [NativeName("Type.Name", "UINT[3]")]
        [NativeName("Name", "ThreadGroupID")]
        public fixed uint ThreadGroupID[3];
    }
}
