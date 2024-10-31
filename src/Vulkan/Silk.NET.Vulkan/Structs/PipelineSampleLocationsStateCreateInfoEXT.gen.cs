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
    [NativeName("Name", "VkPipelineSampleLocationsStateCreateInfoEXT")]
    public unsafe partial struct PipelineSampleLocationsStateCreateInfoEXT : IExtendsChain<PipelineMultisampleStateCreateInfo>
    {
        public PipelineSampleLocationsStateCreateInfoEXT
        (
            StructureType? sType = StructureType.PipelineSampleLocationsStateCreateInfoExt,
            void* pNext = null,
            Bool32? sampleLocationsEnable = null,
            SampleLocationsInfoEXT? sampleLocationsInfo = null
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

            if (sampleLocationsEnable is not null)
            {
                SampleLocationsEnable = sampleLocationsEnable.Value;
            }

            if (sampleLocationsInfo is not null)
            {
                SampleLocationsInfo = sampleLocationsInfo.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sampleLocationsEnable")]
        public Bool32 SampleLocationsEnable;
/// <summary></summary>
        [NativeName("Type", "VkSampleLocationsInfoEXT")]
        [NativeName("Type.Name", "VkSampleLocationsInfoEXT")]
        [NativeName("Name", "sampleLocationsInfo")]
        public SampleLocationsInfoEXT SampleLocationsInfo;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineSampleLocationsStateCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
