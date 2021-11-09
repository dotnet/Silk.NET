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
    [NativeName("Name", "VkPhysicalDeviceTransformFeedbackPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceTransformFeedbackPropertiesEXT : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceTransformFeedbackPropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceTransformFeedbackPropertiesExt,
            void* pNext = null,
            uint? maxTransformFeedbackStreams = null,
            uint? maxTransformFeedbackBuffers = null,
            ulong? maxTransformFeedbackBufferSize = null,
            uint? maxTransformFeedbackStreamDataSize = null,
            uint? maxTransformFeedbackBufferDataSize = null,
            uint? maxTransformFeedbackBufferDataStride = null,
            Bool32? transformFeedbackQueries = null,
            Bool32? transformFeedbackStreamsLinesTriangles = null,
            Bool32? transformFeedbackRasterizationStreamSelect = null,
            Bool32? transformFeedbackDraw = null
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

            if (maxTransformFeedbackStreams is not null)
            {
                MaxTransformFeedbackStreams = maxTransformFeedbackStreams.Value;
            }

            if (maxTransformFeedbackBuffers is not null)
            {
                MaxTransformFeedbackBuffers = maxTransformFeedbackBuffers.Value;
            }

            if (maxTransformFeedbackBufferSize is not null)
            {
                MaxTransformFeedbackBufferSize = maxTransformFeedbackBufferSize.Value;
            }

            if (maxTransformFeedbackStreamDataSize is not null)
            {
                MaxTransformFeedbackStreamDataSize = maxTransformFeedbackStreamDataSize.Value;
            }

            if (maxTransformFeedbackBufferDataSize is not null)
            {
                MaxTransformFeedbackBufferDataSize = maxTransformFeedbackBufferDataSize.Value;
            }

            if (maxTransformFeedbackBufferDataStride is not null)
            {
                MaxTransformFeedbackBufferDataStride = maxTransformFeedbackBufferDataStride.Value;
            }

            if (transformFeedbackQueries is not null)
            {
                TransformFeedbackQueries = transformFeedbackQueries.Value;
            }

            if (transformFeedbackStreamsLinesTriangles is not null)
            {
                TransformFeedbackStreamsLinesTriangles = transformFeedbackStreamsLinesTriangles.Value;
            }

            if (transformFeedbackRasterizationStreamSelect is not null)
            {
                TransformFeedbackRasterizationStreamSelect = transformFeedbackRasterizationStreamSelect.Value;
            }

            if (transformFeedbackDraw is not null)
            {
                TransformFeedbackDraw = transformFeedbackDraw.Value;
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
        [NativeName("Name", "maxTransformFeedbackStreams")]
        public uint MaxTransformFeedbackStreams;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTransformFeedbackBuffers")]
        public uint MaxTransformFeedbackBuffers;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "maxTransformFeedbackBufferSize")]
        public ulong MaxTransformFeedbackBufferSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTransformFeedbackStreamDataSize")]
        public uint MaxTransformFeedbackStreamDataSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTransformFeedbackBufferDataSize")]
        public uint MaxTransformFeedbackBufferDataSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTransformFeedbackBufferDataStride")]
        public uint MaxTransformFeedbackBufferDataStride;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "transformFeedbackQueries")]
        public Bool32 TransformFeedbackQueries;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "transformFeedbackStreamsLinesTriangles")]
        public Bool32 TransformFeedbackStreamsLinesTriangles;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "transformFeedbackRasterizationStreamSelect")]
        public Bool32 TransformFeedbackRasterizationStreamSelect;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "transformFeedbackDraw")]
        public Bool32 TransformFeedbackDraw;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceTransformFeedbackPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
