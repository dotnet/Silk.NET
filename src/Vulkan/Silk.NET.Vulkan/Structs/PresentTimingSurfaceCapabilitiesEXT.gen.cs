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
    [NativeName("Name", "VkPresentTimingSurfaceCapabilitiesEXT")]
    public unsafe partial struct PresentTimingSurfaceCapabilitiesEXT : IExtendsChain<SurfaceCapabilities2KHR>
    {
        public PresentTimingSurfaceCapabilitiesEXT
        (
            StructureType? sType = StructureType.PresentTimingSurfaceCapabilitiesExt,
            void* pNext = null,
            Bool32? presentTimingSupported = null,
            Bool32? presentAtAbsoluteTimeSupported = null,
            Bool32? presentAtRelativeTimeSupported = null,
            PresentStageFlagsEXT? presentStageQueries = null
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

            if (presentTimingSupported is not null)
            {
                PresentTimingSupported = presentTimingSupported.Value;
            }

            if (presentAtAbsoluteTimeSupported is not null)
            {
                PresentAtAbsoluteTimeSupported = presentAtAbsoluteTimeSupported.Value;
            }

            if (presentAtRelativeTimeSupported is not null)
            {
                PresentAtRelativeTimeSupported = presentAtRelativeTimeSupported.Value;
            }

            if (presentStageQueries is not null)
            {
                PresentStageQueries = presentStageQueries.Value;
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
        [NativeName("Name", "presentTimingSupported")]
        public Bool32 PresentTimingSupported;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "presentAtAbsoluteTimeSupported")]
        public Bool32 PresentAtAbsoluteTimeSupported;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "presentAtRelativeTimeSupported")]
        public Bool32 PresentAtRelativeTimeSupported;
/// <summary></summary>
        [NativeName("Type", "VkPresentStageFlagsEXT")]
        [NativeName("Type.Name", "VkPresentStageFlagsEXT")]
        [NativeName("Name", "presentStageQueries")]
        public PresentStageFlagsEXT PresentStageQueries;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PresentTimingSurfaceCapabilitiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
