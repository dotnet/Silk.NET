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
    [NativeName("Name", "D3D12_CPU_DESCRIPTOR_HANDLE")]
    public unsafe partial struct CpuDescriptorHandle
    {
        public CpuDescriptorHandle
        (
            nuint? ptr = null
        ) : this()
        {
            if (ptr is not null)
            {
                Ptr = ptr.Value;
            }
        }


        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "ptr")]
        public nuint Ptr;
    }
}
