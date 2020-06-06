// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_pipeline_executable_properties")]
    public unsafe partial class KhrPipelineExecutableProperties : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_pipeline_executable_properties";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPipelineExecutableInternalRepresentation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] uint* pInternalRepresentationCount, [Count(Computed = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] PipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
            => ImplGetPipelineExecutableInternalRepresentation(device, pExecutableInfo, pInternalRepresentationCount, pInternalRepresentations);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPipelineExecutableInternalRepresentation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PipelineExecutableInfoKHR pExecutableInfo, [Count(Count = 0)] ref uint pInternalRepresentationCount, [Count(Computed = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] out PipelineExecutableInternalRepresentationKHR pInternalRepresentations)
            => ImplGetPipelineExecutableInternalRepresentation(device, pExecutableInfo, pInternalRepresentationCount, pInternalRepresentations);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPipelineExecutableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineInfoKHR* pPipelineInfo, [Count(Count = 0)] uint* pExecutableCount, [Count(Computed = "pExecutableCount"), Flow(FlowDirection.Out)] PipelineExecutablePropertiesKHR* pProperties)
            => ImplGetPipelineExecutableProperties(device, pPipelineInfo, pExecutableCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPipelineExecutableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PipelineInfoKHR pPipelineInfo, [Count(Count = 0)] ref uint pExecutableCount, [Count(Computed = "pExecutableCount"), Flow(FlowDirection.Out)] out PipelineExecutablePropertiesKHR pProperties)
            => ImplGetPipelineExecutableProperties(device, pPipelineInfo, pExecutableCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPipelineExecutableStatistic([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] uint* pStatisticCount, [Count(Computed = "pStatisticCount"), Flow(FlowDirection.Out)] PipelineExecutableStatisticKHR* pStatistics)
            => ImplGetPipelineExecutableStatistic(device, pExecutableInfo, pStatisticCount, pStatistics);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPipelineExecutableStatistic([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PipelineExecutableInfoKHR pExecutableInfo, [Count(Count = 0)] ref uint pStatisticCount, [Count(Computed = "pStatisticCount"), Flow(FlowDirection.Out)] out PipelineExecutableStatisticKHR pStatistics)
            => ImplGetPipelineExecutableStatistic(device, pExecutableInfo, pStatisticCount, pStatistics);

        public KhrPipelineExecutableProperties(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

