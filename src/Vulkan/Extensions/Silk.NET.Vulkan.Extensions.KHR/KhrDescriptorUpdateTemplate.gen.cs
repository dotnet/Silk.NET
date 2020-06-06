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
    [Extension("VK_KHR_descriptor_update_template")]
    public unsafe partial class KhrDescriptorUpdateTemplate : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_descriptor_update_template";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPushDescriptorSetWithTemplateKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdPushDescriptorSetWithTemplate([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint set, [Count(Count = 0)] void* pData)
            => ImplCmdPushDescriptorSetWithTemplate(commandBuffer, descriptorUpdateTemplate, layout, set, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdPushDescriptorSetWithTemplateKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdPushDescriptorSetWithTemplate<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint set, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged
            => ImplCmdPushDescriptorSetWithTemplate<T0>(commandBuffer, descriptorUpdateTemplate, layout, set, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplateKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorUpdateTemplateCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorUpdateTemplate* pDescriptorUpdateTemplate)
            => ImplCreateDescriptorUpdateTemplate(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplateKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DescriptorUpdateTemplateCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorUpdateTemplate pDescriptorUpdateTemplate)
            => ImplCreateDescriptorUpdateTemplate(device, pCreateInfo, pAllocator, pDescriptorUpdateTemplate);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorUpdateTemplateKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyDescriptorUpdateTemplate(device, descriptorUpdateTemplate, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorUpdateTemplateKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyDescriptorUpdateTemplate(device, descriptorUpdateTemplate, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSetWithTemplateKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UpdateDescriptorSetWithTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] void* pData)
            => ImplUpdateDescriptorSetWithTemplate(device, descriptorSet, descriptorUpdateTemplate, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSetWithTemplateKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UpdateDescriptorSetWithTemplate<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged
            => ImplUpdateDescriptorSetWithTemplate<T0>(device, descriptorSet, descriptorUpdateTemplate, pData);

        public KhrDescriptorUpdateTemplate(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

