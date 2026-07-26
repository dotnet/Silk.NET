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
    [NativeName("Name", "VkPhysicalDeviceVulkan14Features")]
    public unsafe partial struct PhysicalDeviceVulkan14Features : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceVulkan14Features
        (
            StructureType? sType = StructureType.PhysicalDeviceVulkan14Features,
            void* pNext = null,
            Bool32? globalPriorityQuery = null,
            Bool32? shaderSubgroupRotate = null,
            Bool32? shaderSubgroupRotateClustered = null,
            Bool32? shaderFloatControls2 = null,
            Bool32? shaderExpectAssume = null,
            Bool32? rectangularLines = null,
            Bool32? bresenhamLines = null,
            Bool32? smoothLines = null,
            Bool32? stippledRectangularLines = null,
            Bool32? stippledBresenhamLines = null,
            Bool32? stippledSmoothLines = null,
            Bool32? vertexAttributeInstanceRateDivisor = null,
            Bool32? vertexAttributeInstanceRateZeroDivisor = null,
            Bool32? indexTypeUint8 = null,
            Bool32? dynamicRenderingLocalRead = null,
            Bool32? maintenance5 = null,
            Bool32? maintenance6 = null,
            Bool32? pipelineProtectedAccess = null,
            Bool32? pipelineRobustness = null,
            Bool32? hostImageCopy = null,
            Bool32? pushDescriptor = null
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

            if (globalPriorityQuery is not null)
            {
                GlobalPriorityQuery = globalPriorityQuery.Value;
            }

            if (shaderSubgroupRotate is not null)
            {
                ShaderSubgroupRotate = shaderSubgroupRotate.Value;
            }

            if (shaderSubgroupRotateClustered is not null)
            {
                ShaderSubgroupRotateClustered = shaderSubgroupRotateClustered.Value;
            }

            if (shaderFloatControls2 is not null)
            {
                ShaderFloatControls2 = shaderFloatControls2.Value;
            }

            if (shaderExpectAssume is not null)
            {
                ShaderExpectAssume = shaderExpectAssume.Value;
            }

            if (rectangularLines is not null)
            {
                RectangularLines = rectangularLines.Value;
            }

            if (bresenhamLines is not null)
            {
                BresenhamLines = bresenhamLines.Value;
            }

            if (smoothLines is not null)
            {
                SmoothLines = smoothLines.Value;
            }

            if (stippledRectangularLines is not null)
            {
                StippledRectangularLines = stippledRectangularLines.Value;
            }

            if (stippledBresenhamLines is not null)
            {
                StippledBresenhamLines = stippledBresenhamLines.Value;
            }

            if (stippledSmoothLines is not null)
            {
                StippledSmoothLines = stippledSmoothLines.Value;
            }

            if (vertexAttributeInstanceRateDivisor is not null)
            {
                VertexAttributeInstanceRateDivisor = vertexAttributeInstanceRateDivisor.Value;
            }

            if (vertexAttributeInstanceRateZeroDivisor is not null)
            {
                VertexAttributeInstanceRateZeroDivisor = vertexAttributeInstanceRateZeroDivisor.Value;
            }

            if (indexTypeUint8 is not null)
            {
                IndexTypeUint8 = indexTypeUint8.Value;
            }

            if (dynamicRenderingLocalRead is not null)
            {
                DynamicRenderingLocalRead = dynamicRenderingLocalRead.Value;
            }

            if (maintenance5 is not null)
            {
                Maintenance5 = maintenance5.Value;
            }

            if (maintenance6 is not null)
            {
                Maintenance6 = maintenance6.Value;
            }

            if (pipelineProtectedAccess is not null)
            {
                PipelineProtectedAccess = pipelineProtectedAccess.Value;
            }

            if (pipelineRobustness is not null)
            {
                PipelineRobustness = pipelineRobustness.Value;
            }

            if (hostImageCopy is not null)
            {
                HostImageCopy = hostImageCopy.Value;
            }

            if (pushDescriptor is not null)
            {
                PushDescriptor = pushDescriptor.Value;
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
        [NativeName("Name", "globalPriorityQuery")]
        public Bool32 GlobalPriorityQuery;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSubgroupRotate")]
        public Bool32 ShaderSubgroupRotate;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSubgroupRotateClustered")]
        public Bool32 ShaderSubgroupRotateClustered;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderFloatControls2")]
        public Bool32 ShaderFloatControls2;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderExpectAssume")]
        public Bool32 ShaderExpectAssume;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "rectangularLines")]
        public Bool32 RectangularLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "bresenhamLines")]
        public Bool32 BresenhamLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "smoothLines")]
        public Bool32 SmoothLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "stippledRectangularLines")]
        public Bool32 StippledRectangularLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "stippledBresenhamLines")]
        public Bool32 StippledBresenhamLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "stippledSmoothLines")]
        public Bool32 StippledSmoothLines;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "vertexAttributeInstanceRateDivisor")]
        public Bool32 VertexAttributeInstanceRateDivisor;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "vertexAttributeInstanceRateZeroDivisor")]
        public Bool32 VertexAttributeInstanceRateZeroDivisor;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "indexTypeUint8")]
        public Bool32 IndexTypeUint8;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "dynamicRenderingLocalRead")]
        public Bool32 DynamicRenderingLocalRead;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "maintenance5")]
        public Bool32 Maintenance5;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "maintenance6")]
        public Bool32 Maintenance6;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "pipelineProtectedAccess")]
        public Bool32 PipelineProtectedAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "pipelineRobustness")]
        public Bool32 PipelineRobustness;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "hostImageCopy")]
        public Bool32 HostImageCopy;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "pushDescriptor")]
        public Bool32 PushDescriptor;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceVulkan14Features;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
