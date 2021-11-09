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
    [NativeName("Name", "VkRenderPassSampleLocationsBeginInfoEXT")]
    public unsafe partial struct RenderPassSampleLocationsBeginInfoEXT : IExtendsChain<RenderPassBeginInfo>
    {
        public RenderPassSampleLocationsBeginInfoEXT
        (
            StructureType? sType = StructureType.RenderPassSampleLocationsBeginInfoExt,
            void* pNext = null,
            uint? attachmentInitialSampleLocationsCount = null,
            AttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations = null,
            uint? postSubpassSampleLocationsCount = null,
            SubpassSampleLocationsEXT* pPostSubpassSampleLocations = null
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

            if (attachmentInitialSampleLocationsCount is not null)
            {
                AttachmentInitialSampleLocationsCount = attachmentInitialSampleLocationsCount.Value;
            }

            if (pAttachmentInitialSampleLocations is not null)
            {
                PAttachmentInitialSampleLocations = pAttachmentInitialSampleLocations;
            }

            if (postSubpassSampleLocationsCount is not null)
            {
                PostSubpassSampleLocationsCount = postSubpassSampleLocationsCount.Value;
            }

            if (pPostSubpassSampleLocations is not null)
            {
                PPostSubpassSampleLocations = pPostSubpassSampleLocations;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "attachmentInitialSampleLocationsCount")]
        public uint AttachmentInitialSampleLocationsCount;
/// <summary></summary>
        [NativeName("Type", "VkAttachmentSampleLocationsEXT*")]
        [NativeName("Type.Name", "VkAttachmentSampleLocationsEXT")]
        [NativeName("Name", "pAttachmentInitialSampleLocations")]
        public AttachmentSampleLocationsEXT* PAttachmentInitialSampleLocations;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "postSubpassSampleLocationsCount")]
        public uint PostSubpassSampleLocationsCount;
/// <summary></summary>
        [NativeName("Type", "VkSubpassSampleLocationsEXT*")]
        [NativeName("Type.Name", "VkSubpassSampleLocationsEXT")]
        [NativeName("Name", "pPostSubpassSampleLocations")]
        public SubpassSampleLocationsEXT* PPostSubpassSampleLocations;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RenderPassSampleLocationsBeginInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
