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
    public unsafe struct ApiLayerProperties
    {
        public ApiLayerProperties
        (
            StructureType type = StructureType.TypeApiLayerProperties,
            void* next = default,
            ulong specVersion = default,
            uint layerVersion = default
        )
        {
           Type = type;
           Next = next;
           SpecVersion = specVersion;
           LayerVersion = layerVersion;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
        /// <summary></summary>
       public fixed byte LayerName[256];
/// <summary></summary>
        public ulong SpecVersion;
/// <summary></summary>
        public uint LayerVersion;
        /// <summary></summary>
       public fixed byte Description[256];
    }
}
