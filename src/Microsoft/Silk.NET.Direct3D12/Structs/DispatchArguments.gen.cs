// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DISPATCH_ARGUMENTS")]
    public unsafe partial struct DispatchArguments
    {
        public DispatchArguments
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
