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
    public unsafe struct HdrMetadataEXT
    {
        public HdrMetadataEXT
        (
            StructureType sType = StructureType.HdrMetadataExt,
            void* pNext = default,
            XYColorEXT displayPrimaryRed = default,
            XYColorEXT displayPrimaryGreen = default,
            XYColorEXT displayPrimaryBlue = default,
            XYColorEXT whitePoint = default,
            float maxLuminance = default,
            float minLuminance = default,
            float maxContentLightLevel = default,
            float maxFrameAverageLightLevel = default
        )
        {
           SType = sType;
           PNext = pNext;
           DisplayPrimaryRed = displayPrimaryRed;
           DisplayPrimaryGreen = displayPrimaryGreen;
           DisplayPrimaryBlue = displayPrimaryBlue;
           WhitePoint = whitePoint;
           MaxLuminance = maxLuminance;
           MinLuminance = minLuminance;
           MaxContentLightLevel = maxContentLightLevel;
           MaxFrameAverageLightLevel = maxFrameAverageLightLevel;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public XYColorEXT DisplayPrimaryRed;
/// <summary></summary>
        public XYColorEXT DisplayPrimaryGreen;
/// <summary></summary>
        public XYColorEXT DisplayPrimaryBlue;
/// <summary></summary>
        public XYColorEXT WhitePoint;
/// <summary></summary>
        public float MaxLuminance;
/// <summary></summary>
        public float MinLuminance;
/// <summary></summary>
        public float MaxContentLightLevel;
/// <summary></summary>
        public float MaxFrameAverageLightLevel;
    }
}
