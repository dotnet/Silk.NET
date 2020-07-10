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
    [NativeName("Name", "VkPhysicalDeviceTransformFeedbackPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceTransformFeedbackPropertiesEXT
    {
        public PhysicalDeviceTransformFeedbackPropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceTransformFeedbackPropertiesExt,
            void* pNext = default,
            uint maxTransformFeedbackStreams = default,
            uint maxTransformFeedbackBuffers = default,
            ulong maxTransformFeedbackBufferSize = default,
            uint maxTransformFeedbackStreamDataSize = default,
            uint maxTransformFeedbackBufferDataSize = default,
            uint maxTransformFeedbackBufferDataStride = default,
            Bool32 transformFeedbackQueries = default,
            Bool32 transformFeedbackStreamsLinesTriangles = default,
            Bool32 transformFeedbackRasterizationStreamSelect = default,
            Bool32 transformFeedbackDraw = default
        )
        {
            SType = sType;
            PNext = pNext;
            MaxTransformFeedbackStreams = maxTransformFeedbackStreams;
            MaxTransformFeedbackBuffers = maxTransformFeedbackBuffers;
            MaxTransformFeedbackBufferSize = maxTransformFeedbackBufferSize;
            MaxTransformFeedbackStreamDataSize = maxTransformFeedbackStreamDataSize;
            MaxTransformFeedbackBufferDataSize = maxTransformFeedbackBufferDataSize;
            MaxTransformFeedbackBufferDataStride = maxTransformFeedbackBufferDataStride;
            TransformFeedbackQueries = transformFeedbackQueries;
            TransformFeedbackStreamsLinesTriangles = transformFeedbackStreamsLinesTriangles;
            TransformFeedbackRasterizationStreamSelect = transformFeedbackRasterizationStreamSelect;
            TransformFeedbackDraw = transformFeedbackDraw;
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
    }
}
