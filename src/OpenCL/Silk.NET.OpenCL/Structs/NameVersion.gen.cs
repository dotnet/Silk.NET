// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_name_version")]
    public unsafe partial struct NameVersion
    {
        public NameVersion
        (
            uint? version = null
        ) : this()
        {
            if (version is not null)
            {
                Version = version.Value;
            }
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
