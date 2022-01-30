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
    [NativeName("Name", "VkFormatProperties3KHR")]
    public unsafe partial struct FormatProperties3KHR : IExtendsChain<FormatProperties2>, IExtendsChain<FormatProperties2KHR>
    {
        public FormatProperties3KHR
        (
            StructureType? sType = StructureType.FormatProperties3Khr,
            void* pNext = null,
            FormatFeatureFlags2KHR? linearTilingFeatures = null,
            FormatFeatureFlags2KHR? optimalTilingFeatures = null,
            FormatFeatureFlags2KHR? bufferFeatures = null
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

            if (linearTilingFeatures is not null)
            {
                LinearTilingFeatures = linearTilingFeatures.Value;
            }

            if (optimalTilingFeatures is not null)
            {
                OptimalTilingFeatures = optimalTilingFeatures.Value;
            }

            if (bufferFeatures is not null)
            {
                BufferFeatures = bufferFeatures.Value;
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
        [NativeName("Type", "VkFormatFeatureFlags2KHR")]
        [NativeName("Type.Name", "VkFormatFeatureFlags2KHR")]
        [NativeName("Name", "linearTilingFeatures")]
        public FormatFeatureFlags2KHR LinearTilingFeatures;
/// <summary></summary>
        [NativeName("Type", "VkFormatFeatureFlags2KHR")]
        [NativeName("Type.Name", "VkFormatFeatureFlags2KHR")]
        [NativeName("Name", "optimalTilingFeatures")]
        public FormatFeatureFlags2KHR OptimalTilingFeatures;
/// <summary></summary>
        [NativeName("Type", "VkFormatFeatureFlags2KHR")]
        [NativeName("Type.Name", "VkFormatFeatureFlags2KHR")]
        [NativeName("Name", "bufferFeatures")]
        public FormatFeatureFlags2KHR BufferFeatures;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.FormatProperties3Khr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
