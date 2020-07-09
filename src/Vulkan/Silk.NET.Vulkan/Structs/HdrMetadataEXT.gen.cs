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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkHdrMetadataEXT")]
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
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkXYColorEXT")]
        [NativeName("Type.Name", "VkXYColorEXT")]
        [NativeName("Name", "displayPrimaryRed")]
        public XYColorEXT DisplayPrimaryRed;
/// <summary></summary>
        [NativeName("Type", "VkXYColorEXT")]
        [NativeName("Type.Name", "VkXYColorEXT")]
        [NativeName("Name", "displayPrimaryGreen")]
        public XYColorEXT DisplayPrimaryGreen;
/// <summary></summary>
        [NativeName("Type", "VkXYColorEXT")]
        [NativeName("Type.Name", "VkXYColorEXT")]
        [NativeName("Name", "displayPrimaryBlue")]
        public XYColorEXT DisplayPrimaryBlue;
/// <summary></summary>
        [NativeName("Type", "VkXYColorEXT")]
        [NativeName("Type.Name", "VkXYColorEXT")]
        [NativeName("Name", "whitePoint")]
        public XYColorEXT WhitePoint;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxLuminance")]
        public float MaxLuminance;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "minLuminance")]
        public float MinLuminance;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxContentLightLevel")]
        public float MaxContentLightLevel;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxFrameAverageLightLevel")]
        public float MaxFrameAverageLightLevel;
    }
}
