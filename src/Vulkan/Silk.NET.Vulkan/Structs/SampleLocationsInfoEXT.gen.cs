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
    public unsafe struct SampleLocationsInfoEXT
    {
        public SampleLocationsInfoEXT
        (
            StructureType sType = StructureType.SampleLocationsInfoExt,
            void* pNext = default,
            SampleCountFlags sampleLocationsPerPixel = default,
            Extent2D sampleLocationGridSize = default,
            uint sampleLocationsCount = default,
            SampleLocationEXT* pSampleLocations = default
        )
        {
           SType = sType;
           PNext = pNext;
           SampleLocationsPerPixel = sampleLocationsPerPixel;
           SampleLocationGridSize = sampleLocationGridSize;
           SampleLocationsCount = sampleLocationsCount;
           PSampleLocations = pSampleLocations;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public SampleCountFlags SampleLocationsPerPixel;
/// <summary></summary>
        public Extent2D SampleLocationGridSize;
/// <summary></summary>
        public uint SampleLocationsCount;
/// <summary></summary>
        public SampleLocationEXT* PSampleLocations;
    }
}
