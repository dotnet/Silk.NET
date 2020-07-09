// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_name_version")]
    public unsafe struct NameVersion
    {
        public NameVersion
        (
            uint version = default
        )
        {
           Version = version;
        }

/// <summary></summary>
        [NativeName("Type", "cl_version")]
        [NativeName("Type.Name", "cl_version")]
        [NativeName("Name", "version")]
        public uint Version;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "name")]
       public fixed char Name[64];
    }
}
