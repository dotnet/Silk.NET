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

namespace Silk.NET.Vulkan
{
    public unsafe struct ApplicationInfo
    {
        public ApplicationInfo
        (
            StructureType sType = StructureType.ApplicationInfo,
            void* pNext = default,
            byte* pApplicationName = default,
            uint applicationVersion = default,
            byte* pEngineName = default,
            uint engineVersion = default,
            uint apiVersion = default
        )
        {
           SType = sType;
           PNext = pNext;
           PApplicationName = pApplicationName;
           ApplicationVersion = applicationVersion;
           PEngineName = pEngineName;
           EngineVersion = engineVersion;
           ApiVersion = apiVersion;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public byte* PApplicationName;
/// <summary></summary>
        public uint ApplicationVersion;
/// <summary></summary>
        public byte* PEngineName;
/// <summary></summary>
        public uint EngineVersion;
/// <summary></summary>
        public uint ApiVersion;
    }
}
