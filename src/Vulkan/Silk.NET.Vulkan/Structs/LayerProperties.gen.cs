// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct LayerProperties
    {
        public LayerProperties
        (
            uint specVersion = default,
            uint implementationVersion = default
        )
        {
           SpecVersion = specVersion;
           ImplementationVersion = implementationVersion;
        }

        /// <summary></summary>
       public fixed byte LayerName[256];
/// <summary></summary>
        public uint SpecVersion;
/// <summary></summary>
        public uint ImplementationVersion;
        /// <summary></summary>
       public fixed byte Description[256];
    }
}
