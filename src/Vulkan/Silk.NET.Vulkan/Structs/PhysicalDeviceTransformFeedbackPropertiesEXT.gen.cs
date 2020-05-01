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
    public unsafe struct PhysicalDeviceTransformFeedbackPropertiesEXT
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint MaxTransformFeedbackStreams;
/// <summary></summary>
        public uint MaxTransformFeedbackBuffers;
/// <summary></summary>
        public ulong MaxTransformFeedbackBufferSize;
/// <summary></summary>
        public uint MaxTransformFeedbackStreamDataSize;
/// <summary></summary>
        public uint MaxTransformFeedbackBufferDataSize;
/// <summary></summary>
        public uint MaxTransformFeedbackBufferDataStride;
/// <summary></summary>
        public Bool32 TransformFeedbackQueries;
/// <summary></summary>
        public Bool32 TransformFeedbackStreamsLinesTriangles;
/// <summary></summary>
        public Bool32 TransformFeedbackRasterizationStreamSelect;
/// <summary></summary>
        public Bool32 TransformFeedbackDraw;
    }
}
