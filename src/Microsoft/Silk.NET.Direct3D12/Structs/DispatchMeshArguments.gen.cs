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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DISPATCH_MESH_ARGUMENTS")]
    public unsafe partial struct DispatchMeshArguments
    {
        public DispatchMeshArguments
        (
            uint? threadGroupCountX = null,
            uint? threadGroupCountY = null,
            uint? threadGroupCountZ = null
        ) : this()
        {
            if (threadGroupCountX is not null)
            {
                ThreadGroupCountX = threadGroupCountX.Value;
            }

            if (threadGroupCountY is not null)
            {
                ThreadGroupCountY = threadGroupCountY.Value;
            }

            if (threadGroupCountZ is not null)
            {
                ThreadGroupCountZ = threadGroupCountZ.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ThreadGroupCountX")]
        public uint ThreadGroupCountX;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ThreadGroupCountY")]
        public uint ThreadGroupCountY;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ThreadGroupCountZ")]
        public uint ThreadGroupCountZ;
    }
}
