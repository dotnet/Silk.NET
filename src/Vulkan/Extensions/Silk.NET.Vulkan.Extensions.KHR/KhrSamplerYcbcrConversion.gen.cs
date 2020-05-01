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

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_sampler_ycbcr_conversion")]
    public abstract unsafe partial class KhrSamplerYcbcrConversion : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_sampler_ycbcr_conversion";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversionKHR")]
        public abstract unsafe Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversionKHR")]
        public abstract Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SamplerYcbcrConversionCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SamplerYcbcrConversion pYcbcrConversion);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySamplerYcbcrConversionKHR")]
        public abstract unsafe void DestroySamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0)] SamplerYcbcrConversion ycbcrConversion, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroySamplerYcbcrConversionKHR")]
        public abstract void DestroySamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0)] SamplerYcbcrConversion ycbcrConversion, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        public KhrSamplerYcbcrConversion(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

