// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_pipeline_executable_properties")]
    public abstract unsafe partial class KhrPipelineExecutableProperties : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
        public abstract unsafe Result GetPipelineExecutableInternalRepresentation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] uint* pInternalRepresentationCount, [Count(Computed = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] PipelineExecutableInternalRepresentationKHR* pInternalRepresentations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
        public abstract Result GetPipelineExecutableInternalRepresentation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PipelineExecutableInfoKHR pExecutableInfo, [Count(Count = 0)] ref uint pInternalRepresentationCount, [Count(Computed = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] out PipelineExecutableInternalRepresentationKHR pInternalRepresentations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
        public abstract unsafe Result GetPipelineExecutableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineInfoKHR* pPipelineInfo, [Count(Count = 0)] uint* pExecutableCount, [Count(Computed = "pExecutableCount"), Flow(FlowDirection.Out)] PipelineExecutablePropertiesKHR* pProperties);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
        public abstract Result GetPipelineExecutableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PipelineInfoKHR pPipelineInfo, [Count(Count = 0)] ref uint pExecutableCount, [Count(Computed = "pExecutableCount"), Flow(FlowDirection.Out)] out PipelineExecutablePropertiesKHR pProperties);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
        public abstract unsafe Result GetPipelineExecutableStatistic([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] uint* pStatisticCount, [Count(Computed = "pStatisticCount"), Flow(FlowDirection.Out)] PipelineExecutableStatisticKHR* pStatistics);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
        public abstract Result GetPipelineExecutableStatistic([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PipelineExecutableInfoKHR pExecutableInfo, [Count(Count = 0)] ref uint pStatisticCount, [Count(Computed = "pStatisticCount"), Flow(FlowDirection.Out)] out PipelineExecutableStatisticKHR pStatistics);

        public KhrPipelineExecutableProperties(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

