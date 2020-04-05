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
    public unsafe struct PipelineRasterizationLineStateCreateInfoEXT
    {
        public PipelineRasterizationLineStateCreateInfoEXT
        (
            StructureType sType = StructureType.PipelineRasterizationLineStateCreateInfoExt,
            void* pNext = default,
            LineRasterizationModeEXT lineRasterizationMode = default,
            Bool32 stippledLineEnable = default,
            uint lineStippleFactor = default,
            ushort lineStipplePattern = default
        )
        {
           SType = sType;
           PNext = pNext;
           LineRasterizationMode = lineRasterizationMode;
           StippledLineEnable = stippledLineEnable;
           LineStippleFactor = lineStippleFactor;
           LineStipplePattern = lineStipplePattern;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public LineRasterizationModeEXT LineRasterizationMode;
/// <summary></summary>
        public Bool32 StippledLineEnable;
/// <summary></summary>
        public uint LineStippleFactor;
/// <summary></summary>
        public ushort LineStipplePattern;
    }
}
