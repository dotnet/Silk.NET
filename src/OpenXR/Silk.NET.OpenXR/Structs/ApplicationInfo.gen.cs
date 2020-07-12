// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public unsafe struct ApplicationInfo
    {
        public ApplicationInfo
        (
            uint applicationVersion = default,
            uint engineVersion = default,
            ulong apiVersion = default
        )
        {
           ApplicationVersion = applicationVersion;
           EngineVersion = engineVersion;
           ApiVersion = apiVersion;
        }

        /// <summary></summary>
       public fixed byte ApplicationName[128];
/// <summary></summary>
        public uint ApplicationVersion;
        /// <summary></summary>
       public fixed byte EngineName[128];
/// <summary></summary>
        public uint EngineVersion;
/// <summary></summary>
        public ulong ApiVersion;
    }
}
