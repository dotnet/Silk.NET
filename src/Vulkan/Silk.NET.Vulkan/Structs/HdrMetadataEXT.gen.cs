// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkHdrMetadataEXT")]
    public unsafe partial struct HdrMetadataEXT : IChainStart
    {
        public HdrMetadataEXT
        (
            StructureType? sType = StructureType.HdrMetadataExt,
            void* pNext = null,
            XYColorEXT? displayPrimaryRed = null,
            XYColorEXT? displayPrimaryGreen = null,
            XYColorEXT? displayPrimaryBlue = null,
            XYColorEXT? whitePoint = null,
            float? maxLuminance = null,
            float? minLuminance = null,
            float? maxContentLightLevel = null,
            float? maxFrameAverageLightLevel = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (displayPrimaryRed is not null)
            {
                DisplayPrimaryRed = displayPrimaryRed.Value;
            }

            if (displayPrimaryGreen is not null)
            {
                DisplayPrimaryGreen = displayPrimaryGreen.Value;
            }

            if (displayPrimaryBlue is not null)
            {
                DisplayPrimaryBlue = displayPrimaryBlue.Value;
            }

            if (whitePoint is not null)
            {
                WhitePoint = whitePoint.Value;
            }

            if (maxLuminance is not null)
            {
                MaxLuminance = maxLuminance.Value;
            }

            if (minLuminance is not null)
            {
                MinLuminance = minLuminance.Value;
            }

            if (maxContentLightLevel is not null)
            {
                MaxContentLightLevel = maxContentLightLevel.Value;
            }

            if (maxFrameAverageLightLevel is not null)
            {
                MaxFrameAverageLightLevel = maxFrameAverageLightLevel.Value;
            }
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.HdrMetadataExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref HdrMetadataEXT Chain(
            out HdrMetadataEXT capture)
        {
            capture = new HdrMetadataEXT(StructureType.HdrMetadataExt);
            return ref capture;
        }
    }
}
