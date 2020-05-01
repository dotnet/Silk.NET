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
    [Extension("VK_KHR_descriptor_update_template")]
    public abstract unsafe partial class KhrDescriptorUpdateTemplate : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_descriptor_update_template";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPushDescriptorSetWithTemplateKHR")]
        public abstract unsafe void CmdPushDescriptorSetWithTemplate([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint set, [Count(Count = 0)] void* pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPushDescriptorSetWithTemplateKHR")]
        public abstract void CmdPushDescriptorSetWithTemplate<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint set, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplateKHR")]
        public abstract unsafe Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorUpdateTemplateCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorUpdateTemplate* pDescriptorUpdateTemplate);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplateKHR")]
        public abstract Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorUpdateTemplateCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorUpdateTemplate pDescriptorUpdateTemplate);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorUpdateTemplateKHR")]
        public abstract unsafe void DestroyDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorUpdateTemplateKHR")]
        public abstract void DestroyDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSetWithTemplateKHR")]
        public abstract unsafe void UpdateDescriptorSetWithTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] void* pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSetWithTemplateKHR")]
        public abstract void UpdateDescriptorSetWithTemplate<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        public KhrDescriptorUpdateTemplate(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

