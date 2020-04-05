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
    public unsafe struct PipelineExecutableInternalRepresentationKHR
    {
        public PipelineExecutableInternalRepresentationKHR
        (
            StructureType sType = StructureType.PipelineExecutableInternalRepresentationKhr,
            void* pNext = default,
            Bool32 isText = default,
            UIntPtr dataSize = default,
            void* pData = default
        )
        {
           SType = sType;
           PNext = pNext;
           IsText = isText;
           DataSize = dataSize;
           PData = pData;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
        /// <summary></summary>
       public fixed byte Name[256];
        /// <summary></summary>
       public fixed byte Description[256];
/// <summary></summary>
        public Bool32 IsText;
/// <summary></summary>
        public UIntPtr DataSize;
/// <summary></summary>
        public void* PData;
    }
}
